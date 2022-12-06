namespace Dapper_Crud.Infrastructure
{
    public interface ISqlQueryProvider
    {
        public string GetAllDataQuery();
        public string CreateData(SuperHero hero);
        public string GetDataById(int id);
        public string UpdateDataQuery(SuperHero hero);
        public string DeleteDataQuery(int id);
    }
}
