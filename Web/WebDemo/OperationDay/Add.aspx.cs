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
namespace WebDemo.Web.WebDemo.OperationDay
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMeterID.Text))
			{
				strErr+="MeterID格式错误！\\n";	
			}
			if(this.txtBeginMonth.Text.Trim().Length==0)
			{
				strErr+="BeginMonth不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtBeginNumber.Text))
			{
				strErr+="BeginNumber格式错误！\\n";	
			}
			if(this.txtEndMonth.Text.Trim().Length==0)
			{
				strErr+="EndMonth不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtEndNumber.Text))
			{
				strErr+="EndNumber格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtUseNumber.Text))
			{
				strErr+="UseNumber格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPriceTypeID.Text))
			{
				strErr+="PriceTypeID格式错误！\\n";	
			}
			if(this.txtPriceTypeName.Text.Trim().Length==0)
			{
				strErr+="PriceTypeName不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice.Text))
			{
				strErr+="Price格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice2.Text))
			{
				strErr+="Price2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice3.Text))
			{
				strErr+="Price3格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFareMoney.Text))
			{
				strErr+="FareMoney格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayMark.Text))
			{
				strErr+="PayMark格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperType.Text))
			{
				strErr+="OperType格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperDate.Text))
			{
				strErr+="业务时间格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(this.txtopermonth.Text.Trim().Length==0)
			{
				strErr+="opermonth不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMeterNumber.Text))
			{
				strErr+="MeterNumber格式错误！\\n";	
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
			int MeterID=int.Parse(this.txtMeterID.Text);
			string BeginMonth=this.txtBeginMonth.Text;
			decimal BeginNumber=decimal.Parse(this.txtBeginNumber.Text);
			string EndMonth=this.txtEndMonth.Text;
			decimal EndNumber=decimal.Parse(this.txtEndNumber.Text);
			decimal UseNumber=decimal.Parse(this.txtUseNumber.Text);
			int PriceTypeID=int.Parse(this.txtPriceTypeID.Text);
			string PriceTypeName=this.txtPriceTypeName.Text;
			decimal Price=decimal.Parse(this.txtPrice.Text);
			decimal Price2=decimal.Parse(this.txtPrice2.Text);
			decimal Price3=decimal.Parse(this.txtPrice3.Text);
			decimal FareMoney=decimal.Parse(this.txtFareMoney.Text);
			int PayMark=int.Parse(this.txtPayMark.Text);
			int OperType=int.Parse(this.txtOperType.Text);
			DateTime OperDate=DateTime.Parse(this.txtOperDate.Text);
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			string opermonth=this.txtopermonth.Text;
			decimal MeterNumber=decimal.Parse(this.txtMeterNumber.Text);
			int Divid1=int.Parse(this.txtDivid1.Text);
			int Divid2=int.Parse(this.txtDivid2.Text);
			decimal UseNumber1=decimal.Parse(this.txtUseNumber1.Text);
			decimal UseNumber2=decimal.Parse(this.txtUseNumber2.Text);
			decimal UseNumber3=decimal.Parse(this.txtUseNumber3.Text);
			string ExtData1=this.txtExtData1.Text;
			string ExtData2=this.txtExtData2.Text;

			WebDemo.Model.WebDemo.OperationDay model=new WebDemo.Model.WebDemo.OperationDay();
			model.MeterID=MeterID;
			model.BeginMonth=BeginMonth;
			model.BeginNumber=BeginNumber;
			model.EndMonth=EndMonth;
			model.EndNumber=EndNumber;
			model.UseNumber=UseNumber;
			model.PriceTypeID=PriceTypeID;
			model.PriceTypeName=PriceTypeName;
			model.Price=Price;
			model.Price2=Price2;
			model.Price3=Price3;
			model.FareMoney=FareMoney;
			model.PayMark=PayMark;
			model.OperType=OperType;
			model.OperDate=OperDate;
			model.OperatorID=OperatorID;
			model.opermonth=opermonth;
			model.MeterNumber=MeterNumber;
			model.Divid1=Divid1;
			model.Divid2=Divid2;
			model.UseNumber1=UseNumber1;
			model.UseNumber2=UseNumber2;
			model.UseNumber3=UseNumber3;
			model.ExtData1=ExtData1;
			model.ExtData2=ExtData2;

			WebDemo.BLL.WebDemo.OperationDay bll=new WebDemo.BLL.WebDemo.OperationDay();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
