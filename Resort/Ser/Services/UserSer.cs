using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
    public class UserSer : IUserSer
    {
        private readonly IUserRepo _userRepo;
        public UserSer(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public Task<bool> AddUser(User user)
        {
            return _userRepo.AddUser(user);
        }

        public Task<User> GetUserByEmailAndPass(string email, string pass)
        {
            return _userRepo.GetUserByEmailAndPass(email, pass);
        }

        public Task<User> GetUserById(int id)
        {
            return _userRepo.GetUserById(id);
        }

        public Task<bool> UpdateUser(User user)
        {
            return _userRepo.UpdateUser(user);
        }
    }
}
