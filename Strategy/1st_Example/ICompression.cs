using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.FirstTry
{
    internal interface ICompression
    {
        public void Compress(string compressedFileFileName);
    }
}
