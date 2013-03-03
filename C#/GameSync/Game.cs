using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSync
{
    class Game
    {
        private string myName = string.Empty;
        private string myLocation = string.Empty;
        private string myWarning = string.Empty;
        private string myExclude = string.Empty;
        private string myInclude = string.Empty;
        private string myType = string.Empty;

        public Game(string name, string location, string warning, string exclude, string include, string type)
        {
            myName = name;
            myLocation = location;
            myWarning = warning;
            myExclude = exclude;
            myInclude = include;
            myType = type;
        }

        public string Name
        {
            get { return myName; }
        }

        public string Location
        {
            get { return myLocation; }
            set { myLocation = value; }
        }

        public string Warning
        {
            get { return myWarning; }
            set { myWarning = value; }
        }

        public string Exclude
        {
            get { return myExclude; }
            set { myExclude = value; }
        }

        public string Include
        {
            get { return myInclude; }
            set { myInclude = value; }
        }

        public string Type
        {
            get { return myType; }
            set { myType = value; }
        }
    }
}
