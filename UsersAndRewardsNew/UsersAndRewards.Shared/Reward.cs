using System;

namespace UsersAndRewards.Shared
{
	public class Reward
	{
		public int RewardId { get; set; }
        private string title;
        private string description;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    title = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty or null!");
                }
            }
        }

		public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty or null!");
                }
            }
        }

	}
}
