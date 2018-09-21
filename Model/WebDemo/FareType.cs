using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// FareType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FareType
	{
		public FareType()
		{}
		#region Model
		private int _faretypeid;
		private string _faretypename;
		private string _remark;
		private int? _metertypeid;
		/// <summary>
		/// 费用编号
		/// </summary>
		public int FareTypeID
		{
			set{ _faretypeid=value;}
			get{return _faretypeid;}
		}
		/// <summary>
		/// 费用名称
		/// </summary>
		public string FareTypeName
		{
			set{ _faretypename=value;}
			get{return _faretypename;}
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
		public int? MeterTypeID
		{
			set{ _metertypeid=value;}
			get{return _metertypeid;}
		}
		#endregion Model

	}
}

