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
namespace WebDemo.Web.WebDemo.LostInfo
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
					int LostID=(Convert.ToInt32(strid));
					ShowInfo(LostID);
				}
			}
		}
		
	private void ShowInfo(int LostID)
	{
		WebDemo.BLL.WebDemo.LostInfo bll=new WebDemo.BLL.WebDemo.LostInfo();
		WebDemo.Model.WebDemo.LostInfo model=bll.GetModel(LostID);
		this.lblLostID.Text=model.LostID.ToString();
		this.lblMultiUserID.Text=model.MultiUserID.ToString();
		this.lblCardID.Text=model.CardID.ToString();
		this.lblLostDate.Text=model.LostDate.ToString();
		this.lblDownloadDate.Text=model.DownloadDate.ToString();
		this.lblSuccessMeterID.Text=model.SuccessMeterID.ToString();
		this.lblSuccessDate.Text=model.SuccessDate.ToString();

	}


    }
}
