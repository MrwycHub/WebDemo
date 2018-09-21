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
namespace WebDemo.Web.WebDemo.RatePrice
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtGroupPriceNo.Text))
			{
				strErr+="GroupPriceNo格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFareRateNo.Text))
			{
				strErr+="FareRateNo格式错误！\\n";	
			}
			if(this.txtFareName.Text.Trim().Length==0)
			{
				strErr+="FareName不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice.Text))
			{
				strErr+="Price格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int GroupPriceNo=int.Parse(this.txtGroupPriceNo.Text);
			int FareRateNo=int.Parse(this.txtFareRateNo.Text);
			string FareName=this.txtFareName.Text;
			decimal Price=decimal.Parse(this.txtPrice.Text);

			WebDemo.Model.WebDemo.RatePrice model=new WebDemo.Model.WebDemo.RatePrice();
			model.GroupPriceNo=GroupPriceNo;
			model.FareRateNo=FareRateNo;
			model.FareName=FareName;
			model.Price=Price;

			WebDemo.BLL.WebDemo.RatePrice bll=new WebDemo.BLL.WebDemo.RatePrice();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
