using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryBLO.Models
{
    public class Country
    {
        public string countryID { get; set; }
        public string countryName { get; set; }
        public string countryCapital { get; set; }
        public int countryPopulation { get; set; }
        public string continentID { get; set; }


        //return countary by id
        public static List<Country> countaryRturn()
        {
            var countries = new List<Country>();    

           
            var counaryDataAccess = new CountryDAL.DataAccess.CountryDataAccess();

            DataTable dataTabe = counaryDataAccess.returnCountry().Tables[0];

            foreach (DataRow row in dataTabe.Rows)
            {
                var countary = new Country();
                countary.countryID = row["countryID"].ToString();
                countary.countryName = row["countryName"].ToString();
                countary.countryCapital = row["countryCapital"].ToString();
                countary.countryPopulation = Convert.ToInt32(row["countryPopulation"]);
                countries.Add(countary);
            }
            return countries;

        }

        //return countary by id
        public static Country countaryRturn(string countaryID)
        {
            var countary = new Country();
            var counaryDataAccess = new CountryDAL.DataAccess.CountryDataAccess();

            DataTable dataTabe =  counaryDataAccess.returnCountry(countaryID).Tables[0];

            foreach (DataRow row in dataTabe.Rows)
            {
                countary.countryID = row["countryID"].ToString();
                countary.countryName = row["countryName"].ToString();
                countary.countryCapital = row["countryCapital"].ToString();
                countary.countryPopulation = Convert.ToInt32(row["countryPopulation"]);
            }
            return countary;

        }
        //return countries by country id      
        //public List<Country> conuntriesRturn(string countaryID)
        //{
        //    //var countries = new List<Country>();
        //    //for (var id = 0; id < countaryID.Length; id++)
        //    //{
        //    //    var countary = new Country();
        //    //    string countryId = countaryID[id];

        //    //    countary = countaryRturn(countryId);

        //    //    countries.Add(countary);
        //    //}

        //    return countries;
        //}
    }


    //
}
