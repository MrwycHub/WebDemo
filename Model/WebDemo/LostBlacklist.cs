using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// LostBlacklist:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LostBlacklist
	{
		public LostBlacklist()
		{}
		#region Model
		private int _saveno;
		private int _cardid;
		private DateTime _lostdate;
		/// <summary>
		/// 
		/// </summary>
		public int SaveNo
		{
			set{ _saveno=value;}
			get{return _saveno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CardID
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime LostDate
		{
			set{ _lostdate=value;}
			get{return _lostdate;}
		}
		#endregion Model

	}
}

