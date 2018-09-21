using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace WebDemo.Web.WebDemo.CompanyInfo
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		WebDemo.BLL.WebDemo.CompanyInfo bll=new WebDemo.BLL.WebDemo.CompanyInfo();
		WebDemo.Model.WebDemo.CompanyInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblCompanyName.Text=model.CompanyName;
		this.lblCompanyNo.Text=model.CompanyNo;
		this.lblPwd.Text=model.Pwd;
		this.lblAuthorizationCode.Text=model.AuthorizationCode;
		this.lblIDCode.Text=model.IDCode;
		this.lblEFileCode.Text=model.EFileCode;
		this.lblTaxAgencyCode.Text=model.TaxAgencyCode;
		this.lblAgentMark.Text=model.AgentMark;
		this.lblProjectName.Text=model.ProjectName;
		this.lblProjectCode.Text=model.ProjectCode;
		this.lblAccountBank.Text=model.AccountBank;
		this.lblAccountNumber.Text=model.AccountNumber;
		this.lblCompanyAddress.Text=model.CompanyAddress;
		this.lblCompanyPhone.Text=model.CompanyPhone;
		this.lblSleepTime.Text=model.SleepTime.ToString();
		this.lblUpdateTime.Text=model.UpdateTime.ToString();

	}


    }
}
