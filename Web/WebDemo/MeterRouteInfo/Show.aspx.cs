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
namespace WebDemo.Web.WebDemo.MeterRouteInfo
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
					string MeterAddr= strid;
					ShowInfo(MeterAddr);
				}
			}
		}
		
	private void ShowInfo(string MeterAddr)
	{
		WebDemo.BLL.WebDemo.MeterRouteInfo bll=new WebDemo.BLL.WebDemo.MeterRouteInfo();
		WebDemo.Model.WebDemo.MeterRouteInfo model=bll.GetModel(MeterAddr);
		this.lblMeterAddr.Text=model.MeterAddr;
		this.lblMeterNo.Text=model.MeterNo.ToString();
		this.lblNode1.Text=model.Node1;
		this.lblDepth1.Text=model.Depth1.ToString();
		this.lblNode2.Text=model.Node2;
		this.lblDepth2.Text=model.Depth2.ToString();
		this.lblNode3.Text=model.Node3;
		this.lblDepth3.Text=model.Depth3.ToString();
		this.lblNode4.Text=model.Node4;
		this.lblDepth4.Text=model.Depth4.ToString();
		this.lblResult.Text=model.Result?"是":"否";
		this.lblCollectorId.Text=model.CollectorId.ToString();
		this.lblMeterId.Text=model.MeterId.ToString();
		this.lblReadTime.Text=model.ReadTime.ToString();

	}


    }
}
