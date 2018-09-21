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
namespace WebDemo.Web.WebDemo.FeeOperation
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
					int FID=(Convert.ToInt32(strid));
					ShowInfo(FID);
				}
			}
		}
		
	private void ShowInfo(int FID)
	{
		WebDemo.BLL.WebDemo.FeeOperation bll=new WebDemo.BLL.WebDemo.FeeOperation();
		WebDemo.Model.WebDemo.FeeOperation model=bll.GetModel(FID);
		this.lblFID.Text=model.FID.ToString();
		this.lblUsersID.Text=model.UsersID.ToString();
		this.lblFareID.Text=model.FareID.ToString();
		this.lblFee.Text=model.Fee.ToString();
		this.lblFactFee.Text=model.FactFee.ToString();
		this.lblOperDate.Text=model.OperDate.ToString();
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblSiteID.Text=model.SiteID.ToString();

	}


    }
}
