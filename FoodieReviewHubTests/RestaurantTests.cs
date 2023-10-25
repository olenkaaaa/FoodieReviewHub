using FoodieReviewHub;

namespace FoodieReviewHubTests
{
    public class RestaurantTests
    {
        [Test]
        public void WhenRestaurantGetStars_CheckIfStatisticsAreCorrect()
        {
            var restaurant = new Restaurant("Bistro");
            restaurant.AddStar(4);
            restaurant.AddStar(3);
            restaurant.AddStar(5);
            restaurant.AddStar(5);

            var statistics = restaurant.GetStatistics();

            Assert.AreEqual(3, statistics.Min);
            Assert.AreEqual(5, statistics.Max);
            Assert.AreEqual(4.25, statistics.Average);
        }
    }
}