using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// FareItem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FareItem
	{
		public FareItem()
		{}
		#region Model
		private int _fareid;
		private int? _cycnumber;
		private string _farename;
		private decimal? _faremoney;
		private string _farememo;
		private int? _faremark;
		private string _priceunit;
		/// <summary>
		/// 
		/// </summary>
		public int FareID
		{
			set{ _fareid=value;}
			get{return _fareid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CycNumber
		{
			set{ _cycnumber=value;}
			get{return _cycnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FareName
		{
			set{ _farename=value;}
			get{return _farename;}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public decimal? FareMoney
		{
			set{ _faremoney=value;}
			get{return _faremoney;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string FareMemo
		{
			set{ _farememo=value;}
			get{return _farememo;}
		}
		/// <summary>
		/// 是否启用 1启用 2不启用
		/// </summary>
		public int? FareMark
		{
			set{ _faremark=value;}
			get{return _faremark;}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string PriceUnit
		{
			set{ _priceunit=value;}
			get{return _priceunit;}
		}
		#endregion Model

	}
}

