using KeyOneTest.Models;
using KeyOneTest.Repositories;

namespace KeyOneTest.Services
{
    /// <summary>
    /// Service class for managing user-related operations.
    /// </summary>
    public class UserService : IUserService
    {
        /// <summary>
        /// Retrieves a user based on the provided login credentials.
        /// </summary>
        /// <param name="userLogin">The user login credentials.</param>
        /// <returns>The user matching the provided credentials, if found; otherwise, null.</returns>
        public User Get(UserLogin userLogin)
        {
            // Retrieve the user from the repository based on the provided username and password.
            User user = UserRepository.Users.FirstOrDefault(x => x.Username.Equals(userLogin.Username, StringComparison.OrdinalIgnoreCase) &&
                x.Password.Equals(userLogin.Password));

            // Return the retrieved user.
            return user;
        }
    }
}
