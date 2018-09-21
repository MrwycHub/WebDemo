using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// BookInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BookInfo
	{
		public BookInfo()
		{}
		#region Model
		private int _bookid;
		private string _deptids;
		private string _bookname;
		private int? _workerid;
		private string _remark;
		private string _bookcode;
		private string _routes;
		private int _readday=1;
		private int _readtype=1;
		private int _usernum=0;
		private DateTime _updatetime= DateTime.Now;
		private string _autoreadbegindate="01";
		private string _autoreadenddate="15";
		/// <summary>
		/// 
		/// </summary>
		public int BookID
		{
			set{ _bookid=value;}
			get{return _bookid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptIDs
		{
			set{ _deptids=value;}
			get{return _deptids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BookName
		{
			set{ _bookname=value;}
			get{return _bookname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? WorkerID
		{
			set{ _workerid=value;}
			get{return _workerid;}
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
		public string BookCode
		{
			set{ _bookcode=value;}
			get{return _bookcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Routes
		{
			set{ _routes=value;}
			get{return _routes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ReadDay
		{
			set{ _readday=value;}
			get{return _readday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ReadType
		{
			set{ _readtype=value;}
			get{return _readtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UserNum
		{
			set{ _usernum=value;}
			get{return _usernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AutoReadBeginDate
		{
			set{ _autoreadbegindate=value;}
			get{return _autoreadbegindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AutoReadEndDate
		{
			set{ _autoreadenddate=value;}
			get{return _autoreadenddate;}
		}
		#endregion Model

	}
}

