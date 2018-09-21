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
namespace WebDemo.Web.WebDemo.RatePeriod
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				int SuiteNo = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					SuiteNo=(Convert.ToInt32(Request.Params["id0"]));
				}
				int GroupPeriodNo = -1;
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					GroupPeriodNo=(Convert.ToInt32(Request.Params["id1"]));
				}
				int PeriodNo = -1;
				if (Request.Params["id2"] != null && Request.Params["id2"].Trim() != "")
				{
					PeriodNo=(Convert.ToInt32(Request.Params["id2"]));
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(SuiteNo,GroupPeriodNo,PeriodNo);
			}
		}
		
	private void ShowInfo(int SuiteNo,int GroupPeriodNo,int PeriodNo)
	{
		WebDemo.BLL.WebDemo.RatePeriod bll=new WebDemo.BLL.WebDemo.RatePeriod();
		WebDemo.Model.WebDemo.RatePeriod model=bll.GetModel(SuiteNo,GroupPeriodNo,PeriodNo);
		this.lblSuiteNo.Text=model.SuiteNo.ToString();
		this.lblGroupPeriodNo.Text=model.GroupPeriodNo.ToString();
		this.lblPeriodNo.Text=model.PeriodNo.ToString();
		this.lblBeginTime.Text=model.BeginTime.ToString();
		this.lblFareRateNo.Text=model.FareRateNo.ToString();

	}


    }
}
