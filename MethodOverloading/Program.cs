using System.ComponentModel.Design;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Add(double dbl1, double dbl2)
        {
            Console.WriteLine($"{dbl1 + dbl2.ToString()} +dollar");
            return dbl1 + dbl2;
        }

        public static string Add(int num1, int num2, bool stayHard)
        {
            if (stayHard)
            {
                if (num1 + num2 > 1)
                {
                    Console.WriteLine($"{num1 + num2} dollars");
                    return (num1 + num2).ToString() + "dollars";

                }//insideif
                else 
                {
                    Console.WriteLine($"{num1 + num2} dollar");
                    return (num1 + num2).ToString() + "dollar";
                }
            }//outsideif

            else
            {
                Console.WriteLine($"{num1 + num2}");
                return (num1 + num2).ToString();

            }//else

        }//add3



                    static void Main(string[] args)
                    {
                        Add(1, 2);
                        Add(3.2, 2.999);
                        Add(-1, 0, true);
                    }//main
                }//class
            } //namespace
        
    
        
    


    
    


        
