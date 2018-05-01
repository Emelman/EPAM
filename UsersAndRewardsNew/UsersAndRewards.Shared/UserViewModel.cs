using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndRewards.Shared;

namespace UsersAndRewards.Shared
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
			model.FirstName = user.FirstName;
			model.LastName = user.LastName;
			model.Age = user.Age;
			model.Birthdate = user.Birthdate;
			model.Rewards = string.Join(", ", user.Rewards.Select(r => r.Title));

			return model;
		}
	}
}
