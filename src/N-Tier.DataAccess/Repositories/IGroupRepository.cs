using System.Text.RegularExpressions;
using Group = N_Tier.Core.Entities.Group;

namespace N_Tier.DataAccess.Repositories;

public interface IGroupRepository: IBaseRepository<Group, Guid> { }