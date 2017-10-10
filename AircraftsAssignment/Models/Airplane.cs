using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftsAssignment.Models
{
    class AirPlane : Aircraft
    {
        //public Airplane(string name) : base (name) { }

        private int numberOfWings;
        public int SetNumberOfWings(int num)
        {
            this.numberOfWings = num;
            return numberOfWings;
        }

        public override string EngineSound()
        {
            return "Airplane Engine Sound: buzz-wzz buzz-wzz buzz-wzz buzz-wzz\n";
        }

        public override string ToString()
        {
            //return base.ToString() + $"Number Of Wings: {SetNumberOfWings(2)}\n";
            return base.ToString() + $"Number Of Wings: {SetNumberOfWings(2)}\n".ToString();
        }
        public AirPlane(string apName, int addAmountAP) // Instance contructor
        {
            this.Name = apName;
            this.AmountInStock = addAmountAP;     // After selling some products, the AmountInStock value isn't change.
            this.SpeedInKM = new Random().Next(4000, 6000);
            this.YearProduced = new Random().Next(2005, 2017);
            this.DateAdded = DateTime.Now;
        }

    }
}
