using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// Otherfare:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Otherfare
	{
		public Otherfare()
		{}
		#region Model
		private int _otherid;
		private int _meterid;
		private int _fareid;
		private int _farenum;
		private string _remark;
		private int _flag;
		/// <summary>
		/// 
		/// </summary>
		public int OtherID
		{
			set{ _otherid=value;}
			get{return _otherid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MeterID
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
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
		public int FareNum
		{
			set{ _farenum=value;}
			get{return _farenum;}
		}
		/// <summary>
		/// 
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

