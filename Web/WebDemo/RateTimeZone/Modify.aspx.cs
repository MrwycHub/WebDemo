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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				int SuiteNo = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					SuiteNo=(Convert.ToInt32(Request.Params["id0"]));
				}
				int TimeZoneNo = -1;
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					TimeZoneNo=(Convert.ToInt32(Request.Params["id1"]));
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(SuiteNo,TimeZoneNo);
			}
		}
			
	private void ShowInfo(int SuiteNo,int TimeZoneNo)
	{
		WebDemo.BLL.WebDemo.RateTimeZone bll=new WebDemo.BLL.WebDemo.RateTimeZone();
		WebDemo.Model.WebDemo.RateTimeZone model=bll.GetModel(SuiteNo,TimeZoneNo);
		this.lblSuiteNo.Text=model.SuiteNo.ToString();
		this.lblTimeZoneNo.Text=model.TimeZoneNo.ToString();
		this.txtBeginDate.Text=model.BeginDate.ToString();
		this.txtGroupPeriodNo.Text=model.GroupPeriodNo.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
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
			int SuiteNo=int.Parse(this.lblSuiteNo.Text);
			int TimeZoneNo=int.Parse(this.lblTimeZoneNo.Text);
			DateTime BeginDate=DateTime.Parse(this.txtBeginDate.Text);
			int GroupPeriodNo=int.Parse(this.txtGroupPeriodNo.Text);


			WebDemo.Model.WebDemo.RateTimeZone model=new WebDemo.Model.WebDemo.RateTimeZone();
			model.SuiteNo=SuiteNo;
			model.TimeZoneNo=TimeZoneNo;
			model.BeginDate=BeginDate;
			model.GroupPeriodNo=GroupPeriodNo;

			WebDemo.BLL.WebDemo.RateTimeZone bll=new WebDemo.BLL.WebDemo.RateTimeZone();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
