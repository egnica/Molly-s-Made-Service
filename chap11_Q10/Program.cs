using System;

namespace chap11_Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            string primer;
            string EXIT = "EXIT";
            string code;
            int total;

            primer = welcome();

            while(primer != EXIT){
                System.Console.WriteLine("Please type your code. For business type 'B', for residential type 'R'");
                code = Console.ReadLine();

                code = defensive(code);
                total = weeklyCleaning(code);

                System.Console.WriteLine($"You entered code: {code} for the amount of ${total}");

                primer = reenter();
            }
            

            }
            static string welcome(){
                string primer;

                System.Console.WriteLine("Welcome to Molly's Made Service. Please type 'enter' to enter.");
                primer = Console.ReadLine();

                return primer;
            }
            static string defensive(string code){
                string CODE_B = "B";
                string CODE_R = "R";
                if(code != CODE_B && code != CODE_R){
                    System.Console.WriteLine("You entered an invalad code. Please enter either 'B' or 'R'");
                    code = Console.ReadLine();
                }
                return code;
            }
            static int weeklyCleaning(string code){
                string CODE_B = "B";
                int B_AMOUNT = 200;
                int A_AMOUNT = 140;
                int total;
                if(code == CODE_B){
                    total = B_AMOUNT;
                }else{
                    total = A_AMOUNT;
                }
                return total;
            }
            static string reenter(){
                string primer;

                System.Console.WriteLine("If you would like to re-enter the program type 'ENTER' to exit type 'EXIT'");
                primer = Console.ReadLine();

                return primer;
            }
        }
    }

