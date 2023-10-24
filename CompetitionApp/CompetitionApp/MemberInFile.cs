namespace CompetitionApp
{
    public class MemberInFile : MemberBase
    {
        private const string fileName = "grades.txt";

        public override event GradeAddedDelegate GradeAdded;

        public string FullFileName;
        public string coupleNumber { get; private set; }

        public MemberInFile(string coupleNumber)
              : base(coupleNumber)
        {
            this.FullFileName = $"{coupleNumber}{fileName}";
        }

        public override void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 7)
            {
                using (var writer = File.AppendText(FullFileName))
                {
                    writer.WriteLine(grade);
                }

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
            float gradeAsFloat = (float)grade;
            using var writer = File.AppendText(fileName);
            writer.WriteLine(gradeAsFloat);
        }
 
        public override void AddGrade(char grade)
        {
            using var writer = File.AppendText(fileName);
            switch (grade)
            {
                case '1':
                    writer.WriteLine(1);
                    break;
                case '2':
                    writer.WriteLine(2);
                    break;
                case '3':
                    writer.WriteLine(3);
                    break;
                case '4':
                    writer.WriteLine(4);
                    break;
                case '5':
                    writer.WriteLine(5);
                    break;
                case '6':
                    writer.WriteLine(6);
                    break;
                case '7':
                    writer.WriteLine(7);
                    break;
                default:
                    throw new Exception("Zła cyfra !");
            }

        }


        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{FullFileName}"))
            {

                using (var reader = File.OpenText($"{FullFileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> gradesFromFile)
        {
            var statistics = new Statistics();

            foreach (var grade in gradesFromFile)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }


    }
}