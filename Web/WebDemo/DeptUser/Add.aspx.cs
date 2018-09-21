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
namespace WebDemo.Web.WebDemo.DeptUser
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtOperatorCode.Text.Trim().Length==0)
			{
				strErr+="OperatorCode不能为空！\\n";	
			}
			if(this.txtDeptID.Text.Trim().Length==0)
			{
				strErr+="DeptID不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string OperatorCode=this.txtOperatorCode.Text;
			string DeptID=this.txtDeptID.Text;

			WebDemo.Model.WebDemo.DeptUser model=new WebDemo.Model.WebDemo.DeptUser();
			model.OperatorCode=OperatorCode;
			model.DeptID=DeptID;

			WebDemo.BLL.WebDemo.DeptUser bll=new WebDemo.BLL.WebDemo.DeptUser();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
