namespace LMS.Data.Repositories.User
{
    public class UserRepository : IUserRepository
    {
        private readonly IGenericRepository<Entities.User> _genericRepository;

        public UserRepository(IGenericRepository<Entities.User> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<IEnumerable<Entities.User>> GetAllAsync()
        {
            return await _genericRepository.GetAllAsync();
        }

        public async Task<Entities.User> GetByIdAsync(int id)
        {
            return await _genericRepository.GetByIdAsync(id);
        }

        public async Task<Entities.User> InsertAsync(Entities.User entity)
        {
            return await _genericRepository.InsertAsync(entity);
        }

        public async Task<Entities.User> UpdateAsync(Entities.User entity)
        {
            return await _genericRepository.UpdateAsync(entity);
        }

        public async Task<Entities.User> DeleteAsync(int id)
        {
            return await _genericRepository.DeleteAsync(id);
        }
    }
}
