using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// BlanceAccount:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BlanceAccount
	{
		public BlanceAccount()
		{}
		#region Model
		private int _id;
		private string _blancedate;
		private string _failusercode;
		private int _fail=0;
		private int _allcount=0;
		private decimal? _allmoney;
		private decimal? _refundmoney;
		private DateTime _blancetime= DateTime.Now;
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
		public string BlanceDate
		{
			set{ _blancedate=value;}
			get{return _blancedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FailUserCode
		{
			set{ _failusercode=value;}
			get{return _failusercode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Fail
		{
			set{ _fail=value;}
			get{return _fail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AllCount
		{
			set{ _allcount=value;}
			get{return _allcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AllMoney
		{
			set{ _allmoney=value;}
			get{return _allmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? RefundMoney
		{
			set{ _refundmoney=value;}
			get{return _refundmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime BlanceTime
		{
			set{ _blancetime=value;}
			get{return _blancetime;}
		}
		#endregion Model

	}
}

