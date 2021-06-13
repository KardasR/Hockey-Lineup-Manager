using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hockey_Lineup_Manager
{
    public static class Methods
    {
        public static Dictionary<string, NHLTeam> Teams = new Dictionary<string, NHLTeam>();
        //public static Org org = new Org();

        private static string _currentTeam = string.Empty;

        static Methods()
        {
            //
        }

        /// <summary>
        /// Return the currently selected team in the dictionary, converted to a string.
        /// </summary>
        /// <returns></returns>
        public static string SelectCurrent()
        {
            if (Teams.ContainsKey(_currentTeam))
                return JsonConvert.SerializeObject(Teams[_currentTeam]);

            return null;
        }

        /// <summary>
        /// Returns the currently selected year. This is to allow other forms to add to the dictionary
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentYear()
        {
            if (_currentTeam.Equals(string.Empty))
                return "2020-2021";

            return _currentTeam;
        }

        /// <summary>
        /// Add a new team to the dictionary of teams. This does NOT change the selected team to the additional team.
        /// </summary>
        /// <param name="team"></param>
        public static void Add(string year, string team)
        {
            if (Teams.ContainsKey(year) == false)
            {
                Teams.Add(year, JsonConvert.DeserializeObject<NHLTeam>(team));
            }
            else
            {
                // Wait to do this but you may need to 
                //Teams[year].Name = givTeam.Name;
                //Teams[year].League = givTeam.League;

                Teams[year] = JsonConvert.DeserializeObject<NHLTeam>(team);
            }
        }

        /// <summary>
        /// Sets the team in the dictionary with the given year to the currently selected team. If there is no team 
        ///     in the dictionary with the year a false will be passed.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static bool SetCurrent(string year)
        {
            if (Teams.ContainsKey(year) == true)
            {
                _currentTeam = year;
                return true;
            }

            return false;
        }

        public static dynamic GiveHistory<T>()
        {
            if (typeof(T) == typeof(Dictionary<string, NHLTeam>))
                return Teams;
            else if (typeof(T) == typeof(string))
                return JsonConvert.SerializeObject(Teams);
            else
                return false;
        }
    }
}
