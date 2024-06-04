using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synot.Task1.Intefraces
{
    public interface IService
    {
        /// <summary> 
        /// Find an extra number that is not repeated twice in the input. 
        /// </summary> 
        ///  <returns> 
        ///  The extra number. 
        ///  </returns> 
        int FindExtraNumber(int[] numbers);
    }
}
