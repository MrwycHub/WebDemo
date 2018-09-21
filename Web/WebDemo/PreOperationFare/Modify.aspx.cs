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
namespace WebDemo.Web.WebDemo.PreOperationFare
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				int OperID = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					OperID=(Convert.ToInt32(Request.Params["id0"]));
				}
				string FareTypeName = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					FareTypeName= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(OperID,FareTypeName);
			}
		}
			
	private void ShowInfo(int OperID,string FareTypeName)
	{
		WebDemo.BLL.WebDemo.PreOperationFare bll=new WebDemo.BLL.WebDemo.PreOperationFare();
		WebDemo.Model.WebDemo.PreOperationFare model=bll.GetModel(OperID,FareTypeName);
		this.lblOperID.Text=model.OperID.ToString();
		this.txtFareID.Text=model.FareID.ToString();
		this.lblFareTypeName.Text=model.FareTypeName;
		this.txtFarePrice.Text=model.FarePrice.ToString();
		this.txtFareMoney.Text=model.FareMoney.ToString();
		this.txtFareMoney1.Text=model.FareMoney1.ToString();
		this.txtFarePrice2.Text=model.FarePrice2.ToString();
		this.txtFareMoney2.Text=model.FareMoney2.ToString();
		this.txtFarePrice3.Text=model.FarePrice3.ToString();
		this.txtFareMoney3.Text=model.FareMoney3.ToString();
		this.txtTaxRate.Text=model.TaxRate.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtFareID.Text))
			{
				strErr+="FareID格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFarePrice.Text))
			{
				strErr+="单价格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFareMoney.Text))
			{
				strErr+="金额格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFareMoney1.Text))
			{
				strErr+="FareMoney1格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFarePrice2.Text))
			{
				strErr+="FarePrice2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFareMoney2.Text))
			{
				strErr+="FareMoney2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFarePrice3.Text))
			{
				strErr+="FarePrice3格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFareMoney3.Text))
			{
				strErr+="FareMoney3格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTaxRate.Text))
			{
				strErr+="TaxRate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int OperID=int.Parse(this.lblOperID.Text);
			int FareID=int.Parse(this.txtFareID.Text);
			string FareTypeName=this.lblFareTypeName.Text;
			decimal FarePrice=decimal.Parse(this.txtFarePrice.Text);
			decimal FareMoney=decimal.Parse(this.txtFareMoney.Text);
			decimal FareMoney1=decimal.Parse(this.txtFareMoney1.Text);
			decimal FarePrice2=decimal.Parse(this.txtFarePrice2.Text);
			decimal FareMoney2=decimal.Parse(this.txtFareMoney2.Text);
			decimal FarePrice3=decimal.Parse(this.txtFarePrice3.Text);
			decimal FareMoney3=decimal.Parse(this.txtFareMoney3.Text);
			decimal TaxRate=decimal.Parse(this.txtTaxRate.Text);


			WebDemo.Model.WebDemo.PreOperationFare model=new WebDemo.Model.WebDemo.PreOperationFare();
			model.OperID=OperID;
			model.FareID=FareID;
			model.FareTypeName=FareTypeName;
			model.FarePrice=FarePrice;
			model.FareMoney=FareMoney;
			model.FareMoney1=FareMoney1;
			model.FarePrice2=FarePrice2;
			model.FareMoney2=FareMoney2;
			model.FarePrice3=FarePrice3;
			model.FareMoney3=FareMoney3;
			model.TaxRate=TaxRate;

			WebDemo.BLL.WebDemo.PreOperationFare bll=new WebDemo.BLL.WebDemo.PreOperationFare();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
