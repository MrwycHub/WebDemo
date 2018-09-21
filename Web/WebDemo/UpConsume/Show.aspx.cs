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
namespace WebDemo.Web.WebDemo.UpConsume
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
					int UpId=(Convert.ToInt32(strid));
					ShowInfo(UpId);
				}
			}
		}
		
	private void ShowInfo(int UpId)
	{
		WebDemo.BLL.WebDemo.UpConsume bll=new WebDemo.BLL.WebDemo.UpConsume();
		WebDemo.Model.WebDemo.UpConsume model=bll.GetModel(UpId);
		this.lblUpId.Text=model.UpId.ToString();
		this.lblCardId.Text=model.CardId.ToString();
		this.lblLostFreeNum.Text=model.LostFreeNum.ToString();
		this.lblSurplusMoney.Text=model.SurplusMoney.ToString();
		this.lblConsumeTime.Text=model.ConsumeTime.ToString();
		this.lblMeterid.Text=model.Meterid.ToString();
		this.lblUseMoney.Text=model.UseMoney.ToString();
		this.lblInsDate.Text=model.InsDate.ToString();

	}


    }
}
