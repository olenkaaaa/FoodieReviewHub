using FoodieReviewHub;

namespace FoodieReviewHubTests
{
    public class RestaurantTests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            var restaurant = new Restaurant("Bistro");
            restaurant.AddStar(2);
            restaurant.AddStar(3);
            restaurant.AddStar(5);

            var statistics = restaurant.GetStatistics();

            Assert.AreEqual(5, statistics.Max);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            var restaurant = new Restaurant("Wodnik");
            restaurant.AddStar(1);
            restaurant.AddStar(2);
            restaurant.AddStar(2);

            var statistics = restaurant.GetStatistics();

            Assert.AreEqual(1, statistics.Min);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            var restaurant = new Restaurant("Sztolnia");
            restaurant.AddStar(4);
            restaurant.AddStar(3);
            restaurant.AddStar(5);

            var statistics = restaurant.GetStatistics();

            Assert.AreEqual(Math.Round(4.00, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverageLetter()
        {
            var restaurant = new Restaurant("Nolio");
            restaurant.AddStar(3);
            restaurant.AddStar('B');
            restaurant.AddStar('a');
            restaurant.AddStar(4);
            var statistics = restaurant.GetStatistics();

            Assert.AreEqual('B', statistics.AverageLetter);
        }
    }
}