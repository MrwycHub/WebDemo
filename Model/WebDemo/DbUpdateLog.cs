using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// DbUpdateLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DbUpdateLog
	{
		public DbUpdateLog()
		{}
		#region Model
		private int _id;
		private long _ver;
		private string _updatecontent;
		private DateTime _updatedate= DateTime.Now;
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
		public long Ver
		{
			set{ _ver=value;}
			get{return _ver;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UpdateContent
		{
			set{ _updatecontent=value;}
			get{return _updatecontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime UpdateDate
		{
			set{ _updatedate=value;}
			get{return _updatedate;}
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

