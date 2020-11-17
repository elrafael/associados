using System.Collections.Generic;

namespace Associados.Core
{
    public interface IUserRepository
    {
        void Add(User u);
        void Edit(User u);
        void Remove(int Id);
        IEnumerable<User> List();
        User findById(int Id);
        bool login(string Username, string Password);
    }
}
