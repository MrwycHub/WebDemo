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
namespace WebDemo.Web.WebDemo.PriceFare
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
					int FareID=(Convert.ToInt32(strid));
					ShowInfo(FareID);
				}
			}
		}
		
	private void ShowInfo(int FareID)
	{
		WebDemo.BLL.WebDemo.PriceFare bll=new WebDemo.BLL.WebDemo.PriceFare();
		WebDemo.Model.WebDemo.PriceFare model=bll.GetModel(FareID);
		this.lblFareID.Text=model.FareID.ToString();
		this.lblPriceTypeID.Text=model.PriceTypeID.ToString();
		this.lblFareTypeName.Text=model.FareTypeName;
		this.lblPrice.Text=model.Price.ToString();
		this.lblPrice2.Text=model.Price2.ToString();
		this.lblPrice3.Text=model.Price3.ToString();
		this.lblFareNo.Text=model.FareNo.ToString();
		this.lblReMark.Text=model.ReMark;
		this.lblPrice4.Text=model.Price4.ToString();
		this.lblPrice5.Text=model.Price5.ToString();
		this.lblPrice6.Text=model.Price6.ToString();
		this.lblTaxRate.Text=model.TaxRate.ToString();
		this.lblProjectName.Text=model.ProjectName;

	}


    }
}
