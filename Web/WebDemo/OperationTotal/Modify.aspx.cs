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
namespace WebDemo.Web.WebDemo.OperationTotal
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int TID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(TID);
				}
			}
		}
			
	private void ShowInfo(int TID)
	{
		WebDemo.BLL.WebDemo.OperationTotal bll=new WebDemo.BLL.WebDemo.OperationTotal();
		WebDemo.Model.WebDemo.OperationTotal model=bll.GetModel(TID);
		this.lblTID.Text=model.TID.ToString();
		this.txtMeterID.Text=model.MeterID.ToString();
		this.txtPayID.Text=model.PayID.ToString();
		this.txtBeginMonth.Text=model.BeginMonth;
		this.txtBeginNumber.Text=model.BeginNumber.ToString();
		this.txtEndMonth.Text=model.EndMonth;
		this.txtEndNumber.Text=model.EndNumber.ToString();
		this.txtUseNumber.Text=model.UseNumber.ToString();
		this.txtPriceTypeID.Text=model.PriceTypeID.ToString();
		this.txtPriceTypeName.Text=model.PriceTypeName;
		this.txtPrice.Text=model.Price.ToString();
		this.txtPrice2.Text=model.Price2.ToString();
		this.txtPrice3.Text=model.Price3.ToString();
		this.txtFareMoney.Text=model.FareMoney.ToString();
		this.txtPayMark.Text=model.PayMark.ToString();
		this.txtOperType.Text=model.OperType.ToString();
		this.txtOperDate.Text=model.OperDate.ToString();
		this.txtOperatorID.Text=model.OperatorID.ToString();
		this.txtopermonth.Text=model.opermonth;
		this.txtPriceUnit.Text=model.PriceUnit;
		this.txtOperationName.Text=model.OperationName;
		this.txtDivid1.Text=model.Divid1.ToString();
		this.txtDivid2.Text=model.Divid2.ToString();
		this.txtUseNumber1.Text=model.UseNumber1.ToString();
		this.txtUseNumber2.Text=model.UseNumber2.ToString();
		this.txtUseNumber3.Text=model.UseNumber3.ToString();
		this.txtAdditionNum.Text=model.AdditionNum.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMeterID.Text))
			{
				strErr+="MeterID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayID.Text))
			{
				strErr+="PayID格式错误！\\n";	
			}
			if(this.txtBeginMonth.Text.Trim().Length==0)
			{
				strErr+="BeginMonth不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtBeginNumber.Text))
			{
				strErr+="BeginNumber格式错误！\\n";	
			}
			if(this.txtEndMonth.Text.Trim().Length==0)
			{
				strErr+="EndMonth不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtEndNumber.Text))
			{
				strErr+="EndNumber格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUseNumber.Text))
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
				strErr+="总金额格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayMark.Text))
			{
				strErr+="PayMark格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperType.Text))
			{
				strErr+="1-抄表结算；2-换表结算；格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperDate.Text))
			{
				strErr+="OperDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(this.txtopermonth.Text.Trim().Length==0)
			{
				strErr+="opermonth不能为空！\\n";	
			}
			if(this.txtPriceUnit.Text.Trim().Length==0)
			{
				strErr+="PriceUnit不能为空！\\n";	
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
			if(!PageValidate.IsDecimal(txtAdditionNum.Text))
			{
				strErr+="AdditionNum格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int TID=int.Parse(this.lblTID.Text);
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
			string PriceUnit=this.txtPriceUnit.Text;
			string OperationName=this.txtOperationName.Text;
			int Divid1=int.Parse(this.txtDivid1.Text);
			int Divid2=int.Parse(this.txtDivid2.Text);
			decimal UseNumber1=decimal.Parse(this.txtUseNumber1.Text);
			decimal UseNumber2=decimal.Parse(this.txtUseNumber2.Text);
			decimal UseNumber3=decimal.Parse(this.txtUseNumber3.Text);
			decimal AdditionNum=decimal.Parse(this.txtAdditionNum.Text);


			WebDemo.Model.WebDemo.OperationTotal model=new WebDemo.Model.WebDemo.OperationTotal();
			model.TID=TID;
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
			model.PriceUnit=PriceUnit;
			model.OperationName=OperationName;
			model.Divid1=Divid1;
			model.Divid2=Divid2;
			model.UseNumber1=UseNumber1;
			model.UseNumber2=UseNumber2;
			model.UseNumber3=UseNumber3;
			model.AdditionNum=AdditionNum;

			WebDemo.BLL.WebDemo.OperationTotal bll=new WebDemo.BLL.WebDemo.OperationTotal();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
