using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// DBBackup:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DBBackup
	{
		public DBBackup()
		{}
		#region Model
		private int _id;
		private DateTime _backuptime;
		private string _backupname;
		private string _path;
		private string _remark;
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
		public DateTime BackupTime
		{
			set{ _backuptime=value;}
			get{return _backuptime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BackupName
		{
			set{ _backupname=value;}
			get{return _backupname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Path
		{
			set{ _path=value;}
			get{return _path;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

