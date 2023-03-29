using Microsoft.AspNetCore.Mvc;
using WebApi.Fake;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {

        private List<User> _users = FakeData.GetUsers(200);
        public List<User> Get()
        {
            return _users;
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
           
            return _users.FirstOrDefault(u => u.Id == id);
        }

        [HttpPost]
        public User Post([FromBody]User user)
        {
            _users.Add(user);
            return user;
        }

        [HttpPut]
        public User Put([FromBody] User user)
        {
            var _user = _users.FirstOrDefault(a => a.Id == user.Id);
            if(_user != null)
            {
                _user.Id = user.Id;
                _user.FirstName = user.FirstName;
                _user.LastName = user.LastName;
                _user.Address = user.Address;
            }
            return user;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var _user = _users.FirstOrDefault(a => a.Id == id);
            _users.Remove(_user);


        }

    }

}

