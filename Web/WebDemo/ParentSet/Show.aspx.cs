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
namespace WebDemo.Web.WebDemo.ParentSet
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
					int MeterID=(Convert.ToInt32(strid));
					ShowInfo(MeterID);
				}
			}
		}
		
	private void ShowInfo(int MeterID)
	{
		WebDemo.BLL.WebDemo.ParentSet bll=new WebDemo.BLL.WebDemo.ParentSet();
		WebDemo.Model.WebDemo.ParentSet model=bll.GetModel(MeterID);
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblParentID.Text=model.ParentID.ToString();

	}


    }
}
