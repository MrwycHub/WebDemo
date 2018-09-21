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
namespace WebDemo.Web.WebDemo.InvoiceList
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
					int InID=(Convert.ToInt32(strid));
					ShowInfo(InID);
				}
			}
		}
		
	private void ShowInfo(int InID)
	{
		WebDemo.BLL.WebDemo.InvoiceList bll=new WebDemo.BLL.WebDemo.InvoiceList();
		WebDemo.Model.WebDemo.InvoiceList model=bll.GetModel(InID);
		this.lblInID.Text=model.InID.ToString();
		this.lblInCode.Text=model.InCode;
		this.lblInNumber.Text=model.InNumber.ToString();
		this.lblSiteID.Text=model.SiteID.ToString();
		this.lblOperatorName.Text=model.OperatorName;
		this.lblGetDate.Text=model.GetDate.ToString();
		this.lblPayID.Text=model.PayID.ToString();
		this.lblPrintDate.Text=model.PrintDate.ToString();
		this.lblInMoney.Text=model.InMoney.ToString();
		this.lblInMark.Text=model.InMark.ToString();
		this.lblSendMark.Text=model.SendMark.ToString();
		this.lblSendDate.Text=model.SendDate.ToString();
		this.lblprintMan.Text=model.printMan;
		this.lblzfDate.Text=model.zfDate.ToString();
		this.lblzfInCode.Text=model.zfInCode;
		this.lblzfInNumber.Text=model.zfInNumber;
		this.lblUName.Text=model.UName;

	}


    }
}
