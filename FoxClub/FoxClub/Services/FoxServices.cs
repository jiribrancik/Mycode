using FoxClub.Model;

namespace FoxClub.Services
{
    public class FoxServices
    {
        public Fox CurentFoxa { get; set; } = new("dasdasd");
        public List<Fox> ListOfFOxes{ get; set; }
        public FoxServices()
        {
            ListOfFOxes = new List<Fox>();
        }

        public void SetCurrent(string name)
        {
            Fox? current = ListOfFOxes.Find(x => x.Name == name);
            if (current == null)
            {
                CurentFoxa = new Fox(name);
                ListOfFOxes.Add(CurentFoxa);
            }
            else
            {
                CurentFoxa = current;
            }
                
                
            
            
        }
       
    }

    
}