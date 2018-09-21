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
namespace WebDemo.Web.WebDemo.PriceType
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
		WebDemo.BLL.WebDemo.PriceType bll=new WebDemo.BLL.WebDemo.PriceType();
		WebDemo.Model.WebDemo.PriceType model=bll.GetModel(PriceTypeID);
		this.lblPriceTypeID.Text=model.PriceTypeID.ToString();
		this.txtPriceTypeName.Text=model.PriceTypeName;
		this.txtMeterTypeID.Text=model.MeterTypeID.ToString();
		this.txtPriceNo.Text=model.PriceNo.ToString();
		this.txtPrice.Text=model.Price.ToString();
		this.txtPrice2.Text=model.Price2.ToString();
		this.txtPrice3.Text=model.Price3.ToString();
		this.txtDivid1.Text=model.Divid1.ToString();
		this.txtDivid2.Text=model.Divid2.ToString();
		this.txtPriceUnit.Text=model.PriceUnit;
		this.txtRemark.Text=model.Remark;
		this.txtPrice4.Text=model.Price4.ToString();
		this.txtPrice5.Text=model.Price5.ToString();
		this.txtPrice6.Text=model.Price6.ToString();
		this.txtDivid3.Text=model.Divid3.ToString();
		this.txtDivid4.Text=model.Divid4.ToString();
		this.txtDivid5.Text=model.Divid5.ToString();
		this.txtExeDate.Text=model.ExeDate.ToString();
		this.txtSetNo.Text=model.SetNo.ToString();
		this.txtSuiteNo.Text=model.SuiteNo.ToString();
		this.txtGroupPriceNo.Text=model.GroupPriceNo.ToString();
		this.txtPriceTypeCode.Text=model.PriceTypeCode;
		this.txtIsStartStar.Text=model.IsStartStar.ToString();
		this.txtIsStartPeople.Text=model.IsStartPeople.ToString();
		this.txtPeopleCheck.Text=model.PeopleCheck.ToString();
		this.txtMaxPeople.Text=model.MaxPeople.ToString();
		this.txtAddUseNumber.Text=model.AddUseNumber.ToString();
		this.txtStarsLevel.Text=model.StarsLevel.ToString();
		this.txtStarsPeriod.Text=model.StarsPeriod.ToString();
		this.txtStarsCorrected.Text=model.StarsCorrected.ToString();
		this.txtIsStartArea.Text=model.IsStartArea.ToString();
		this.txtCoefficient.Text=model.Coefficient.ToString();
		this.txtCalculateDay.Text=model.CalculateDay.ToString();
		this.txtStarsAreaWay.Text=model.StarsAreaWay.ToString();
		this.txtStarsByUser.Text=model.StarsByUser.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtPriceTypeName.Text.Trim().Length==0)
			{
				strErr+="价格名称不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterTypeID.Text))
			{
				strErr+="表类型编号格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPriceNo.Text))
			{
				strErr+="程序控制格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice.Text))
			{
				strErr+="单价格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice2.Text))
			{
				strErr+="单价2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice3.Text))
			{
				strErr+="单价3格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDivid1.Text))
			{
				strErr+="分界点1格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDivid2.Text))
			{
				strErr+="分界点2格式错误！\\n";	
			}
			if(this.txtPriceUnit.Text.Trim().Length==0)
			{
				strErr+="PriceUnit不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注信息不能为空！\\n";	
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
			if(!PageValidate.IsDateTime(txtExeDate.Text))
			{
				strErr+="ExeDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSetNo.Text))
			{
				strErr+="SetNo格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSuiteNo.Text))
			{
				strErr+="SuiteNo格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtGroupPriceNo.Text))
			{
				strErr+="GroupPriceNo格式错误！\\n";	
			}
			if(this.txtPriceTypeCode.Text.Trim().Length==0)
			{
				strErr+="PriceTypeCode不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtIsStartStar.Text))
			{
				strErr+="IsStartStar格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtIsStartPeople.Text))
			{
				strErr+="IsStartPeople格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPeopleCheck.Text))
			{
				strErr+="PeopleCheck格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMaxPeople.Text))
			{
				strErr+="MaxPeople格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtAddUseNumber.Text))
			{
				strErr+="AddUseNumber格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtStarsLevel.Text))
			{
				strErr+="StarsLevel格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtStarsPeriod.Text))
			{
				strErr+="StarsPeriod格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtStarsCorrected.Text))
			{
				strErr+="StarsCorrected格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtIsStartArea.Text))
			{
				strErr+="IsStartArea格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtCoefficient.Text))
			{
				strErr+="Coefficient格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCalculateDay.Text))
			{
				strErr+="CalculateDay格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtStarsAreaWay.Text))
			{
				strErr+="StarsAreaWay格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtStarsByUser.Text))
			{
				strErr+="StarsByUser格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int PriceTypeID=int.Parse(this.lblPriceTypeID.Text);
			string PriceTypeName=this.txtPriceTypeName.Text;
			int MeterTypeID=int.Parse(this.txtMeterTypeID.Text);
			int PriceNo=int.Parse(this.txtPriceNo.Text);
			decimal Price=decimal.Parse(this.txtPrice.Text);
			decimal Price2=decimal.Parse(this.txtPrice2.Text);
			decimal Price3=decimal.Parse(this.txtPrice3.Text);
			int Divid1=int.Parse(this.txtDivid1.Text);
			int Divid2=int.Parse(this.txtDivid2.Text);
			string PriceUnit=this.txtPriceUnit.Text;
			string Remark=this.txtRemark.Text;
			decimal Price4=decimal.Parse(this.txtPrice4.Text);
			decimal Price5=decimal.Parse(this.txtPrice5.Text);
			decimal Price6=decimal.Parse(this.txtPrice6.Text);
			int Divid3=int.Parse(this.txtDivid3.Text);
			int Divid4=int.Parse(this.txtDivid4.Text);
			int Divid5=int.Parse(this.txtDivid5.Text);
			DateTime ExeDate=DateTime.Parse(this.txtExeDate.Text);
			int SetNo=int.Parse(this.txtSetNo.Text);
			int SuiteNo=int.Parse(this.txtSuiteNo.Text);
			int GroupPriceNo=int.Parse(this.txtGroupPriceNo.Text);
			string PriceTypeCode=this.txtPriceTypeCode.Text;
			int IsStartStar=int.Parse(this.txtIsStartStar.Text);
			int IsStartPeople=int.Parse(this.txtIsStartPeople.Text);
			int PeopleCheck=int.Parse(this.txtPeopleCheck.Text);
			int MaxPeople=int.Parse(this.txtMaxPeople.Text);
			decimal AddUseNumber=decimal.Parse(this.txtAddUseNumber.Text);
			int StarsLevel=int.Parse(this.txtStarsLevel.Text);
			int StarsPeriod=int.Parse(this.txtStarsPeriod.Text);
			int StarsCorrected=int.Parse(this.txtStarsCorrected.Text);
			int IsStartArea=int.Parse(this.txtIsStartArea.Text);
			decimal Coefficient=decimal.Parse(this.txtCoefficient.Text);
			int CalculateDay=int.Parse(this.txtCalculateDay.Text);
			int StarsAreaWay=int.Parse(this.txtStarsAreaWay.Text);
			int StarsByUser=int.Parse(this.txtStarsByUser.Text);


			WebDemo.Model.WebDemo.PriceType model=new WebDemo.Model.WebDemo.PriceType();
			model.PriceTypeID=PriceTypeID;
			model.PriceTypeName=PriceTypeName;
			model.MeterTypeID=MeterTypeID;
			model.PriceNo=PriceNo;
			model.Price=Price;
			model.Price2=Price2;
			model.Price3=Price3;
			model.Divid1=Divid1;
			model.Divid2=Divid2;
			model.PriceUnit=PriceUnit;
			model.Remark=Remark;
			model.Price4=Price4;
			model.Price5=Price5;
			model.Price6=Price6;
			model.Divid3=Divid3;
			model.Divid4=Divid4;
			model.Divid5=Divid5;
			model.ExeDate=ExeDate;
			model.SetNo=SetNo;
			model.SuiteNo=SuiteNo;
			model.GroupPriceNo=GroupPriceNo;
			model.PriceTypeCode=PriceTypeCode;
			model.IsStartStar=IsStartStar;
			model.IsStartPeople=IsStartPeople;
			model.PeopleCheck=PeopleCheck;
			model.MaxPeople=MaxPeople;
			model.AddUseNumber=AddUseNumber;
			model.StarsLevel=StarsLevel;
			model.StarsPeriod=StarsPeriod;
			model.StarsCorrected=StarsCorrected;
			model.IsStartArea=IsStartArea;
			model.Coefficient=Coefficient;
			model.CalculateDay=CalculateDay;
			model.StarsAreaWay=StarsAreaWay;
			model.StarsByUser=StarsByUser;

			WebDemo.BLL.WebDemo.PriceType bll=new WebDemo.BLL.WebDemo.PriceType();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
