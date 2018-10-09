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
        private int _conNo;
        private DateTime _ngayNop;

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
        public string maLoaiVS
        {
            get { return maLoaiVS; }
            set { maLoaiVS = value; }
        }
        public int soLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public DateTime ngayNhan
        {
            get { return ngayNhan; }
            set { ngayNhan = value; }
        }
        public int soLuongBan
        {
            get { return soLuongBan; }
            set { soLuongBan = value; }
        }
        public float doanhThu
        {
            get { return doanhThu; }
            set { doanhThu = value; }
        }
        public float hoaHong
        {
            get { return hoaHong; }
            set { hoaHong = value; }
        }
        public int daNop
        {
            get { return daNop; }
            set { daNop = value; }
        }
        public float conNo
        {
            get { return conNo; }
            set { conNo = value; }
        }
        public DateTime ngayNop
        {
            get { return ngayNop; }
            set { ngayNop = value; }
        }
    }
}
