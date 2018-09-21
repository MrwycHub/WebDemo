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
namespace WebDemo.Web.WebDemo.MeterStateDictionary
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
					int StateCode=(Convert.ToInt32(strid));
					ShowInfo(StateCode);
				}
			}
		}
		
	private void ShowInfo(int StateCode)
	{
		WebDemo.BLL.WebDemo.MeterStateDictionary bll=new WebDemo.BLL.WebDemo.MeterStateDictionary();
		WebDemo.Model.WebDemo.MeterStateDictionary model=bll.GetModel(StateCode);
		this.lblStateCode.Text=model.StateCode.ToString();
		this.lblStateName.Text=model.StateName;
		this.lblEnable.Text=model.Enable?"是":"否";
		this.lblIsShow.Text=model.IsShow?"是":"否";
		this.lblOrderNum.Text=model.OrderNum.ToString();
		this.lblReasion.Text=model.Reasion;
		this.lblOperation.Text=model.Operation;

	}


    }
}
