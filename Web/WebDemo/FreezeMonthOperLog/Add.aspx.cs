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
namespace WebDemo.Web.WebDemo.FreezeMonthOperLog
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMeterID.Text))
			{
				strErr+="MeterID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtType.Text))
			{
				strErr+="Type格式错误！\\n";	
			}
			if(this.txtFreezeMonth.Text.Trim().Length==0)
			{
				strErr+="FreezeMonth不能为空！\\n";	
			}
			if(this.txtContent.Text.Trim().Length==0)
			{
				strErr+="Content不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdateTime.Text))
			{
				strErr+="UpdateTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MeterID=int.Parse(this.txtMeterID.Text);
			int Type=int.Parse(this.txtType.Text);
			string FreezeMonth=this.txtFreezeMonth.Text;
			string Content=this.txtContent.Text;
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);

			WebDemo.Model.WebDemo.FreezeMonthOperLog model=new WebDemo.Model.WebDemo.FreezeMonthOperLog();
			model.MeterID=MeterID;
			model.Type=Type;
			model.FreezeMonth=FreezeMonth;
			model.Content=Content;
			model.UpdateTime=UpdateTime;

			WebDemo.BLL.WebDemo.FreezeMonthOperLog bll=new WebDemo.BLL.WebDemo.FreezeMonthOperLog();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
