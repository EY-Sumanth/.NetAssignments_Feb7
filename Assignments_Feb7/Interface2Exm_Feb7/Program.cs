using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionhandling_feb7
{
    internal class Program : ISavingAccount
    {
        static void Main(string[] args)
        {
            //syntax of exception handking
            try
            {
                var students = new List<string>() { "vishal", "sunil", "mahesh", "sumanth", "ravi" };                 /*students.Add("vishal");
                students.Add("sunil");
                students.Add("mahesh");
                students.Add("sumanth");
                students.Add("ravi");*/
                /*foreach (var student in students)
                {
                    Console.WriteLine(student + " ");
                }*/
                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine(students[i]);
                }
            }
            catch (ArgumentException argex)
            {
                Console.WriteLine(argex.Message);
            }
            catch (IndexOutOfRangeException index)
            {
                Console.WriteLine(index.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CreateAccount()
        {
            Console.WriteLine("Come after Lunch Break");
        }

        public void UpdateAccount()
        {
            throw new NotImplementedException();
        }
    }
}