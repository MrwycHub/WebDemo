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
namespace WebDemo.Web.WebDemo.RateTimeZone
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
			if(!PageValidate.IsNumber(txtTimeZoneNo.Text))
			{
				strErr+="TimeZoneNo格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBeginDate.Text))
			{
				strErr+="BeginDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtGroupPeriodNo.Text))
			{
				strErr+="GroupPeriodNo格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int SuiteNo=int.Parse(this.txtSuiteNo.Text);
			int TimeZoneNo=int.Parse(this.txtTimeZoneNo.Text);
			DateTime BeginDate=DateTime.Parse(this.txtBeginDate.Text);
			int GroupPeriodNo=int.Parse(this.txtGroupPeriodNo.Text);

			WebDemo.Model.WebDemo.RateTimeZone model=new WebDemo.Model.WebDemo.RateTimeZone();
			model.SuiteNo=SuiteNo;
			model.TimeZoneNo=TimeZoneNo;
			model.BeginDate=BeginDate;
			model.GroupPeriodNo=GroupPeriodNo;

			WebDemo.BLL.WebDemo.RateTimeZone bll=new WebDemo.BLL.WebDemo.RateTimeZone();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
