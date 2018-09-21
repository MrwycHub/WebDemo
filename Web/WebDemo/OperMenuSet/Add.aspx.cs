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
namespace WebDemo.Web.WebDemo.OperMenuSet
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
			if(!PageValidate.IsNumber(txtFlag.Text))
			{
				strErr+="Flag格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			int MenuID=int.Parse(this.txtMenuID.Text);
			int OrderNo=int.Parse(this.txtOrderNo.Text);
			int Flag=int.Parse(this.txtFlag.Text);

			WebDemo.Model.WebDemo.OperMenuSet model=new WebDemo.Model.WebDemo.OperMenuSet();
			model.OperatorID=OperatorID;
			model.MenuID=MenuID;
			model.OrderNo=OrderNo;
			model.Flag=Flag;

			WebDemo.BLL.WebDemo.OperMenuSet bll=new WebDemo.BLL.WebDemo.OperMenuSet();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
