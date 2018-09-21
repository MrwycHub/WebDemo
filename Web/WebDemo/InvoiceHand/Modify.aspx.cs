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
namespace WebDemo.Web.WebDemo.InvoiceHand
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
		WebDemo.BLL.WebDemo.InvoiceHand bll=new WebDemo.BLL.WebDemo.InvoiceHand();
		WebDemo.Model.WebDemo.InvoiceHand model=bll.GetModel(OperID);
		this.lblOperID.Text=model.OperID.ToString();
		this.txtspName.Text=model.spName;
		this.txtspUnit.Text=model.spUnit;
		this.txtspNum.Text=model.spNum.ToString();
		this.txtspPrice.Text=model.spPrice.ToString();
		this.txtspMoney.Text=model.spMoney.ToString();
		this.txtRemark.Text=model.Remark;
		this.txtInID.Text=model.InID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtspName.Text.Trim().Length==0)
			{
				strErr+="spName不能为空！\\n";	
			}
			if(this.txtspUnit.Text.Trim().Length==0)
			{
				strErr+="spUnit不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtspNum.Text))
			{
				strErr+="spNum格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtspPrice.Text))
			{
				strErr+="spPrice格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtspMoney.Text))
			{
				strErr+="spMoney格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtInID.Text))
			{
				strErr+="InID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int OperID=int.Parse(this.lblOperID.Text);
			string spName=this.txtspName.Text;
			string spUnit=this.txtspUnit.Text;
			decimal spNum=decimal.Parse(this.txtspNum.Text);
			decimal spPrice=decimal.Parse(this.txtspPrice.Text);
			decimal spMoney=decimal.Parse(this.txtspMoney.Text);
			string Remark=this.txtRemark.Text;
			int InID=int.Parse(this.txtInID.Text);


			WebDemo.Model.WebDemo.InvoiceHand model=new WebDemo.Model.WebDemo.InvoiceHand();
			model.OperID=OperID;
			model.spName=spName;
			model.spUnit=spUnit;
			model.spNum=spNum;
			model.spPrice=spPrice;
			model.spMoney=spMoney;
			model.Remark=Remark;
			model.InID=InID;

			WebDemo.BLL.WebDemo.InvoiceHand bll=new WebDemo.BLL.WebDemo.InvoiceHand();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
