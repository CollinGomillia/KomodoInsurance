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
        public DevTeam(DevType devTeam)
        {
            DevType = devTeam;
        }

       

        public DevType DevTeamNumber { get; set; }

        public enum DevType
        {
            Dev_TeamOne = 1,
            Dev_TeamTwo
        }
    }
}
