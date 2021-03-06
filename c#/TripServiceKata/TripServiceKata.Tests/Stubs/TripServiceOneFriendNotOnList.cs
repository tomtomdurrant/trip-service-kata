﻿using System.Collections.Generic;
using TripServiceKata.Trip;

namespace TripServiceKata.Tests
{
    public class TripServiceOneFriendNotOnList : TripService
    {
        private readonly User.User _testUser = new User.User();

        public override User.User GetLoggedUser()
        {
            return _testUser;
        }

        public override List<User.User> GetUserFriends(User.User user)
        {
            return new List<User.User>
            {
                new User.User()
            };
        }

        public override List<Trip.Trip> FindTripsByUser(User.User user)
        {
            return new List<Trip.Trip>
            {
                new Trip.Trip()
            };
        }
    }
}