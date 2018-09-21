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
namespace WebDemo.Web.WebDemo.CommandType
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtCommandID.Text))
			{
				strErr+="指令编号格式错误！\\n";	
			}
			if(this.txtCommandName.Text.Trim().Length==0)
			{
				strErr+="指令名称不能为空！\\n";	
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
			int CommandID=int.Parse(this.txtCommandID.Text);
			string CommandName=this.txtCommandName.Text;
			int Flag=int.Parse(this.txtFlag.Text);

			WebDemo.Model.WebDemo.CommandType model=new WebDemo.Model.WebDemo.CommandType();
			model.CommandID=CommandID;
			model.CommandName=CommandName;
			model.Flag=Flag;

			WebDemo.BLL.WebDemo.CommandType bll=new WebDemo.BLL.WebDemo.CommandType();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
