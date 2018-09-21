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
namespace WebDemo.Web.WebDemo.CheckInfo
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
			if(!PageValidate.IsDateTime(txtCheckDate.Text))
			{
				strErr+="CheckDate格式错误！\\n";	
			}
			if(this.txtCheckWorker.Text.Trim().Length==0)
			{
				strErr+="CheckWorker不能为空！\\n";	
			}
			if(this.txtCheckInfo.Text.Trim().Length==0)
			{
				strErr+="CheckInfo不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtCheckMark.Text))
			{
				strErr+="CheckMark格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MeterID=int.Parse(this.txtMeterID.Text);
			DateTime CheckDate=DateTime.Parse(this.txtCheckDate.Text);
			string CheckWorker=this.txtCheckWorker.Text;
			string CheckInfo=this.txtCheckInfo.Text;
			int CheckMark=int.Parse(this.txtCheckMark.Text);

			WebDemo.Model.WebDemo.CheckInfo model=new WebDemo.Model.WebDemo.CheckInfo();
			model.MeterID=MeterID;
			model.CheckDate=CheckDate;
			model.CheckWorker=CheckWorker;
			model.CheckInfo=CheckInfo;
			model.CheckMark=CheckMark;

			WebDemo.BLL.WebDemo.CheckInfo bll=new WebDemo.BLL.WebDemo.CheckInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
