using FoodieReviewHub;

namespace FoodieReviewHubTests
{
    public class RestaurantTests
    {
        [Test]
        public void WhenRestaurantCollectsTwoScores_ShouldReturnCorrectResult()
        {
            var restaurant = new Restaurant("Bistro");
            restaurant.AddStar(4);
            restaurant.AddStar(3);

            var result = restaurant.Stars;

            Assert.AreEqual(7, result);
        }
    }
}