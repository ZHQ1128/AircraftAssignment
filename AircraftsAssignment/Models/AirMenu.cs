using AircraftsAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public static class AirMenu
{
    //public static int addAmount;
    //public static int sellAmountAP;
    //public static int addAmount;
    //public static int sellAmountH;
    public static void StartProgram()
    {
        AirHanger airHanger = new AirHanger();
        int userAction = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("1. Buy Airplanes");
            Console.WriteLine("2  Sell Airplanes");
            Console.WriteLine("3. Buy Helicoptors");
            Console.WriteLine("4  Sell Helicoptors");
            Console.WriteLine("5. Show aircrafts");
            Console.WriteLine("6. Quit");
            userAction = int.Parse(Console.ReadLine());

            switch (userAction)
            {
                case 1:
                    {
                        Console.WriteLine("Enter Airplane Name");
                        string apName = Console.ReadLine().ToLower();
                        Console.WriteLine("Enter Amount to buy");
                        int addAmountAP = int.Parse(Console.ReadLine());
                        airHanger.BuyAirplanes(apName, addAmountAP);
                        //Console.WriteLine($"APlist.Count =  {AirHanger.APList.Count}");
                        Console.ReadKey();
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("Enter Airplane Name");
                        string apName = Console.ReadLine().ToLower();
                        var obj = AirHanger.APList.FirstOrDefault(x => x.Name == apName);

                        if (obj == null)  // wrong helicopter name
                        {
                            Console.WriteLine($"There is no airplane with a name {apName} in the stock.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Enter Amount to sell");
                            int sellAmountAP = int.Parse(Console.ReadLine());

                            if ((obj != null) && sellAmountAP <= obj.AmountInStock)
                            {
                                airHanger.SellAirPlanes(apName, sellAmountAP);
                                //Console.WriteLine($"obj.AmountInStock ={obj.AmountInStock} sellAmount ={sellAmountAP} Call Sellaircrafts()!");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine($"There are only {obj.AmountInStock} {apName} Airplanes in the stock. Please enter a number between (1 and {obj.AmountInStock}).");
                                Console.ReadKey();
                            }
                        }
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Enter Helicopter Name");
                        string hName = Console.ReadLine().ToLower();
                        Console.WriteLine("Enter Amount to buy");
                        int addAmountH = int.Parse(Console.ReadLine());
                        airHanger.BuyHelicopters(hName, addAmountH);
                        //Console.WriteLine($"HeliList.Count =  {AirHanger.HeliList.Count}");
                        Console.ReadKey();
                    }

                    break;
                case 4:
                    {
                        Console.WriteLine("Enter Helicopter Name");
                        string hName = Console.ReadLine().ToLower();
                        var obj2 = AirHanger.HeliList.FirstOrDefault(x => x.Name == hName);

                        if (obj2 == null)  // wrong helicopter name
                        {
                            Console.WriteLine($"There is no helicopter with a name {hName} in the stock.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Enter Amount to sell");
                            int sellAmountH = int.Parse(Console.ReadLine());

                            if ((obj2 != null) && sellAmountH <= obj2.AmountInStock)
                            {
                                airHanger.SellHelicopters(hName, sellAmountH);
                                //Console.WriteLine($"obj.AmountInStock ={obj2.AmountInStock} sellAmount= {sellAmountH} Numbers instock: {obj2.AmountInStock - sellAmountH}. Call Sellaircrafts()!");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine($"There are only {obj2.AmountInStock} {hName} helicopters in the stock. Please enter a number between (1 and {obj2.AmountInStock}).");
                                Console.ReadKey();
                            }
                        }
                    }
                    break;

                case 5:
                    {
                        airHanger.Display();
                        Console.WriteLine($"There are {AirHanger.APList.Count} airplanes and {AirHanger.HeliList.Count} helicopters in the stock.");
                        Console.ReadKey();
                    }
                    break;

                default:
                    break;
            }

        } while (userAction != 6);

    }
}
