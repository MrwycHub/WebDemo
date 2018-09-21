using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// FillOperLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FillOperLog
	{
		public FillOperLog()
		{}
		#region Model
		private int _id;
		private int? _operid;
		private string _opertype;
		private DateTime? _operdate;
		private int? _operflag;
		private string _operinfo;
		private int? _operatorid;
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
		public int? OperID
		{
			set{ _operid=value;}
			get{return _operid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperType
		{
			set{ _opertype=value;}
			get{return _opertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OperDate
		{
			set{ _operdate=value;}
			get{return _operdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperFlag
		{
			set{ _operflag=value;}
			get{return _operflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperInfo
		{
			set{ _operinfo=value;}
			get{return _operinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
		}
		#endregion Model

	}
}

