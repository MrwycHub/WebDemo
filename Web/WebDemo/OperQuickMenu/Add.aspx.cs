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
namespace WebDemo.Web.WebDemo.OperQuickMenu
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMenuID.Text))
			{
				strErr+="MenuID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrderNo.Text))
			{
				strErr+="OrderNo格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtQuickMenuNum.Text))
			{
				strErr+="QuickMenuNum格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			int MenuID=int.Parse(this.txtMenuID.Text);
			int OrderNo=int.Parse(this.txtOrderNo.Text);
			int QuickMenuNum=int.Parse(this.txtQuickMenuNum.Text);

			WebDemo.Model.WebDemo.OperQuickMenu model=new WebDemo.Model.WebDemo.OperQuickMenu();
			model.OperatorID=OperatorID;
			model.MenuID=MenuID;
			model.OrderNo=OrderNo;
			model.QuickMenuNum=QuickMenuNum;

			WebDemo.BLL.WebDemo.OperQuickMenu bll=new WebDemo.BLL.WebDemo.OperQuickMenu();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
