using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoInsurance.POCO;

namespace KomodoInsurance.REPO
{
    public class DeveloperRepo
    {
        private readonly List<DevTeam> _developers = new List<DevTeam>();

        //Crud
        public void AddDeveloper(DevTeam developer)
        {
            _developers.Add(developer);
        }

        public List<DevTeam> GetDeveloper()
        {
            return _developers;
        }

        public void RemoveOrder(DevTeam developer)
        {
            foreach (var developerPOCO in _developers)
            {
                if(developerPOCO == developer)
                {
                    _developers.Remove(developerPOCO);
                    break;
                }
            }
        }
    }
}
