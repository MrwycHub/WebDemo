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
namespace WebDemo.Web.WebDemo.Operation
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int OperID=(Convert.ToInt32(strid));
					ShowInfo(OperID);
				}
			}
		}
		
	private void ShowInfo(int OperID)
	{
		WebDemo.BLL.WebDemo.Operation bll=new WebDemo.BLL.WebDemo.Operation();
		WebDemo.Model.WebDemo.Operation model=bll.GetModel(OperID);
		this.lblOperID.Text=model.OperID.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblPayID.Text=model.PayID.ToString();
		this.lblBeginMonth.Text=model.BeginMonth;
		this.lblBeginNumber.Text=model.BeginNumber.ToString();
		this.lblEndMonth.Text=model.EndMonth;
		this.lblEndNumber.Text=model.EndNumber.ToString();
		this.lblUseNumber.Text=model.UseNumber.ToString();
		this.lblPriceTypeID.Text=model.PriceTypeID.ToString();
		this.lblPriceTypeName.Text=model.PriceTypeName;
		this.lblPrice.Text=model.Price.ToString();
		this.lblPrice2.Text=model.Price2.ToString();
		this.lblPrice3.Text=model.Price3.ToString();
		this.lblFareMoney.Text=model.FareMoney.ToString();
		this.lblPayMark.Text=model.PayMark.ToString();
		this.lblOperType.Text=model.OperType.ToString();
		this.lblOperDate.Text=model.OperDate.ToString();
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblopermonth.Text=model.opermonth;
		this.lblTID.Text=model.TID.ToString();
		this.lblPriceUnit.Text=model.PriceUnit;
		this.lblDerateid.Text=model.Derateid.ToString();
		this.lblFareName.Text=model.FareName;
		this.lblOperationName.Text=model.OperationName;
		this.lblDivid1.Text=model.Divid1.ToString();
		this.lblDivid2.Text=model.Divid2.ToString();
		this.lblUseNumber1.Text=model.UseNumber1.ToString();
		this.lblUseNumber2.Text=model.UseNumber2.ToString();
		this.lblUseNumber3.Text=model.UseNumber3.ToString();
		this.lblDerateReason.Text=model.DerateReason;
		this.lblAdditionNum.Text=model.AdditionNum.ToString();
		this.lblFareID.Text=model.FareID.ToString();

	}


    }
}
