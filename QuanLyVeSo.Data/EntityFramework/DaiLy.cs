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
            get { return id; }
            set { id = value; }
        }
        public string maDL
        {
            get { return maDL; }
            set { maDL = value; }
        }
        public string tenDL
        {
            get { return tenDL; }
            set { tenDL = value; }
        }
        public string diaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string email
        {
            get { return email; }
            set { email = value; }
        }
        public int dangHoatDong
        {
            get { return dangHoatDong; }
            set { dangHoatDong = value; }
        }

    }
}
