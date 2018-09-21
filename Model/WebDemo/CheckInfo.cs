using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// CheckInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CheckInfo
	{
		public CheckInfo()
		{}
		#region Model
		private int _fid;
		private int? _meterid;
		private DateTime? _checkdate;
		private string _checkworker;
		private string _checkinfo;
		private int? _checkmark=0;
		/// <summary>
		/// 
		/// </summary>
		public int FID
		{
			set{ _fid=value;}
			get{return _fid;}
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
		public DateTime? CheckDate
		{
			set{ _checkdate=value;}
			get{return _checkdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CheckWorker
		{
			set{ _checkworker=value;}
			get{return _checkworker;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CheckInfo
		{
			set{ _checkinfo=value;}
			get{return _checkinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CheckMark
		{
			set{ _checkmark=value;}
			get{return _checkmark;}
		}
		#endregion Model

	}
}

