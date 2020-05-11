using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Location
    {


        
        public string StateString { get; set; }
        public string Description { get; set; }

        public Location( string stateString, string description)
        {
            
            StateString = stateString;
            Description = description;
        }

        
    }
}//end class

    
