using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// FailureInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FailureInfo
	{
		public FailureInfo()
		{}
		#region Model
		private int _id;
		private int? _meterid;
		private string _failurephone;
		private string _failureman;
		private string _failurememo;
		private int? _failuretype;
		private DateTime? _failureregtime;
		private int? _failureregtype=1;
		private string _disposeman;
		private string _disposememo;
		private int? _disposestatus=1;
		private DateTime? _disposetime;
		private bool _sel= false;
		private string _failurecode;
		private string _appointman;
		private string _appointmanphone;
		private int? _failuresort;
		private int? _usersid;
		private string _usercode;
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
		public int? MeterID
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FailurePhone
		{
			set{ _failurephone=value;}
			get{return _failurephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FailureMan
		{
			set{ _failureman=value;}
			get{return _failureman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FailureMemo
		{
			set{ _failurememo=value;}
			get{return _failurememo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FailureType
		{
			set{ _failuretype=value;}
			get{return _failuretype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? FailureRegTime
		{
			set{ _failureregtime=value;}
			get{return _failureregtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FailureRegType
		{
			set{ _failureregtype=value;}
			get{return _failureregtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DisposeMan
		{
			set{ _disposeman=value;}
			get{return _disposeman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DisposeMemo
		{
			set{ _disposememo=value;}
			get{return _disposememo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DisposeStatus
		{
			set{ _disposestatus=value;}
			get{return _disposestatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DisposeTime
		{
			set{ _disposetime=value;}
			get{return _disposetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool sel
		{
			set{ _sel=value;}
			get{return _sel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FailureCode
		{
			set{ _failurecode=value;}
			get{return _failurecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AppointMan
		{
			set{ _appointman=value;}
			get{return _appointman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AppointManPhone
		{
			set{ _appointmanphone=value;}
			get{return _appointmanphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FailureSort
		{
			set{ _failuresort=value;}
			get{return _failuresort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UsersID
		{
			set{ _usersid=value;}
			get{return _usersid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserCode
		{
			set{ _usercode=value;}
			get{return _usercode;}
		}
		#endregion Model

	}
}

