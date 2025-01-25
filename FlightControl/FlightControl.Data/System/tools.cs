using Rychlikapp.stdlibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Rychlikapp.stdlibrary.System
{
    public class tools
    {
        public static double ComputeDistance(Position a , Position b) {
            // przyjmujemy ze a to opis szerokosci i dlugosci geograficznej a nie punkt na plaszczyznie oraz a.X to szerokosc geograficzan a a.Y to dlugosc geograficzna
            decimal x = ((decimal)Math.Pow((b.X - a.X),2));
            decimal y = (decimal)(Math.Pow(Math.Cos((a.X*3.14)/180)*(b.Y-a.Y),2.0));
            return Math.Round(Math.Sqrt((double)Decimal.Add(x,y)) * (40075.704 / 360), 2);
            
        }
        public static DateTime EstimatearrivalTime(Airplane airplane) {
            double distance = ComputeDistance(airplane.Location, airplane.ArrivalTown.TownLocation);
            int velocity = (int)(airplane.Velocity);
            double time = Math.Round((distance / velocity)*60, 0);
            return DateTime.Now.AddMinutes(time);
        }
    }
}
