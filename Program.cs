using System;

namespace _44663_P1
{
    class Program
    {
        //totalAmount method starts here.
        public decimal totalAmount(char choose, decimal individualAmount, int totalTickets)
        {
            decimal totalCost = 0.0m;
            switch(choose)
            {
                case 'A': case 'a':
                totalCost = individualAmount*totalTickets;
                break;
                case 'B': case 'b':
                totalCost = individualAmount*totalTickets;
                break;
                case 'C': case 'c':
                totalCost= individualAmount*totalTickets;
                break;
                case 'D': case 'd':
                totalCost = individualAmount*totalTickets;
                break;
                case 'E': case 'e':
                totalCost = individualAmount*totalTickets;
                break;
                default:
                totalCost=  totalCost+(13*totalTickets);
                break;
            }
            return totalCost;    
        }//end of the totalAmount method

        //main method Starts here
        static void Main(string[] args)
        {
           // variabe Declaration here
           string name="";
           int age = 0;
           char choose;
           decimal individualAmount=0.0m;
           int totalTickets= 0;
           var finalCost = 0.0m;
           bool quitOption=true;
           //do-while starts here
           do
           {
                name = "";
                age=0;
                    Console.WriteLine("Enter the name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the age:");
                    age = Convert.ToInt32(Console.ReadLine());
                if(age>17)
                {
                    Console.WriteLine("Menu for Horror Movie List ");
                    Console.WriteLine("\n\ta.A Quiet Place");
                    Console.WriteLine("\n\tb.Halloween");
                    Console.WriteLine("\n\tc.Hereditary");
                    Console.WriteLine("\n\td.Saw");
                    Console.WriteLine("\n\te.Bird Box");
                    Console.WriteLine("Please Select the Movie from the above list:");
                    choose = Convert.ToChar(Console.ReadLine());
                    if(choose == 'a'|| choose == 'A'||choose == 'c' || choose == 'C'||
                                                                    choose =='e'||choose =='E')
                    {
                            individualAmount = 23;
                    }//end of if
                    else if(choose == 'b'|| choose == 'B'||choose == 'd' || choose == 'D')
                    {
                        individualAmount = 18;
                    }//end of else-if
                    Console.WriteLine("Enter Number of tickets to Buy");
                    totalTickets = Convert.ToInt32(Console.ReadLine());
                    Program totalPrice = new Program();
                    finalCost = totalPrice.totalAmount(choose,individualAmount,totalTickets);
                    Console.WriteLine("Printing the Total Cost of the Customer");
                    Console.WriteLine($"Total Cost of the {choose}. For {totalTickets} is: {finalCost}$");
                }//end of if
                else
                {
                    Console.WriteLine("Age Above 18 years is only eligible");
                }//end of else
                Console.WriteLine("Enter true to continue or false to Exit from the transaction");
                quitOption = Convert.ToBoolean(Console.ReadLine());
            }while(quitOption == true);//end of do-while
        }//end of main method
    }
}
    
