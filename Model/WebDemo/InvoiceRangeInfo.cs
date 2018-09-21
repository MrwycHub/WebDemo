using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// InvoiceRangeInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InvoiceRangeInfo
	{
		public InvoiceRangeInfo()
		{}
		#region Model
		private int _batchid;
		private string _incode;
		private string _startnum;
		private string _endnum;
		private string _operatorname;
		private DateTime? _getdatetime= DateTime.Now;
		private DateTime? _indate= DateTime.Now;
		private int? _siteid;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int BatchId
		{
			set{ _batchid=value;}
			get{return _batchid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InCode
		{
			set{ _incode=value;}
			get{return _incode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartNum
		{
			set{ _startnum=value;}
			get{return _startnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndNum
		{
			set{ _endnum=value;}
			get{return _endnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperatorName
		{
			set{ _operatorname=value;}
			get{return _operatorname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? GetDateTime
		{
			set{ _getdatetime=value;}
			get{return _getdatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? InDate
		{
			set{ _indate=value;}
			get{return _indate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SiteID
		{
			set{ _siteid=value;}
			get{return _siteid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

