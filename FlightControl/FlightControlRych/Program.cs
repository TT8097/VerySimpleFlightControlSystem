using Rychlikapp.stdlibrary.Models;
using Rychlikapp.stdlibrary.Source;
using Rychlikapp.stdlibrary.System;
using System.Collections.Generic;


namespace FlightControlRych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = new List<Town>();
            List<Airplane> airplanes = new List<Airplane>();
            
           // FlightControlSystem flightcontrol= new FlightControlSystem();
           //flightcontrol.CurrentStateView(airplane);
            Repository repository = new Repository();
            FlightControlSystem x = new FlightControlSystem();
            Town town=repository.getTown("Krakow");
            Town town2 = repository.getTown("Seattle");
            Airplane airplane = repository.getAirplane(town);
            airplane.ArrivalTown = town2;
            x.Register_Airplane(airplane);
            x.CurrentStateView();





            towns.Add(repository.getTown("Lublin"));
            towns.Add(repository.getTown("Warszawa"));
            towns.Add(repository.getTown("Poznań"));
            towns.Add(repository.getTown("Londun"));
            towns.Add(repository.getTown("Dublin"));
            towns.Add(repository.getTown("Las Vegas"));
            towns.Add(repository.getTown("Detroit"));
            towns.Add(repository.getTown("Katowice"));
            towns.Add(repository.getTown("Rembertow"));
            towns.Add(repository.getTown("Ciechocinek"));
            towns.Add(repository.getTown("Mikolajki"));
            towns.Add(repository.getTown("Zakopane"));
            towns.Add(repository.getTown("Bialystok"));
            towns.Add(repository.getTown("Moskwa"));
            towns.Add(repository.getTown("Kijow"));
            towns.Add(repository.getTown("Budpeszt"));
            towns.Add(repository.getTown("Lipinki"));
            towns.Add(repository.getTown("Choroszcz"));
            towns.Add(repository.getTown("Gdynia"));
            towns.Add(repository.getTown("lokow"));
            for (int i = 0; i < 10; i++) {
                Airplane temp_airplane = new Airplane($"Lot{i}", 900, towns[i]);
                temp_airplane.ArrivalTown = towns[towns.Count-1-i];
                
                airplanes.Add(temp_airplane);
            }
            
            
            
            x.Register_Airplane(airplanes);
           
            x.CurrentStateView();
        }
    }
}
