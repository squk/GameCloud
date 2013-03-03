using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSync
{
    class Location
    {
        private string myName = string.Empty;
        private string myLocation = string.Empty;

        public Location(string name, string location)
        {
            myName = name;
            myLocation = location;
        }

        public string Name
        {
            get { return myName; }
        }

        public string Directory
        {
            get { return myLocation; }
            set { myLocation = value; }
        }
    }
}
