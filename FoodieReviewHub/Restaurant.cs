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

        public void AddStar(int star)
        {
            if(star >= 1 && star <= 5)
            {
                this.stars.Add(star);
            }
            else
            {
                Console.WriteLine("Invalid star value");
            }
        }

        public void AddStar(string star)
        {
            if(int.TryParse(star, out int result))
            {
                this.AddStar(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddStar(float star)
        {
            int floatToInt = (int)star;
            this.AddStar(floatToInt);
        }

        public void AddStar(double star)
        {
            int doubleToInt = (int)star;
            this.AddStar(doubleToInt);
        }

        public void AddStar(long star)
        {
            int longToInt = (int)star;
            this.AddStar(longToInt);
        }

        public void AddStar(decimal star)
        {
            int decimalToInt = (int)star;
            this.AddStar(decimalToInt);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var star in this.stars)
            {
                if(star >= 1)
                {
                    statistics.Max = Math.Max(statistics.Max, star);
                    statistics.Min = Math.Min(statistics.Min, star);
                    statistics.Average += star;
                }
            }

            statistics.Average /= this.stars.Count;

            return statistics;
        }
    }

}
