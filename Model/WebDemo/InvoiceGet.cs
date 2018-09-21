using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// InvoiceGet:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InvoiceGet
	{
		public InvoiceGet()
		{}
		#region Model
		private int _inid;
		private string _incode;
		private int? _startnum;
		private int? _endnum;
		private string _operatorname;
		private DateTime? _indate;
		private int? _siteid;
		/// <summary>
		/// 
		/// </summary>
		public int InID
		{
			set{ _inid=value;}
			get{return _inid;}
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
		public int? StartNum
		{
			set{ _startnum=value;}
			get{return _startnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EndNum
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
		#endregion Model

	}
}

