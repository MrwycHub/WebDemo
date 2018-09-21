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
namespace WebDemo.Web.WebDemo.MeterCurrentState
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				int MeterID = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					MeterID=(Convert.ToInt32(Request.Params["id0"]));
				}
				int StateCode = -1;
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					StateCode=(Convert.ToInt32(Request.Params["id1"]));
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(MeterID,StateCode);
			}
		}
		
	private void ShowInfo(int MeterID,int StateCode)
	{
		WebDemo.BLL.WebDemo.MeterCurrentState bll=new WebDemo.BLL.WebDemo.MeterCurrentState();
		WebDemo.Model.WebDemo.MeterCurrentState model=bll.GetModel(MeterID,StateCode);
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblStateCode.Text=model.StateCode.ToString();
		this.lblStateValue.Text=model.StateValue;
		this.lblStateInfo.Text=model.StateInfo;
		this.lblUpdateTime.Text=model.UpdateTime.ToString();

	}


    }
}
