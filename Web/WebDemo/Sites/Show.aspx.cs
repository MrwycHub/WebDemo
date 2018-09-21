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
namespace WebDemo.Web.WebDemo.Sites
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
					int SiteID=(Convert.ToInt32(strid));
					ShowInfo(SiteID);
				}
			}
		}
		
	private void ShowInfo(int SiteID)
	{
		WebDemo.BLL.WebDemo.Sites bll=new WebDemo.BLL.WebDemo.Sites();
		WebDemo.Model.WebDemo.Sites model=bll.GetModel(SiteID);
		this.lblSiteID.Text=model.SiteID.ToString();
		this.lblSiteName.Text=model.SiteName;
		this.lblSiteAddr.Text=model.SiteAddr;
		this.lblRemark.Text=model.Remark;

	}


    }
}
