using Rychlikapp.stdlibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rychlikapp.stdlibrary.Source
{
    public class Repository
    {
        public Town getTown()
        {
            return new Town() { name = "London", TownLocation = new Position(1123, -2142) };
        }
        public Airplane GetAirplane()
        {
            return new Airplane("Lot 94124", new Position(131, 2255));
        }
        Random rand = new Random();
        public Town getTown(String name)
        {
            
            return new Town() { name = name, TownLocation = new Position(rand.Next(0,200), rand.Next(0, 200)) };
        }
        public Airplane getAirplane(Town departureTown)
        {
            return new Airplane("Lot 23513", 900, departureTown);
        }

       
    }
}
