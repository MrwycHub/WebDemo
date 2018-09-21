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
namespace WebDemo.Web.WebDemo.ActivityValveInfo
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
					int MeterID=(Convert.ToInt32(strid));
					ShowInfo(MeterID);
				}
			}
		}
		
	private void ShowInfo(int MeterID)
	{
		WebDemo.BLL.WebDemo.ActivityValveInfo bll=new WebDemo.BLL.WebDemo.ActivityValveInfo();
		WebDemo.Model.WebDemo.ActivityValveInfo model=bll.GetModel(MeterID);
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblValveStatusBefore.Text=model.ValveStatusBefore.ToString();
		this.lblValveStatusAfter.Text=model.ValveStatusAfter.ToString();
		this.lblOperTime.Text=model.OperTime.ToString();
		this.lblOperFlag.Text=model.OperFlag;

	}


    }
}
