using CompetitionApp;

namespace CompetitionApp
{
    public abstract class MemberBase : IMember
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;

        public MemberBase(int coupleNumber)
        {
            this.CoupleNumber = coupleNumber;
        }

        public string Number { get; private set; }
        

        public abstract void AddGrade(float grade);


        public abstract void AddGrade(int grade);


        public abstract void AddGrade(char grade);


        public abstract Statistics GetStatistics();

    }
}