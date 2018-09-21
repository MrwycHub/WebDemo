using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// HostStateLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HostStateLog
	{
		public HostStateLog()
		{}
		#region Model
		private int _id;
		private int _hostid;
		private int _functype;
		private DateTime _readtime= DateTime.Now;
		private int _state;
		private string _descripion;
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
		public int HostId
		{
			set{ _hostid=value;}
			get{return _hostid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FuncType
		{
			set{ _functype=value;}
			get{return _functype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ReadTime
		{
			set{ _readtime=value;}
			get{return _readtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Descripion
		{
			set{ _descripion=value;}
			get{return _descripion;}
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

