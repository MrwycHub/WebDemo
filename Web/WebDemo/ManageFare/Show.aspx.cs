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
namespace WebDemo.Web.WebDemo.ManageFare
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
					int ManageFareID=(Convert.ToInt32(strid));
					ShowInfo(ManageFareID);
				}
			}
		}
		
	private void ShowInfo(int ManageFareID)
	{
		WebDemo.BLL.WebDemo.ManageFare bll=new WebDemo.BLL.WebDemo.ManageFare();
		WebDemo.Model.WebDemo.ManageFare model=bll.GetModel(ManageFareID);
		this.lblManageFareID.Text=model.ManageFareID.ToString();
		this.lblManageFareName.Text=model.ManageFareName;
		this.lblManageFarePrice.Text=model.ManageFarePrice.ToString();
		this.lblManageFareTypeID.Text=model.ManageFareTypeID.ToString();
		this.lblReMark.Text=model.ReMark;
		this.lblSystemNum.Text=model.SystemNum.ToString();

	}


    }
}
