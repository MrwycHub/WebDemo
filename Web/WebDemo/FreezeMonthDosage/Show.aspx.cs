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
namespace WebDemo.Web.WebDemo.FreezeMonthDosage
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
					int id=(Convert.ToInt32(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		WebDemo.BLL.WebDemo.FreezeMonthDosage bll=new WebDemo.BLL.WebDemo.FreezeMonthDosage();
		WebDemo.Model.WebDemo.FreezeMonthDosage model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblBeginMonth.Text=model.BeginMonth;
		this.lblBeginNumber.Text=model.BeginNumber.ToString();
		this.lblFreezeMonth.Text=model.FreezeMonth;
		this.lblEndNumber.Text=model.EndNumber.ToString();
		this.lblUseNumber.Text=model.UseNumber.ToString();
		this.lblInsertDate.Text=model.InsertDate.ToString();
		this.lblUseActiveSharp.Text=model.UseActiveSharp.ToString();
		this.lblUseActivePeak.Text=model.UseActivePeak.ToString();
		this.lblUseActiveShoulder.Text=model.UseActiveShoulder.ToString();
		this.lblUseActiveOffPeak.Text=model.UseActiveOffPeak.ToString();
		this.lblSyncFlag.Text=model.SyncFlag.ToString();

	}


    }
}
