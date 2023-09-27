namespace CompetitionApp
{
    public class Statistics
    {
        public float Min { get; private set; }

        public float Max { get; private set; }

        public float Sum { get; private set; }

        public int Count { get; private set; }

        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }

        public char AveragePlace
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average <= 1.4:
                        return '1';
                    case var average when average <= 2.4:
                        return '2';
                    case var average when average <= 3.4:
                        return '3';
                    case var average when average <= 4.4:
                        return '4';
                    case var average when average <= 5.4:
                        return '5';
                    case var average when average <= 6.4:
                        return '6';
                    default:
                        return '7';
                }
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);
        }
    }
}