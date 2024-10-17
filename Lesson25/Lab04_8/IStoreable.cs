using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_8
{
    internal interface IStoreable
    {
        string Data { get; set; }

        void Write(string fileName);
        void Read(string fileName);

    }
}
