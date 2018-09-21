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
namespace WebDemo.Web.WebDemo.PreOperationFare
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				int OperID = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					OperID=(Convert.ToInt32(Request.Params["id0"]));
				}
				string FareTypeName = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					FareTypeName= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(OperID,FareTypeName);
			}
		}
		
	private void ShowInfo(int OperID,string FareTypeName)
	{
		WebDemo.BLL.WebDemo.PreOperationFare bll=new WebDemo.BLL.WebDemo.PreOperationFare();
		WebDemo.Model.WebDemo.PreOperationFare model=bll.GetModel(OperID,FareTypeName);
		this.lblOperID.Text=model.OperID.ToString();
		this.lblFareID.Text=model.FareID.ToString();
		this.lblFareTypeName.Text=model.FareTypeName;
		this.lblFarePrice.Text=model.FarePrice.ToString();
		this.lblFareMoney.Text=model.FareMoney.ToString();
		this.lblFareMoney1.Text=model.FareMoney1.ToString();
		this.lblFarePrice2.Text=model.FarePrice2.ToString();
		this.lblFareMoney2.Text=model.FareMoney2.ToString();
		this.lblFarePrice3.Text=model.FarePrice3.ToString();
		this.lblFareMoney3.Text=model.FareMoney3.ToString();
		this.lblTaxRate.Text=model.TaxRate.ToString();

	}


    }
}
