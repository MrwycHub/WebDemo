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
namespace WebDemo.Web.WebDemo.FareType
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
					int FareTypeID=(Convert.ToInt32(strid));
					ShowInfo(FareTypeID);
				}
			}
		}
		
	private void ShowInfo(int FareTypeID)
	{
		WebDemo.BLL.WebDemo.FareType bll=new WebDemo.BLL.WebDemo.FareType();
		WebDemo.Model.WebDemo.FareType model=bll.GetModel(FareTypeID);
		this.lblFareTypeID.Text=model.FareTypeID.ToString();
		this.lblFareTypeName.Text=model.FareTypeName;
		this.lblRemark.Text=model.Remark;
		this.lblMeterTypeID.Text=model.MeterTypeID.ToString();

	}


    }
}
