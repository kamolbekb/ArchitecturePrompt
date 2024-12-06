using N_Tier.Core.Entities;
using N_Tier.DataAccess.Persistence;
namespace N_Tier.DataAccess.Repositories.Impl;
public class ReviewRepository : BaseRepository<Review, Guid>, IReviewRepository
{
    public ReviewRepository(DatabaseContext context) : base(context) { }
}