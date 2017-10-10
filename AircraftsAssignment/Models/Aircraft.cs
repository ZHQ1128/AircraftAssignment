using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftsAssignment.Models
{
    class Aircraft
    {
        public string Name { get; set; }
        public int SpeedInKM { get; set; }
        public int YearProduced { get; set; }
        public int AmountInStock { get; set; }
        public DateTime DateAdded { get; set; }

        public virtual string EngineSound() { return "Engine sound"; }
        public override string ToString()
        {
            return $"Name: {Name}\nAmount In Stock: {AmountInStock}\n";
            //return $"Name: {Name}\nAmount In Stock: {AmountInStock}\nSpeed In KM: {SpeedInKM}\nYear Produced: {YearProduced}\nDate Added: {DateAdded}\n";
        }

    }
}
