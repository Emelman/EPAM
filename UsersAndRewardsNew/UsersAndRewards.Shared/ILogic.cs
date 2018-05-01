using System.Collections.Generic;

namespace UsersAndRewards.Shared
{
	public interface ILogic	: IData
	{
		List<UserViewModel> GetUsersViewModel();
		List<RewardViewModel> GetRewardViewModels();
	}
}
