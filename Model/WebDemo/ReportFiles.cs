using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// ReportFiles:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ReportFiles
	{
		public ReportFiles()
		{}
		#region Model
		private int _id;
		private string _reportid;
		private string _reportname;
		private string _reporttype;
		private string _reportfilename;
		private int? _reportdbtype;
		private string _reportsql;
		private string _reportserviceurl;
		private int? _reportrole;
		private int? _operatorid;
		private DateTime? _insdate= DateTime.Now;
		private string _remark;
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
		public string ReportID
		{
			set{ _reportid=value;}
			get{return _reportid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReportName
		{
			set{ _reportname=value;}
			get{return _reportname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReportType
		{
			set{ _reporttype=value;}
			get{return _reporttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReportFileName
		{
			set{ _reportfilename=value;}
			get{return _reportfilename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReportDbType
		{
			set{ _reportdbtype=value;}
			get{return _reportdbtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReportSql
		{
			set{ _reportsql=value;}
			get{return _reportsql;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReportServiceUrl
		{
			set{ _reportserviceurl=value;}
			get{return _reportserviceurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReportRole
		{
			set{ _reportrole=value;}
			get{return _reportrole;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? InsDate
		{
			set{ _insdate=value;}
			get{return _insdate;}
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

