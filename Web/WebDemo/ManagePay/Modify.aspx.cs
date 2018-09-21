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
namespace WebDemo.Web.WebDemo.ManagePay
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int OperID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(OperID);
				}
			}
		}
			
	private void ShowInfo(int OperID)
	{
		WebDemo.BLL.WebDemo.ManagePay bll=new WebDemo.BLL.WebDemo.ManagePay();
		WebDemo.Model.WebDemo.ManagePay model=bll.GetModel(OperID);
		this.lblOperID.Text=model.OperID.ToString();
		this.txtUsersID.Text=model.UsersID.ToString();
		this.txtOperMoney.Text=model.OperMoney.ToString();
		this.txtOperatorID.Text=model.OperatorID.ToString();
		this.txtOperDate.Text=model.OperDate.ToString();
		this.txtPayType.Text=model.PayType.ToString();
		this.txtFlag.Text=model.Flag.ToString();
		this.txtThisReserve.Text=model.ThisReserve.ToString();
		this.txtLastReserve.Text=model.LastReserve.ToString();
		this.txtRedOperId.Text=model.RedOperId.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUsersID.Text))
			{
				strErr+="UsersID格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtOperMoney.Text))
			{
				strErr+="OperMoney格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperDate.Text))
			{
				strErr+="OperDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayType.Text))
			{
				strErr+="PayType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFlag.Text))
			{
				strErr+="Flag格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtThisReserve.Text))
			{
				strErr+="ThisReserve格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLastReserve.Text))
			{
				strErr+="LastReserve格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtRedOperId.Text))
			{
				strErr+="RedOperId格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int OperID=int.Parse(this.lblOperID.Text);
			int UsersID=int.Parse(this.txtUsersID.Text);
			decimal OperMoney=decimal.Parse(this.txtOperMoney.Text);
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			DateTime OperDate=DateTime.Parse(this.txtOperDate.Text);
			int PayType=int.Parse(this.txtPayType.Text);
			int Flag=int.Parse(this.txtFlag.Text);
			decimal ThisReserve=decimal.Parse(this.txtThisReserve.Text);
			decimal LastReserve=decimal.Parse(this.txtLastReserve.Text);
			int RedOperId=int.Parse(this.txtRedOperId.Text);


			WebDemo.Model.WebDemo.ManagePay model=new WebDemo.Model.WebDemo.ManagePay();
			model.OperID=OperID;
			model.UsersID=UsersID;
			model.OperMoney=OperMoney;
			model.OperatorID=OperatorID;
			model.OperDate=OperDate;
			model.PayType=PayType;
			model.Flag=Flag;
			model.ThisReserve=ThisReserve;
			model.LastReserve=LastReserve;
			model.RedOperId=RedOperId;

			WebDemo.BLL.WebDemo.ManagePay bll=new WebDemo.BLL.WebDemo.ManagePay();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
