using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// ManageUser:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ManageUser
	{
		public ManageUser()
		{}
		#region Model
		private int _usersid;
		private string _managefareid;
		private DateTime? _chargedate;
		private DateTime? _lastdate;
		private string _remark;
		private int _status=1;
		/// <summary>
		/// 用户ID
		/// </summary>
		public int UsersID
		{
			set{ _usersid=value;}
			get{return _usersid;}
		}
		/// <summary>
		/// 物业费ID
		/// </summary>
		public string ManageFareID
		{
			set{ _managefareid=value;}
			get{return _managefareid;}
		}
		/// <summary>
		/// 启用时间
		/// </summary>
		public DateTime? ChargeDate
		{
			set{ _chargedate=value;}
			get{return _chargedate;}
		}
		/// <summary>
		/// 最后一次收费
		/// </summary>
		public DateTime? LastDate
		{
			set{ _lastdate=value;}
			get{return _lastdate;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string ReMark
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
		#endregion Model

	}
}

