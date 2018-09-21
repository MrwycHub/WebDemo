using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// FailureMessage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FailureMessage
	{
		public FailureMessage()
		{}
		#region Model
		private int _id;
		private int? _failid;
		private int? _type;
		private int? _flag;
		private string _name;
		private DateTime? _uploadtime;
		private string _size;
		private string _pattern;
		private string _url;
		private decimal? _locationx;
		private decimal? _locationy;
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
		public int? FailID
		{
			set{ _failid=value;}
			get{return _failid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Flag
		{
			set{ _flag=value;}
			get{return _flag;}
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
		public DateTime? UpLoadTime
		{
			set{ _uploadtime=value;}
			get{return _uploadtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Size
		{
			set{ _size=value;}
			get{return _size;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Pattern
		{
			set{ _pattern=value;}
			get{return _pattern;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Url
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LocationX
		{
			set{ _locationx=value;}
			get{return _locationx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LocationY
		{
			set{ _locationy=value;}
			get{return _locationy;}
		}
		#endregion Model

	}
}

