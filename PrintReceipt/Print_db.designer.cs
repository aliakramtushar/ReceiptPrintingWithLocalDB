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

namespace PrintReceipt
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PrintItems")]
	public partial class Print_dbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertprint_information(print_information instance);
    partial void Updateprint_information(print_information instance);
    partial void Deleteprint_information(print_information instance);
    #endregion
		
		public Print_dbDataContext() : 
				base(global::PrintReceipt.Properties.Settings.Default.PrintItemsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Print_dbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Print_dbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Print_dbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Print_dbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<print_information> print_informations
		{
			get
			{
				return this.GetTable<print_information>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.print_information")]
	public partial class print_information : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _customer_name;
		
		private System.Nullable<decimal> _total_amount;
		
		private System.Nullable<decimal> _paid_amount;
		
		private System.Nullable<decimal> _due_amount;
		
		private System.Nullable<System.DateTime> _date;
		
		private string _information;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Oncustomer_nameChanging(string value);
    partial void Oncustomer_nameChanged();
    partial void Ontotal_amountChanging(System.Nullable<decimal> value);
    partial void Ontotal_amountChanged();
    partial void Onpaid_amountChanging(System.Nullable<decimal> value);
    partial void Onpaid_amountChanged();
    partial void Ondue_amountChanging(System.Nullable<decimal> value);
    partial void Ondue_amountChanged();
    partial void OndateChanging(System.Nullable<System.DateTime> value);
    partial void OndateChanged();
    partial void OninformationChanging(string value);
    partial void OninformationChanged();
    #endregion
		
		public print_information()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customer_name", DbType="NVarChar(200)")]
		public string customer_name
		{
			get
			{
				return this._customer_name;
			}
			set
			{
				if ((this._customer_name != value))
				{
					this.Oncustomer_nameChanging(value);
					this.SendPropertyChanging();
					this._customer_name = value;
					this.SendPropertyChanged("customer_name");
					this.Oncustomer_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total_amount", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> total_amount
		{
			get
			{
				return this._total_amount;
			}
			set
			{
				if ((this._total_amount != value))
				{
					this.Ontotal_amountChanging(value);
					this.SendPropertyChanging();
					this._total_amount = value;
					this.SendPropertyChanged("total_amount");
					this.Ontotal_amountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paid_amount", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> paid_amount
		{
			get
			{
				return this._paid_amount;
			}
			set
			{
				if ((this._paid_amount != value))
				{
					this.Onpaid_amountChanging(value);
					this.SendPropertyChanging();
					this._paid_amount = value;
					this.SendPropertyChanged("paid_amount");
					this.Onpaid_amountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_due_amount", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> due_amount
		{
			get
			{
				return this._due_amount;
			}
			set
			{
				if ((this._due_amount != value))
				{
					this.Ondue_amountChanging(value);
					this.SendPropertyChanging();
					this._due_amount = value;
					this.SendPropertyChanged("due_amount");
					this.Ondue_amountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="Date")]
		public System.Nullable<System.DateTime> date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_information", DbType="NVarChar(200)")]
		public string information
		{
			get
			{
				return this._information;
			}
			set
			{
				if ((this._information != value))
				{
					this.OninformationChanging(value);
					this.SendPropertyChanging();
					this._information = value;
					this.SendPropertyChanged("information");
					this.OninformationChanged();
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
}
#pragma warning restore 1591
