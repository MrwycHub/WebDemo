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
namespace WebDemo.Web.WebDemo.BalanceNodeInfo
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
					int Id=(Convert.ToInt32(strid));
					ShowInfo(Id);
				}
			}
		}
		
	private void ShowInfo(int Id)
	{
		WebDemo.BLL.WebDemo.BalanceNodeInfo bll=new WebDemo.BLL.WebDemo.BalanceNodeInfo();
		WebDemo.Model.WebDemo.BalanceNodeInfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblOperatorId.Text=model.OperatorId.ToString();
		this.lblBeginDate.Text=model.BeginDate.ToString();
		this.lblEndDate.Text=model.EndDate.ToString();
		this.lblFactMoney.Text=model.FactMoney.ToString();
		this.lblPayCount.Text=model.PayCount.ToString();

	}


    }
}
