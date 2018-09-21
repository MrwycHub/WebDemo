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
namespace WebDemo.Web.WebDemo.InvoiceHand
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
		WebDemo.BLL.WebDemo.InvoiceHand bll=new WebDemo.BLL.WebDemo.InvoiceHand();
		WebDemo.Model.WebDemo.InvoiceHand model=bll.GetModel(OperID);
		this.lblOperID.Text=model.OperID.ToString();
		this.lblspName.Text=model.spName;
		this.lblspUnit.Text=model.spUnit;
		this.lblspNum.Text=model.spNum.ToString();
		this.lblspPrice.Text=model.spPrice.ToString();
		this.lblspMoney.Text=model.spMoney.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblInID.Text=model.InID.ToString();

	}


    }
}
