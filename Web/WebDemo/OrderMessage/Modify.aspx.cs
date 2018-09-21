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
namespace WebDemo.Web.WebDemo.OrderMessage
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
		WebDemo.BLL.WebDemo.OrderMessage bll=new WebDemo.BLL.WebDemo.OrderMessage();
		WebDemo.Model.WebDemo.OrderMessage model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtout_trade_no.Text=model.out_trade_no;
		this.txtTransactionId.Text=model.TransactionId;
		this.txttotal_amount.Text=model.total_amount.ToString();
		this.txtStatus.Text=model.Status.ToString();
		this.txtCreateDate.Text=model.CreateDate.ToString();
		this.txtFinishDate.Text=model.FinishDate.ToString();
		this.txtPayWay.Text=model.PayWay.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtout_trade_no.Text.Trim().Length==0)
			{
				strErr+="out_trade_no不能为空！\\n";	
			}
			if(this.txtTransactionId.Text.Trim().Length==0)
			{
				strErr+="TransactionId不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txttotal_amount.Text))
			{
				strErr+="total_amount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtStatus.Text))
			{
				strErr+="Status格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreateDate.Text))
			{
				strErr+="CreateDate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtFinishDate.Text))
			{
				strErr+="FinishDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayWay.Text))
			{
				strErr+="PayWay格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string out_trade_no=this.txtout_trade_no.Text;
			string TransactionId=this.txtTransactionId.Text;
			decimal total_amount=decimal.Parse(this.txttotal_amount.Text);
			int Status=int.Parse(this.txtStatus.Text);
			DateTime CreateDate=DateTime.Parse(this.txtCreateDate.Text);
			DateTime FinishDate=DateTime.Parse(this.txtFinishDate.Text);
			int PayWay=int.Parse(this.txtPayWay.Text);


			WebDemo.Model.WebDemo.OrderMessage model=new WebDemo.Model.WebDemo.OrderMessage();
			model.ID=ID;
			model.out_trade_no=out_trade_no;
			model.TransactionId=TransactionId;
			model.total_amount=total_amount;
			model.Status=Status;
			model.CreateDate=CreateDate;
			model.FinishDate=FinishDate;
			model.PayWay=PayWay;

			WebDemo.BLL.WebDemo.OrderMessage bll=new WebDemo.BLL.WebDemo.OrderMessage();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
