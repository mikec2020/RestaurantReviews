using System;

namespace RestaurantReviews.Web.Data.Entities
{
    public class Review
    {
        public int Id { get; set; }

        public int RestaurantId { get; set; }

        public Restaurant Restaurant { get; set; }

        public int UserId { get; set; }

        public string Text { get; set; }

        public bool Active { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
