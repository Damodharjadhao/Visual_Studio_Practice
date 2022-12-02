namespace Dapper_Crud.Infrastructure
{
    public class QueryProvider : ISqlQueryProvider
    {

        public string GetAllDataQuery()
        {
            string _getQuery = "SELECT * FROM superheroes";
            return _getQuery;
        }

        public string CreateData(SuperHero hero)
        {
            string sqlQuery = $"Insert into superheroes(Name,FirstName,LastName,place) values('{hero.Name}','{hero.FirstName}','{hero.LastName}','{hero.place}')";
            return sqlQuery;
        }

        
        public string GetDataById(int id)
        {
          string sqlQuery= $"SELECT * From superheroes where id={id}";
            return sqlQuery;
        }

        public string UpdateDataQuery(SuperHero hero)
        {
            string sqlQuery = $"Update superheroes set Name='{hero.Name}',FirstName='{hero.FirstName}',LastName='{hero.LastName}',place='{hero.place}' where id='{hero.Id}'";
            return sqlQuery;
        }


        public string DeleteDataQuery(int id)
        {
            string sqlQuery = $"delete From superheroes where id={id}";
            return sqlQuery;
        }
    }
}
