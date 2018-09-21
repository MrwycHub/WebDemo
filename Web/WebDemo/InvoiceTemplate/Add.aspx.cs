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
namespace WebDemo.Web.WebDemo.InvoiceTemplate
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtTemplateID.Text))
			{
				strErr+="TemplateID格式错误！\\n";	
			}
			if(this.txtTemplateName.Text.Trim().Length==0)
			{
				strErr+="TemplateName不能为空！\\n";	
			}
			if(this.txtTemplatePath.Text.Trim().Length==0)
			{
				strErr+="TemplatePath不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFlag.Text))
			{
				strErr+="Flag格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLastOperTime.Text))
			{
				strErr+="LastOperTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtLastOperatorId.Text))
			{
				strErr+="LastOperatorId格式错误！\\n";	
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
			int TemplateID=int.Parse(this.txtTemplateID.Text);
			string TemplateName=this.txtTemplateName.Text;
			string TemplatePath=this.txtTemplatePath.Text;
			int Flag=int.Parse(this.txtFlag.Text);
			byte[] TemplateFile= new UnicodeEncoding().GetBytes(this.txtTemplateFile.Text);
			DateTime LastOperTime=DateTime.Parse(this.txtLastOperTime.Text);
			int LastOperatorId=int.Parse(this.txtLastOperatorId.Text);
			string Remark=this.txtRemark.Text;

			WebDemo.Model.WebDemo.InvoiceTemplate model=new WebDemo.Model.WebDemo.InvoiceTemplate();
			model.TemplateID=TemplateID;
			model.TemplateName=TemplateName;
			model.TemplatePath=TemplatePath;
			model.Flag=Flag;
			model.TemplateFile=TemplateFile;
			model.LastOperTime=LastOperTime;
			model.LastOperatorId=LastOperatorId;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.InvoiceTemplate bll=new WebDemo.BLL.WebDemo.InvoiceTemplate();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
