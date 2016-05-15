using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    public class Class1
    {
        int? j = null; // here j is nullable int type, so j = null is legal;
        string name = null; //reference type can have null value 

        bool? AreYouMajor = null;

        if(AreYouMajor == true)
        {
        }


    }
}
