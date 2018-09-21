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
namespace WebDemo.Web.WebDemo.AdjustPriceLog
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
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		WebDemo.BLL.WebDemo.AdjustPriceLog bll=new WebDemo.BLL.WebDemo.AdjustPriceLog();
		WebDemo.Model.WebDemo.AdjustPriceLog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblPriceTypeID.Text=model.PriceTypeID.ToString();
		this.lblExeDate.Text=model.ExeDate.ToString();
		this.lblMark.Text=model.Mark.ToString();
		this.lblDivid1.Text=model.Divid1.ToString();
		this.lblDivid2.Text=model.Divid2.ToString();
		this.lblDivid3.Text=model.Divid3.ToString();
		this.lblDivid4.Text=model.Divid4.ToString();
		this.lblDivid5.Text=model.Divid5.ToString();
		this.lblFareID.Text=model.FareID.ToString();
		this.lblFareTypeName.Text=model.FareTypeName;
		this.lblPrice.Text=model.Price.ToString();
		this.lblPrice2.Text=model.Price2.ToString();
		this.lblPrice3.Text=model.Price3.ToString();
		this.lblPrice4.Text=model.Price4.ToString();
		this.lblPrice5.Text=model.Price5.ToString();
		this.lblPrice6.Text=model.Price6.ToString();
		this.lblFareNo.Text=model.FareNo.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblPreFareTypeName.Text=model.PreFareTypeName;
		this.lblPrePrice.Text=model.PrePrice.ToString();
		this.lblPrePrice2.Text=model.PrePrice2.ToString();
		this.lblPrePrice3.Text=model.PrePrice3.ToString();
		this.lblPrePrice4.Text=model.PrePrice4.ToString();
		this.lblPrePrice5.Text=model.PrePrice5.ToString();
		this.lblPrePrice6.Text=model.PrePrice6.ToString();
		this.lblPreFareNo.Text=model.PreFareNo.ToString();
		this.lblPreRemark.Text=model.PreRemark;
		this.lblSetNo.Text=model.SetNo.ToString();
		this.lblFreezeDay.Text=model.FreezeDay.ToString();

	}


    }
}
