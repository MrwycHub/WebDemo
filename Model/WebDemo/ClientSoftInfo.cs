using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// ClientSoftInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ClientSoftInfo
	{
		public ClientSoftInfo()
		{}
		#region Model
		private int _id;
		private string _danweiname;
		private string _jiqima;
		private string _renzhengma;
		private string _softname;
		private string _softhao;
		private string _usepassword;
		private string _jieticaldate;
		private int _sqlversion;
		private string _metertypes;
		private string _cardtypes;
		private string _paytypes;
		private DateTime _updatetime= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DanWeiName
		{
			set{ _danweiname=value;}
			get{return _danweiname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JiQiMa
		{
			set{ _jiqima=value;}
			get{return _jiqima;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RenZhengMa
		{
			set{ _renzhengma=value;}
			get{return _renzhengma;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SoftName
		{
			set{ _softname=value;}
			get{return _softname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SoftHao
		{
			set{ _softhao=value;}
			get{return _softhao;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UsePassword
		{
			set{ _usepassword=value;}
			get{return _usepassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JieTiCalDate
		{
			set{ _jieticaldate=value;}
			get{return _jieticaldate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SqlVersion
		{
			set{ _sqlversion=value;}
			get{return _sqlversion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MeterTypes
		{
			set{ _metertypes=value;}
			get{return _metertypes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardTypes
		{
			set{ _cardtypes=value;}
			get{return _cardtypes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayTypes
		{
			set{ _paytypes=value;}
			get{return _paytypes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		#endregion Model

	}
}

