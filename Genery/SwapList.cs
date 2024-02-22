using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genery
{
    public class SwapList<T>:List<T>
    {
       public SwapList() { }
       public void Swaper(int i1, int i2) 
        { 
            T temp = this[i1];
            this[i1] = this[i2];
            this[i2] = temp;
        }
    }
}
