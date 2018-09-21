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
namespace WebDemo.Web.WebDemo.OperQuickMenu
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				int OperatorID = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					OperatorID=(Convert.ToInt32(Request.Params["id0"]));
				}
				int MenuID = -1;
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					MenuID=(Convert.ToInt32(Request.Params["id1"]));
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(OperatorID,MenuID);
			}
		}
		
	private void ShowInfo(int OperatorID,int MenuID)
	{
		WebDemo.BLL.WebDemo.OperQuickMenu bll=new WebDemo.BLL.WebDemo.OperQuickMenu();
		WebDemo.Model.WebDemo.OperQuickMenu model=bll.GetModel(OperatorID,MenuID);
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblMenuID.Text=model.MenuID.ToString();
		this.lblOrderNo.Text=model.OrderNo.ToString();
		this.lblQuickMenuNum.Text=model.QuickMenuNum.ToString();

	}


    }
}
