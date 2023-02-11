using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionhandling_feb7
{
    internal class Program
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
                //for (int i = 0; i < students.Count; i++)
                //{
                //    Console.WriteLine(students[i]);
                //}

                var studentlist = new List<student>();
                {
                    studentlist.Add(new student { Id = 1, Name = "mikee", city = "Goa", mobNo = 23124 });
                    studentlist.Add(new student { Id = 2, Name = "mahesh", city = "pune", mobNo = 252345 });
                    studentlist.Add(new student { Id = 3, Name = "Ravi", city = "ranchi", mobNo = 45654});
                    studentlist.Add(new student { Id = 4, Name = "shradhha", city = "dubai", mobNo = 287675 });
                    studentlist.Add(new student { Id = 5, Name = "ismail", city = "qatar", mobNo = 287768 });
                    
                }
                foreach(student st in studentlist) {
                 Console.WriteLine(st.Id+" "+ st.Name+" "+st.city+" "+st.mobNo);

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

            class student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string city { get; set; }
            public int mobNo { get; set; }

        }
    }
}