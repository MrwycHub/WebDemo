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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtPriceTypeID.Text))
			{
				strErr+="PriceTypeID格式错误！\\n";	
			}
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
			int PriceTypeID=int.Parse(this.txtPriceTypeID.Text);
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
