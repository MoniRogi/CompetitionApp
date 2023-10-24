namespace CompetitionApp
{
    public class MemberInMemory : MemberBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
        
        public string coupleNumber;

        public MemberInMemory(string coupleNumber)
            : base(coupleNumber)
        { grades = new List<float>(); }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 7)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Błędna ocena !");
            }
        }
     
        public override void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }
      
        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case '1':                
                    this.grades.Add(1);
                    break;
                case '2':
                    this.grades.Add(2);
                    break;
                case '3':                
                    this.grades.Add(3);
                    break;
                case '4':                
                    this.grades.Add(4);
                    break;
                case '5':              
                    this.grades.Add(5);
                    break;
                case '6':
                    this.grades.Add(6);
                    break;
                case '7':
                    this.grades.Add(7);
                    break;
                default:
                    throw new Exception("Zła cyfra !");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }


            return statistics;

        }
    }
}