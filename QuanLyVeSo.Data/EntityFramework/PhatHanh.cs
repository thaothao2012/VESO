using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeSo.Data.EntityFramework
{
    class PhatHanh
    {
        private int _id;
        private string _maDL;
        private string _maLoaiVS;
        private int _soLuong;
        private DateTime _ngayNhan;
        private int _soLuongBan;
        private float _doanhThu;
        private float _hoaHong;
        private int _daNop;
        private float _conNo;
        private DateTime _ngayNop;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string maDL
        {
            get { return _maDL; }
            set { maDL = value; }
        }
        public string maLoaiVS
        {
            get { return _maLoaiVS; }
            set { _maLoaiVS = value; }
        }
        public int soLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        public DateTime ngayNhan
        {
            get { return _ngayNhan; }
            set { _ngayNhan = value; }
        }
        public int soLuongBan
        {
            get { return _soLuongBan; }
            set { _soLuongBan = value; }
        }
        public float doanhThu
        {
            get { return _doanhThu; }
            set { _doanhThu = value; }
        }
        public float hoaHong
        {
            get { return _hoaHong; }
            set { _hoaHong = value; }
        }
        public int daNop
        {
            get { return _daNop; }
            set { _daNop = value; }
        }
        public float conNo
        {
            get { return _conNo; }
            set { _conNo = value; }
        }
        public DateTime ngayNop
        {
            get { return _ngayNop; }
            set { _ngayNop = value; }
        }
    }
}
