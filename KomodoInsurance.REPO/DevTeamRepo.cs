using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoInsurance.POCO;

namespace KomodoInsurance.REPO
{
    public class DevTeamRepo
    {
        private readonly List<DevTeam> _teams = new List<DevTeam>();
        private readonly List<Developer> _developers = new List<Developer>();
        private int _count = 0;
        public bool AddTeams(DevTeam teams)
        {
            if (_teams == null)
            {
                return false;
            }
            
            _teams.Add(teams);
            return true;


        }
            
        public bool RemoveTeams(int id)
        {
            DevTeam deleteTeam = GetDevTeamById(id);
            if (deleteTeam == null)
            {
                return false;
            }
            else
            {
                _teams.Remove(deleteTeam);
                return true;
            }
        }

        public DevTeam GetDevTeamById(int Id)
        {


            foreach (DevTeam devTeams in _teams)
            {
                if (Id == devTeams.Id)
                {
                    return devTeams;
                }
            }
            return null;
        }
    }
}
