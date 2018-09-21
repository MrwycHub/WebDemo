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
namespace WebDemo.Web.WebDemo.OperationFareDay
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtOperID.Text))
			{
				strErr+="OperID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFareID.Text))
			{
				strErr+="FareID格式错误！\\n";	
			}
			if(this.txtFareTypeName.Text.Trim().Length==0)
			{
				strErr+="FareTypeName不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFarePrice.Text))
			{
				strErr+="FarePrice格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFareMoney.Text))
			{
				strErr+="FareMoney格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFarePrice2.Text))
			{
				strErr+="FarePrice2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFarePrice3.Text))
			{
				strErr+="FarePrice3格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDivid1.Text))
			{
				strErr+="Divid1格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDivid2.Text))
			{
				strErr+="Divid2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtUseNumber1.Text))
			{
				strErr+="UseNumber1格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtUseNumber2.Text))
			{
				strErr+="UseNumber2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtUseNumber3.Text))
			{
				strErr+="UseNumber3格式错误！\\n";	
			}
			if(this.txtExtData1.Text.Trim().Length==0)
			{
				strErr+="ExtData1不能为空！\\n";	
			}
			if(this.txtExtData2.Text.Trim().Length==0)
			{
				strErr+="ExtData2不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int OperID=int.Parse(this.txtOperID.Text);
			int FareID=int.Parse(this.txtFareID.Text);
			string FareTypeName=this.txtFareTypeName.Text;
			decimal FarePrice=decimal.Parse(this.txtFarePrice.Text);
			decimal FareMoney=decimal.Parse(this.txtFareMoney.Text);
			decimal FarePrice2=decimal.Parse(this.txtFarePrice2.Text);
			decimal FarePrice3=decimal.Parse(this.txtFarePrice3.Text);
			int Divid1=int.Parse(this.txtDivid1.Text);
			int Divid2=int.Parse(this.txtDivid2.Text);
			decimal UseNumber1=decimal.Parse(this.txtUseNumber1.Text);
			decimal UseNumber2=decimal.Parse(this.txtUseNumber2.Text);
			decimal UseNumber3=decimal.Parse(this.txtUseNumber3.Text);
			string ExtData1=this.txtExtData1.Text;
			string ExtData2=this.txtExtData2.Text;

			WebDemo.Model.WebDemo.OperationFareDay model=new WebDemo.Model.WebDemo.OperationFareDay();
			model.OperID=OperID;
			model.FareID=FareID;
			model.FareTypeName=FareTypeName;
			model.FarePrice=FarePrice;
			model.FareMoney=FareMoney;
			model.FarePrice2=FarePrice2;
			model.FarePrice3=FarePrice3;
			model.Divid1=Divid1;
			model.Divid2=Divid2;
			model.UseNumber1=UseNumber1;
			model.UseNumber2=UseNumber2;
			model.UseNumber3=UseNumber3;
			model.ExtData1=ExtData1;
			model.ExtData2=ExtData2;

			WebDemo.BLL.WebDemo.OperationFareDay bll=new WebDemo.BLL.WebDemo.OperationFareDay();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
