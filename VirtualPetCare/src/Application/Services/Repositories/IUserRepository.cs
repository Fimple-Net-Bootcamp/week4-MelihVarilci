using Domain.Entities;

namespace Application.Services.Repositories;

public interface IUserRepository : IAsyncRepository<User, int>, IRepository<User, int> { }
