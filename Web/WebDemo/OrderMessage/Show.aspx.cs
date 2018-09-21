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
namespace WebDemo.Web.WebDemo.OrderMessage
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
		WebDemo.BLL.WebDemo.OrderMessage bll=new WebDemo.BLL.WebDemo.OrderMessage();
		WebDemo.Model.WebDemo.OrderMessage model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblout_trade_no.Text=model.out_trade_no;
		this.lblTransactionId.Text=model.TransactionId;
		this.lbltotal_amount.Text=model.total_amount.ToString();
		this.lblStatus.Text=model.Status.ToString();
		this.lblCreateDate.Text=model.CreateDate.ToString();
		this.lblFinishDate.Text=model.FinishDate.ToString();
		this.lblPayWay.Text=model.PayWay.ToString();

	}


    }
}
