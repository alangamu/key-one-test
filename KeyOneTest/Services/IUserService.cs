using KeyOneTest.Models;

namespace KeyOneTest.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
