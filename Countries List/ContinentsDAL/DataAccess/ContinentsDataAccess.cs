using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ContinentsDAL.DataAccess
{
    public class ContinentsDataAccess
    {
        private string cs = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        //return all continents
        public DataSet ReturnContinent()
        {
            var dataSet = new DataSet();
            using (var con = new SqlConnection(cs))
            {
                con.Open();
                var command = new SqlCommand("SP_ReturnContent", con);
                command.CommandType = CommandType.StoredProcedure;

                var dataAdaapter = new SqlDataAdapter(command);
                dataAdaapter.Fill(dataSet);
                    
                 command.ExecuteReader();
                 return dataSet;   
            }
       
        }
        //return continent by its id
        public DataSet ReturnContinent(string continentID)
        {
            var dataSet = new DataSet();
            using (var con = new SqlConnection(cs))
            {
                var command = new SqlCommand("SP_ReturnContentByID", con);

                var paramContinentID = new SqlParameter("@continentID", continentID);
                command.Parameters.Add(paramContinentID);

                command.CommandType = CommandType.StoredProcedure;

                var dataAdaapter = new SqlDataAdapter(command);
                dataAdaapter.Fill(dataSet);

                command.ExecuteReader();
                return dataSet;
            }

        }
    }
}
