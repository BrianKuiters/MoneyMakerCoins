using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMakerCoins
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables
            double goldValue = 10;
            double silverValue = 5;

            //Question to user
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("What is the amount?:\n");
            // Console.ReadLine(); 

            //Saving amount of coins to variable + converting ToDouble
            double amountCoins = Convert.ToDouble(Console.ReadLine());

            //Maximum Gold Coins in amountCoins
            double maximumGold = Math.Floor(amountCoins / goldValue);
            double goldCoins = maximumGold;

            //Calculate remainding cents

            double remainingCents = amountCoins % goldValue;

            // Silver coins remainder

            double maximumSilver = Math.Floor(remainingCents / silverValue);
            double silverCoins = maximumSilver;

            //Total remainder after silver calculation

            double totalRemainder = amountCoins % silverValue;



            // //Get.Type for variables
            // Type amountType = amountCoins.GetType();

            Console.WriteLine($"{amountCoins} cents is equal to {goldCoins} Goldcoins, {silverCoins} SilverCoins and {totalRemainder} Bronze coins!");
            Console.ReadKey();
        }
    }
}
