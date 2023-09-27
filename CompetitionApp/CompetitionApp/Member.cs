namespace CompetitionApp
{
    public class Member
    {
        public virtual int CoupleNumber { get; set; }

        public Member(int coupleNumber)
        {
            this.CoupleNumber = coupleNumber;           
        }
    }
}

