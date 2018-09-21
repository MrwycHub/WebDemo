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
namespace WebDemo.Web.WebDemo.EInvoices
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
		WebDemo.BLL.WebDemo.EInvoices bll=new WebDemo.BLL.WebDemo.EInvoices();
		WebDemo.Model.WebDemo.EInvoices model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblOperID.Text=model.OperID.ToString();
		this.lblOperType.Text=model.OperType.ToString();
		this.lblInvoiceNumber.Text=model.InvoiceNumber;
		this.lblOrderNo.Text=model.OrderNo;
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblOperMoney.Text=model.OperMoney.ToString();
		this.lblFactMoney.Text=model.FactMoney.ToString();
		this.lblInvoiceState.Text=model.InvoiceState.ToString();
		this.lblOperDate.Text=model.OperDate.ToString();
		this.lblURL.Text=model.URL;
		this.lblCreateDate.Text=model.CreateDate.ToString();
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblInvoiceCode.Text=model.InvoiceCode;
		this.lblRtnInvoiceNumber.Text=model.RtnInvoiceNumber;
		this.lblManualRegist.Text=model.ManualRegist.ToString();
		this.lblRedSaleURL.Text=model.RedSaleURL;
		this.lblRSInvoiceNumber.Text=model.RSInvoiceNumber;
		this.lblRegistDate.Text=model.RegistDate.ToString();

	}


    }
}
