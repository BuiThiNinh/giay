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

namespace GiaoDien
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLCHBANGIAY")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertQUANLYND(QUANLYND instance);
    partial void UpdateQUANLYND(QUANLYND instance);
    partial void DeleteQUANLYND(QUANLYND instance);
    partial void InsertQLNDNHOMND(QLNDNHOMND instance);
    partial void UpdateQLNDNHOMND(QLNDNHOMND instance);
    partial void DeleteQLNDNHOMND(QLNDNHOMND instance);
    partial void InsertQLNHOMND(QLNHOMND instance);
    partial void UpdateQLNHOMND(QLNHOMND instance);
    partial void DeleteQLNHOMND(QLNHOMND instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::GiaoDien.Properties.Settings.Default.QLCHBANGIAY_MoiConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<QUANLYND> QUANLYNDs
		{
			get
			{
				return this.GetTable<QUANLYND>();
			}
		}
		
		public System.Data.Linq.Table<QLNDNHOMND> QLNDNHOMNDs
		{
			get
			{
				return this.GetTable<QLNDNHOMND>();
			}
		}
		
		public System.Data.Linq.Table<QLNHOMND> QLNHOMNDs
		{
			get
			{
				return this.GetTable<QLNHOMND>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QUANLYND")]
	public partial class QUANLYND : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TENDN;
		
		private string _MK;
		
		private System.Nullable<bool> _HOATDONG;
		
		private EntitySet<QLNDNHOMND> _QLNDNHOMNDs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTENDNChanging(string value);
    partial void OnTENDNChanged();
    partial void OnMKChanging(string value);
    partial void OnMKChanged();
    partial void OnHOATDONGChanging(System.Nullable<bool> value);
    partial void OnHOATDONGChanged();
    #endregion
		
		public QUANLYND()
		{
			this._QLNDNHOMNDs = new EntitySet<QLNDNHOMND>(new Action<QLNDNHOMND>(this.attach_QLNDNHOMNDs), new Action<QLNDNHOMND>(this.detach_QLNDNHOMNDs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENDN", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TENDN
		{
			get
			{
				return this._TENDN;
			}
			set
			{
				if ((this._TENDN != value))
				{
					this.OnTENDNChanging(value);
					this.SendPropertyChanging();
					this._TENDN = value;
					this.SendPropertyChanged("TENDN");
					this.OnTENDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MK", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string MK
		{
			get
			{
				return this._MK;
			}
			set
			{
				if ((this._MK != value))
				{
					this.OnMKChanging(value);
					this.SendPropertyChanging();
					this._MK = value;
					this.SendPropertyChanged("MK");
					this.OnMKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOATDONG", DbType="Bit")]
		public System.Nullable<bool> HOATDONG
		{
			get
			{
				return this._HOATDONG;
			}
			set
			{
				if ((this._HOATDONG != value))
				{
					this.OnHOATDONGChanging(value);
					this.SendPropertyChanging();
					this._HOATDONG = value;
					this.SendPropertyChanged("HOATDONG");
					this.OnHOATDONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="QUANLYND_QLNDNHOMND", Storage="_QLNDNHOMNDs", ThisKey="TENDN", OtherKey="TENDN")]
		public EntitySet<QLNDNHOMND> QLNDNHOMNDs
		{
			get
			{
				return this._QLNDNHOMNDs;
			}
			set
			{
				this._QLNDNHOMNDs.Assign(value);
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
		
		private void attach_QLNDNHOMNDs(QLNDNHOMND entity)
		{
			this.SendPropertyChanging();
			entity.QUANLYND = this;
		}
		
		private void detach_QLNDNHOMNDs(QLNDNHOMND entity)
		{
			this.SendPropertyChanging();
			entity.QUANLYND = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QLNDNHOMND")]
	public partial class QLNDNHOMND : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TENDN;
		
		private string _MANHOM;
		
		private string _GHICHU;
		
		private EntityRef<QUANLYND> _QUANLYND;
		
		private EntityRef<QLNHOMND> _QLNHOMND;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTENDNChanging(string value);
    partial void OnTENDNChanged();
    partial void OnMANHOMChanging(string value);
    partial void OnMANHOMChanged();
    partial void OnGHICHUChanging(string value);
    partial void OnGHICHUChanged();
    #endregion
		
		public QLNDNHOMND()
		{
			this._QUANLYND = default(EntityRef<QUANLYND>);
			this._QLNHOMND = default(EntityRef<QLNHOMND>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENDN", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TENDN
		{
			get
			{
				return this._TENDN;
			}
			set
			{
				if ((this._TENDN != value))
				{
					if (this._QUANLYND.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTENDNChanging(value);
					this.SendPropertyChanging();
					this._TENDN = value;
					this.SendPropertyChanged("TENDN");
					this.OnTENDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANHOM", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MANHOM
		{
			get
			{
				return this._MANHOM;
			}
			set
			{
				if ((this._MANHOM != value))
				{
					if (this._QLNHOMND.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMANHOMChanging(value);
					this.SendPropertyChanging();
					this._MANHOM = value;
					this.SendPropertyChanged("MANHOM");
					this.OnMANHOMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GHICHU", DbType="NVarChar(50)")]
		public string GHICHU
		{
			get
			{
				return this._GHICHU;
			}
			set
			{
				if ((this._GHICHU != value))
				{
					this.OnGHICHUChanging(value);
					this.SendPropertyChanging();
					this._GHICHU = value;
					this.SendPropertyChanged("GHICHU");
					this.OnGHICHUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="QUANLYND_QLNDNHOMND", Storage="_QUANLYND", ThisKey="TENDN", OtherKey="TENDN", IsForeignKey=true)]
		public QUANLYND QUANLYND
		{
			get
			{
				return this._QUANLYND.Entity;
			}
			set
			{
				QUANLYND previousValue = this._QUANLYND.Entity;
				if (((previousValue != value) 
							|| (this._QUANLYND.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._QUANLYND.Entity = null;
						previousValue.QLNDNHOMNDs.Remove(this);
					}
					this._QUANLYND.Entity = value;
					if ((value != null))
					{
						value.QLNDNHOMNDs.Add(this);
						this._TENDN = value.TENDN;
					}
					else
					{
						this._TENDN = default(string);
					}
					this.SendPropertyChanged("QUANLYND");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="QLNHOMND_QLNDNHOMND", Storage="_QLNHOMND", ThisKey="MANHOM", OtherKey="MANHOM", IsForeignKey=true)]
		public QLNHOMND QLNHOMND
		{
			get
			{
				return this._QLNHOMND.Entity;
			}
			set
			{
				QLNHOMND previousValue = this._QLNHOMND.Entity;
				if (((previousValue != value) 
							|| (this._QLNHOMND.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._QLNHOMND.Entity = null;
						previousValue.QLNDNHOMNDs.Remove(this);
					}
					this._QLNHOMND.Entity = value;
					if ((value != null))
					{
						value.QLNDNHOMNDs.Add(this);
						this._MANHOM = value.MANHOM;
					}
					else
					{
						this._MANHOM = default(string);
					}
					this.SendPropertyChanged("QLNHOMND");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QLNHOMND")]
	public partial class QLNHOMND : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MANHOM;
		
		private string _TENNHOMND;
		
		private string _GHICHU;
		
		private EntitySet<QLNDNHOMND> _QLNDNHOMNDs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMANHOMChanging(string value);
    partial void OnMANHOMChanged();
    partial void OnTENNHOMNDChanging(string value);
    partial void OnTENNHOMNDChanged();
    partial void OnGHICHUChanging(string value);
    partial void OnGHICHUChanged();
    #endregion
		
		public QLNHOMND()
		{
			this._QLNDNHOMNDs = new EntitySet<QLNDNHOMND>(new Action<QLNDNHOMND>(this.attach_QLNDNHOMNDs), new Action<QLNDNHOMND>(this.detach_QLNDNHOMNDs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANHOM", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MANHOM
		{
			get
			{
				return this._MANHOM;
			}
			set
			{
				if ((this._MANHOM != value))
				{
					this.OnMANHOMChanging(value);
					this.SendPropertyChanging();
					this._MANHOM = value;
					this.SendPropertyChanged("MANHOM");
					this.OnMANHOMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENNHOMND", DbType="NVarChar(50)")]
		public string TENNHOMND
		{
			get
			{
				return this._TENNHOMND;
			}
			set
			{
				if ((this._TENNHOMND != value))
				{
					this.OnTENNHOMNDChanging(value);
					this.SendPropertyChanging();
					this._TENNHOMND = value;
					this.SendPropertyChanged("TENNHOMND");
					this.OnTENNHOMNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GHICHU", DbType="NVarChar(50)")]
		public string GHICHU
		{
			get
			{
				return this._GHICHU;
			}
			set
			{
				if ((this._GHICHU != value))
				{
					this.OnGHICHUChanging(value);
					this.SendPropertyChanging();
					this._GHICHU = value;
					this.SendPropertyChanged("GHICHU");
					this.OnGHICHUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="QLNHOMND_QLNDNHOMND", Storage="_QLNDNHOMNDs", ThisKey="MANHOM", OtherKey="MANHOM")]
		public EntitySet<QLNDNHOMND> QLNDNHOMNDs
		{
			get
			{
				return this._QLNDNHOMNDs;
			}
			set
			{
				this._QLNDNHOMNDs.Assign(value);
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
		
		private void attach_QLNDNHOMNDs(QLNDNHOMND entity)
		{
			this.SendPropertyChanging();
			entity.QLNHOMND = this;
		}
		
		private void detach_QLNDNHOMNDs(QLNDNHOMND entity)
		{
			this.SendPropertyChanging();
			entity.QLNHOMND = null;
		}
	}
}
#pragma warning restore 1591
