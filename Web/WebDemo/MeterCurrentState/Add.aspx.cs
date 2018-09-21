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
namespace WebDemo.Web.WebDemo.MeterCurrentState
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
			if(!PageValidate.IsNumber(txtStateCode.Text))
			{
				strErr+="StateCode格式错误！\\n";	
			}
			if(this.txtStateValue.Text.Trim().Length==0)
			{
				strErr+="StateValue不能为空！\\n";	
			}
			if(this.txtStateInfo.Text.Trim().Length==0)
			{
				strErr+="StateInfo不能为空！\\n";	
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
			int StateCode=int.Parse(this.txtStateCode.Text);
			string StateValue=this.txtStateValue.Text;
			string StateInfo=this.txtStateInfo.Text;
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);

			WebDemo.Model.WebDemo.MeterCurrentState model=new WebDemo.Model.WebDemo.MeterCurrentState();
			model.MeterID=MeterID;
			model.StateCode=StateCode;
			model.StateValue=StateValue;
			model.StateInfo=StateInfo;
			model.UpdateTime=UpdateTime;

			WebDemo.BLL.WebDemo.MeterCurrentState bll=new WebDemo.BLL.WebDemo.MeterCurrentState();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
