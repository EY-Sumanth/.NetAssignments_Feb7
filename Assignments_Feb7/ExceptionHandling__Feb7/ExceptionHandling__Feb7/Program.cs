using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling__Feb7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //Syntax of exceptional Handling
            try
            {
                var students = new List<string>() {"vishal","shirly","Mike"};
                //students.Add("vishal");
                //students.Add("Sumanth");
                //students.Add("shirly");

                //foreach (var student in students)
                //{
                //    Console.WriteLine(student + " ");
                //}

                for(int i=0;i<students.Count;i++)
                {
                    Console.WriteLine(students[i]);
                }

            }
            catch(ArgumentException argex)
            {
                Console.WriteLine(argex.Message);
            }
            catch(IndexOutOfRangeException index)
            {
                Console.WriteLine(index.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
