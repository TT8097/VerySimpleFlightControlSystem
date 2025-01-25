using Rychlikapp.stdlibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rychlikapp.stdlibrary.System
{
    public class FlightControlSystem
    {
        private List<Airplane> _tracedAirplanes=new List<Airplane>();
        public void Register_Airplane(Airplane airplane) {
            _tracedAirplanes.Add(airplane);
            Console.WriteLine($"Zarejestrowano - {airplane.Identificator} ");
        }
        public void Register_Airplane(List<Airplane> airplanes)
        {
            foreach (Airplane airplane in airplanes)
            {
                _tracedAirplanes.Add(airplane);
                Console.WriteLine($"Zarejestrowano - {airplane.Identificator} ");
            }
        }
        public void CurrentStateView() {
            // zle zrozumialem poprzednie wymmagania i ta funkcja dostawala obiekt airplane do funkcji a nie do klasy dlatego tu uzywam airplane zamiast _tracedAirplane
            //Console.WriteLine($"zarejestrowano {airplane.Identificator}");
            //Console.WriteLine("Obecny stan systemu [{0:t}]:", DateTime.Now);
            //Console.WriteLine($"identyfikator  Poz. X  Poz.Y  Wylecial z  Leci do  Dotrze o\n " +
            //    $"{airplane.Identificator},   " +
            //    $" {airplane.Location.X},     {airplane.Location.Y},  " +
            //    $"{(airplane.DepartureTown != null ? airplane.DepartureTown.name:"Brak") },       " +
            //    $"{(airplane.ArrivalTown.name != null ? airplane.ArrivalTown.name : "Brak")}," +
            //    $"{tools.EstimatearrivalTime(airplane).ToString()}");


           
            Console.WriteLine("Obecny stan systemu [{0:t}]:", DateTime.Now);
            Console.WriteLine("{0,15} {1,8} {2,8} {3,12} {4,12} {5,10}",
            "Identyfikator", "Poz. X", "Poz. Y", "Wylecial z", "Leci do", "Dotrze o");
            foreach (Airplane _tracedAirplane in _tracedAirplanes)
            {
                string odp = "";
                if (_tracedAirplane.DepartureTown is null || _tracedAirplane.ArrivalTown is null) { odp = "blad"; } else { odp = tools.EstimatearrivalTime(_tracedAirplane).ToString(); }

                Console.WriteLine("{0,15} {1,8} {2,8} {3,12} {4,12} {5,10}",
                $"{_tracedAirplane.Identificator}", $"{(_tracedAirplane.Location is null ? "brak": _tracedAirplane.Location.X.ToString())}", $"{(_tracedAirplane.Location is null ? "brak":_tracedAirplane.Location.Y.ToString())}", $"{(_tracedAirplane.DepartureTown != null ? _tracedAirplane.DepartureTown.name : "Brak")}", $"{(_tracedAirplane.ArrivalTown != null ? _tracedAirplane.ArrivalTown.name : "Brak")}", $"{odp}");
            }
        }
        
            public FlightControlSystem() { Console.WriteLine("System kontroli lotow zostal uruchomiony");}
        


    }
}
