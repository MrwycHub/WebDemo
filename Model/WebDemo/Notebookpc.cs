using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// Notebookpc:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Notebookpc
	{
		public Notebookpc()
		{}
		#region Model
		private string _notebookid;
		private string _notebookname;
		private string _remark;
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
		public string NoteBookName
		{
			set{ _notebookname=value;}
			get{return _notebookname;}
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

