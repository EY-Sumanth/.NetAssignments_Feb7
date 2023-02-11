using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection1__Feb7
{
   public partial class FrmObject 
    {
        object n1 = 1;
        object n2 = 2;
        object n3 = 2;
        object n4 = 3;

        object str1 = "tesT";
        object str2 = "test1";
        object str3 = "Test";

static void Main(string[] args)
        {
            Console.WriteLine(object.Equals(n1));
        }
        

    }
}
