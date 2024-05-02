using KeyOneTest.Models;

namespace KeyOneTest.Repositories
{
    public class UserRepository
    {
        public static List<User> Users =
        [
            new() {Username = "alberto_admin", Email = "alberto.admin@email.com", Password = "albertoP4ssW0rd", Role = "Administrator"},
            new() {Username = "alberto_standard", Email = "alberto.standard@email.com", Password = "albertoP4ssW0rd", Role = "Standard"}
        ];
    }
}
