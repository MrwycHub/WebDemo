using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// BookTaskInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BookTaskInfo
	{
		public BookTaskInfo()
		{}
		#region Model
		private int _id;
		private int _bookid;
		private string _readdate;
		private string _bookcode;
		private string _bookname;
		private int _operatorid=0;
		private string _remark;
		private string _routes;
		private int _usernum=0;
		private int _factnum=0;
		private DateTime _updatetime= DateTime.Now;
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
		public int BookID
		{
			set{ _bookid=value;}
			get{return _bookid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReadDate
		{
			set{ _readdate=value;}
			get{return _readdate;}
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
		public string BookName
		{
			set{ _bookname=value;}
			get{return _bookname;}
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
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
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
		public int UserNum
		{
			set{ _usernum=value;}
			get{return _usernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FactNum
		{
			set{ _factnum=value;}
			get{return _factnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		#endregion Model

	}
}

