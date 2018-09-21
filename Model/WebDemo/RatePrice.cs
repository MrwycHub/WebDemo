using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// RatePrice:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RatePrice
	{
		public RatePrice()
		{}
		#region Model
		private int _grouppriceno;
		private int _farerateno;
		private string _farename;
		private decimal _price=0M;
		/// <summary>
		/// 
		/// </summary>
		public int GroupPriceNo
		{
			set{ _grouppriceno=value;}
			get{return _grouppriceno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FareRateNo
		{
			set{ _farerateno=value;}
			get{return _farerateno;}
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
		/// 
		/// </summary>
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		#endregion Model

	}
}

