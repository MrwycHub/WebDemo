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
namespace WebDemo.Web.WebDemo.InstallFee
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
					int InstallID=(Convert.ToInt32(strid));
					ShowInfo(InstallID);
				}
			}
		}
		
	private void ShowInfo(int InstallID)
	{
		WebDemo.BLL.WebDemo.InstallFee bll=new WebDemo.BLL.WebDemo.InstallFee();
		WebDemo.Model.WebDemo.InstallFee model=bll.GetModel(InstallID);
		this.lblInstallID.Text=model.InstallID.ToString();
		this.lblUserNum.Text=model.UserNum.ToString();
		this.lblSingleFee.Text=model.SingleFee.ToString();
		this.lblSumFee.Text=model.SumFee.ToString();
		this.lblOperDate.Text=model.OperDate.ToString();
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblSiteID.Text=model.SiteID.ToString();
		this.lblMark.Text=model.Mark.ToString();
		this.lblInstallMark.Text=model.InstallMark.ToString();

	}


    }
}
