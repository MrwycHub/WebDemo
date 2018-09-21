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
namespace WebDemo.Web.WebDemo.BlanceAccount
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		WebDemo.BLL.WebDemo.BlanceAccount bll=new WebDemo.BLL.WebDemo.BlanceAccount();
		WebDemo.Model.WebDemo.BlanceAccount model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtBlanceDate.Text=model.BlanceDate;
		this.txtFailUserCode.Text=model.FailUserCode;
		this.txtFail.Text=model.Fail.ToString();
		this.txtAllCount.Text=model.AllCount.ToString();
		this.txtAllMoney.Text=model.AllMoney.ToString();
		this.txtRefundMoney.Text=model.RefundMoney.ToString();
		this.txtBlanceTime.Text=model.BlanceTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtBlanceDate.Text.Trim().Length==0)
			{
				strErr+="BlanceDate不能为空！\\n";	
			}
			if(this.txtFailUserCode.Text.Trim().Length==0)
			{
				strErr+="FailUserCode不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFail.Text))
			{
				strErr+="Fail格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtAllCount.Text))
			{
				strErr+="AllCount格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtAllMoney.Text))
			{
				strErr+="AllMoney格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtRefundMoney.Text))
			{
				strErr+="RefundMoney格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBlanceTime.Text))
			{
				strErr+="BlanceTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string BlanceDate=this.txtBlanceDate.Text;
			string FailUserCode=this.txtFailUserCode.Text;
			int Fail=int.Parse(this.txtFail.Text);
			int AllCount=int.Parse(this.txtAllCount.Text);
			decimal AllMoney=decimal.Parse(this.txtAllMoney.Text);
			decimal RefundMoney=decimal.Parse(this.txtRefundMoney.Text);
			DateTime BlanceTime=DateTime.Parse(this.txtBlanceTime.Text);


			WebDemo.Model.WebDemo.BlanceAccount model=new WebDemo.Model.WebDemo.BlanceAccount();
			model.ID=ID;
			model.BlanceDate=BlanceDate;
			model.FailUserCode=FailUserCode;
			model.Fail=Fail;
			model.AllCount=AllCount;
			model.AllMoney=AllMoney;
			model.RefundMoney=RefundMoney;
			model.BlanceTime=BlanceTime;

			WebDemo.BLL.WebDemo.BlanceAccount bll=new WebDemo.BLL.WebDemo.BlanceAccount();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
