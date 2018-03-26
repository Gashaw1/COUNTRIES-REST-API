using ContinentsDAL.DataAccess;
using CountryBLO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinentsBLO.Models
{
    public class Cotinent
    {
        public string CotinentID { get; set; }
        public string CotinentName { get; set; }
        public int CotinentPopulation { get; set; }
        public List<Country> countries { get; set; }

        //return single cotinent with its countary.
        public static List<Cotinent> continteniesRturn()
        {
            var continenties = new List<Cotinent>();              

            var continentDataAccess = new ContinentsDataAccess();

            DataTable dataTabe = continentDataAccess.ReturnContinent().Tables[0];

            foreach (DataRow row in dataTabe.Rows)
            {
                var continent = new Cotinent();
                continent.CotinentID = row["CotinentID"].ToString();
                continent.CotinentName = row["CotinentName"].ToString();
                continent.CotinentPopulation = ContinentTotalPopulation(continent.CotinentID);
                continent.countries = CotinentReturnCountary(continent.CotinentID);
                continenties.Add(continent);
            }
            return continenties;

        }
        //return country by continent id
        static List<Country> CotinentReturnCountary(string ID)
        {            
            var countaryResult = Country.countaryRturn().Where(x => x.continentID == ID).ToList();
            return countaryResult;
        }
        //return total of population in continent
        private static int ContinentTotalPopulation(string ID)
        {
            int toltal = 0;
           
            var countaryResult = Country.countaryRturn().Where(x => x.continentID == ID).ToList();

            foreach (var i in countaryResult)
            {
                toltal += i.countryPopulation;
            }
            return toltal;
           
        }
        ////return countary by id
        //public Country continentRturn(string countaryID)
        //    {
        //        var countary = new Cotinent();
        //        var counaryDataAccess = new CountryDAL.DataAccess.CountryDataAccess();

        //        DataTable dataTabe = counaryDataAccess.returnCountry(countaryID).Tables[0];

        //        foreach (DataRow row in dataTabe.Rows)
        //        {
        //            countary.countryID = row["countryID"].ToString();
        //            countary.countryName = row["countryName"].ToString();
        //            countary.countryCapital = row["countryCapital"].ToString();
        //            countary.countryPopulation = Convert.ToInt32(row["countryPopulation"]);
        //        }
        //        return countary;

        //    }
    }
}
