using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// UpConsume:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UpConsume
	{
		public UpConsume()
		{}
		#region Model
		private int _upid;
		private int? _cardid;
		private decimal? _lostfreenum;
		private decimal? _surplusmoney;
		private DateTime? _consumetime;
		private int? _meterid;
		private decimal? _usemoney;
		private DateTime? _insdate;
		/// <summary>
		/// 
		/// </summary>
		public int UpId
		{
			set{ _upid=value;}
			get{return _upid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CardId
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LostFreeNum
		{
			set{ _lostfreenum=value;}
			get{return _lostfreenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SurplusMoney
		{
			set{ _surplusmoney=value;}
			get{return _surplusmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ConsumeTime
		{
			set{ _consumetime=value;}
			get{return _consumetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Meterid
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UseMoney
		{
			set{ _usemoney=value;}
			get{return _usemoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? InsDate
		{
			set{ _insdate=value;}
			get{return _insdate;}
		}
		#endregion Model

	}
}

