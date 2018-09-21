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
namespace WebDemo.Web.WebDemo.RatePrice
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				int GroupPriceNo = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					GroupPriceNo=(Convert.ToInt32(Request.Params["id0"]));
				}
				int FareRateNo = -1;
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					FareRateNo=(Convert.ToInt32(Request.Params["id1"]));
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(GroupPriceNo,FareRateNo);
			}
		}
		
	private void ShowInfo(int GroupPriceNo,int FareRateNo)
	{
		WebDemo.BLL.WebDemo.RatePrice bll=new WebDemo.BLL.WebDemo.RatePrice();
		WebDemo.Model.WebDemo.RatePrice model=bll.GetModel(GroupPriceNo,FareRateNo);
		this.lblGroupPriceNo.Text=model.GroupPriceNo.ToString();
		this.lblFareRateNo.Text=model.FareRateNo.ToString();
		this.lblFareName.Text=model.FareName;
		this.lblPrice.Text=model.Price.ToString();

	}


    }
}
