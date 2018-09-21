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
namespace WebDemo.Web.WebDemo.FareItem
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
		WebDemo.BLL.WebDemo.FareItem bll=new WebDemo.BLL.WebDemo.FareItem();
		WebDemo.Model.WebDemo.FareItem model=bll.GetModel(FareID);
		this.lblFareID.Text=model.FareID.ToString();
		this.lblCycNumber.Text=model.CycNumber.ToString();
		this.lblFareName.Text=model.FareName;
		this.lblFareMoney.Text=model.FareMoney.ToString();
		this.lblFareMemo.Text=model.FareMemo;
		this.lblFareMark.Text=model.FareMark.ToString();
		this.lblPriceUnit.Text=model.PriceUnit;

	}


    }
}
