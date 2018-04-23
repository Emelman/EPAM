using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndRewards.Shared;

namespace UsersAndRewards.PL.WinForms
{
    public class UserViewModel
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public int Age { get; set; }

        public string Rewards { get; set; }

        public static UserViewModel ToModel(User user)
        {
            var model = new UserViewModel();
            model.UserId = user.UserId;
            model.FirstName = user.Name;
            model.LastName = user.Surname;
            model.Age = user.Age;
            model.Birthdate = user.BirthDay;
            model.Rewards = string.Join(", ", user.Rewards.Select(r => r.RewardName));

            return model;
        }
    }
}
