namespace CompetitionApp
{
    public class Member
    {
        public virtual string CoupleNumber { get; set; }

        public Member(string coupleNumber)
        {
            this.CoupleNumber = coupleNumber;           
        }
    }
}

