using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// PriceTypeDev:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PriceTypeDev
	{
		public PriceTypeDev()
		{}
		#region Model
		private int _pricetypeid;
		private decimal? _latefeerate;
		private int? _latefeedate;
		private decimal? _latefeebase;
		private int? _icmonth;
		private int? _icmaxbuy;
		private int? _icamount;
		private int? _icmonthbuy;
		private int? _icdayavg;
		/// <summary>
		/// 
		/// </summary>
		public int PriceTypeID
		{
			set{ _pricetypeid=value;}
			get{return _pricetypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LateFeeRate
		{
			set{ _latefeerate=value;}
			get{return _latefeerate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LateFeeDate
		{
			set{ _latefeedate=value;}
			get{return _latefeedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LateFeeBase
		{
			set{ _latefeebase=value;}
			get{return _latefeebase;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ICMonth
		{
			set{ _icmonth=value;}
			get{return _icmonth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ICMaxBuy
		{
			set{ _icmaxbuy=value;}
			get{return _icmaxbuy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ICAmount
		{
			set{ _icamount=value;}
			get{return _icamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ICMonthBuy
		{
			set{ _icmonthbuy=value;}
			get{return _icmonthbuy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ICDayAvg
		{
			set{ _icdayavg=value;}
			get{return _icdayavg;}
		}
		#endregion Model

	}
}

