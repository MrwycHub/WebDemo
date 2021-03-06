﻿using System;
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
namespace WebDemo.Web.WebDemo.PriceFare
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int FareID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(FareID);
				}
			}
		}
			
	private void ShowInfo(int FareID)
	{
		WebDemo.BLL.WebDemo.PriceFare bll=new WebDemo.BLL.WebDemo.PriceFare();
		WebDemo.Model.WebDemo.PriceFare model=bll.GetModel(FareID);
		this.lblFareID.Text=model.FareID.ToString();
		this.txtPriceTypeID.Text=model.PriceTypeID.ToString();
		this.txtFareTypeName.Text=model.FareTypeName;
		this.txtPrice.Text=model.Price.ToString();
		this.txtPrice2.Text=model.Price2.ToString();
		this.txtPrice3.Text=model.Price3.ToString();
		this.txtFareNo.Text=model.FareNo.ToString();
		this.txtReMark.Text=model.ReMark;
		this.txtPrice4.Text=model.Price4.ToString();
		this.txtPrice5.Text=model.Price5.ToString();
		this.txtPrice6.Text=model.Price6.ToString();
		this.txtTaxRate.Text=model.TaxRate.ToString();
		this.txtProjectName.Text=model.ProjectName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtPriceTypeID.Text))
			{
				strErr+="PriceTypeID格式错误！\\n";	
			}
			if(this.txtFareTypeName.Text.Trim().Length==0)
			{
				strErr+="费用名称不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice.Text))
			{
				strErr+="单价格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice2.Text))
			{
				strErr+="Price2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice3.Text))
			{
				strErr+="Price3格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFareNo.Text))
			{
				strErr+="FareNo格式错误！\\n";	
			}
			if(this.txtReMark.Text.Trim().Length==0)
			{
				strErr+="ReMark不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice4.Text))
			{
				strErr+="Price4格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice5.Text))
			{
				strErr+="Price5格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice6.Text))
			{
				strErr+="Price6格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTaxRate.Text))
			{
				strErr+="TaxRate格式错误！\\n";	
			}
			if(this.txtProjectName.Text.Trim().Length==0)
			{
				strErr+="ProjectName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int FareID=int.Parse(this.lblFareID.Text);
			int PriceTypeID=int.Parse(this.txtPriceTypeID.Text);
			string FareTypeName=this.txtFareTypeName.Text;
			decimal Price=decimal.Parse(this.txtPrice.Text);
			decimal Price2=decimal.Parse(this.txtPrice2.Text);
			decimal Price3=decimal.Parse(this.txtPrice3.Text);
			int FareNo=int.Parse(this.txtFareNo.Text);
			string ReMark=this.txtReMark.Text;
			decimal Price4=decimal.Parse(this.txtPrice4.Text);
			decimal Price5=decimal.Parse(this.txtPrice5.Text);
			decimal Price6=decimal.Parse(this.txtPrice6.Text);
			decimal TaxRate=decimal.Parse(this.txtTaxRate.Text);
			string ProjectName=this.txtProjectName.Text;


			WebDemo.Model.WebDemo.PriceFare model=new WebDemo.Model.WebDemo.PriceFare();
			model.FareID=FareID;
			model.PriceTypeID=PriceTypeID;
			model.FareTypeName=FareTypeName;
			model.Price=Price;
			model.Price2=Price2;
			model.Price3=Price3;
			model.FareNo=FareNo;
			model.ReMark=ReMark;
			model.Price4=Price4;
			model.Price5=Price5;
			model.Price6=Price6;
			model.TaxRate=TaxRate;
			model.ProjectName=ProjectName;

			WebDemo.BLL.WebDemo.PriceFare bll=new WebDemo.BLL.WebDemo.PriceFare();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
