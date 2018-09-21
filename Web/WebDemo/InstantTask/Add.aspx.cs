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
namespace WebDemo.Web.WebDemo.InstantTask
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtTaskID.Text))
			{
				strErr+="TaskID格式错误！\\n";	
			}
			if(this.txtTaskType.Text.Trim().Length==0)
			{
				strErr+="TaskType不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtCollectorID.Text))
			{
				strErr+="CollectorID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterType.Text))
			{
				strErr+="MeterType格式错误！\\n";	
			}
			if(this.txtMeterAddr.Text.Trim().Length==0)
			{
				strErr+="MeterAddr不能为空！\\n";	
			}
			if(this.txtHostAddr.Text.Trim().Length==0)
			{
				strErr+="HostAddr不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterStatus.Text))
			{
				strErr+="MeterStatus格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterData.Text))
			{
				strErr+="MeterData格式错误！\\n";	
			}
			if(this.txtPayMoney.Text.Trim().Length==0)
			{
				strErr+="本次购买量不能为空！\\n";	
			}
			if(this.txtTotalPayMoney.Text.Trim().Length==0)
			{
				strErr+="总量不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int TaskID=int.Parse(this.txtTaskID.Text);
			string TaskType=this.txtTaskType.Text;
			int CollectorID=int.Parse(this.txtCollectorID.Text);
			int MeterType=int.Parse(this.txtMeterType.Text);
			string MeterAddr=this.txtMeterAddr.Text;
			string HostAddr=this.txtHostAddr.Text;
			int MeterStatus=int.Parse(this.txtMeterStatus.Text);
			int MeterData=int.Parse(this.txtMeterData.Text);
			string PayMoney=this.txtPayMoney.Text;
			string TotalPayMoney=this.txtTotalPayMoney.Text;

			WebDemo.Model.WebDemo.InstantTask model=new WebDemo.Model.WebDemo.InstantTask();
			model.TaskID=TaskID;
			model.TaskType=TaskType;
			model.CollectorID=CollectorID;
			model.MeterType=MeterType;
			model.MeterAddr=MeterAddr;
			model.HostAddr=HostAddr;
			model.MeterStatus=MeterStatus;
			model.MeterData=MeterData;
			model.PayMoney=PayMoney;
			model.TotalPayMoney=TotalPayMoney;

			WebDemo.BLL.WebDemo.InstantTask bll=new WebDemo.BLL.WebDemo.InstantTask();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
