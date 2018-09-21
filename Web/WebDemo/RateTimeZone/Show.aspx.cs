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
namespace WebDemo.Web.WebDemo.RateTimeZone
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
				int TimeZoneNo = -1;
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					TimeZoneNo=(Convert.ToInt32(Request.Params["id1"]));
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(SuiteNo,TimeZoneNo);
			}
		}
		
	private void ShowInfo(int SuiteNo,int TimeZoneNo)
	{
		WebDemo.BLL.WebDemo.RateTimeZone bll=new WebDemo.BLL.WebDemo.RateTimeZone();
		WebDemo.Model.WebDemo.RateTimeZone model=bll.GetModel(SuiteNo,TimeZoneNo);
		this.lblSuiteNo.Text=model.SuiteNo.ToString();
		this.lblTimeZoneNo.Text=model.TimeZoneNo.ToString();
		this.lblBeginDate.Text=model.BeginDate.ToString();
		this.lblGroupPeriodNo.Text=model.GroupPeriodNo.ToString();

	}


    }
}
