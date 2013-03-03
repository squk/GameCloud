using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSync
{
    class LocationList
    {
        private List<Location> myLocations = new List<Location>();

        public LocationList()
        {
            myLocations.Add(new Location("Ubisoft", Utility.getLocalEnvironmentPath("LOCALAPPLICATIONDATA") + @"Ubisoft\"));
            myLocations.Add(new Location("My Games", Utility.getLocalEnvironmentPath("MYDOCUMENTS") + @"My Games"));


            #region Require Steam Name input
            #endregion
        }

        public List<Location> Locations
        {
            get { return myLocations; }
        }

    }
}
