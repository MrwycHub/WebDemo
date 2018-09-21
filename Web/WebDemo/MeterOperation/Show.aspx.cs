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
namespace WebDemo.Web.WebDemo.MeterOperation
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
					int OperID=(Convert.ToInt32(strid));
					ShowInfo(OperID);
				}
			}
		}
		
	private void ShowInfo(int OperID)
	{
		WebDemo.BLL.WebDemo.MeterOperation bll=new WebDemo.BLL.WebDemo.MeterOperation();
		WebDemo.Model.WebDemo.MeterOperation model=bll.GetModel(OperID);
		this.lblOperID.Text=model.OperID.ToString();
		this.lblOperType.Text=model.OperType;
		this.lblOperDate.Text=model.OperDate.ToString();
		this.lblMeterIDOld.Text=model.MeterIDOld.ToString();
		this.lblMeterIDNew.Text=model.MeterIDNew.ToString();
		this.lblUseNumberOld.Text=model.UseNumberOld.ToString();
		this.lblStatFlag.Text=model.StatFlag.ToString();

	}


    }
}
