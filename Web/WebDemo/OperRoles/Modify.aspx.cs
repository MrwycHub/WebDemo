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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace WebDemo.Web.WebDemo.OperRoles
{
    public partial class Modify : Page
    {       

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

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MenuID=int.Parse(this.lblMenuID.Text);
			int RoleID=int.Parse(this.lblRoleID.Text);


			WebDemo.Model.WebDemo.OperRoles model=new WebDemo.Model.WebDemo.OperRoles();
			model.MenuID=MenuID;
			model.RoleID=RoleID;

			WebDemo.BLL.WebDemo.OperRoles bll=new WebDemo.BLL.WebDemo.OperRoles();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
