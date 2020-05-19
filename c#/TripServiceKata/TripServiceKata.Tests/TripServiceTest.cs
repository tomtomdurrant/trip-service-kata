using NUnit.Framework;
using TripServiceKata.Exception;

namespace TripServiceKata.Tests
{
    [TestFixture]
    public class TripServiceTest
    {
        [Test]
        public void TripServiceThrowsUserNotLoggedInExceptionWhenNotLoggedIn()
        {
            // Arrange
            var tripService = new TestTripService();
            var userNotLoggedIn = new User.User();

            // Act & Assert
            Assert.Throws<UserNotLoggedInException>(() => tripService.GetTripsByUser(userNotLoggedIn));
        }

        [Test]
        public void TripServiceReturnsEmptyListIfUserHasNoFriends()
        {
            // Arrange
            var tripService = new TestTripServiceNotNull();
            var loggedInUser = new User.User();

            // Act
            var trips = tripService.GetTripsByUser(loggedInUser);

            // Assert
            Assert.IsEmpty(trips);
        }

        [Test]
        public void UserHasFriendsButLoggedUserIsNotOnList()
        {
            var tripService = new TripServiceOneFriendNotOnList();
            var loggedInUser = new User.User();

            var trips = tripService.GetTripsByUser(loggedInUser);

            Assert.IsEmpty(trips);
        }

        [Test]
        public void IfUserHasFriendsAndLoggedUserIsOnList()
        {
            var tripService = new TripServiceOneFriend();
            var loggedInUser = new User.User();

            var trips = tripService.GetTripsByUser(loggedInUser);

            Assert.IsNotEmpty(trips);
        }
    }
}