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
namespace WebDemo.Web.WebDemo.UpConsume
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int UpId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(UpId);
				}
			}
		}
			
	private void ShowInfo(int UpId)
	{
		WebDemo.BLL.WebDemo.UpConsume bll=new WebDemo.BLL.WebDemo.UpConsume();
		WebDemo.Model.WebDemo.UpConsume model=bll.GetModel(UpId);
		this.lblUpId.Text=model.UpId.ToString();
		this.txtCardId.Text=model.CardId.ToString();
		this.txtLostFreeNum.Text=model.LostFreeNum.ToString();
		this.txtSurplusMoney.Text=model.SurplusMoney.ToString();
		this.txtConsumeTime.Text=model.ConsumeTime.ToString();
		this.txtMeterid.Text=model.Meterid.ToString();
		this.txtUseMoney.Text=model.UseMoney.ToString();
		this.txtInsDate.Text=model.InsDate.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtCardId.Text))
			{
				strErr+="CardId格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLostFreeNum.Text))
			{
				strErr+="LostFreeNum格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtSurplusMoney.Text))
			{
				strErr+="SurplusMoney格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtConsumeTime.Text))
			{
				strErr+="ConsumeTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterid.Text))
			{
				strErr+="Meterid格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtUseMoney.Text))
			{
				strErr+="UseMoney格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtInsDate.Text))
			{
				strErr+="InsDate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int UpId=int.Parse(this.lblUpId.Text);
			int CardId=int.Parse(this.txtCardId.Text);
			decimal LostFreeNum=decimal.Parse(this.txtLostFreeNum.Text);
			decimal SurplusMoney=decimal.Parse(this.txtSurplusMoney.Text);
			DateTime ConsumeTime=DateTime.Parse(this.txtConsumeTime.Text);
			int Meterid=int.Parse(this.txtMeterid.Text);
			decimal UseMoney=decimal.Parse(this.txtUseMoney.Text);
			DateTime InsDate=DateTime.Parse(this.txtInsDate.Text);


			WebDemo.Model.WebDemo.UpConsume model=new WebDemo.Model.WebDemo.UpConsume();
			model.UpId=UpId;
			model.CardId=CardId;
			model.LostFreeNum=LostFreeNum;
			model.SurplusMoney=SurplusMoney;
			model.ConsumeTime=ConsumeTime;
			model.Meterid=Meterid;
			model.UseMoney=UseMoney;
			model.InsDate=InsDate;

			WebDemo.BLL.WebDemo.UpConsume bll=new WebDemo.BLL.WebDemo.UpConsume();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
