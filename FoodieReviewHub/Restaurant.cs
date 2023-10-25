namespace FoodieReviewHub
{
    public class Restaurant
    {
        private List<int> stars = new List<int>();
        public Restaurant(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public int Stars
        {
            get
            { 
                return this.stars.Sum();
            }
        }

        public void AddStar(int star)
        {
            this.stars.Add(star);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var star in this.stars)
            {
                statistics.Max = Math.Max(statistics.Max, star);
                statistics.Min = Math.Min(statistics.Min, star);
                statistics.Average += star;
            }

            statistics.Average /= this.stars.Count;

            return statistics;
        }
    }

}
