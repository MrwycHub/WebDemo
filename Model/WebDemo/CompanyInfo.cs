using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// CompanyInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CompanyInfo
	{
		public CompanyInfo()
		{}
		#region Model
		private int _id;
		private string _companyname;
		private string _companyno;
		private string _pwd;
		private string _authorizationcode;
		private string _idcode;
		private string _efilecode;
		private string _taxagencycode;
		private string _agentmark;
		private string _projectname;
		private string _projectcode;
		private string _accountbank;
		private string _accountnumber;
		private string _companyaddress;
		private string _companyphone;
		private int _sleeptime=0;
		private DateTime? _updatetime= DateTime.Now;
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
		public string CompanyName
		{
			set{ _companyname=value;}
			get{return _companyname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyNo
		{
			set{ _companyno=value;}
			get{return _companyno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Pwd
		{
			set{ _pwd=value;}
			get{return _pwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AuthorizationCode
		{
			set{ _authorizationcode=value;}
			get{return _authorizationcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IDCode
		{
			set{ _idcode=value;}
			get{return _idcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EFileCode
		{
			set{ _efilecode=value;}
			get{return _efilecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TaxAgencyCode
		{
			set{ _taxagencycode=value;}
			get{return _taxagencycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AgentMark
		{
			set{ _agentmark=value;}
			get{return _agentmark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProjectName
		{
			set{ _projectname=value;}
			get{return _projectname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProjectCode
		{
			set{ _projectcode=value;}
			get{return _projectcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AccountBank
		{
			set{ _accountbank=value;}
			get{return _accountbank;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AccountNumber
		{
			set{ _accountnumber=value;}
			get{return _accountnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyAddress
		{
			set{ _companyaddress=value;}
			get{return _companyaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyPhone
		{
			set{ _companyphone=value;}
			get{return _companyphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SleepTime
		{
			set{ _sleeptime=value;}
			get{return _sleeptime;}
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

