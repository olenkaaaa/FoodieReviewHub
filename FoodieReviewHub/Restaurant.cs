namespace FoodieReviewHub
{
    public class Restaurant : Business
    {
        private List<int> stars = new List<int>();
        public Restaurant(string name)
            : base(name)
        {
        }

        public void AddStar(int star)
        {
            if(star >= 1 && star <= 5)
            {
                this.stars.Add(star);
            }
            else
            {
                throw new Exception("Invalid star value");
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
                throw new Exception("String is not float");
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

        public void AddStar(char star)
        {
            switch (star)
            {
                case 'A':
                case 'a':
                    this.stars.Add(5);
                    break;
                case 'B':
                    this.stars.Add(4);
                    break;
                case 'C':
                    this.stars.Add(3);
                    break;
                case 'D':
                    this.stars.Add(2);
                    break;
                case 'E':
                    this.stars.Add(1);
                    break;
                default:
                    throw new Exception("Wrong Letter");
                    break;
            }
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

            switch (statistics.Average)
            {
                case var average when average > 4:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average > 3:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average > 2:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average > 1:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }


            return statistics;
        }
    }

}
