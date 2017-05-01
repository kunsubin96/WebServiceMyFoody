using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceMyFoody
{
    public class UserObject
    {
        private string _Username;
        private string _HoTen;
        private string _DiaChi;
        private string _SDT;
        private byte[] _Avatar;

        public string Username
        {
            get
            {
                return _Username;
            }

            set
            {
                _Username = value;
            }
        }

        public string HoTen
        {
            get
            {
                return _HoTen;
            }

            set
            {
                _HoTen = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                _DiaChi = value;
            }
        }

        public string SDT
        {
            get
            {
                return _SDT;
            }

            set
            {
                _SDT = value;
            }
        }

        public byte[] Avatar
        {
            get
            {
                return _Avatar;
            }

            set
            {
                _Avatar = value;
            }
        }
    }
}