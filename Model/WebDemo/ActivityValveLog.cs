using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// ActivityValveLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ActivityValveLog
	{
		public ActivityValveLog()
		{}
		#region Model
		private int _id;
		private int _meterid;
		private int _valvestatusbefore;
		private int _valvestatusafter;
		private DateTime _opertime;
		private string _operflag;
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
		public int ValveStatusBefore
		{
			set{ _valvestatusbefore=value;}
			get{return _valvestatusbefore;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ValveStatusAfter
		{
			set{ _valvestatusafter=value;}
			get{return _valvestatusafter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OperTime
		{
			set{ _opertime=value;}
			get{return _opertime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperFlag
		{
			set{ _operflag=value;}
			get{return _operflag;}
		}
		#endregion Model

	}
}

