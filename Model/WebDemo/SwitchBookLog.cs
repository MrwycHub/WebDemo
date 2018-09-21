using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// SwitchBookLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SwitchBookLog
	{
		public SwitchBookLog()
		{}
		#region Model
		private int _id;
		private int _meterid;
		private int _bookidbefore;
		private int? _booknumbefore;
		private int _bookidafter;
		private int? _booknumafter;
		private DateTime _opertime= DateTime.Now;
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
		public int MeterID
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BookIDBefore
		{
			set{ _bookidbefore=value;}
			get{return _bookidbefore;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BookNumBefore
		{
			set{ _booknumbefore=value;}
			get{return _booknumbefore;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BookIDAfter
		{
			set{ _bookidafter=value;}
			get{return _bookidafter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BookNumAfter
		{
			set{ _booknumafter=value;}
			get{return _booknumafter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OperTime
		{
			set{ _opertime=value;}
			get{return _opertime;}
		}
		#endregion Model

	}
}

