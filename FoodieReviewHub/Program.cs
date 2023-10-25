using FoodieReviewHub;

//Restaurant restaurant1 = new Restaurant("Parana");
//Restaurant restaurant2 = new Restaurant("Jaga");
//Restaurant restaurant3 = new Restaurant("Sztolnia");

//restaurant1.AddStar(2);
//restaurant2.AddStar(5);
//restaurant3.AddStar(3);

//List<Restaurant> restaurants = new List<Restaurant>()
//{
//    restaurant1, restaurant2, restaurant3
//};

//int bestReview = -1;
//Restaurant restaurantWithBestReview = null;

//foreach(var restaurant in restaurants)
//{
//    if(restaurant.Stars > bestReview)
//    {
//        restaurantWithBestReview = restaurant;
//        bestReview = restaurant.Stars;
//    }
//}

//Console.WriteLine($"The best restaurant in town is {restaurantWithBestReview.Name}");


var restaurant1 = new Restaurant("Wodnik");
restaurant1.AddStar(6);
restaurant1.AddStar(-1);
restaurant1.AddStar(2);
restaurant1.AddStar(1);
var statistics1 = restaurant1.GetStatistics();
Console.WriteLine($"{restaurant1.Name}");
Console.WriteLine($"Average: {statistics1.Average}");
Console.WriteLine($"Min:{statistics1.Min}");
Console.WriteLine($"Max:{statistics1.Max}");
Console.WriteLine();

var restaurant2 = new Restaurant("Sztolnia");
restaurant2.AddStar(4);
restaurant2.AddStar(5);
restaurant2.AddStar(3);
restaurant2.AddStar(3);
var statistics2 = restaurant2.GetStatistics();
Console.WriteLine($"{restaurant2.Name}");
Console.WriteLine($"Average: {statistics2.Average}");
Console.WriteLine($"Min:{statistics2.Min}");
Console.WriteLine($"Max:{statistics2.Max}");
Console.WriteLine();