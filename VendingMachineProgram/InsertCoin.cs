using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineProgram
{
    internal class InsertCoin
    {
        public long currentAmount = 0;
        public void InsertCoinValue()
        {
            Console.WriteLine("Please Select Product");
            foreach (string s in Enum.GetNames(typeof(ProductEnum)))
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Please Enter selected product");
            string selectedProduct = Console.ReadLine();
            if (selectedProduct.ToUpper() == ProductEnum.Chips.ToString().ToUpper())
            {
                Console.WriteLine("Price of chips =" + ((int)(ProductEnum)0.50));
            }
            else if (selectedProduct.ToUpper() == ProductEnum.Candy.ToString().ToUpper())
            {
                Console.WriteLine("Price of Candy =" + ((int)(ProductEnum)0.65));
            }
            else if (selectedProduct.ToUpper() == ProductEnum.Cola.ToString().ToUpper())
            {
                Console.WriteLine("Price of cola =" + ((int)(ProductEnum)1));
            }
            else
            {
                Console.WriteLine("Please Select right product");
                return;
            }
            Console.WriteLine("Please insert coin");
            long receivedCoin = Convert.ToInt64(Console.ReadLine());

            if (receivedCoin == ((long)VendingEnum.dimes) || receivedCoin == ((long)VendingEnum.nickles) || receivedCoin == ((long)VendingEnum.quarters))
            {
                currentAmount += receivedCoin;
            }
            else
            {
                Console.WriteLine("Invalid Coin");
            }
            if(selectedProduct.ToUpper()== ProductEnum.Chips.ToString().ToUpper()&& currentAmount>= ((int)(ProductEnum)1))
            {
                Console.WriteLine("Please Collect your Chips");
            }
            if (selectedProduct.ToUpper() == ProductEnum.Candy.ToString().ToUpper() && currentAmount >= ((int)(ProductEnum)1))
            {
                Console.WriteLine("Please Collect your Candy");
            }
            if (selectedProduct.ToUpper() == ProductEnum.Cola.ToString().ToUpper() && currentAmount >= ((int)(ProductEnum)1))
            {
                Console.WriteLine("Please Collect your Cola");
            }
            else
            {
                Console.WriteLine("Please enter more amount");
            }
            Console.ReadLine();
        }
    }
}
