using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// FailTypeInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FailTypeInfo
	{
		public FailTypeInfo()
		{}
		#region Model
		private int _id;
		private int? _failtypenum=0;
		private string _failtypename;
		private int? _failflag=1;
		private string _remark;
		private int? _enabledelete=1;
		private int _autoanalyse=0;
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
		public int? FailTypeNum
		{
			set{ _failtypenum=value;}
			get{return _failtypenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FailTypeName
		{
			set{ _failtypename=value;}
			get{return _failtypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FailFlag
		{
			set{ _failflag=value;}
			get{return _failflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EnableDelete
		{
			set{ _enabledelete=value;}
			get{return _enabledelete;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AutoAnalyse
		{
			set{ _autoanalyse=value;}
			get{return _autoanalyse;}
		}
		#endregion Model

	}
}

