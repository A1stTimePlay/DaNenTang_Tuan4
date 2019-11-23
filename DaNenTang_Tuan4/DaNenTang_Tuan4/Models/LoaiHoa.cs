using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaNenTang_Tuan4.Models
{
    class LoaiHoa
    {
        [PrimaryKey, AutoIncrement]
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
    }
}
