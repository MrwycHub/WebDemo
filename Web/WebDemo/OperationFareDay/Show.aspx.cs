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
namespace WebDemo.Web.WebDemo.OperationFareDay
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
				int FareID = -1;
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					FareID=(Convert.ToInt32(Request.Params["id1"]));
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(OperID,FareID);
			}
		}
		
	private void ShowInfo(int OperID,int FareID)
	{
		WebDemo.BLL.WebDemo.OperationFareDay bll=new WebDemo.BLL.WebDemo.OperationFareDay();
		WebDemo.Model.WebDemo.OperationFareDay model=bll.GetModel(OperID,FareID);
		this.lblOperID.Text=model.OperID.ToString();
		this.lblFareID.Text=model.FareID.ToString();
		this.lblFareTypeName.Text=model.FareTypeName;
		this.lblFarePrice.Text=model.FarePrice.ToString();
		this.lblFareMoney.Text=model.FareMoney.ToString();
		this.lblFarePrice2.Text=model.FarePrice2.ToString();
		this.lblFarePrice3.Text=model.FarePrice3.ToString();
		this.lblDivid1.Text=model.Divid1.ToString();
		this.lblDivid2.Text=model.Divid2.ToString();
		this.lblUseNumber1.Text=model.UseNumber1.ToString();
		this.lblUseNumber2.Text=model.UseNumber2.ToString();
		this.lblUseNumber3.Text=model.UseNumber3.ToString();
		this.lblExtData1.Text=model.ExtData1;
		this.lblExtData2.Text=model.ExtData2;

	}


    }
}
