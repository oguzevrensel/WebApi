using Bogus;
using WebApi.Models;

namespace WebApi.Fake
{
    public class FakeData
    {
        public static List<User> _Users;

        public static List<User> GetUsers(int number)
        {
            if(_Users == null)
            {
                _Users = new Faker<User>().RuleFor(u => u.Id, f => f.IndexFaker + 1)
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.Address, f => f.Address.FullAddress())
                .Generate(number);

            }
            return _Users;
        }


    }
}






