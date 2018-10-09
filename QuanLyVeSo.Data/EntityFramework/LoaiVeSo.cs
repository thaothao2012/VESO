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
            get { return _id; }
            set { _id = value; }
        }
        public string maLoaiVS
        {
            get { return _maLoaiVS; }
            set { _maLoaiVS = value; }
        }
        public string tinhThanh
        {
            get { return _tinhThanh; }
            set { _tinhThanh = value; }
        }
        public int gia
        {
            get { return _gia; }
            set { _gia = value; }
        }
        public DateTime ngayXo
        {
            get { return _ngayXo; }
            set { _ngayXo = value; }
        }
    }
}
