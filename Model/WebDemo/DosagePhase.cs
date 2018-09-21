using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// DosagePhase:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DosagePhase
	{
		public DosagePhase()
		{}
		#region Model
		private int _id;
		private string _phasetitle;
		private decimal? _phasebnum;
		private decimal? _phaseenum;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PhaseTitle
		{
			set{ _phasetitle=value;}
			get{return _phasetitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PhaseBNum
		{
			set{ _phasebnum=value;}
			get{return _phasebnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PhaseENum
		{
			set{ _phaseenum=value;}
			get{return _phaseenum;}
		}
		#endregion Model

	}
}

