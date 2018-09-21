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
namespace WebDemo.Web.WebDemo.Otherfare
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
					int OtherID=(Convert.ToInt32(strid));
					ShowInfo(OtherID);
				}
			}
		}
		
	private void ShowInfo(int OtherID)
	{
		WebDemo.BLL.WebDemo.Otherfare bll=new WebDemo.BLL.WebDemo.Otherfare();
		WebDemo.Model.WebDemo.Otherfare model=bll.GetModel(OtherID);
		this.lblOtherID.Text=model.OtherID.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblFareID.Text=model.FareID.ToString();
		this.lblFareNum.Text=model.FareNum.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblFlag.Text=model.Flag.ToString();

	}


    }
}
