using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// NoteBookGroup:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NoteBookGroup
	{
		public NoteBookGroup()
		{}
		#region Model
		private int _groupid;
		private string _notebookid;
		private string _groupname;
		private int? _limitnum;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int GroupID
		{
			set{ _groupid=value;}
			get{return _groupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NoteBookID
		{
			set{ _notebookid=value;}
			get{return _notebookid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GroupName
		{
			set{ _groupname=value;}
			get{return _groupname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LimitNum
		{
			set{ _limitnum=value;}
			get{return _limitnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReMark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

