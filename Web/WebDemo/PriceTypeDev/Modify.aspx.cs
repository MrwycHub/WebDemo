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
namespace WebDemo.Web.WebDemo.PriceTypeDev
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int PriceTypeID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(PriceTypeID);
				}
			}
		}
			
	private void ShowInfo(int PriceTypeID)
	{
		WebDemo.BLL.WebDemo.PriceTypeDev bll=new WebDemo.BLL.WebDemo.PriceTypeDev();
		WebDemo.Model.WebDemo.PriceTypeDev model=bll.GetModel(PriceTypeID);
		this.lblPriceTypeID.Text=model.PriceTypeID.ToString();
		this.txtLateFeeRate.Text=model.LateFeeRate.ToString();
		this.txtLateFeeDate.Text=model.LateFeeDate.ToString();
		this.txtLateFeeBase.Text=model.LateFeeBase.ToString();
		this.txtICMonth.Text=model.ICMonth.ToString();
		this.txtICMaxBuy.Text=model.ICMaxBuy.ToString();
		this.txtICAmount.Text=model.ICAmount.ToString();
		this.txtICMonthBuy.Text=model.ICMonthBuy.ToString();
		this.txtICDayAvg.Text=model.ICDayAvg.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDecimal(txtLateFeeRate.Text))
			{
				strErr+="LateFeeRate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtLateFeeDate.Text))
			{
				strErr+="LateFeeDate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLateFeeBase.Text))
			{
				strErr+="LateFeeBase格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtICMonth.Text))
			{
				strErr+="ICMonth格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtICMaxBuy.Text))
			{
				strErr+="ICMaxBuy格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtICAmount.Text))
			{
				strErr+="ICAmount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtICMonthBuy.Text))
			{
				strErr+="ICMonthBuy格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtICDayAvg.Text))
			{
				strErr+="ICDayAvg格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int PriceTypeID=int.Parse(this.lblPriceTypeID.Text);
			decimal LateFeeRate=decimal.Parse(this.txtLateFeeRate.Text);
			int LateFeeDate=int.Parse(this.txtLateFeeDate.Text);
			decimal LateFeeBase=decimal.Parse(this.txtLateFeeBase.Text);
			int ICMonth=int.Parse(this.txtICMonth.Text);
			int ICMaxBuy=int.Parse(this.txtICMaxBuy.Text);
			int ICAmount=int.Parse(this.txtICAmount.Text);
			int ICMonthBuy=int.Parse(this.txtICMonthBuy.Text);
			int ICDayAvg=int.Parse(this.txtICDayAvg.Text);


			WebDemo.Model.WebDemo.PriceTypeDev model=new WebDemo.Model.WebDemo.PriceTypeDev();
			model.PriceTypeID=PriceTypeID;
			model.LateFeeRate=LateFeeRate;
			model.LateFeeDate=LateFeeDate;
			model.LateFeeBase=LateFeeBase;
			model.ICMonth=ICMonth;
			model.ICMaxBuy=ICMaxBuy;
			model.ICAmount=ICAmount;
			model.ICMonthBuy=ICMonthBuy;
			model.ICDayAvg=ICDayAvg;

			WebDemo.BLL.WebDemo.PriceTypeDev bll=new WebDemo.BLL.WebDemo.PriceTypeDev();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
