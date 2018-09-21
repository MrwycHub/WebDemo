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
namespace WebDemo.Web.WebDemo.MeterImageDataLog
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
		WebDemo.BLL.WebDemo.MeterImageDataLog bll=new WebDemo.BLL.WebDemo.MeterImageDataLog();
		WebDemo.Model.WebDemo.MeterImageDataLog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblReadTime.Text=model.ReadTime.ToString();
		this.lblVoltage.Text=model.Voltage.ToString();
		this.lblValveState.Text=model.ValveState.ToString();
		this.lblLowVoltage.Text=model.LowVoltage?"是":"否";
		this.lblMagneticDisturb.Text=model.MagneticDisturb?"是":"否";
		this.lblImageQuality.Text=model.ImageQuality.ToString();
		this.lblEnableUpload.Text=model.EnableUpload?"是":"否";
		this.lblMeterImage.Text=model.MeterImage.ToString();
		this.lblInsertDate.Text=model.InsertDate.ToString();
		this.lblFreezeNumber.Text=model.FreezeNumber.ToString();
		this.lblLeftMeterImage.Text=model.LeftMeterImage.ToString();
		this.lblRightMeterImage.Text=model.RightMeterImage.ToString();

	}


    }
}
