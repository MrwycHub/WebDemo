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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		WebDemo.BLL.WebDemo.FreezeMonthDosage bll=new WebDemo.BLL.WebDemo.FreezeMonthDosage();
		WebDemo.Model.WebDemo.FreezeMonthDosage model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.txtBeginMonth.Text=model.BeginMonth;
		this.txtBeginNumber.Text=model.BeginNumber.ToString();
		this.lblFreezeMonth.Text=model.FreezeMonth;
		this.txtEndNumber.Text=model.EndNumber.ToString();
		this.txtUseNumber.Text=model.UseNumber.ToString();
		this.txtInsertDate.Text=model.InsertDate.ToString();
		this.txtUseActiveSharp.Text=model.UseActiveSharp.ToString();
		this.txtUseActivePeak.Text=model.UseActivePeak.ToString();
		this.txtUseActiveShoulder.Text=model.UseActiveShoulder.ToString();
		this.txtUseActiveOffPeak.Text=model.UseActiveOffPeak.ToString();
		this.txtSyncFlag.Text=model.SyncFlag.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtBeginMonth.Text.Trim().Length==0)
			{
				strErr+="BeginMonth不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtBeginNumber.Text))
			{
				strErr+="BeginNumber格式错误！\\n";	
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
			int id=int.Parse(this.lblid.Text);
			int MeterID=int.Parse(this.lblMeterID.Text);
			string BeginMonth=this.txtBeginMonth.Text;
			decimal BeginNumber=decimal.Parse(this.txtBeginNumber.Text);
			string FreezeMonth=this.lblFreezeMonth.Text;
			decimal EndNumber=decimal.Parse(this.txtEndNumber.Text);
			decimal UseNumber=decimal.Parse(this.txtUseNumber.Text);
			DateTime InsertDate=DateTime.Parse(this.txtInsertDate.Text);
			decimal UseActiveSharp=decimal.Parse(this.txtUseActiveSharp.Text);
			decimal UseActivePeak=decimal.Parse(this.txtUseActivePeak.Text);
			decimal UseActiveShoulder=decimal.Parse(this.txtUseActiveShoulder.Text);
			decimal UseActiveOffPeak=decimal.Parse(this.txtUseActiveOffPeak.Text);
			int SyncFlag=int.Parse(this.txtSyncFlag.Text);


			WebDemo.Model.WebDemo.FreezeMonthDosage model=new WebDemo.Model.WebDemo.FreezeMonthDosage();
			model.id=id;
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
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
