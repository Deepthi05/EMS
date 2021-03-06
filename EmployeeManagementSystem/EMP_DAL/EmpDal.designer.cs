﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMP_DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Employee")]
	public partial class EmpDalDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public EmpDalDataContext() : 
				base(global::EMP_DAL.Properties.Settings.Default.EmployeeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EmpDalDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmpDalDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmpDalDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmpDalDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EmpAttendance> EmpAttendances
		{
			get
			{
				return this.GetTable<EmpAttendance>();
			}
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
		
		public System.Data.Linq.Table<EmpDetail> EmpDetails
		{
			get
			{
				return this.GetTable<EmpDetail>();
			}
		}
		
		public System.Data.Linq.Table<EmailLog> EmailLogs
		{
			get
			{
				return this.GetTable<EmailLog>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteEmployee")]
		public int DeleteEmployee([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> inEmpId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), inEmpId);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insertEmployee")]
		public int insertEmployee([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpFname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpMname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpLname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpAdd, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpCity, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inZipCode, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpState, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpPhNo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpEmail, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpDepart, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpPic, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,2)")] System.Nullable<decimal> inEmpSal, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> inEmpLeaves, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpPosition)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), inEmpFname, inEmpMname, inEmpLname, inEmpAdd, inEmpCity, inZipCode, inEmpState, inEmpPhNo, inEmpEmail, inEmpDepart, inEmpPic, inEmpSal, inEmpLeaves, inEmpPosition);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateEmp")]
		public int UpdateEmp([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> inEmpId, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpFname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpMname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpLname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpAdd, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpCity, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inZipCode, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpState, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpPhNo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpEmail, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpDepart, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpPic, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,2)")] System.Nullable<decimal> inEmpSal, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> inEmpLeaves, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inEmpPosition)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), inEmpId, inEmpFname, inEmpMname, inEmpLname, inEmpAdd, inEmpCity, inZipCode, inEmpState, inEmpPhNo, inEmpEmail, inEmpDepart, inEmpPic, inEmpSal, inEmpLeaves, inEmpPosition);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.getEmp")]
		public ISingleResult<getEmpResult> getEmp([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string in_FirstName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), in_FirstName);
			return ((ISingleResult<getEmpResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAuthorization")]
		public ISingleResult<GetAuthorizationResult> GetAuthorization([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string inUser, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string inPass)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), inUser, inPass);
			return ((ISingleResult<GetAuthorizationResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.getEmpOnId")]
		public ISingleResult<getEmpOnIdResult> getEmpOnId([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> empId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), empId);
			return ((ISingleResult<getEmpOnIdResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertLeave")]
		public int InsertLeave([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> in_EmpId, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> in_Todate, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> in_FromDate, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string in_descr)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), in_EmpId, in_Todate, in_FromDate, in_descr);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.getLeaves")]
		public ISingleResult<getLeavesResult> getLeaves([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> in_EmpId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), in_EmpId);
			return ((ISingleResult<getLeavesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.getIsPresent")]
		public int getIsPresent([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> in_EmpId, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> in_dau)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), in_EmpId, in_dau);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetLeavesApplied")]
		public ISingleResult<GetLeavesAppliedResult> GetLeavesApplied([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> in_empId, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> in_month)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), in_empId, in_month);
			return ((ISingleResult<GetLeavesAppliedResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetSalary")]
		public ISingleResult<GetSalaryResult> GetSalary([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> in_empId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), in_empId);
			return ((ISingleResult<GetSalaryResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetIsAdmin")]
		public ISingleResult<GetIsAdminResult> GetIsAdmin([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inU, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string inP)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), inU, inP);
			return ((ISingleResult<GetIsAdminResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.getEmpOnName")]
		public ISingleResult<getEmpOnNameResult> getEmpOnName([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string empName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), empName);
			return ((ISingleResult<getEmpOnNameResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.changePassword")]
		public int changePassword([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string in_uname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string in_oldPass, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string in_newPass)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), in_uname, in_oldPass, in_newPass);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertEmailLog")]
		public int InsertEmailLog([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] string in_emsg)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), in_emsg);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetSalaryonAttend")]
		public ISingleResult<GetSalaryonAttendResult> GetSalaryonAttend([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> in_EmpId, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> in_month)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), in_EmpId, in_month);
			return ((ISingleResult<GetSalaryonAttendResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmpAttendance")]
	public partial class EmpAttendance
	{
		
		private System.Nullable<int> _Month;
		
		private System.Nullable<int> _Empld;
		
		private System.Nullable<int> _DaysPresent;
		
		public EmpAttendance()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Month", DbType="Int")]
		public System.Nullable<int> Month
		{
			get
			{
				return this._Month;
			}
			set
			{
				if ((this._Month != value))
				{
					this._Month = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Empld", DbType="Int")]
		public System.Nullable<int> Empld
		{
			get
			{
				return this._Empld;
			}
			set
			{
				if ((this._Empld != value))
				{
					this._Empld = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaysPresent", DbType="Int")]
		public System.Nullable<int> DaysPresent
		{
			get
			{
				return this._DaysPresent;
			}
			set
			{
				if ((this._DaysPresent != value))
				{
					this._DaysPresent = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class user
	{
		
		private string _username;
		
		private string _password;
		
		private System.Nullable<bool> _IsAdmin;
		
		public user()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this._username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this._password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsAdmin", DbType="Bit")]
		public System.Nullable<bool> IsAdmin
		{
			get
			{
				return this._IsAdmin;
			}
			set
			{
				if ((this._IsAdmin != value))
				{
					this._IsAdmin = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmpDetails")]
	public partial class EmpDetail
	{
		
		private string _FirstName;
		
		private string _MiddleName;
		
		private string _LastName;
		
		private string _Address;
		
		private string _City;
		
		private string _ZipCode;
		
		private string _State;
		
		private string _PhoneNumber;
		
		private string _EmailId;
		
		private int _EmpId;
		
		private string _Department;
		
		private string _Picture;
		
		private System.Nullable<decimal> _Salary;
		
		private System.Nullable<int> _Leaves;
		
		private string _Position;
		
		public EmpDetail()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this._FirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MiddleName", DbType="VarChar(50)")]
		public string MiddleName
		{
			get
			{
				return this._MiddleName;
			}
			set
			{
				if ((this._MiddleName != value))
				{
					this._MiddleName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this._LastName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="VarChar(50)")]
		public string ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this._ZipCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(50)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this._State = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="VarChar(50)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this._PhoneNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailId", DbType="VarChar(50)")]
		public string EmailId
		{
			get
			{
				return this._EmailId;
			}
			set
			{
				if ((this._EmailId != value))
				{
					this._EmailId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpId", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int EmpId
		{
			get
			{
				return this._EmpId;
			}
			set
			{
				if ((this._EmpId != value))
				{
					this._EmpId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="VarChar(50)")]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this._Department = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="VarChar(50)")]
		public string Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this._Picture = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this._Salary = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Leaves", DbType="Int")]
		public System.Nullable<int> Leaves
		{
			get
			{
				return this._Leaves;
			}
			set
			{
				if ((this._Leaves != value))
				{
					this._Leaves = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="VarChar(50)")]
		public string Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				if ((this._Position != value))
				{
					this._Position = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmailLog")]
	public partial class EmailLog
	{
		
		private string _mailMsg;
		
		private System.Nullable<System.DateTime> _DateofLog;
		
		public EmailLog()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mailMsg", DbType="VarChar(1500)")]
		public string mailMsg
		{
			get
			{
				return this._mailMsg;
			}
			set
			{
				if ((this._mailMsg != value))
				{
					this._mailMsg = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateofLog", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateofLog
		{
			get
			{
				return this._DateofLog;
			}
			set
			{
				if ((this._DateofLog != value))
				{
					this._DateofLog = value;
				}
			}
		}
	}
	
	public partial class getEmpResult
	{
		
		private string _FirstName;
		
		private string _MiddleName;
		
		private string _LastName;
		
		private string _Address;
		
		private string _City;
		
		private string _ZipCode;
		
		private string _State;
		
		private string _PhoneNumber;
		
		private string _EmailId;
		
		private int _EmpId;
		
		private string _Department;
		
		private string _Picture;
		
		private System.Nullable<decimal> _Salary;
		
		private System.Nullable<int> _Leaves;
		
		private string _Position;
		
		public getEmpResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this._FirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MiddleName", DbType="VarChar(50)")]
		public string MiddleName
		{
			get
			{
				return this._MiddleName;
			}
			set
			{
				if ((this._MiddleName != value))
				{
					this._MiddleName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this._LastName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="VarChar(50)")]
		public string ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this._ZipCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(50)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this._State = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="VarChar(50)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this._PhoneNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailId", DbType="VarChar(50)")]
		public string EmailId
		{
			get
			{
				return this._EmailId;
			}
			set
			{
				if ((this._EmailId != value))
				{
					this._EmailId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpId", DbType="Int NOT NULL")]
		public int EmpId
		{
			get
			{
				return this._EmpId;
			}
			set
			{
				if ((this._EmpId != value))
				{
					this._EmpId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="VarChar(50)")]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this._Department = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="VarChar(50)")]
		public string Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this._Picture = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this._Salary = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Leaves", DbType="Int")]
		public System.Nullable<int> Leaves
		{
			get
			{
				return this._Leaves;
			}
			set
			{
				if ((this._Leaves != value))
				{
					this._Leaves = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="VarChar(50)")]
		public string Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				if ((this._Position != value))
				{
					this._Position = value;
				}
			}
		}
	}
	
	public partial class GetAuthorizationResult
	{
		
		private string _username;
		
		public GetAuthorizationResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this._username = value;
				}
			}
		}
	}
	
	public partial class getEmpOnIdResult
	{
		
		private string _FirstName;
		
		private string _MiddleName;
		
		private string _LastName;
		
		private string _Address;
		
		private string _City;
		
		private string _ZipCode;
		
		private string _State;
		
		private string _PhoneNumber;
		
		private string _EmailId;
		
		private int _EmpId;
		
		private string _Department;
		
		private string _Picture;
		
		private System.Nullable<decimal> _Salary;
		
		private System.Nullable<int> _Leaves;
		
		private string _Position;
		
		public getEmpOnIdResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this._FirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MiddleName", DbType="VarChar(50)")]
		public string MiddleName
		{
			get
			{
				return this._MiddleName;
			}
			set
			{
				if ((this._MiddleName != value))
				{
					this._MiddleName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this._LastName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="VarChar(50)")]
		public string ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this._ZipCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(50)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this._State = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="VarChar(50)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this._PhoneNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailId", DbType="VarChar(50)")]
		public string EmailId
		{
			get
			{
				return this._EmailId;
			}
			set
			{
				if ((this._EmailId != value))
				{
					this._EmailId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpId", DbType="Int NOT NULL")]
		public int EmpId
		{
			get
			{
				return this._EmpId;
			}
			set
			{
				if ((this._EmpId != value))
				{
					this._EmpId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="VarChar(50)")]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this._Department = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="VarChar(50)")]
		public string Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this._Picture = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this._Salary = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Leaves", DbType="Int")]
		public System.Nullable<int> Leaves
		{
			get
			{
				return this._Leaves;
			}
			set
			{
				if ((this._Leaves != value))
				{
					this._Leaves = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="VarChar(50)")]
		public string Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				if ((this._Position != value))
				{
					this._Position = value;
				}
			}
		}
	}
	
	public partial class getLeavesResult
	{
		
		private System.Nullable<int> _EmpId;
		
		private System.Nullable<System.DateTime> _FromDate;
		
		private System.Nullable<System.DateTime> _ToDate;
		
		private string _Reason;
		
		public getLeavesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpId", DbType="Int")]
		public System.Nullable<int> EmpId
		{
			get
			{
				return this._EmpId;
			}
			set
			{
				if ((this._EmpId != value))
				{
					this._EmpId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FromDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> FromDate
		{
			get
			{
				return this._FromDate;
			}
			set
			{
				if ((this._FromDate != value))
				{
					this._FromDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ToDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ToDate
		{
			get
			{
				return this._ToDate;
			}
			set
			{
				if ((this._ToDate != value))
				{
					this._ToDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Reason", DbType="VarChar(100)")]
		public string Reason
		{
			get
			{
				return this._Reason;
			}
			set
			{
				if ((this._Reason != value))
				{
					this._Reason = value;
				}
			}
		}
	}
	
	public partial class GetLeavesAppliedResult
	{
		
		private System.Nullable<System.DateTime> _FromDate;
		
		private System.Nullable<System.DateTime> _ToDate;
		
		public GetLeavesAppliedResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FromDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> FromDate
		{
			get
			{
				return this._FromDate;
			}
			set
			{
				if ((this._FromDate != value))
				{
					this._FromDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ToDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ToDate
		{
			get
			{
				return this._ToDate;
			}
			set
			{
				if ((this._ToDate != value))
				{
					this._ToDate = value;
				}
			}
		}
	}
	
	public partial class GetSalaryResult
	{
		
		private System.Nullable<decimal> _Salary;
		
		public GetSalaryResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this._Salary = value;
				}
			}
		}
	}
	
	public partial class GetIsAdminResult
	{
		
		private System.Nullable<bool> _IsAdmin;
		
		public GetIsAdminResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsAdmin", DbType="Bit")]
		public System.Nullable<bool> IsAdmin
		{
			get
			{
				return this._IsAdmin;
			}
			set
			{
				if ((this._IsAdmin != value))
				{
					this._IsAdmin = value;
				}
			}
		}
	}
	
	public partial class getEmpOnNameResult
	{
		
		private string _FirstName;
		
		private string _MiddleName;
		
		private string _LastName;
		
		private string _Address;
		
		private string _City;
		
		private string _ZipCode;
		
		private string _State;
		
		private string _PhoneNumber;
		
		private string _EmailId;
		
		private int _EmpId;
		
		private string _Department;
		
		private string _Picture;
		
		private System.Nullable<decimal> _Salary;
		
		private System.Nullable<int> _Leaves;
		
		private string _Position;
		
		public getEmpOnNameResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this._FirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MiddleName", DbType="VarChar(50)")]
		public string MiddleName
		{
			get
			{
				return this._MiddleName;
			}
			set
			{
				if ((this._MiddleName != value))
				{
					this._MiddleName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this._LastName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="VarChar(50)")]
		public string ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this._ZipCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(50)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this._State = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="VarChar(50)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this._PhoneNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailId", DbType="VarChar(50)")]
		public string EmailId
		{
			get
			{
				return this._EmailId;
			}
			set
			{
				if ((this._EmailId != value))
				{
					this._EmailId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpId", DbType="Int NOT NULL")]
		public int EmpId
		{
			get
			{
				return this._EmpId;
			}
			set
			{
				if ((this._EmpId != value))
				{
					this._EmpId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="VarChar(50)")]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this._Department = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="VarChar(50)")]
		public string Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this._Picture = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this._Salary = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Leaves", DbType="Int")]
		public System.Nullable<int> Leaves
		{
			get
			{
				return this._Leaves;
			}
			set
			{
				if ((this._Leaves != value))
				{
					this._Leaves = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="VarChar(50)")]
		public string Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				if ((this._Position != value))
				{
					this._Position = value;
				}
			}
		}
	}
	
	public partial class GetSalaryonAttendResult
	{
		
		private System.Nullable<int> _EmpId;
		
		private System.Nullable<System.DateTime> _DateCurrent;
		
		public GetSalaryonAttendResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpId", DbType="Int")]
		public System.Nullable<int> EmpId
		{
			get
			{
				return this._EmpId;
			}
			set
			{
				if ((this._EmpId != value))
				{
					this._EmpId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCurrent", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateCurrent
		{
			get
			{
				return this._DateCurrent;
			}
			set
			{
				if ((this._DateCurrent != value))
				{
					this._DateCurrent = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
