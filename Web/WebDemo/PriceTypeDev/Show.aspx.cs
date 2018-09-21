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
namespace WebDemo.Web.WebDemo.PriceTypeDev
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
					int PriceTypeID=(Convert.ToInt32(strid));
					ShowInfo(PriceTypeID);
				}
			}
		}
		
	private void ShowInfo(int PriceTypeID)
	{
		WebDemo.BLL.WebDemo.PriceTypeDev bll=new WebDemo.BLL.WebDemo.PriceTypeDev();
		WebDemo.Model.WebDemo.PriceTypeDev model=bll.GetModel(PriceTypeID);
		this.lblPriceTypeID.Text=model.PriceTypeID.ToString();
		this.lblLateFeeRate.Text=model.LateFeeRate.ToString();
		this.lblLateFeeDate.Text=model.LateFeeDate.ToString();
		this.lblLateFeeBase.Text=model.LateFeeBase.ToString();
		this.lblICMonth.Text=model.ICMonth.ToString();
		this.lblICMaxBuy.Text=model.ICMaxBuy.ToString();
		this.lblICAmount.Text=model.ICAmount.ToString();
		this.lblICMonthBuy.Text=model.ICMonthBuy.ToString();
		this.lblICDayAvg.Text=model.ICDayAvg.ToString();

	}


    }
}
