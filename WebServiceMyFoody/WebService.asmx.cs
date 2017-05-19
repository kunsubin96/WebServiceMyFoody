using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceMyFoody
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://anhky.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        //phần login table user
        [WebMethod]
        public tbl_User getUser(string username)
        {
           return db.tbl_Users.FirstOrDefault(x => x.Username == username);
        }
        [WebMethod]
        public int checkLogin(string username, string password)
        {
            int check = -1;
            var truyvan = from tk in db.tbl_Users
                       where tk.Username == username && tk.Password == password
                       select tk;
            if (truyvan.Count() > 0)
            {
                check = 1;
            }
            return check;
        }
        [WebMethod]
        public List<tbl_User> getAllUser()
        {
            return db.tbl_Users.ToList();
        }

        //phần table tinh thanh
        [WebMethod]
        public List<tbl_TinhThanh> getAllTinhThanh()
        {
            var truyvan = from tinh in db.tbl_TinhThanhs
                          orderby tinh.TenTinhThanh.Length
                          select tinh;
            return truyvan.ToList();
        }
        //phần table quận huyện
        [WebMethod]
        public List<tbl_QuanHuyen> getAllQuanHuyen()
        {
            var truyvan = from huyen in db.tbl_QuanHuyens
                          orderby huyen.TenQuanHuyen.Length
                          select huyen;
            return truyvan.ToList();
        }
        [WebMethod]
        public List<tbl_QuanHuyen> getQuanHuyenTheoTinh(string maTinh)
        {
            var truyvan = from huyen in db.tbl_QuanHuyens
                          where huyen.MaTinhThanh == maTinh
                          select huyen;
            return truyvan.ToList();
        }
        //phần table đường
        [WebMethod]
        public List<tbl_Duong> getAllDuong()
        {
            return db.tbl_Duongs.ToList();
        }
        [WebMethod]
        public List<tbl_Duong> getDuongTheoHuyen(string maHuyen)
        {
            var truyvan = from duong in db.tbl_Duongs
                          where duong.MaQuanHuyen == maHuyen
                          select duong;
            return truyvan.ToList();
        }
        //phần table danhmuc
        [WebMethod]
        public List<tbl_DanhMuc> getAllDanhMuc()
        {
            return db.tbl_DanhMucs.ToList();
        }
        //phần table NhaHang
        [WebMethod]
        public List<tbl_NhaHang> getAllNhaHang()
        {
            return db.tbl_NhaHangs.ToList();
        }

        //upload image
        [WebMethod]
        public string UploadImage(string image, string name)
        {
            //Image hinh = Image.FromFile(@"E:/df.jpg");
            //MemoryStream m = new MemoryStream();
            //hinh.Save(m, hinh.RawFormat);
            //byte[] imageBytes = m.ToArray();

            //// Convert byte[] to Base64 String
            //string base64String = Convert.ToBase64String(imageBytes);


            //image string base64
            string ImageFolderPath = @"D:/upload/";
            Image convertedImage = ConvertToImage(name);
            try
            {
                convertedImage.Save(ImageFolderPath + name + ".jpg", ImageFormat.Jpeg);
                return "true";
            }
            catch (Exception ex)
            {
                return "false";
            }
        }

        public Image ConvertToImage(string image)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(image);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                //// Convert byte[] to Image
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image img = Image.FromStream(ms, true);
                return img;
        }
        //getImage theo file foder localhost
        [WebMethod]
        public byte[] getImage(string filename)
        {
            byte[] imageBytes=null;
            string path = @"D:/upload/";
            Image image = Image.FromFile(path+filename+".jpg");
            MemoryStream m = new MemoryStream();
            image.Save(m, image.RawFormat);
            imageBytes = m.ToArray();
            return imageBytes;
        }
        //change password
        [WebMethod]
        public bool changePassword(string username,string newPass)
        {
            var query =
                from user in db.tbl_Users
                where user.Username == username
                select user;
            foreach (tbl_User user in query)
            {
                user.Password = newPass;
            }
            // Submit the changes to the database.
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Provide for exceptions.
                return false;
            }
        }
        //change profile
        [WebMethod]
        public bool changeProfile(string username,string hoten,string diachi,string SDT)
        {
            var query =
                from user in db.tbl_Users
                where user.Username == username
                select user;
            foreach (tbl_User user in query)
            {
                user.HoTen = hoten;
                user.DiaChi = diachi;
                user.SDT = SDT;
            }
            // Submit the changes to the database.
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Provide for exceptions.
                return false;
            }
        }
        //insert tài khoản
        [WebMethod]
        public bool createUser(string username,string password,string hoten,string diachi,string SDT,string Email)
        {
            bool f = false;

            tbl_User user = new tbl_User();
            user.Username = username;
            user.Password = password;
            user.HoTen = hoten;
            user.DiaChi = diachi;
            user.SDT = SDT;
            user.Email = Email;
            user.Avatar = "None";

            // Add the new object to the Orders collection.
            db.tbl_Users.InsertOnSubmit(user);

            // Submit the change to the database.
            try
            {
                db.SubmitChanges();
                f = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                f = false;            
            }
            return f;
        }
        //table bình luận
        [WebMethod]
        public List<tbl_BinhLuan> getBinhLuanNhaHang(string id_nhahang)
        {
            var truyvan = from binluan in db.tbl_BinhLuans
                          where binluan.ID_NhaHang == id_nhahang
                          select binluan;
            return truyvan.ToList();
        }
        //tbl_ImageMoreNhaHang
        [WebMethod]
        public List<tbl_ImageMoreNhaHang> getImageMore(string id_nhahang)
        {
            var truyvan = from imageMore in db.tbl_ImageMoreNhaHangs
                          where imageMore.ID_NhaHang == id_nhahang
                          select imageMore;
            return truyvan.ToList();
        }
        //tbl nha hang
        //tbl nhà hàng Ở đâu
        [WebMethod]
        public List<tbl_NhaHang> getNhaHang(string danhmuc,string tinhthanh,string quanhuyen,string duong,string moinhat)
        {
            if(moinhat.Trim()=="Phổ biến")
            {
                if (danhmuc == "danhmuc")
                {
                    if (quanhuyen == null || quanhuyen.Trim() == "")
                    {
                        var truyvan = from nhahang in db.tbl_NhaHangs
                                      where nhahang.MaTinhThanh == tinhthanh
                                      orderby  nhahang.LuotXem descending
                                      select nhahang;
                        return truyvan.ToList();
                    }
                    else
                    {
                        if (duong == null || duong.Trim() == "")
                        {
                            var truyvan = from nhahang in db.tbl_NhaHangs
                                          where nhahang.MaQuanHuyen == quanhuyen
                                          orderby nhahang.LuotXem descending
                                          select nhahang;
                            return truyvan.ToList();
                        }
                        else
                        {
                            var truyvan = from nhahang in db.tbl_NhaHangs
                                          where nhahang.MaQuanHuyen == quanhuyen && nhahang.MaDuong == duong
                                          orderby nhahang.LuotXem descending
                                          select nhahang;
                            return truyvan.ToList();
                        }
                    }
                }
                else
                {
                    if (quanhuyen == null || quanhuyen.Trim() == "")
                    {
                        var truyvan = from nhahang in db.tbl_NhaHangs
                                      where nhahang.MaTinhThanh == tinhthanh && nhahang.ID_DanhMucODau == danhmuc
                                      orderby nhahang.LuotXem descending
                                      select nhahang;
                        return truyvan.ToList();
                    }
                    else
                    {
                        if (duong == null || duong.Trim() == "")
                        {
                            var truyvan = from nhahang in db.tbl_NhaHangs
                                          where nhahang.MaQuanHuyen == quanhuyen && nhahang.ID_DanhMucODau == danhmuc
                                          orderby nhahang.LuotXem descending
                                          select nhahang;
                            return truyvan.ToList();
                        }
                        else
                        {
                            var truyvan = from nhahang in db.tbl_NhaHangs
                                          where nhahang.MaQuanHuyen == quanhuyen && nhahang.ID_DanhMucODau == danhmuc && nhahang.MaDuong == duong
                                          orderby nhahang.LuotXem descending
                                          select nhahang;
                            return truyvan.ToList();
                        }
                    }
                }
            }
            else
            {
                if (danhmuc == "danhmuc")
                {
                    if (quanhuyen == null || quanhuyen.Trim() == "")
                    {
                        var truyvan = from nhahang in db.tbl_NhaHangs
                                      where nhahang.MaTinhThanh == tinhthanh
                                      select nhahang;
                        return truyvan.ToList();
                    }
                    else
                    {
                        if (duong == null || duong.Trim() == "")
                        {
                            var truyvan = from nhahang in db.tbl_NhaHangs
                                          where nhahang.MaQuanHuyen == quanhuyen
                                          select nhahang;
                            return truyvan.ToList();
                        }
                        else
                        {
                            var truyvan = from nhahang in db.tbl_NhaHangs
                                          where nhahang.MaQuanHuyen == quanhuyen && nhahang.MaDuong == duong
                                          select nhahang;
                            return truyvan.ToList();
                        }
                    }
                }
                else
                {
                    if (quanhuyen == null || quanhuyen.Trim() == "")
                    {
                        var truyvan = from nhahang in db.tbl_NhaHangs
                                      where nhahang.MaTinhThanh == tinhthanh && nhahang.ID_DanhMucODau == danhmuc
                                      select nhahang;
                        return truyvan.ToList();
                    }
                    else
                    {
                        if (duong == null || duong.Trim() == "")
                        {
                            var truyvan = from nhahang in db.tbl_NhaHangs
                                          where nhahang.MaQuanHuyen == quanhuyen && nhahang.ID_DanhMucODau == danhmuc
                                          select nhahang;
                            return truyvan.ToList();
                        }
                        else
                        {
                            var truyvan = from nhahang in db.tbl_NhaHangs
                                          where nhahang.MaQuanHuyen == quanhuyen && nhahang.ID_DanhMucODau == danhmuc && nhahang.MaDuong == duong
                                          select nhahang;
                            return truyvan.ToList();
                        }
                    }
                }
            }
           

        }
        //get nha hàng ăn gì
        [WebMethod]
        public List<tbl_NhaHang> getNhaHangAnGi(string danhmuc,string tinhthanh,string quanhuyen,string duong,string moinhat)
        {
            if(moinhat.Trim()=="Phổ biến")
            {
                if (danhmuc == "danhmuc")
                {
                    if (quanhuyen == null || quanhuyen.Trim() == "")
                    {
                        var truyvan = from nhahang in db.tbl_NhaHangs
                                      where nhahang.MaTinhThanh == tinhthanh
                                      orderby nhahang.LuotXem descending
                                      select nhahang;
                        return truyvan.ToList();
                    }
                    else
                    {
                        if (duong == null || duong.Trim() == "")
                        {
                            var truyvan = from nhahang in db.tbl_NhaHangs
                                          where nhahang.MaQuanHuyen == quanhuyen
                                          orderby nhahang.LuotXem descending
                                          select nhahang;
                            return truyvan.ToList();
                        }
                        else
                        {
                            var truyvan = from nhahang in db.tbl_NhaHangs
                                          where nhahang.MaQuanHuyen == quanhuyen && nhahang.MaDuong == duong
                                          orderby nhahang.LuotXem descending
                                          select nhahang;
                            return truyvan.ToList();
                        }
                    }
                }
                else
                {
                    if (quanhuyen == null || quanhuyen.Trim() == "")
                    {
                        var truyvan = from nhahang in db.tbl_NhaHangs
                                      where nhahang.MaTinhThanh == tinhthanh && nhahang.ID_DanhMucAnGi == danhmuc
                                      orderby nhahang.LuotXem descending
                                      select nhahang;
                        return truyvan.ToList();
                    }
                    else
                    {
                        if (duong == null || duong.Trim() == "")
                        {
                            var truyvan = from nhahang in db.tbl_NhaHangs
                                          where nhahang.MaQuanHuyen == quanhuyen && nhahang.ID_DanhMucAnGi == danhmuc
                                          orderby nhahang.LuotXem descending
                                          select nhahang;
                            return truyvan.ToList();
                        }
                        else
                        {
                            var truyvan = from nhahang in db.tbl_NhaHangs
                                          where nhahang.MaQuanHuyen == quanhuyen && nhahang.ID_DanhMucAnGi == danhmuc && nhahang.MaDuong == duong
                                          orderby nhahang.LuotXem descending
                                          select nhahang;
                            return truyvan.ToList();
                        }
                    }
                }
            }
            else
            {
                if (danhmuc == "danhmuc")
                {
                    if (quanhuyen == null || quanhuyen.Trim() == "")
                    {
                        var truyvan = from nhahang in db.tbl_NhaHangs
                                      where nhahang.MaTinhThanh == tinhthanh
                                      select nhahang;
                        return truyvan.ToList();
                    }
                    else
                    {
                        if (duong == null || duong.Trim() == "")
                        {
                            var truyvan = from nhahang in db.tbl_NhaHangs
                                          where nhahang.MaQuanHuyen == quanhuyen
                                          select nhahang;
                            return truyvan.ToList();
                        }
                        else
                        {
                            var truyvan = from nhahang in db.tbl_NhaHangs
                                          where nhahang.MaQuanHuyen == quanhuyen && nhahang.MaDuong == duong
                                          select nhahang;
                            return truyvan.ToList();
                        }
                    }
                }
                else
                {
                    if (quanhuyen == null || quanhuyen.Trim() == "")
                    {
                        var truyvan = from nhahang in db.tbl_NhaHangs
                                      where nhahang.MaTinhThanh == tinhthanh && nhahang.ID_DanhMucAnGi == danhmuc
                                      select nhahang;
                        return truyvan.ToList();
                    }
                    else
                    {
                        if (duong == null || duong.Trim() == "")
                        {
                            var truyvan = from nhahang in db.tbl_NhaHangs
                                          where nhahang.MaQuanHuyen == quanhuyen && nhahang.ID_DanhMucAnGi == danhmuc
                                          select nhahang;
                            return truyvan.ToList();
                        }
                        else
                        {
                            var truyvan = from nhahang in db.tbl_NhaHangs
                                          where nhahang.MaQuanHuyen == quanhuyen && nhahang.ID_DanhMucAnGi == danhmuc && nhahang.MaDuong == duong
                                          select nhahang;
                            return truyvan.ToList();
                        }
                    }
                }
            }
        }
        //get món ăn
        [WebMethod]
        public List<tbl_MonAn> getAllMonAn()
        {
            var truyvan = from monan in db.tbl_MonAns
                          select monan;
            return truyvan.ToList();
        }
        //get thông tin
        [WebMethod]
        public tbl_Info getThongTin(string nhahang)
        {
            return db.tbl_Infos.FirstOrDefault(x => x.ID_NhaHang == nhahang);
        }
        //================================================================
        [WebMethod]
        public bool insertNhaHang(string ID,string TenNhaHang, string DiaChi, string SDT, string TinhThanh, string QuanHuyen,string Duong,string DanhMucODau)
        {
            bool f = false;


            tbl_NhaHang nhahang = new tbl_NhaHang();
            nhahang.ID = ID;
            nhahang.TenNhaHang = TenNhaHang;
            nhahang.DiaChi = DiaChi;
            nhahang.DienThoai = SDT;
            nhahang.MaTinhThanh = TinhThanh;
            nhahang.MaQuanHuyen = QuanHuyen;
            nhahang.MaDuong = Duong;
            nhahang.ID_DanhMucODau = DanhMucODau;
            nhahang.LuotXem = 0;
            nhahang.DanhGia = 0;
            // Add the new object to the Orders collection.
            db.tbl_NhaHangs.InsertOnSubmit(nhahang);

            // Submit the change to the database.
            try
            {
                db.SubmitChanges();
                f = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                f = false;
            }
            return f;
        }
    }
}
