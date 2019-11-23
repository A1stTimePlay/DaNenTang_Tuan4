using DaNenTang_Tuan4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DaNenTang_Tuan4.Interface
{
    interface ILoaiHoaRepository
    {
        ObservableCollection<LoaiHoa> GetLoaiHoa();
        LoaiHoa GetLoaiHoaById(int MaLoai);
        bool Insert(LoaiHoa lh);
        bool Update(LoaiHoa lh);
        bool Delete(LoaiHoa lh);
    }
}
