﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceMyFoody
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MyFoody")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_User(tbl_User instance);
    partial void Updatetbl_User(tbl_User instance);
    partial void Deletetbl_User(tbl_User instance);
    partial void Inserttbl_TinhThanh(tbl_TinhThanh instance);
    partial void Updatetbl_TinhThanh(tbl_TinhThanh instance);
    partial void Deletetbl_TinhThanh(tbl_TinhThanh instance);
    partial void Inserttbl_QuanHuyen(tbl_QuanHuyen instance);
    partial void Updatetbl_QuanHuyen(tbl_QuanHuyen instance);
    partial void Deletetbl_QuanHuyen(tbl_QuanHuyen instance);
    partial void Inserttbl_NhaHang(tbl_NhaHang instance);
    partial void Updatetbl_NhaHang(tbl_NhaHang instance);
    partial void Deletetbl_NhaHang(tbl_NhaHang instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MyFoodyConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_User> tbl_Users
		{
			get
			{
				return this.GetTable<tbl_User>();
			}
		}
		
		public System.Data.Linq.Table<tbl_TinhThanh> tbl_TinhThanhs
		{
			get
			{
				return this.GetTable<tbl_TinhThanh>();
			}
		}
		
		public System.Data.Linq.Table<tbl_QuanHuyen> tbl_QuanHuyens
		{
			get
			{
				return this.GetTable<tbl_QuanHuyen>();
			}
		}
		
		public System.Data.Linq.Table<tbl_NhaHang> tbl_NhaHangs
		{
			get
			{
				return this.GetTable<tbl_NhaHang>();
			}
		}
		
		public System.Data.Linq.Table<tbl_MonAn> tbl_MonAns
		{
			get
			{
				return this.GetTable<tbl_MonAn>();
			}
		}
		
		public System.Data.Linq.Table<tbl_Info> tbl_Infos
		{
			get
			{
				return this.GetTable<tbl_Info>();
			}
		}
		
		public System.Data.Linq.Table<tbl_ImageMoreNhaHang> tbl_ImageMoreNhaHangs
		{
			get
			{
				return this.GetTable<tbl_ImageMoreNhaHang>();
			}
		}
		
		public System.Data.Linq.Table<tbl_Duong> tbl_Duongs
		{
			get
			{
				return this.GetTable<tbl_Duong>();
			}
		}
		
		public System.Data.Linq.Table<tbl_DanhMuc> tbl_DanhMucs
		{
			get
			{
				return this.GetTable<tbl_DanhMuc>();
			}
		}
		
		public System.Data.Linq.Table<tbl_BinhLuan> tbl_BinhLuans
		{
			get
			{
				return this.GetTable<tbl_BinhLuan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_User")]
	public partial class tbl_User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Username;
		
		private string _Password;
		
		private string _HoTen;
		
		private string _DiaChi;
		
		private string _SDT;
		
		private string _Avatar;
		
		private string _Email;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnAvatarChanging(string value);
    partial void OnAvatarChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public tbl_User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NChar(20)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(80)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="NChar(11)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Avatar", DbType="NVarChar(50)")]
		public string Avatar
		{
			get
			{
				return this._Avatar;
			}
			set
			{
				if ((this._Avatar != value))
				{
					this.OnAvatarChanging(value);
					this.SendPropertyChanging();
					this._Avatar = value;
					this.SendPropertyChanged("Avatar");
					this.OnAvatarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_TinhThanh")]
	public partial class tbl_TinhThanh : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaTinhThanh;
		
		private string _TenTinhThanh;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTinhThanhChanging(string value);
    partial void OnMaTinhThanhChanged();
    partial void OnTenTinhThanhChanging(string value);
    partial void OnTenTinhThanhChanged();
    #endregion
		
		public tbl_TinhThanh()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTinhThanh", DbType="NChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaTinhThanh
		{
			get
			{
				return this._MaTinhThanh;
			}
			set
			{
				if ((this._MaTinhThanh != value))
				{
					this.OnMaTinhThanhChanging(value);
					this.SendPropertyChanging();
					this._MaTinhThanh = value;
					this.SendPropertyChanged("MaTinhThanh");
					this.OnMaTinhThanhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTinhThanh", DbType="NVarChar(50)")]
		public string TenTinhThanh
		{
			get
			{
				return this._TenTinhThanh;
			}
			set
			{
				if ((this._TenTinhThanh != value))
				{
					this.OnTenTinhThanhChanging(value);
					this.SendPropertyChanging();
					this._TenTinhThanh = value;
					this.SendPropertyChanged("TenTinhThanh");
					this.OnTenTinhThanhChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_QuanHuyen")]
	public partial class tbl_QuanHuyen : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaQuanHuyen;
		
		private string _TenQuanHuyen;
		
		private string _MaTinhThanh;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaQuanHuyenChanging(string value);
    partial void OnMaQuanHuyenChanged();
    partial void OnTenQuanHuyenChanging(string value);
    partial void OnTenQuanHuyenChanged();
    partial void OnMaTinhThanhChanging(string value);
    partial void OnMaTinhThanhChanged();
    #endregion
		
		public tbl_QuanHuyen()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaQuanHuyen", DbType="NChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaQuanHuyen
		{
			get
			{
				return this._MaQuanHuyen;
			}
			set
			{
				if ((this._MaQuanHuyen != value))
				{
					this.OnMaQuanHuyenChanging(value);
					this.SendPropertyChanging();
					this._MaQuanHuyen = value;
					this.SendPropertyChanged("MaQuanHuyen");
					this.OnMaQuanHuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenQuanHuyen", DbType="NVarChar(50)")]
		public string TenQuanHuyen
		{
			get
			{
				return this._TenQuanHuyen;
			}
			set
			{
				if ((this._TenQuanHuyen != value))
				{
					this.OnTenQuanHuyenChanging(value);
					this.SendPropertyChanging();
					this._TenQuanHuyen = value;
					this.SendPropertyChanged("TenQuanHuyen");
					this.OnTenQuanHuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTinhThanh", DbType="NChar(20)")]
		public string MaTinhThanh
		{
			get
			{
				return this._MaTinhThanh;
			}
			set
			{
				if ((this._MaTinhThanh != value))
				{
					this.OnMaTinhThanhChanging(value);
					this.SendPropertyChanging();
					this._MaTinhThanh = value;
					this.SendPropertyChanged("MaTinhThanh");
					this.OnMaTinhThanhChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_NhaHang")]
	public partial class tbl_NhaHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _MaTinhThanh;
		
		private string _MaQuanHuyen;
		
		private string _MaDuong;
		
		private string _TenNhaHang;
		
		private string _DiaChi;
		
		private System.Nullable<double> _DanhGia;
		
		private string _DienThoai;
		
		private string _Hinh;
		
		private System.Nullable<int> _LuotXem;
		
		private string _ID_DanhMucODau;
		
		private string _ID_DanhMucAnGi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnMaTinhThanhChanging(string value);
    partial void OnMaTinhThanhChanged();
    partial void OnMaQuanHuyenChanging(string value);
    partial void OnMaQuanHuyenChanged();
    partial void OnMaDuongChanging(string value);
    partial void OnMaDuongChanged();
    partial void OnTenNhaHangChanging(string value);
    partial void OnTenNhaHangChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnDanhGiaChanging(System.Nullable<double> value);
    partial void OnDanhGiaChanged();
    partial void OnDienThoaiChanging(string value);
    partial void OnDienThoaiChanged();
    partial void OnHinhChanging(string value);
    partial void OnHinhChanged();
    partial void OnLuotXemChanging(System.Nullable<int> value);
    partial void OnLuotXemChanged();
    partial void OnID_DanhMucODauChanging(string value);
    partial void OnID_DanhMucODauChanged();
    partial void OnID_DanhMucAnGiChanging(string value);
    partial void OnID_DanhMucAnGiChanged();
    #endregion
		
		public tbl_NhaHang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTinhThanh", DbType="NChar(20)")]
		public string MaTinhThanh
		{
			get
			{
				return this._MaTinhThanh;
			}
			set
			{
				if ((this._MaTinhThanh != value))
				{
					this.OnMaTinhThanhChanging(value);
					this.SendPropertyChanging();
					this._MaTinhThanh = value;
					this.SendPropertyChanged("MaTinhThanh");
					this.OnMaTinhThanhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaQuanHuyen", DbType="NChar(20)")]
		public string MaQuanHuyen
		{
			get
			{
				return this._MaQuanHuyen;
			}
			set
			{
				if ((this._MaQuanHuyen != value))
				{
					this.OnMaQuanHuyenChanging(value);
					this.SendPropertyChanging();
					this._MaQuanHuyen = value;
					this.SendPropertyChanged("MaQuanHuyen");
					this.OnMaQuanHuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDuong", DbType="NChar(20)")]
		public string MaDuong
		{
			get
			{
				return this._MaDuong;
			}
			set
			{
				if ((this._MaDuong != value))
				{
					this.OnMaDuongChanging(value);
					this.SendPropertyChanging();
					this._MaDuong = value;
					this.SendPropertyChanged("MaDuong");
					this.OnMaDuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNhaHang", DbType="NVarChar(250)")]
		public string TenNhaHang
		{
			get
			{
				return this._TenNhaHang;
			}
			set
			{
				if ((this._TenNhaHang != value))
				{
					this.OnTenNhaHangChanging(value);
					this.SendPropertyChanging();
					this._TenNhaHang = value;
					this.SendPropertyChanged("TenNhaHang");
					this.OnTenNhaHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(250)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DanhGia", DbType="Float")]
		public System.Nullable<double> DanhGia
		{
			get
			{
				return this._DanhGia;
			}
			set
			{
				if ((this._DanhGia != value))
				{
					this.OnDanhGiaChanging(value);
					this.SendPropertyChanging();
					this._DanhGia = value;
					this.SendPropertyChanged("DanhGia");
					this.OnDanhGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="NVarChar(80)")]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this.OnDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._DienThoai = value;
					this.SendPropertyChanged("DienThoai");
					this.OnDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hinh", DbType="NVarChar(50)")]
		public string Hinh
		{
			get
			{
				return this._Hinh;
			}
			set
			{
				if ((this._Hinh != value))
				{
					this.OnHinhChanging(value);
					this.SendPropertyChanging();
					this._Hinh = value;
					this.SendPropertyChanged("Hinh");
					this.OnHinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LuotXem", DbType="Int")]
		public System.Nullable<int> LuotXem
		{
			get
			{
				return this._LuotXem;
			}
			set
			{
				if ((this._LuotXem != value))
				{
					this.OnLuotXemChanging(value);
					this.SendPropertyChanging();
					this._LuotXem = value;
					this.SendPropertyChanged("LuotXem");
					this.OnLuotXemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_DanhMucODau", DbType="NChar(20)")]
		public string ID_DanhMucODau
		{
			get
			{
				return this._ID_DanhMucODau;
			}
			set
			{
				if ((this._ID_DanhMucODau != value))
				{
					this.OnID_DanhMucODauChanging(value);
					this.SendPropertyChanging();
					this._ID_DanhMucODau = value;
					this.SendPropertyChanged("ID_DanhMucODau");
					this.OnID_DanhMucODauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_DanhMucAnGi", DbType="NChar(20)")]
		public string ID_DanhMucAnGi
		{
			get
			{
				return this._ID_DanhMucAnGi;
			}
			set
			{
				if ((this._ID_DanhMucAnGi != value))
				{
					this.OnID_DanhMucAnGiChanging(value);
					this.SendPropertyChanging();
					this._ID_DanhMucAnGi = value;
					this.SendPropertyChanged("ID_DanhMucAnGi");
					this.OnID_DanhMucAnGiChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_MonAn")]
	public partial class tbl_MonAn
	{
		
		private System.Nullable<int> _ID;
		
		private string _TenMon;
		
		private string _ID_NhaHang;
		
		public tbl_MonAn()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int")]
		public System.Nullable<int> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMon", DbType="NVarChar(200)")]
		public string TenMon
		{
			get
			{
				return this._TenMon;
			}
			set
			{
				if ((this._TenMon != value))
				{
					this._TenMon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_NhaHang", DbType="NChar(10)")]
		public string ID_NhaHang
		{
			get
			{
				return this._ID_NhaHang;
			}
			set
			{
				if ((this._ID_NhaHang != value))
				{
					this._ID_NhaHang = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Info")]
	public partial class tbl_Info
	{
		
		private string _ID;
		
		private string _Photo;
		
		private string _Date;
		
		private string _ID_NhaHang;
		
		private string _Name;
		
		public tbl_Info()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="NChar(10)")]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Photo", DbType="NVarChar(50)")]
		public string Photo
		{
			get
			{
				return this._Photo;
			}
			set
			{
				if ((this._Photo != value))
				{
					this._Photo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="NChar(20)")]
		public string Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this._Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_NhaHang", DbType="NChar(10)")]
		public string ID_NhaHang
		{
			get
			{
				return this._ID_NhaHang;
			}
			set
			{
				if ((this._ID_NhaHang != value))
				{
					this._ID_NhaHang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_ImageMoreNhaHang")]
	public partial class tbl_ImageMoreNhaHang
	{
		
		private string _ID_NhaHang;
		
		private string _Image;
		
		public tbl_ImageMoreNhaHang()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_NhaHang", DbType="NChar(10)")]
		public string ID_NhaHang
		{
			get
			{
				return this._ID_NhaHang;
			}
			set
			{
				if ((this._ID_NhaHang != value))
				{
					this._ID_NhaHang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NVarChar(20)")]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this._Image = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Duong")]
	public partial class tbl_Duong
	{
		
		private string _MaDuong;
		
		private string _TenDuong;
		
		private string _MaQuanHuyen;
		
		public tbl_Duong()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDuong", DbType="NChar(10)")]
		public string MaDuong
		{
			get
			{
				return this._MaDuong;
			}
			set
			{
				if ((this._MaDuong != value))
				{
					this._MaDuong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDuong", DbType="NVarChar(200)")]
		public string TenDuong
		{
			get
			{
				return this._TenDuong;
			}
			set
			{
				if ((this._TenDuong != value))
				{
					this._TenDuong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaQuanHuyen", DbType="NChar(10)")]
		public string MaQuanHuyen
		{
			get
			{
				return this._MaQuanHuyen;
			}
			set
			{
				if ((this._MaQuanHuyen != value))
				{
					this._MaQuanHuyen = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_DanhMuc")]
	public partial class tbl_DanhMuc
	{
		
		private string _ID;
		
		private string _TenDanhMuc;
		
		public tbl_DanhMuc()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="NChar(20)")]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDanhMuc", DbType="NVarChar(50)")]
		public string TenDanhMuc
		{
			get
			{
				return this._TenDanhMuc;
			}
			set
			{
				if ((this._TenDanhMuc != value))
				{
					this._TenDanhMuc = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_BinhLuan")]
	public partial class tbl_BinhLuan
	{
		
		private int _ID;
		
		private string _ID_NhaHang;
		
		private string _ID_User;
		
		private string _NoiDung;
		
		private System.Nullable<double> _DanhGia;
		
		public tbl_BinhLuan()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_NhaHang", DbType="NChar(10)")]
		public string ID_NhaHang
		{
			get
			{
				return this._ID_NhaHang;
			}
			set
			{
				if ((this._ID_NhaHang != value))
				{
					this._ID_NhaHang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_User", DbType="NChar(10)")]
		public string ID_User
		{
			get
			{
				return this._ID_User;
			}
			set
			{
				if ((this._ID_User != value))
				{
					this._ID_User = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NVarChar(200)")]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this._NoiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DanhGia", DbType="Float")]
		public System.Nullable<double> DanhGia
		{
			get
			{
				return this._DanhGia;
			}
			set
			{
				if ((this._DanhGia != value))
				{
					this._DanhGia = value;
				}
			}
		}
	}
}
#pragma warning restore 1591