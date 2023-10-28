using FoodieReviewHub;

Console.WriteLine("Welcome to the Restaurant evaluation program FoodieReviewHub");
Console.WriteLine("============================================================");
Console.WriteLine("Rate the restaurant from the last few stays. Enter the star number from 1 do 5.");
Console.WriteLine();

var restaurant = new Restaurant("Nolio");

while(true)
{
    Console.WriteLine("Enter the next star");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    restaurant.AddStar(input);
}
var statistics = restaurant.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");