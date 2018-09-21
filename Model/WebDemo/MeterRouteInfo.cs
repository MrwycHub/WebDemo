using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// MeterRouteInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MeterRouteInfo
	{
		public MeterRouteInfo()
		{}
		#region Model
		private string _meteraddr;
		private int _meterno;
		private string _node1;
		private int? _depth1;
		private string _node2;
		private int? _depth2;
		private string _node3;
		private int? _depth3;
		private string _node4;
		private int? _depth4;
		private bool _result;
		private int _collectorid;
		private int _meterid;
		private DateTime _readtime;
		/// <summary>
		/// 
		/// </summary>
		public string MeterAddr
		{
			set{ _meteraddr=value;}
			get{return _meteraddr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MeterNo
		{
			set{ _meterno=value;}
			get{return _meterno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Node1
		{
			set{ _node1=value;}
			get{return _node1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Depth1
		{
			set{ _depth1=value;}
			get{return _depth1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Node2
		{
			set{ _node2=value;}
			get{return _node2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Depth2
		{
			set{ _depth2=value;}
			get{return _depth2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Node3
		{
			set{ _node3=value;}
			get{return _node3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Depth3
		{
			set{ _depth3=value;}
			get{return _depth3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Node4
		{
			set{ _node4=value;}
			get{return _node4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Depth4
		{
			set{ _depth4=value;}
			get{return _depth4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Result
		{
			set{ _result=value;}
			get{return _result;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CollectorId
		{
			set{ _collectorid=value;}
			get{return _collectorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MeterId
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ReadTime
		{
			set{ _readtime=value;}
			get{return _readtime;}
		}
		#endregion Model

	}
}

