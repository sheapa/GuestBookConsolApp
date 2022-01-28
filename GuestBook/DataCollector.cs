using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace GuestBook
{
    internal class DataCollector
    {
        public static void PartyInfo(bool lastGuest, List<object> partyList, int partyTotal)
        {
            
          
            do
            {
                Console.Write("Would you like to add a party to the guest list? (yes/no) ");
                string guestCheck = Console.ReadLine();

                if (guestCheck == "yes")
                {
                    Console.Write("What is the name of the guest party? ");
                    string partyName = Console.ReadLine();
                    if (partyName == null)
                    {
                        partyName = " ";
                    }

                    Console.Write("How many are in the party? ");
                    int partyNumber = Int32.Parse(Console.ReadLine());

                    partyTotal += partyNumber;

                    Tuple<string, int> partyTuple = new Tuple<string, int>(partyName, partyNumber);

                    partyList.Add(partyTuple);

                }
                else if (guestCheck == "no")
                {
                    Console.WriteLine("Final list of party attendees:");
                    foreach (var party in partyList)
                    {
                        Console.WriteLine(party);
                    }

                    Console.WriteLine($"The total number of guests is {partyTotal}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid response. Please try again");
                }


            } while (lastGuest == false);


        }

        
        

    }


}
