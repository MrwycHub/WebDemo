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
namespace WebDemo.Web.WebDemo.ManagePay
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
		WebDemo.BLL.WebDemo.ManagePay bll=new WebDemo.BLL.WebDemo.ManagePay();
		WebDemo.Model.WebDemo.ManagePay model=bll.GetModel(OperID);
		this.lblOperID.Text=model.OperID.ToString();
		this.lblUsersID.Text=model.UsersID.ToString();
		this.lblOperMoney.Text=model.OperMoney.ToString();
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblOperDate.Text=model.OperDate.ToString();
		this.lblPayType.Text=model.PayType.ToString();
		this.lblFlag.Text=model.Flag.ToString();
		this.lblThisReserve.Text=model.ThisReserve.ToString();
		this.lblLastReserve.Text=model.LastReserve.ToString();
		this.lblRedOperId.Text=model.RedOperId.ToString();

	}


    }
}
