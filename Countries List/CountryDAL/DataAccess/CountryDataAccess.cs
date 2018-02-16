using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CountryDAL.DataAccess
{
    public class CountryDataAccess
    {

        private string cs = ConfigurationManager.ConnectionStrings[""].ConnectionString;

        //return all users
        DataSet dataset { get; set; }
        public DataSet returnCountrys()
        {

            dataset = new DataSet();
            using (SqlConnection con = new SqlConnection(cs))
            {

                SqlCommand cmd = new SqlCommand("", con);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);

                dataadapter.Fill(dataset);

                return dataset;

            }

        }
    }
}
