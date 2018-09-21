using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// HostsCH:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HostsCH
	{
		public HostsCH()
		{}
		#region Model
		private int _id;
		private int? _hostid;
		private int? _chno;
		private string _factcode;
		private string _dataid;
		private int? _chband;
		private string _chbtyetype;
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
		public int? HostID
		{
			set{ _hostid=value;}
			get{return _hostid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ChNo
		{
			set{ _chno=value;}
			get{return _chno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FactCode
		{
			set{ _factcode=value;}
			get{return _factcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DataID
		{
			set{ _dataid=value;}
			get{return _dataid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ChBand
		{
			set{ _chband=value;}
			get{return _chband;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChBtyeType
		{
			set{ _chbtyetype=value;}
			get{return _chbtyetype;}
		}
		#endregion Model

	}
}

