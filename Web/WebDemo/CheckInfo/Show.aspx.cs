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
namespace WebDemo.Web.WebDemo.CheckInfo
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
		WebDemo.BLL.WebDemo.CheckInfo bll=new WebDemo.BLL.WebDemo.CheckInfo();
		WebDemo.Model.WebDemo.CheckInfo model=bll.GetModel(FID);
		this.lblFID.Text=model.FID.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblCheckDate.Text=model.CheckDate.ToString();
		this.lblCheckWorker.Text=model.CheckWorker;
		this.lblCheckInfo.Text=model.CheckInfo;
		this.lblCheckMark.Text=model.CheckMark.ToString();

	}


    }
}
