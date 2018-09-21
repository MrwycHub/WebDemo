using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// MeterCurrentState:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MeterCurrentState
	{
		public MeterCurrentState()
		{}
		#region Model
		private int _meterid;
		private int _statecode;
		private string _statevalue;
		private string _stateinfo;
		private DateTime? _updatetime;
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
		public int StateCode
		{
			set{ _statecode=value;}
			get{return _statecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StateValue
		{
			set{ _statevalue=value;}
			get{return _statevalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StateInfo
		{
			set{ _stateinfo=value;}
			get{return _stateinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		#endregion Model

	}
}

