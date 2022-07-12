using System.Linq;
using TrialFVersion.Database;
using TrialFVersion.Model;

namespace TrialFVersion.Service
{
    public class AliasersService : IAliasersService
    {
        private ApplicationDbContext context;
        public AliasersService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Aliaser AddAlias(string url, string alias)
        {
            //steve bishop nema vysvetleni
            Aliaser aliaser = context.Aliases.Add(new Aliaser {Url = url, Title = alias }).Entity;
            context.SaveChanges();
            return aliaser;
        }
        public bool IsAliasInUse(string alias)
        {
            return context.Aliases.Any(a => a.Title == alias);
        }

        public Aliaser FindAliasersByAlias(string alias)
        {
            return context.Aliases.Where(a => a.Title == alias).FirstOrDefault();
        }
        public void HitCountIncrease(string alias)
        {
            var searchedAlias = FindAliasersByAlias(alias);
            searchedAlias.HitCount++;
            context.SaveChanges();
        }
        
        public List<Aliaser> GetList()
        {
            var listOfAliases = context.Aliases.ToList();
            return listOfAliases;
        }

        public void DeleteAliaser(int id)
        {
            Aliaser r = GetAlias(id)!;
            if (r is not null)
            {
                context.Aliases.Remove(r);
                context.SaveChanges();
            }

        }
        public Aliaser? GetAlias(int id)
        {
            return context.Aliases.FirstOrDefault(a => a.Id == id);
        }
    }
}
