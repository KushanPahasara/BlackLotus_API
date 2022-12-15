using BlackLotus.Model;

namespace BlackLotus.Data
{
    public class UserRepo : IUserRepo
    {
        private AppDBContex context;

        public UserRepo(AppDBContex dBContext)
        {
            context = dBContext;
        }
        public void createUser(User user)
        {
            if (user == null)
            {
                throw new NotImplementedException(nameof(user));
            }
            context.user.Add(user);
        }

        public void delete(User user)
        {
            context.user.Remove(user);
            Save();
        }

        public User GetUserById(int userId)
        {
            return context.user.FirstOrDefault(u => u.userId == userId);
        }

        public IEnumerable<User> GetUsers()
        {
            return context.user.ToList();
        }

        public bool Save()
        {


            int count = context.SaveChanges();
            if (count > 0)
                return true;
            else
                return false;
        }

        public bool update(User user)
        {
            context.user.Update(user);
            return Save();
        }
    }
}
