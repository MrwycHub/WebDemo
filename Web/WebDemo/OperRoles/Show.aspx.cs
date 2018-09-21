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
namespace WebDemo.Web.WebDemo.OperRoles
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				int MenuID = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					MenuID=(Convert.ToInt32(Request.Params["id0"]));
				}
				int RoleID = -1;
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					RoleID=(Convert.ToInt32(Request.Params["id1"]));
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(MenuID,RoleID);
			}
		}
		
	private void ShowInfo(int MenuID,int RoleID)
	{
		WebDemo.BLL.WebDemo.OperRoles bll=new WebDemo.BLL.WebDemo.OperRoles();
		WebDemo.Model.WebDemo.OperRoles model=bll.GetModel(MenuID,RoleID);
		this.lblMenuID.Text=model.MenuID.ToString();
		this.lblRoleID.Text=model.RoleID.ToString();

	}


    }
}
