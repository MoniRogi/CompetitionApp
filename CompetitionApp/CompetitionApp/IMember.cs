using System.Runtime.CompilerServices;
using static CompetitionApp.MemberBase;

namespace CompetitionApp
{
    public interface IMember
    {
        public string CoupleNumber { get; }

        public void AddGrade(float grade)
        {
            if (grade >= 1 && grade <= 7)
            {
                this.AddGrade(grade);
            }
            else
            {
                Console.WriteLine("Błędna cyfra, wpisz z zakrsu 1-7");
            }
        }

        void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("Błędna cyfra, wpisz z zakresu 1-7");
            }
        }

        void AddGrade(int grade);   
       
        void AddGrade(char grade);


        event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics();
    }
}