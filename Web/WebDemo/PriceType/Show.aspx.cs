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
namespace WebDemo.Web.WebDemo.PriceType
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
					int PriceTypeID=(Convert.ToInt32(strid));
					ShowInfo(PriceTypeID);
				}
			}
		}
		
	private void ShowInfo(int PriceTypeID)
	{
		WebDemo.BLL.WebDemo.PriceType bll=new WebDemo.BLL.WebDemo.PriceType();
		WebDemo.Model.WebDemo.PriceType model=bll.GetModel(PriceTypeID);
		this.lblPriceTypeID.Text=model.PriceTypeID.ToString();
		this.lblPriceTypeName.Text=model.PriceTypeName;
		this.lblMeterTypeID.Text=model.MeterTypeID.ToString();
		this.lblPriceNo.Text=model.PriceNo.ToString();
		this.lblPrice.Text=model.Price.ToString();
		this.lblPrice2.Text=model.Price2.ToString();
		this.lblPrice3.Text=model.Price3.ToString();
		this.lblDivid1.Text=model.Divid1.ToString();
		this.lblDivid2.Text=model.Divid2.ToString();
		this.lblPriceUnit.Text=model.PriceUnit;
		this.lblRemark.Text=model.Remark;
		this.lblPrice4.Text=model.Price4.ToString();
		this.lblPrice5.Text=model.Price5.ToString();
		this.lblPrice6.Text=model.Price6.ToString();
		this.lblDivid3.Text=model.Divid3.ToString();
		this.lblDivid4.Text=model.Divid4.ToString();
		this.lblDivid5.Text=model.Divid5.ToString();
		this.lblExeDate.Text=model.ExeDate.ToString();
		this.lblSetNo.Text=model.SetNo.ToString();
		this.lblSuiteNo.Text=model.SuiteNo.ToString();
		this.lblGroupPriceNo.Text=model.GroupPriceNo.ToString();
		this.lblPriceTypeCode.Text=model.PriceTypeCode;
		this.lblIsStartStar.Text=model.IsStartStar.ToString();
		this.lblIsStartPeople.Text=model.IsStartPeople.ToString();
		this.lblPeopleCheck.Text=model.PeopleCheck.ToString();
		this.lblMaxPeople.Text=model.MaxPeople.ToString();
		this.lblAddUseNumber.Text=model.AddUseNumber.ToString();
		this.lblStarsLevel.Text=model.StarsLevel.ToString();
		this.lblStarsPeriod.Text=model.StarsPeriod.ToString();
		this.lblStarsCorrected.Text=model.StarsCorrected.ToString();
		this.lblIsStartArea.Text=model.IsStartArea.ToString();
		this.lblCoefficient.Text=model.Coefficient.ToString();
		this.lblCalculateDay.Text=model.CalculateDay.ToString();
		this.lblStarsAreaWay.Text=model.StarsAreaWay.ToString();
		this.lblStarsByUser.Text=model.StarsByUser.ToString();

	}


    }
}
