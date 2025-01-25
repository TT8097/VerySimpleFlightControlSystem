using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rychlikapp.stdlibrary.Models
{
    public class Airplane
    {
        public string Identificator { get; private set; }
        public Position Location { get; private set; }
        public float Velocity { get; set; }
        public Town DepartureTown;
        public Town ArrivalTown;

        public Airplane(string identificator, Position location)
        {
            Identificator = identificator;
            Location = location;
        }
        public Airplane(string identificator , float velocity) {
            Identificator = identificator;
            Velocity = velocity;
            Location = null;
        }
        public Airplane( string identificator,float velocity,Town departurtown) {
            Identificator =identificator;
            Velocity = velocity;
            Location = departurtown.TownLocation;
            DepartureTown=departurtown;

        
        }
    }
}
