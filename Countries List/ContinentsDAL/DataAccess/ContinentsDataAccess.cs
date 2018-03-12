using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinentsDAL.DataAccess
{
    class ContinentsDataAccess
    {

        //return all continents
        public DataSet ReturnContinent()
        {
            var dataSet = new DataSet();
            using (var con = new SqlConnection(""))
            {
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
            using (var con = new SqlConnection(""))
            {
                var command = new SqlCommand("SP_ReturnContent", con);

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
