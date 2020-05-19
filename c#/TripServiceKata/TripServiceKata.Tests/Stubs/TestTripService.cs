using TripServiceKata.Trip;

namespace TripServiceKata.Tests
{
    public class TestTripService : TripService
    {
        public override User.User GetLoggedUser()
        {
            return null;
        }
    }
}