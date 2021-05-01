using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hockey_Lineup_Manager
{
    public static class Methods
    {
        public static Dictionary<string, Team> Teams = new Dictionary<string, Team>();

        private static string _currentTeam = string.Empty;

        static Methods()
        {
            //
        }

        /// <summary>
        /// Return the currently selected team in the dictionary.
        /// </summary>
        /// <returns></returns>
        public static Team SelectCurrent()
        {
            if (Teams.ContainsKey(_currentTeam) == true)
            {
                return Teams[_currentTeam];
            }

            return null;
        }

        /// <summary>
        /// Add a new team to the dictionary of teams. This does NOT change the selected team to the additional team.
        /// </summary>
        /// <param name="team"></param>
        public static void Add(Team team)
        {
            if (Teams.ContainsKey(team.Year) == false)
            {
                Teams.Add(team.Year, team);
            }
            else
            {
                Teams[team.Year] = team;
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
    }
}
