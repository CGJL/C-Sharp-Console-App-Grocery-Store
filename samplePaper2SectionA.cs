using System;
using System.Collections.Generic;


namespace SamplePaperOOP
{
    class Program
    {
       
    
         static void Main(string[] args)
        {
            //initializing lists to store items
            List<int> qtyList = new List<int>();
            List<string> codeList = new List<string>();
            List<decimal> priceList = new List<decimal>();
            List<decimal> foodDiscountList = new List<decimal>();


            

            void Prompt() // the input prompt for each item
            {

                Console.WriteLine("Enter Item Code: ");
                string itemCode = Console.ReadLine();
                Console.WriteLine("Enter Qty: ");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Unit Price: ");
                decimal unitPrice = Convert.ToDecimal(Console.ReadLine());
                decimal fDiscount = 0;

                if (itemCode.Substring(0, 1) == "F")
                {
                    fDiscount = 0.2m * unitPrice;
                }

                foodDiscountList.Add(fDiscount);
                qtyList.Add(quantity);
                codeList.Add(itemCode);
                priceList.Add(unitPrice);
            }
            
            
            bool x = true;
            bool y = true;
            //initialise membership number
            string memberNo = "";

            //intialise foodDiscount for midweek sale
            decimal foodDiscountTotal = 0;

            //intialising gross total
            decimal grossTotal = 0;

            // intialising member discount
            decimal memberDiscount = 0.1m;

            //initialise discount amount
            decimal discountAmt = 0;

            //intialise gst
            decimal gst = 0.07m;

            //initialise gstAmt
            decimal gstAmt = 0;

            //initialise totalPayable
            decimal totayPayable = 0;
            // run console prompts
            while (y)
            {
                while (x)
                {
                    Prompt();
                    Console.WriteLine("To enter more items, press Y; to end, press N: ");
                    string state = Console.ReadLine().ToUpper();
                    if (state == "Y")
                    {
                        continue;
                    }
                    else
                        break;
                }

                for (int i = 0; i < qtyList.Count; i++) //for loop to calculate food discounts
                {
                    foodDiscountTotal += foodDiscountList[i];
                }

                for (int i = 0; i < qtyList.Count; i++) //for loop to calcualate gross total
                {
                    decimal a = qtyList[i]* (priceList[i] - foodDiscountList[i]);
                    grossTotal += a;

                }
                Console.WriteLine("The Shopper a loyalty member?");
                string memberState = Console.ReadLine().ToUpper();

                if (memberState == "Y")
                {
                    Console.WriteLine("Member No: ");
                    memberNo = Console.ReadLine();
                    discountAmt = memberDiscount * grossTotal;
                    break;
                }
                else
                    break;
               
                


            }

            // calculate gstAmt
            gstAmt = (grossTotal - discountAmt) * gst;

            //calculate totalPayable
            totayPayable = grossTotal + gstAmt - discountAmt;

            string line = "";
            string line1 = line.PadRight(100,'-'); //horizontal line to be printed
            // all the output data
            Console.WriteLine("\nABC STORE"); 
            Console.WriteLine("SINGAPORE\n");

            Console.WriteLine("INVOICE\n");
            Console.WriteLine($"Date of Purchase: {DateTime.Today.Day}-{DateTime.Today.Month}-{DateTime.Today.Year}\t{DateTime.Today.DayOfWeek}");
            Console.WriteLine();
            Console.WriteLine(line1);
            Console.WriteLine("{0, -5} {1, -15} {2, -5} {3, -10:0.00} {4, -8:0.00} {5, -12:0.00} {6, -5:0.00}", "SNo", "Item Code" , "Qty", "U/Price" , "Cost", "Discount", "Net");
            Console.WriteLine(line1);
            for (int i = 0; i < qtyList.Count; i++)
            {

                Console.WriteLine("{0, -5} {1, -15} {2, -5} {3, -10:0.00} {4, -8:0.00} {5, -12:0.00} {6, -5:0.00}", i, codeList[i], qtyList[i], priceList[i], qtyList[i]*priceList[i], foodDiscountList[i]*qtyList[i], qtyList[i] * (priceList[i] - foodDiscountList[i]));

            }
            Console.WriteLine(line1);
            Console.WriteLine("{0, -60} {1, -10:0.00}", "Gross Total", $"${grossTotal:0.00}");
            Console.WriteLine("{0, -60} {1, -10:0.00}", "Member Discount\t"+ $"Member No ({memberNo})", $"-${discountAmt:0.00}");
            Console.WriteLine("{0, -60} {1, -10:0.00}", "GST @ 7%", $"+${gstAmt:0.00}");
            Console.WriteLine("{0, -60} {1, -10:0.00}", "Please Pay: ", $"+${totayPayable:0.00}");
        }


    }