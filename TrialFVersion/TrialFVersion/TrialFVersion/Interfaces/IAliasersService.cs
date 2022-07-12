using TrialFVersion.Database;
using TrialFVersion.Model;

namespace TrialFVersion.Service
{
    public interface IAliasersService
    {
        public Aliaser AddAlias(string url, string alias);
        public bool IsAliasInUse(string alias);
        public Aliaser FindAliasersByAlias(string alias);
        public void HitCountIncrease(string alias);
        public List<Aliaser> GetList();
        Aliaser? GetAlias(int id);
        void DeleteAliaser(int id);
    }
}