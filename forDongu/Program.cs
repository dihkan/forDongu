using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forDongu
{
    class Program
    {
        static void Main(string[] args)
        {
      
            for(int i = 1; i<=30; i++)
            {
               for(int j = 1; j<=10; j++)
                {
                    if(i==1 || i==30 || j==1 || j==10)
                    {

                        if (j == 10 )
                        {
                            Console.WriteLine(" * ");

                        }
                        else
                        {
                            Console.Write(" * ");
                        }
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                       

                  
                }  
            }
           
            Console.ReadKey();
        }
    }
}
