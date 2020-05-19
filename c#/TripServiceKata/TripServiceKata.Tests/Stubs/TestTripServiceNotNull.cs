using TripServiceKata.Trip;

namespace TripServiceKata.Tests
{
    public class TestTripServiceNotNull : TripService
    {
        public override User.User GetLoggedUser()
        {
            return new User.User();
        }
    }
}