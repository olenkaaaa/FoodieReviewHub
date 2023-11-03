namespace FoodieReviewHub
{
    public abstract class Business
    {
        public Business(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}
