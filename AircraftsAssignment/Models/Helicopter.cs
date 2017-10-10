using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftsAssignment.Models
{
    class Helicopter : Aircraft
    {
        public int NumberOfBlades { get; set; }
        public bool CanLandOnWater { get; set; }
        public override string EngineSound()
        {
            return "Helicopter Engine Sound : chakk-chackk-chaka-chak-akk-chk-chk-chk\n";
        }
        public override string ToString()
        {
            //return base.ToString() + $"Number Of Blades: {NumberOfBlades}\n" + $"CanLandOnWater: {CanLandOnWater}\n";
            return base.ToString();
        }
        public Helicopter(string hName, int addAmountH)
        {
            this.Name = hName;
            //this.AmountInStock = addAmountH - AirMenu.sellAmountH;
            this.AmountInStock = addAmountH;
            this.SpeedInKM = new Random().Next(3000, 5000);
            this.YearProduced = new Random().Next(1999, 2014);
            this.DateAdded = DateTime.Now;
            this.NumberOfBlades = new Random().Next(3, 5);
            this.CanLandOnWater = new Random().Next(10) % 2 == 0;
        }
    }
}
