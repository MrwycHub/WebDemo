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
namespace WebDemo.Web.WebDemo.Operators
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
					int OperatorID=(Convert.ToInt32(strid));
					ShowInfo(OperatorID);
				}
			}
		}
		
	private void ShowInfo(int OperatorID)
	{
		WebDemo.BLL.WebDemo.Operators bll=new WebDemo.BLL.WebDemo.Operators();
		WebDemo.Model.WebDemo.Operators model=bll.GetModel(OperatorID);
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblOperatorCode.Text=model.OperatorCode;
		this.lblOperatorName.Text=model.OperatorName;
		this.lblRoleID.Text=model.RoleID.ToString();
		this.lblOperPassword.Text=model.OperPassword;
		this.lblSiteID.Text=model.SiteID.ToString();
		this.lblFlag.Text=model.Flag.ToString();
		this.lblCreateDate.Text=model.CreateDate.ToString();
		this.lblLastLoginDate.Text=model.LastLoginDate.ToString();
		this.lblPageRowCounts.Text=model.PageRowCounts.ToString();
		this.lblOperLevel.Text=model.OperLevel;
		this.lblTemplateID.Text=model.TemplateID.ToString();
		this.lblPaymentTemplateID.Text=model.PaymentTemplateID.ToString();
		this.lblICTemplateID.Text=model.ICTemplateID.ToString();
		this.lblPhone.Text=model.Phone;
		this.lblSelfSetting.Text=model.SelfSetting;
		this.lblAutoRead.Text=model.AutoRead.ToString();
		this.lblPhoneSerialNumber.Text=model.PhoneSerialNumber;
		this.lblIsBinding.Text=model.IsBinding.ToString();
		this.lblRoleLevel.Text=model.RoleLevel.ToString();
		this.lblExpiryDate.Text=model.ExpiryDate.ToString();
		this.lblSkin.Text=model.Skin;

	}


    }
}
