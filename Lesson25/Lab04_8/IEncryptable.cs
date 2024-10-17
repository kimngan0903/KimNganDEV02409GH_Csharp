using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_8
{
    internal interface IEncryptable
    {
        string Encrypt(); // Phương thức mã hóa 
        string Decrypt(); // Phương thức giải mã
    }
}
