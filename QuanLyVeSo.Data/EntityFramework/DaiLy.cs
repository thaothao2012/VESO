using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class DaiLy
    {
        private int _id;
        private string _maDL;
        private string _tenDL;
        private string _diaChi;
        private string _sdt;
        private string _email;
        private int _dangHoatDong;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string maDL
        {
            get { return _maDL; }
            set { _maDL = value; }
        }
        public string tenDL
        {
            get { return _tenDL; }
            set { _tenDL = value; }
        }
        public string diaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        public string sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public int dangHoatDong
        {
            get { return _dangHoatDong; }
            set { _dangHoatDong = value; }
        }

    }
}
