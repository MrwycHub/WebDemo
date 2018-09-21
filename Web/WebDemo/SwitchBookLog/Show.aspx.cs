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
namespace WebDemo.Web.WebDemo.SwitchBookLog
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
		WebDemo.BLL.WebDemo.SwitchBookLog bll=new WebDemo.BLL.WebDemo.SwitchBookLog();
		WebDemo.Model.WebDemo.SwitchBookLog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblBookIDBefore.Text=model.BookIDBefore.ToString();
		this.lblBookNumBefore.Text=model.BookNumBefore.ToString();
		this.lblBookIDAfter.Text=model.BookIDAfter.ToString();
		this.lblBookNumAfter.Text=model.BookNumAfter.ToString();
		this.lblOperTime.Text=model.OperTime.ToString();

	}


    }
}
