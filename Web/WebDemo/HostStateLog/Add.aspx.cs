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
namespace WebDemo.Web.WebDemo.HostStateLog
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtHostId.Text))
			{
				strErr+="HostId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFuncType.Text))
			{
				strErr+="FuncType格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtReadTime.Text))
			{
				strErr+="ReadTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtState.Text))
			{
				strErr+="State格式错误！\\n";	
			}
			if(this.txtDescripion.Text.Trim().Length==0)
			{
				strErr+="Descripion不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int HostId=int.Parse(this.txtHostId.Text);
			int FuncType=int.Parse(this.txtFuncType.Text);
			DateTime ReadTime=DateTime.Parse(this.txtReadTime.Text);
			int State=int.Parse(this.txtState.Text);
			string Descripion=this.txtDescripion.Text;
			string Remark=this.txtRemark.Text;

			WebDemo.Model.WebDemo.HostStateLog model=new WebDemo.Model.WebDemo.HostStateLog();
			model.HostId=HostId;
			model.FuncType=FuncType;
			model.ReadTime=ReadTime;
			model.State=State;
			model.Descripion=Descripion;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.HostStateLog bll=new WebDemo.BLL.WebDemo.HostStateLog();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
