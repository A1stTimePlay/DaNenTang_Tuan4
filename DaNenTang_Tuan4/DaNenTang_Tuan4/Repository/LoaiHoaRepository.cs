using DaNenTang_Tuan4.Helpers;
using DaNenTang_Tuan4.Interface;
using DaNenTang_Tuan4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DaNenTang_Tuan4.Repository
{
    class LoaiHoaRepository:ILoaiHoaRepository
    {
        Database db;
        public LoaiHoaRepository()
        {
            db = new Database()
        }

        public bool Delete(LoaiHoa lh)
        {
            return db.DeleteLoaiHoa(lh);
        }

        public ObservableCollection<LoaiHoa> GetLoaiHoa()
        {
            return new ObservableCollection<LoaiHoa>(db.GetLoaiHoa());
        }

        public LoaiHoa GetLoaiHoaById(int MaLoai)
        {
            return db.GetLoaiHoaById(MaLoai);
        }

        public bool Insert(LoaiHoa lh)
        {
            return db.InsertLoaiHoa(lh);
        }

        public bool Update(LoaiHoa lh)
        {
            return db.UpdateLoaiHoa(lh);
        }
    }
}
