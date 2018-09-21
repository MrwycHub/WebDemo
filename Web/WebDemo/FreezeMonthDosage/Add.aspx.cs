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
namespace WebDemo.Web.WebDemo.FreezeMonthDosage
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
			if(this.txtBeginMonth.Text.Trim().Length==0)
			{
				strErr+="BeginMonth不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtBeginNumber.Text))
			{
				strErr+="BeginNumber格式错误！\\n";	
			}
			if(this.txtFreezeMonth.Text.Trim().Length==0)
			{
				strErr+="FreezeMonth不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtEndNumber.Text))
			{
				strErr+="EndNumber格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtUseNumber.Text))
			{
				strErr+="UseNumber格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtInsertDate.Text))
			{
				strErr+="InsertDate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtUseActiveSharp.Text))
			{
				strErr+="UseActiveSharp格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtUseActivePeak.Text))
			{
				strErr+="UseActivePeak格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtUseActiveShoulder.Text))
			{
				strErr+="UseActiveShoulder格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtUseActiveOffPeak.Text))
			{
				strErr+="UseActiveOffPeak格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSyncFlag.Text))
			{
				strErr+="SyncFlag格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MeterID=int.Parse(this.txtMeterID.Text);
			string BeginMonth=this.txtBeginMonth.Text;
			decimal BeginNumber=decimal.Parse(this.txtBeginNumber.Text);
			string FreezeMonth=this.txtFreezeMonth.Text;
			decimal EndNumber=decimal.Parse(this.txtEndNumber.Text);
			decimal UseNumber=decimal.Parse(this.txtUseNumber.Text);
			DateTime InsertDate=DateTime.Parse(this.txtInsertDate.Text);
			decimal UseActiveSharp=decimal.Parse(this.txtUseActiveSharp.Text);
			decimal UseActivePeak=decimal.Parse(this.txtUseActivePeak.Text);
			decimal UseActiveShoulder=decimal.Parse(this.txtUseActiveShoulder.Text);
			decimal UseActiveOffPeak=decimal.Parse(this.txtUseActiveOffPeak.Text);
			int SyncFlag=int.Parse(this.txtSyncFlag.Text);

			WebDemo.Model.WebDemo.FreezeMonthDosage model=new WebDemo.Model.WebDemo.FreezeMonthDosage();
			model.MeterID=MeterID;
			model.BeginMonth=BeginMonth;
			model.BeginNumber=BeginNumber;
			model.FreezeMonth=FreezeMonth;
			model.EndNumber=EndNumber;
			model.UseNumber=UseNumber;
			model.InsertDate=InsertDate;
			model.UseActiveSharp=UseActiveSharp;
			model.UseActivePeak=UseActivePeak;
			model.UseActiveShoulder=UseActiveShoulder;
			model.UseActiveOffPeak=UseActiveOffPeak;
			model.SyncFlag=SyncFlag;

			WebDemo.BLL.WebDemo.FreezeMonthDosage bll=new WebDemo.BLL.WebDemo.FreezeMonthDosage();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
