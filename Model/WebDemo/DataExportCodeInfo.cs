using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// DataExportCodeInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DataExportCodeInfo
	{
		public DataExportCodeInfo()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _strsql;
		private bool _showdeptcondition;
		private string _infocondition;
		private string _datecondition;
		private string _extcondition;
		private string _ascstring;
		private int? _gridviewwidth;
		private string _exporttype;
		private bool _showheader;
		private string _splitchar;
		private string _createdbfsql;
		private string _dbffilename;
		private string _remark;
		private string _enddatecondition;
		private string _showotherheader;
		private string _exportcols;
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StrSql
		{
			set{ _strsql=value;}
			get{return _strsql;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ShowDeptCondition
		{
			set{ _showdeptcondition=value;}
			get{return _showdeptcondition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InfoCondition
		{
			set{ _infocondition=value;}
			get{return _infocondition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DateCondition
		{
			set{ _datecondition=value;}
			get{return _datecondition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExtCondition
		{
			set{ _extcondition=value;}
			get{return _extcondition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AscString
		{
			set{ _ascstring=value;}
			get{return _ascstring;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GridViewWidth
		{
			set{ _gridviewwidth=value;}
			get{return _gridviewwidth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExportType
		{
			set{ _exporttype=value;}
			get{return _exporttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ShowHeader
		{
			set{ _showheader=value;}
			get{return _showheader;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SplitChar
		{
			set{ _splitchar=value;}
			get{return _splitchar;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CreateDbfSql
		{
			set{ _createdbfsql=value;}
			get{return _createdbfsql;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DbfFileName
		{
			set{ _dbffilename=value;}
			get{return _dbffilename;}
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
		public string EndDateCondition
		{
			set{ _enddatecondition=value;}
			get{return _enddatecondition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShowOtherHeader
		{
			set{ _showotherheader=value;}
			get{return _showotherheader;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExportCols
		{
			set{ _exportcols=value;}
			get{return _exportcols;}
		}
		#endregion Model

	}
}

