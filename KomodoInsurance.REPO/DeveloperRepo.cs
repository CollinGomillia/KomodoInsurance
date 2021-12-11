using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoInsurance.POCO;

namespace KomodoInsurance.REPO
{
    private readonly List<Developer> _developers = new List<Developer>();

        private int _count = 0;
        //Crud
        public bool AddDeveloper(Developer developer)
        {
            if (developer == null)
            {
                return false;
            }
            _count++;
            developer.Id = _count;
            _developers.Add(developer);
            return true;
        }

        public List<Developer> GetDeveloper()
        {
            return _developers;
        }

        public bool RemoveDeveloper(int id)
        {
            Developer developerRemove = GetDeveloperById(id);
            if (developerRemove == null)
            {
                return false;
            }
            else
            {
                _developers.Remove(developerRemove);
                return true;
            }
        }

        public Developer GetDeveloperById(int Id)
        {
            

            foreach (Developer developer in _developers)
            {
                if (Id == developer.Id)
                {
                    return developer;
                }
            }
            return null;
        }
    }
}
