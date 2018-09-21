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
namespace WebDemo.Web.WebDemo.BlanceAccount
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
		WebDemo.BLL.WebDemo.BlanceAccount bll=new WebDemo.BLL.WebDemo.BlanceAccount();
		WebDemo.Model.WebDemo.BlanceAccount model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblBlanceDate.Text=model.BlanceDate;
		this.lblFailUserCode.Text=model.FailUserCode;
		this.lblFail.Text=model.Fail.ToString();
		this.lblAllCount.Text=model.AllCount.ToString();
		this.lblAllMoney.Text=model.AllMoney.ToString();
		this.lblRefundMoney.Text=model.RefundMoney.ToString();
		this.lblBlanceTime.Text=model.BlanceTime.ToString();

	}


    }
}
