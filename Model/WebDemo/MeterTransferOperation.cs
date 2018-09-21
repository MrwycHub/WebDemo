using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// MeterTransferOperation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MeterTransferOperation
	{
		public MeterTransferOperation()
		{}
		#region Model
		private int _id;
		private int _meterid;
		private int _olduserid;
		private string _oldusername;
		private string _oldusercode;
		private decimal _oldlastreadnumber;
		private decimal _olduserreserve;
		private int _newuserid;
		private string _newusername;
		private string _newusercode;
		private int _operatorid;
		private DateTime _begindate;
		private DateTime _operdatetime;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MeterID
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OldUserID
		{
			set{ _olduserid=value;}
			get{return _olduserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OldUserName
		{
			set{ _oldusername=value;}
			get{return _oldusername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OldUserCode
		{
			set{ _oldusercode=value;}
			get{return _oldusercode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal OldLastReadNumber
		{
			set{ _oldlastreadnumber=value;}
			get{return _oldlastreadnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal OldUserReserve
		{
			set{ _olduserreserve=value;}
			get{return _olduserreserve;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int NewUserID
		{
			set{ _newuserid=value;}
			get{return _newuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewUserName
		{
			set{ _newusername=value;}
			get{return _newusername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewUserCode
		{
			set{ _newusercode=value;}
			get{return _newusercode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OperatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime BeginDate
		{
			set{ _begindate=value;}
			get{return _begindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OperDateTime
		{
			set{ _operdatetime=value;}
			get{return _operdatetime;}
		}
		#endregion Model

	}
}

