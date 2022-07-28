using Microsoft.AspNetCore.Mvc;
using WebAPI_Blog.Models;
namespace WebAPI_Blog.Services.Interfaces
{
    public interface IUserService
    {
        ActionResult<IEnumerable<User>> Get();
        User Get(int id);
        void Create(User user);
        void Update(int id, User user);
        void Delete(int id);

    }
}
