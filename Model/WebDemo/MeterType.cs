using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// MeterType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MeterType
	{
		public MeterType()
		{}
		#region Model
		private int _metertypeid;
		private string _metertypename;
		private string _remark;
		private int _flag=1;
		/// <summary>
		/// 表类型编号
		/// </summary>
		public int MeterTypeID
		{
			set{ _metertypeid=value;}
			get{return _metertypeid;}
		}
		/// <summary>
		/// 表类型名称
		/// </summary>
		public string MeterTypeName
		{
			set{ _metertypename=value;}
			get{return _metertypename;}
		}
		/// <summary>
		/// 备注信息
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		#endregion Model

	}
}

