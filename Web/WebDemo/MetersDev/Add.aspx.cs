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
namespace WebDemo.Web.WebDemo.MetersDev
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
			if(!PageValidate.IsDateTime(txtDisenableDate.Text))
			{
				strErr+="DisenableDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSiteDir.Text))
			{
				strErr+="SiteDir格式错误！\\n";	
			}
			if(this.txtInsureCode.Text.Trim().Length==0)
			{
				strErr+="InsureCode不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtInsureDate.Text))
			{
				strErr+="InsureDate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtInsureEndDate.Text))
			{
				strErr+="InsureEndDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtGasDir.Text))
			{
				strErr+="GasDir格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtInstallPos.Text))
			{
				strErr+="InstallPos格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtInstallWorkerID.Text))
			{
				strErr+="InstallWorkerID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtInstallDate.Text))
			{
				strErr+="InstallDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFireWorkerID.Text))
			{
				strErr+="FireWorkerID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtFireDate.Text))
			{
				strErr+="FireDate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtFirstCheckDate.Text))
			{
				strErr+="FirstCheckDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFirstCheckMark.Text))
			{
				strErr+="FirstCheckMark格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCheckCyc.Text))
			{
				strErr+="CheckCyc格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtBoilerFlag.Text))
			{
				strErr+="BoilerFlag格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSelfFlag.Text))
			{
				strErr+="SelfFlag格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtBookID.Text))
			{
				strErr+="BookID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtInstallID.Text))
			{
				strErr+="InstallID格式错误！\\n";	
			}
			if(this.txtFirstCheckInfo.Text.Trim().Length==0)
			{
				strErr+="FirstCheckInfo不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFirstCheckWorkerID.Text))
			{
				strErr+="FirstCheckWorkerID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCurrValveState.Text))
			{
				strErr+="CurrValveState格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MeterID=int.Parse(this.txtMeterID.Text);
			DateTime DisenableDate=DateTime.Parse(this.txtDisenableDate.Text);
			int SiteDir=int.Parse(this.txtSiteDir.Text);
			string InsureCode=this.txtInsureCode.Text;
			DateTime InsureDate=DateTime.Parse(this.txtInsureDate.Text);
			DateTime InsureEndDate=DateTime.Parse(this.txtInsureEndDate.Text);
			int GasDir=int.Parse(this.txtGasDir.Text);
			int InstallPos=int.Parse(this.txtInstallPos.Text);
			int InstallWorkerID=int.Parse(this.txtInstallWorkerID.Text);
			DateTime InstallDate=DateTime.Parse(this.txtInstallDate.Text);
			int FireWorkerID=int.Parse(this.txtFireWorkerID.Text);
			DateTime FireDate=DateTime.Parse(this.txtFireDate.Text);
			DateTime FirstCheckDate=DateTime.Parse(this.txtFirstCheckDate.Text);
			int FirstCheckMark=int.Parse(this.txtFirstCheckMark.Text);
			int CheckCyc=int.Parse(this.txtCheckCyc.Text);
			int BoilerFlag=int.Parse(this.txtBoilerFlag.Text);
			int SelfFlag=int.Parse(this.txtSelfFlag.Text);
			int BookID=int.Parse(this.txtBookID.Text);
			int InstallID=int.Parse(this.txtInstallID.Text);
			string FirstCheckInfo=this.txtFirstCheckInfo.Text;
			int FirstCheckWorkerID=int.Parse(this.txtFirstCheckWorkerID.Text);
			int CurrValveState=int.Parse(this.txtCurrValveState.Text);

			WebDemo.Model.WebDemo.MetersDev model=new WebDemo.Model.WebDemo.MetersDev();
			model.MeterID=MeterID;
			model.DisenableDate=DisenableDate;
			model.SiteDir=SiteDir;
			model.InsureCode=InsureCode;
			model.InsureDate=InsureDate;
			model.InsureEndDate=InsureEndDate;
			model.GasDir=GasDir;
			model.InstallPos=InstallPos;
			model.InstallWorkerID=InstallWorkerID;
			model.InstallDate=InstallDate;
			model.FireWorkerID=FireWorkerID;
			model.FireDate=FireDate;
			model.FirstCheckDate=FirstCheckDate;
			model.FirstCheckMark=FirstCheckMark;
			model.CheckCyc=CheckCyc;
			model.BoilerFlag=BoilerFlag;
			model.SelfFlag=SelfFlag;
			model.BookID=BookID;
			model.InstallID=InstallID;
			model.FirstCheckInfo=FirstCheckInfo;
			model.FirstCheckWorkerID=FirstCheckWorkerID;
			model.CurrValveState=CurrValveState;

			WebDemo.BLL.WebDemo.MetersDev bll=new WebDemo.BLL.WebDemo.MetersDev();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
