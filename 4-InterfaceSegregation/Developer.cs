namespace InterfaceSegregation
{
    public class Developer : IWorkTeamActivities, IDeveloperActivities 
    {
        public Developer()
        {
        }

        public void Plan()
        {
            throw new NotImplementedException();
        }
        public void Comunicate()
        {
            throw new NotImplementedException();
        }

        public void Develop()
        {
            Console.WriteLine("Actividades de desarrollo ejecutandose ... ");
        }

  
    }
}