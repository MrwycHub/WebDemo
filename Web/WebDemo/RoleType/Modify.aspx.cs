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
namespace WebDemo.Web.WebDemo.RoleType
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int RoleID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(RoleID);
				}
			}
		}
			
	private void ShowInfo(int RoleID)
	{
		WebDemo.BLL.WebDemo.RoleType bll=new WebDemo.BLL.WebDemo.RoleType();
		WebDemo.Model.WebDemo.RoleType model=bll.GetModel(RoleID);
		this.lblRoleID.Text=model.RoleID.ToString();
		this.txtRoleName.Text=model.RoleName;
		this.txtRemark.Text=model.Remark;
		this.txtPriority.Text=model.Priority.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtRoleName.Text.Trim().Length==0)
			{
				strErr+="RoleName不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注信息不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPriority.Text))
			{
				strErr+="Priority格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int RoleID=int.Parse(this.lblRoleID.Text);
			string RoleName=this.txtRoleName.Text;
			string Remark=this.txtRemark.Text;
			int Priority=int.Parse(this.txtPriority.Text);


			WebDemo.Model.WebDemo.RoleType model=new WebDemo.Model.WebDemo.RoleType();
			model.RoleID=RoleID;
			model.RoleName=RoleName;
			model.Remark=Remark;
			model.Priority=Priority;

			WebDemo.BLL.WebDemo.RoleType bll=new WebDemo.BLL.WebDemo.RoleType();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
