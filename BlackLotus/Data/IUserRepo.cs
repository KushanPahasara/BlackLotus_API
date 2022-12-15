using BlackLotus.Model;

namespace BlackLotus.Data
{
    public interface IUserRepo
    {
        bool Save();
        IEnumerable<User> GetUsers();
        User GetUserById(int userId);
        void createUser(User user);

        void delete(User user);

        bool update(User user);
    }
}
