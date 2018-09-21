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
namespace WebDemo.Web.WebDemo.FreezeMonthOperLog
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
		WebDemo.BLL.WebDemo.FreezeMonthOperLog bll=new WebDemo.BLL.WebDemo.FreezeMonthOperLog();
		WebDemo.Model.WebDemo.FreezeMonthOperLog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblType.Text=model.Type.ToString();
		this.lblFreezeMonth.Text=model.FreezeMonth;
		this.lblContent.Text=model.Content;
		this.lblUpdateTime.Text=model.UpdateTime.ToString();

	}


    }
}
