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
namespace WebDemo.Web.WebDemo.PhoneMessage
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
		WebDemo.BLL.WebDemo.PhoneMessage bll=new WebDemo.BLL.WebDemo.PhoneMessage();
		WebDemo.Model.WebDemo.PhoneMessage model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblSoftName.Text=model.SoftName;
		this.lblBrands.Text=model.Brands;
		this.lblModel.Text=model.Model;
		this.lblVersion.Text=model.Version;
		this.lblBlueToothVer.Text=model.BlueToothVer;
		this.lblSDKVer.Text=model.SDKVer;
		this.lblIMEI.Text=model.IMEI;
		this.lblCPU.Text=model.CPU;
		this.lblMemory.Text=model.Memory;
		this.lblResolution.Text=model.Resolution;
		this.lblFirstLoginDate.Text=model.FirstLoginDate.ToString();

	}


    }
}
