using FoodieReviewHub;

Console.WriteLine("Welcome to the Restaurant evaluation program FoodieReviewHub");
Console.WriteLine("============================================================");
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
    try
    {
        restaurant.AddStar(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
var statistics = restaurant.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");