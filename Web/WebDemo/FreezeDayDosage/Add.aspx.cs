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
namespace WebDemo.Web.WebDemo.FreezeDayDosage
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
			if(this.txtFreezeDate.Text.Trim().Length==0)
			{
				strErr+="FreezeDate不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtUseNumber.Text))
			{
				strErr+="UseNumber格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDosageType.Text))
			{
				strErr+="DosageType格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtInsertDate.Text))
			{
				strErr+="InsertDate格式错误！\\n";	
			}
			if(this.txtBeginDate.Text.Trim().Length==0)
			{
				strErr+="BeginDate不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtBeginNumber.Text))
			{
				strErr+="BeginNumber格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtEndNumber.Text))
			{
				strErr+="EndNumber格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MeterID=int.Parse(this.txtMeterID.Text);
			string FreezeDate=this.txtFreezeDate.Text;
			decimal UseNumber=decimal.Parse(this.txtUseNumber.Text);
			int DosageType=int.Parse(this.txtDosageType.Text);
			DateTime InsertDate=DateTime.Parse(this.txtInsertDate.Text);
			string BeginDate=this.txtBeginDate.Text;
			decimal BeginNumber=decimal.Parse(this.txtBeginNumber.Text);
			decimal EndNumber=decimal.Parse(this.txtEndNumber.Text);

			WebDemo.Model.WebDemo.FreezeDayDosage model=new WebDemo.Model.WebDemo.FreezeDayDosage();
			model.MeterID=MeterID;
			model.FreezeDate=FreezeDate;
			model.UseNumber=UseNumber;
			model.DosageType=DosageType;
			model.InsertDate=InsertDate;
			model.BeginDate=BeginDate;
			model.BeginNumber=BeginNumber;
			model.EndNumber=EndNumber;

			WebDemo.BLL.WebDemo.FreezeDayDosage bll=new WebDemo.BLL.WebDemo.FreezeDayDosage();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
