using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_Blog.Database;
using WebAPI_Blog.Models;
using WebAPI_Blog.Services.Interfaces;

namespace WebAPI_Blog.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly ApplicationContext _context;
        public UserService(ApplicationContext context)
        {
            _context = context;
        }

        public void Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = Find(id);
            if (user != null) throw new Exception("Пользователь не найден");
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public ActionResult<IEnumerable<User>> Get()
        {
            return _context.Users.AsNoTracking().ToList();
        }

        public User Get(int id)
        {
            return Find(id);
        }

        public void Update(int id,User userVm)
        {
            var user = Find(id);
            if (user == null) throw new Exception("Пользователь не найден");
            user = userVm;
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public User Find(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            if (user == null) throw new Exception("Пользователь не найден");
            return user;
        }
    }
}
