using Ado_crud_practice.Model;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Ado_crud_practice.Repositorys
{
    public class SuperHeroRepo
    {
        private readonly string _connectionString;
        private IConfiguration Configuration;

        public SuperHeroRepo(IConfiguration config)
        {
            Configuration = config;
            _connectionString = Configuration["ConnectionStrings:DefaultConnection"];
        }
       
        public IEnumerable<SuperHero> get()
        {
            var superheros = new List<SuperHero>();
            DataTable SuperHeroTable = new DataTable();

            using (var connection = new SqlConnection(_connectionString))
            {

                string query = "SELECT * FROM superheroes";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(SuperHeroTable);
            }

            for (int i = 0; i < SuperHeroTable.Rows.Count; i++)
            {
                SuperHero emp = new SuperHero()
                {
                    Id = (int)SuperHeroTable.Rows[i]["Id"],
                    Name = (string)SuperHeroTable.Rows[i]["Name"],
                    FirstName = (string)SuperHeroTable.Rows[i]["FirstName"],
                    LastName = (string)SuperHeroTable.Rows[i]["LastName"],
                    place = (string)SuperHeroTable.Rows[i]["place"],

                };
                superheros.Add(emp);
            }
            return superheros;
        }

        public bool Post(SuperHero Hero)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = $"insert into superheroes(Name,Firstname,LastName,place) values ('{Hero.Name}','{Hero.FirstName}','{Hero.LastName}','{Hero.place}')";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            return true;
        }

        public bool Update(SuperHero hero, int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = $"UPDATE superheroes set Name='{hero.Name}',Firstname='{hero.FirstName}',LastName='{hero.LastName}',place='{hero.place}' Where Id='{id}'";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            return true;
        }

        public bool Delete(int id)
        {
            
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = $"DELETE FROM superheroes where Id='{id}'";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                return true;            
        }
    }
}
    
