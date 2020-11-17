using Associados.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associados.Data
{
    public class UserRepository : IUserRepository
    {
        Context context = new Context();

        public void Add(User u)
        {
            context.User.Add(u);
            context.SaveChanges();
        }

        public void Edit(User u)
        {
            context.Entry(u).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(int Id)
        {
            User u = context.User.Find(Id);
            context.User.Remove(u);
            context.SaveChanges();
        }

        public IEnumerable<User> List()
        {
            return context.User;
        }

        public User findById(int Id)
        {
            var result = (from r in context.User where r.Id == Id select r).FirstOrDefault();

            return result;
        }

        public bool login(string Username, string Password)
        {
            return true;
        }

    }
}
