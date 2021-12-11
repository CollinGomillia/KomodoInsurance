using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.POCO
{
    public class DevTeam
    {
        public DevTeam()
        {

        }

        public string NameOfTeam { get; set; }
        public int TeamId { get; set; }
        public string Developers { get; set; }
        public int Id { get; set; }

        public DevTeam(string nameOfTeam, int teamId, string developers)
        {
            NameOfTeam = nameOfTeam;
            TeamId = teamId;
            Developers = developers;
        }




    }
}
