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
namespace WebDemo.Web.WebDemo.RatePeriod
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtSuiteNo.Text))
			{
				strErr+="SuiteNo格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtGroupPeriodNo.Text))
			{
				strErr+="GroupPeriodNo格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPeriodNo.Text))
			{
				strErr+="PeriodNo格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBeginTime.Text))
			{
				strErr+="BeginTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFareRateNo.Text))
			{
				strErr+="FareRateNo格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int SuiteNo=int.Parse(this.txtSuiteNo.Text);
			int GroupPeriodNo=int.Parse(this.txtGroupPeriodNo.Text);
			int PeriodNo=int.Parse(this.txtPeriodNo.Text);
			DateTime BeginTime=DateTime.Parse(this.txtBeginTime.Text);
			int FareRateNo=int.Parse(this.txtFareRateNo.Text);

			WebDemo.Model.WebDemo.RatePeriod model=new WebDemo.Model.WebDemo.RatePeriod();
			model.SuiteNo=SuiteNo;
			model.GroupPeriodNo=GroupPeriodNo;
			model.PeriodNo=PeriodNo;
			model.BeginTime=BeginTime;
			model.FareRateNo=FareRateNo;

			WebDemo.BLL.WebDemo.RatePeriod bll=new WebDemo.BLL.WebDemo.RatePeriod();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
