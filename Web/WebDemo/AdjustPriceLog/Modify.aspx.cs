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
namespace WebDemo.Web.WebDemo.AdjustPriceLog
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		WebDemo.BLL.WebDemo.AdjustPriceLog bll=new WebDemo.BLL.WebDemo.AdjustPriceLog();
		WebDemo.Model.WebDemo.AdjustPriceLog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtPriceTypeID.Text=model.PriceTypeID.ToString();
		this.txtExeDate.Text=model.ExeDate.ToString();
		this.txtMark.Text=model.Mark.ToString();
		this.txtDivid1.Text=model.Divid1.ToString();
		this.txtDivid2.Text=model.Divid2.ToString();
		this.txtDivid3.Text=model.Divid3.ToString();
		this.txtDivid4.Text=model.Divid4.ToString();
		this.txtDivid5.Text=model.Divid5.ToString();
		this.txtFareID.Text=model.FareID.ToString();
		this.txtFareTypeName.Text=model.FareTypeName;
		this.txtPrice.Text=model.Price.ToString();
		this.txtPrice2.Text=model.Price2.ToString();
		this.txtPrice3.Text=model.Price3.ToString();
		this.txtPrice4.Text=model.Price4.ToString();
		this.txtPrice5.Text=model.Price5.ToString();
		this.txtPrice6.Text=model.Price6.ToString();
		this.txtFareNo.Text=model.FareNo.ToString();
		this.txtRemark.Text=model.Remark;
		this.txtPreFareTypeName.Text=model.PreFareTypeName;
		this.txtPrePrice.Text=model.PrePrice.ToString();
		this.txtPrePrice2.Text=model.PrePrice2.ToString();
		this.txtPrePrice3.Text=model.PrePrice3.ToString();
		this.txtPrePrice4.Text=model.PrePrice4.ToString();
		this.txtPrePrice5.Text=model.PrePrice5.ToString();
		this.txtPrePrice6.Text=model.PrePrice6.ToString();
		this.txtPreFareNo.Text=model.PreFareNo.ToString();
		this.txtPreRemark.Text=model.PreRemark;
		this.txtSetNo.Text=model.SetNo.ToString();
		this.txtFreezeDay.Text=model.FreezeDay.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtPriceTypeID.Text))
			{
				strErr+="PriceTypeID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtExeDate.Text))
			{
				strErr+="ExeDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMark.Text))
			{
				strErr+="Mark格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDivid1.Text))
			{
				strErr+="Divid1格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDivid2.Text))
			{
				strErr+="Divid2格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDivid3.Text))
			{
				strErr+="Divid3格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDivid4.Text))
			{
				strErr+="Divid4格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDivid5.Text))
			{
				strErr+="Divid5格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFareID.Text))
			{
				strErr+="FareID格式错误！\\n";	
			}
			if(this.txtFareTypeName.Text.Trim().Length==0)
			{
				strErr+="FareTypeName不能为空！\\n";	
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
			if(!PageValidate.IsNumber(txtFareNo.Text))
			{
				strErr+="FareNo格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(this.txtPreFareTypeName.Text.Trim().Length==0)
			{
				strErr+="PreFareTypeName不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrePrice.Text))
			{
				strErr+="PrePrice格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrePrice2.Text))
			{
				strErr+="PrePrice2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrePrice3.Text))
			{
				strErr+="PrePrice3格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrePrice4.Text))
			{
				strErr+="PrePrice4格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrePrice5.Text))
			{
				strErr+="PrePrice5格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrePrice6.Text))
			{
				strErr+="PrePrice6格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPreFareNo.Text))
			{
				strErr+="PreFareNo格式错误！\\n";	
			}
			if(this.txtPreRemark.Text.Trim().Length==0)
			{
				strErr+="PreRemark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSetNo.Text))
			{
				strErr+="SetNo格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFreezeDay.Text))
			{
				strErr+="FreezeDay格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			int PriceTypeID=int.Parse(this.txtPriceTypeID.Text);
			DateTime ExeDate=DateTime.Parse(this.txtExeDate.Text);
			int Mark=int.Parse(this.txtMark.Text);
			int Divid1=int.Parse(this.txtDivid1.Text);
			int Divid2=int.Parse(this.txtDivid2.Text);
			int Divid3=int.Parse(this.txtDivid3.Text);
			int Divid4=int.Parse(this.txtDivid4.Text);
			int Divid5=int.Parse(this.txtDivid5.Text);
			int FareID=int.Parse(this.txtFareID.Text);
			string FareTypeName=this.txtFareTypeName.Text;
			decimal Price=decimal.Parse(this.txtPrice.Text);
			decimal Price2=decimal.Parse(this.txtPrice2.Text);
			decimal Price3=decimal.Parse(this.txtPrice3.Text);
			decimal Price4=decimal.Parse(this.txtPrice4.Text);
			decimal Price5=decimal.Parse(this.txtPrice5.Text);
			decimal Price6=decimal.Parse(this.txtPrice6.Text);
			int FareNo=int.Parse(this.txtFareNo.Text);
			string Remark=this.txtRemark.Text;
			string PreFareTypeName=this.txtPreFareTypeName.Text;
			decimal PrePrice=decimal.Parse(this.txtPrePrice.Text);
			decimal PrePrice2=decimal.Parse(this.txtPrePrice2.Text);
			decimal PrePrice3=decimal.Parse(this.txtPrePrice3.Text);
			decimal PrePrice4=decimal.Parse(this.txtPrePrice4.Text);
			decimal PrePrice5=decimal.Parse(this.txtPrePrice5.Text);
			decimal PrePrice6=decimal.Parse(this.txtPrePrice6.Text);
			int PreFareNo=int.Parse(this.txtPreFareNo.Text);
			string PreRemark=this.txtPreRemark.Text;
			int SetNo=int.Parse(this.txtSetNo.Text);
			int FreezeDay=int.Parse(this.txtFreezeDay.Text);


			WebDemo.Model.WebDemo.AdjustPriceLog model=new WebDemo.Model.WebDemo.AdjustPriceLog();
			model.ID=ID;
			model.PriceTypeID=PriceTypeID;
			model.ExeDate=ExeDate;
			model.Mark=Mark;
			model.Divid1=Divid1;
			model.Divid2=Divid2;
			model.Divid3=Divid3;
			model.Divid4=Divid4;
			model.Divid5=Divid5;
			model.FareID=FareID;
			model.FareTypeName=FareTypeName;
			model.Price=Price;
			model.Price2=Price2;
			model.Price3=Price3;
			model.Price4=Price4;
			model.Price5=Price5;
			model.Price6=Price6;
			model.FareNo=FareNo;
			model.Remark=Remark;
			model.PreFareTypeName=PreFareTypeName;
			model.PrePrice=PrePrice;
			model.PrePrice2=PrePrice2;
			model.PrePrice3=PrePrice3;
			model.PrePrice4=PrePrice4;
			model.PrePrice5=PrePrice5;
			model.PrePrice6=PrePrice6;
			model.PreFareNo=PreFareNo;
			model.PreRemark=PreRemark;
			model.SetNo=SetNo;
			model.FreezeDay=FreezeDay;

			WebDemo.BLL.WebDemo.AdjustPriceLog bll=new WebDemo.BLL.WebDemo.AdjustPriceLog();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
