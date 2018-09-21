using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// InvoiceTemplate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InvoiceTemplate
	{
		public InvoiceTemplate()
		{}
		#region Model
		private int _templateid;
		private string _templatename;
		private string _templatepath;
		private int _flag=0;
		private byte[] _templatefile;
		private DateTime _lastopertime= DateTime.Now;
		private int? _lastoperatorid;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int TemplateID
		{
			set{ _templateid=value;}
			get{return _templateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TemplateName
		{
			set{ _templatename=value;}
			get{return _templatename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TemplatePath
		{
			set{ _templatepath=value;}
			get{return _templatepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] TemplateFile
		{
			set{ _templatefile=value;}
			get{return _templatefile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime LastOperTime
		{
			set{ _lastopertime=value;}
			get{return _lastopertime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LastOperatorId
		{
			set{ _lastoperatorid=value;}
			get{return _lastoperatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

