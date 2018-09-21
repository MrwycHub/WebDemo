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
namespace WebDemo.Web.WebDemo.ManageUser
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUsersID.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}
			if(this.txtManageFareID.Text.Trim().Length==0)
			{
				strErr+="物业费ID不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtChargeDate.Text))
			{
				strErr+="启用时间格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLastDate.Text))
			{
				strErr+="最后一次收费格式错误！\\n";	
			}
			if(this.txtReMark.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtStatus.Text))
			{
				strErr+="Status格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int UsersID=int.Parse(this.txtUsersID.Text);
			string ManageFareID=this.txtManageFareID.Text;
			DateTime ChargeDate=DateTime.Parse(this.txtChargeDate.Text);
			DateTime LastDate=DateTime.Parse(this.txtLastDate.Text);
			string ReMark=this.txtReMark.Text;
			int Status=int.Parse(this.txtStatus.Text);

			WebDemo.Model.WebDemo.ManageUser model=new WebDemo.Model.WebDemo.ManageUser();
			model.UsersID=UsersID;
			model.ManageFareID=ManageFareID;
			model.ChargeDate=ChargeDate;
			model.LastDate=LastDate;
			model.ReMark=ReMark;
			model.Status=Status;

			WebDemo.BLL.WebDemo.ManageUser bll=new WebDemo.BLL.WebDemo.ManageUser();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
