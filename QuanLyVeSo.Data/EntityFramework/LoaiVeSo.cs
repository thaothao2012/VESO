using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeSo.Data.EntityFramework
{
    class LoaiVeSo
    {
        private int _id;
        private string _maLoaiVS;
        private string _tinhThanh;
        private int _gia;
        private DateTime _ngayXo;
        public int id
        {
            get { return id; }
            set { id = value; }
        }
        public string maLoaiVS
        {
            get { return maLoaiVS; }
            set { maLoaiVS = value; }
        }
        public string tinhThanh
        {
            get { return tinhThanh; }
            set { tinhThanh = value; }
        }
        public int gia
        {
            get { return gia; }
            set { gia = value; }
        }
        public DateTime ngayXo
        {
            get { return ngayXo; }
            set { ngayXo = value; }
        }
    }
}
