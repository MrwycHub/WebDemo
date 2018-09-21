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
namespace WebDemo.Web.WebDemo.MeterModal
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
					int Modalid=(Convert.ToInt32(strid));
					ShowInfo(Modalid);
				}
			}
		}
		
	private void ShowInfo(int Modalid)
	{
		WebDemo.BLL.WebDemo.MeterModal bll=new WebDemo.BLL.WebDemo.MeterModal();
		WebDemo.Model.WebDemo.MeterModal model=bll.GetModel(Modalid);
		this.lblModalid.Text=model.Modalid.ToString();
		this.lblModalname.Text=model.Modalname;
		this.lblRemark.Text=model.Remark;
		this.lblUseProtocol.Text=model.UseProtocol.ToString();
		this.lblFactoryCode.Text=model.FactoryCode;
		this.lblFactoryName.Text=model.FactoryName;
		this.lblMaxValue.Text=model.MaxValue.ToString();
		this.lblMaxYear.Text=model.MaxYear.ToString();
		this.lblCaliber.Text=model.Caliber;
		this.lblMaxFlow.Text=model.MaxFlow.ToString();
		this.lblMeterHeaderType.Text=model.MeterHeaderType.ToString();
		this.lblMeterStatusCode.Text=model.MeterStatusCode;

	}


    }
}
