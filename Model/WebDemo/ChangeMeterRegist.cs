using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// ChangeMeterRegist:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ChangeMeterRegist
	{
		public ChangeMeterRegist()
		{}
		#region Model
		private int _id;
		private int _usersid;
		private string _usercode;
		private decimal? _oldnumber;
		private string _newmeteraddr;
		private string _remark;
		private int _status=1;
		private string _imagepath;
		private string _operatorcode;
		private decimal? _newnumber;
		private int? _newmeterid;
		private DateTime _insertdate= DateTime.Now;
		private DateTime _changemeterdate= DateTime.Now;
		private int _meterid=0;
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
		public int UsersID
		{
			set{ _usersid=value;}
			get{return _usersid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserCode
		{
			set{ _usercode=value;}
			get{return _usercode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OldNumber
		{
			set{ _oldnumber=value;}
			get{return _oldnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewMeterAddr
		{
			set{ _newmeteraddr=value;}
			get{return _newmeteraddr;}
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
		public int Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImagePath
		{
			set{ _imagepath=value;}
			get{return _imagepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperatorCode
		{
			set{ _operatorcode=value;}
			get{return _operatorcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? NewNumber
		{
			set{ _newnumber=value;}
			get{return _newnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? NewMeterId
		{
			set{ _newmeterid=value;}
			get{return _newmeterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime InsertDate
		{
			set{ _insertdate=value;}
			get{return _insertdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ChangeMeterDate
		{
			set{ _changemeterdate=value;}
			get{return _changemeterdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MeterID
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
		#endregion Model

	}
}

