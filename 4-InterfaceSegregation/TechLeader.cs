namespace InterfaceSegregation
{
    public class TechLeader : IWorkTeamActivities, ILeadTech
    {
        public TechLeader(){
            Console.WriteLine("Tech Leader is created");
        }
        public void CodeReview()
        {
          Console.WriteLine("ejecutandoo el CodeReview");
        }

        public void Comunicate()
        {
            throw new NotImplementedException();
        }

        public void ManagingTeam()
        {
            throw new NotImplementedException();
        }

        public void Plan()
        {
            throw new NotImplementedException();
        }
    }
}