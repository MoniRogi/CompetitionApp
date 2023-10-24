using CompetitionApp;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

namespace CompetitionApp
{
    public abstract class MemberBase : IMember
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;

        public string CoupleNumber { get; private set; }

        public MemberBase(string coupleNumber)
        {
            this.CoupleNumber = coupleNumber;
        }
        
        public abstract void AddGrade(float grade);
      
        
        public abstract void AddGrade(int grade);


        public abstract void AddGrade(char grade);


        public abstract Statistics GetStatistics();

    }
}