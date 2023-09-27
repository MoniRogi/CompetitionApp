using static CompetitionApp.MemberBase;

namespace CompetitionApp
{
    public interface IMember
    {
        int CoupleNumber { get; }
      
        void AddGrade(float grade);
      
        void AddGrade(int grade);        

        void AddGrade(char grade);

        event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics();
    }
}