using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_4
{
    // Định nghĩa giao diện
     internal interface IPerson
    {
        // Phương thức Insert
        void Insert(object obj);

        // Phương thức xóa
        void Delete(object obj);

        // Phương thức sửa
        void Update(object obj);

        // Phương thức hiển thị
        void Display(object obj);
    }
}
