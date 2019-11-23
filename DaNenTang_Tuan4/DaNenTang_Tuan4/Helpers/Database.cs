using DaNenTang_Tuan4.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaNenTang_Tuan4.Helpers
{
    class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        public Database()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.CreateTable<LoaiHoa>();
                    connection.CreateTable<Hoa>();
                }
            }
            catch (SQLiteException e)
            {

            }
        }

        public List<LoaiHoa> GetLoaiHoa()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<LoaiHoa>().ToList();
                }
            }
            catch (SQLiteException e)
            {
                return null;
            }
        } 

        public LoaiHoa GetLoaiHoaById(int MaLoai)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    var dsh = from lhs in connection.Table<LoaiHoa>().ToList()
                              where lhs.MaLoai == MaLoai
                              select lhs;
                    return dsh.ToList<LoaiHoa>().FirstOrDefault();
                }
            }
            catch (SQLiteException e)
            {
                return null;
            }
        }

        public bool InsertLoaiHoa(LoaiHoa lh)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(lh);
                    return true;
                }
            }
            catch (SQLiteException e)
            {
                return false;
            }
        }

        public bool DeleteLoaiHoa(LoaiHoa lh)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Delete(lh);
                    return true;
                }
            }
            catch (SQLiteException e)
            {
                return false;
            }
        }

        public bool UpdateLoaiHoa(LoaiHoa lh)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Update(lh);
                    return true;
                }
            }
            catch (SQLiteException e)
            {
                return false;
            }
        }
    }
}
