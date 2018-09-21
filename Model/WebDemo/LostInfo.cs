using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// LostInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LostInfo
	{
		public LostInfo()
		{}
		#region Model
		private int _lostid;
		private int _multiuserid;
		private int _cardid;
		private DateTime _lostdate;
		private DateTime? _downloaddate;
		private int? _successmeterid;
		private DateTime? _successdate;
		/// <summary>
		/// 
		/// </summary>
		public int LostID
		{
			set{ _lostid=value;}
			get{return _lostid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MultiUserID
		{
			set{ _multiuserid=value;}
			get{return _multiuserid;}
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
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DownloadDate
		{
			set{ _downloaddate=value;}
			get{return _downloaddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SuccessMeterID
		{
			set{ _successmeterid=value;}
			get{return _successmeterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SuccessDate
		{
			set{ _successdate=value;}
			get{return _successdate;}
		}
		#endregion Model

	}
}

