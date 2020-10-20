using System;

namespace RestaurantReviews.Web.Exceptions
{
    public class UserNotFoundException : Exception
    {
        private readonly string _message = "User not found";
        
        public UserNotFoundException() { }

        public UserNotFoundException(int userId)
        {
            _message = $"No user found for ID { userId }";
        }
        
        public override string Message => _message;
    }
}
