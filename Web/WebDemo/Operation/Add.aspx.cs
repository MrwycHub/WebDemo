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
namespace WebDemo.Web.WebDemo.Operation
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
				strErr+="表编号格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayID.Text))
			{
				strErr+="缴费ID格式错误！\\n";	
			}
			if(this.txtBeginMonth.Text.Trim().Length==0)
			{
				strErr+="起始月份不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtBeginNumber.Text))
			{
				strErr+="起始读数格式错误！\\n";	
			}
			if(this.txtEndMonth.Text.Trim().Length==0)
			{
				strErr+="终止月份不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtEndNumber.Text))
			{
				strErr+="终止读数格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUseNumber.Text))
			{
				strErr+="周期用量格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPriceTypeID.Text))
			{
				strErr+="PriceTypeID格式错误！\\n";	
			}
			if(this.txtPriceTypeName.Text.Trim().Length==0)
			{
				strErr+="价格名称不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice.Text))
			{
				strErr+="单价格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice2.Text))
			{
				strErr+="单价格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice3.Text))
			{
				strErr+="单价格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFareMoney.Text))
			{
				strErr+="费用格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayMark.Text))
			{
				strErr+="缴费标志格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperType.Text))
			{
				strErr+="业务类型(1-抄表结算；2-换表结算格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperDate.Text))
			{
				strErr+="业务日期格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="操作员格式错误！\\n";	
			}
			if(this.txtopermonth.Text.Trim().Length==0)
			{
				strErr+="opermonth不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtTID.Text))
			{
				strErr+="TID格式错误！\\n";	
			}
			if(this.txtPriceUnit.Text.Trim().Length==0)
			{
				strErr+="PriceUnit不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtDerateid.Text))
			{
				strErr+="Derateid格式错误！\\n";	
			}
			if(this.txtFareName.Text.Trim().Length==0)
			{
				strErr+="FareName不能为空！\\n";	
			}
			if(this.txtOperationName.Text.Trim().Length==0)
			{
				strErr+="OperationName不能为空！\\n";	
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
			if(this.txtDerateReason.Text.Trim().Length==0)
			{
				strErr+="DerateReason不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtAdditionNum.Text))
			{
				strErr+="AdditionNum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFareID.Text))
			{
				strErr+="FareID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MeterID=int.Parse(this.txtMeterID.Text);
			int PayID=int.Parse(this.txtPayID.Text);
			string BeginMonth=this.txtBeginMonth.Text;
			int BeginNumber=int.Parse(this.txtBeginNumber.Text);
			string EndMonth=this.txtEndMonth.Text;
			int EndNumber=int.Parse(this.txtEndNumber.Text);
			int UseNumber=int.Parse(this.txtUseNumber.Text);
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
			int TID=int.Parse(this.txtTID.Text);
			string PriceUnit=this.txtPriceUnit.Text;
			int Derateid=int.Parse(this.txtDerateid.Text);
			string FareName=this.txtFareName.Text;
			string OperationName=this.txtOperationName.Text;
			int Divid1=int.Parse(this.txtDivid1.Text);
			int Divid2=int.Parse(this.txtDivid2.Text);
			decimal UseNumber1=decimal.Parse(this.txtUseNumber1.Text);
			decimal UseNumber2=decimal.Parse(this.txtUseNumber2.Text);
			decimal UseNumber3=decimal.Parse(this.txtUseNumber3.Text);
			string DerateReason=this.txtDerateReason.Text;
			decimal AdditionNum=decimal.Parse(this.txtAdditionNum.Text);
			int FareID=int.Parse(this.txtFareID.Text);

			WebDemo.Model.WebDemo.Operation model=new WebDemo.Model.WebDemo.Operation();
			model.MeterID=MeterID;
			model.PayID=PayID;
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
			model.TID=TID;
			model.PriceUnit=PriceUnit;
			model.Derateid=Derateid;
			model.FareName=FareName;
			model.OperationName=OperationName;
			model.Divid1=Divid1;
			model.Divid2=Divid2;
			model.UseNumber1=UseNumber1;
			model.UseNumber2=UseNumber2;
			model.UseNumber3=UseNumber3;
			model.DerateReason=DerateReason;
			model.AdditionNum=AdditionNum;
			model.FareID=FareID;

			WebDemo.BLL.WebDemo.Operation bll=new WebDemo.BLL.WebDemo.Operation();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
