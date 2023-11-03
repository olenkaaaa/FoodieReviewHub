namespace FoodieReviewHub
{
    public interface IRestaurant
    {
        string Name { get; }

        void AddStar(int star);
        void AddStar(string star);
        void AddStar(float star);
        void AddStar(double star);
        void AddStar(long star);
        void AddStar(decimal star);
        void AddStar(char star);

        Statistics GetStatistics();
    }
}
