using System;

namespace RestaurantReviews.Web
{
    public class RestaurantNotFoundException : Exception 
    {
        private readonly string _message = "Restaurant not found";

        public RestaurantNotFoundException() { }

        public RestaurantNotFoundException(int restaurantId)
        {
            _message = $"No restaurant found for ID { restaurantId }";
        }

        public override string Message => _message;
    }
}
