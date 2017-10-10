using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftsAssignment.Models
{
    class AirHanger 
    {
        // public static List<Aircraft> Aircrafts = new List<Aircraft>();
        public static List<Aircraft> APList = new List<Aircraft>();
        public static List<Aircraft> HeliList = new List<Aircraft>();
        // enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
        // Enum!!! casting!!! 
        //  drag the file to you file, then click  project => show all files
        //
        // int top =console.cursortop
        // int left =console.cursorLeft
        //ConsoleColor.white
        //microsoft ignite 2017 Quantum computing

        public void BuyAirplanes(string apName, int addAmountAP)     //(add airplanes to the list) 
        {
            for (int i = 0; i < addAmountAP; i++)
            {
                AirPlane AP = new AirPlane(apName, addAmountAP);
                APList.Add(AP);
                //Aircrafts.Add(AP);
            }
        }

        public void BuyHelicopters(string hName, int addAmountH)    //(add airplanes to the list) 
        {
            for (int i = 0; i < addAmountH; i++)
            {
                Helicopter Heli = new Helicopter(hName, addAmountH);
                HeliList.Add(Heli);
                //Aircrafts.Add(Heli);
            }
        }

        //remove helicopters or planes (can be two separate methods, the amount of items in the list should not go below zero) 
        public void SellAirPlanes(string apName, int sellAmountAP)
        {
            for (int i = 0; i < APList.Count; i++)
            {
                if (APList[i].Name == apName)
                {
                    APList.RemoveRange(i, sellAmountAP);
                    //APList.RemoveRange(i, 2);
                    //Console.WriteLine($"remove");
                    foreach (AirPlane ap in APList)
                    {
                        if (ap.Name == apName)
                        {
                            ap.AmountInStock -= sellAmountAP;
                        }
                    }
                    break;
                }
            }
        }


        public void SellHelicopters(string hName, int sellAmountH)
        {

            for (int i = 0; i < HeliList.Count; i++)
            {
                int count = 0;
                while (HeliList[i].Name == hName)
                {
                    count++;
                    HeliList.Remove(HeliList[i]);
                    foreach (var heli in HeliList)  // to change the amount number in the stock and also make sure user can not sell more numbers than the stock numbers.
                    {
                        if (heli.Name == hName)
                        {
                            heli.AmountInStock -= sellAmountH;
                        }
                    }
                    if (count == sellAmountH)
                        break;
                }
                break;
            }
        }
        //for (int i = 0; i < APList.Count; i++)
        //{
        //    if (HeliList[i].Name == hName)
        //    {
        //        HeliList.RemoveRange(i, sellAmountH);
        //        foreach (Helicopter heli in HeliList)
        //        {
        //            if (heli.Name == hName)
        //            {
        //                heli.AmountInStock -= sellAmountH;
        //            }
        //        }
        //        break;
        //    }
        //}


        // is 
        //   foreach (Aircraft a in aircrafts)
        //{
        //   if (a is AirPlane)
        //   {
        //   }
         //}
      

            // Aircrafts.Count(x => x is Helicopter)


        public void Display()
        {
            string disPlay = "";
            foreach (AirPlane item in APList)
            {
                //Aircrafts.Add(item);
                disPlay += $"{item.ToString()}{item.EngineSound()}SpeedInKM: {item.SpeedInKM}\nYearProduced: {item.YearProduced}\n" +
                $"DateAdded{item.DateAdded}\n" + Environment.NewLine;

            }
            foreach (Helicopter item in HeliList)
            {
                //Aircrafts.Add(item);
                disPlay += $"{item.ToString()}{item.EngineSound()}SpeedInKM: {item.SpeedInKM}\nYearProduced: {item.YearProduced}\n" +
                $"DateAdded{item.DateAdded}\nNumberOfBlades: {item.NumberOfBlades}\nCanLandOnWater: {item.CanLandOnWater}\n" + Environment.NewLine;
            }
            Console.WriteLine(disPlay);
        }
    }
}
