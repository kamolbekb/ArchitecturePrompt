using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using N_Tier.Core.Common;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Identity;
using N_Tier.Shared.Services;

namespace N_Tier.DataAccess.Persistence;

public class DatabaseContext : IdentityDbContext<ApplicationUser>
{
    private readonly IClaimService _claimService;

    public DatabaseContext(DbContextOptions options, IClaimService claimService) : base(options)
    {
        _claimService = claimService;
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
    }


    public DbSet<TodoItem> TodoItems { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Exam> Exams{ get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<StudyProcess> StudyProcesses { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<TodoList> TodoLists { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        // builder.Entity<Group>(entity =>
        // {
        //     entity.HasKey(r => r.Id);
        //
        //     entity.HasOne(e => e.StudyProcess)
        //         .WithOne(o => o.Group)
        //         .HasForeignKey<Group>(o => o.StudyProcessId);
        // });
        
        builder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id);
            
            entity.HasOne(e => e.Group) 
                .WithMany(g => g.Students)
                .HasForeignKey(e => e.GroupId)
                .OnDelete(DeleteBehavior.Cascade);
        });
        
        builder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id);
            
           
            // entity.HasOne(e => e.StudyProcess)
            //     .WithMany(sp => sp.Groups)
            //     .HasForeignKey(e => e.StudyProcessId)
            //     .OnDelete(DeleteBehavior.Restrict);
            
            entity.HasMany(e => e.Students)
                .WithOne(s => s.Group)
                .HasForeignKey(s => s.GroupId)
                .OnDelete(DeleteBehavior.Cascade);
            
            entity.HasMany(e => e.Teachers)
                .WithMany(t => t.Groups)
                .UsingEntity(j => j.ToTable("GroupTeachers")); // Таблица для связи многие-ко-многим
            
            entity.HasMany(e => e.Rooms)
                .WithMany(r => r.Groups)
                .UsingEntity(j => j.ToTable("GroupRooms")); // Таблица для связи многие-ко-многим
        });
        
        builder.Entity<Exam>(entity =>
        {
            entity.HasKey(e => e.Id); // Первичный ключ
            
            entity.HasOne(e => e.Subject)
                .WithMany()
                .HasForeignKey(e => e.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            // entity.HasOne(e => e.Room)
            //     .WithMany(r => r.Exams)
            //     .HasForeignKey(e => e.RoomId)
            //     .OnDelete(DeleteBehavior.Restrict);

            // entity.HasOne(e => e.Group)
            //     .WithMany(g => g.Exams)
            //     .HasForeignKey(e => e.GroupId)
            //     .OnDelete(DeleteBehavior.Restrict);
        });
        
        base.OnModelCreating(builder);
    }

    public new async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        foreach (var entry in ChangeTracker.Entries<IAuditedEntity>())
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedBy = _claimService.GetUserId();
                    entry.Entity.CreatedOn = DateTime.Now;
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdatedBy = _claimService.GetUserId();
                    entry.Entity.UpdatedOn = DateTime.Now;
                    break;
            }

        return await base.SaveChangesAsync(cancellationToken);
    }
}
