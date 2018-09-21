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
namespace WebDemo.Web.WebDemo.Temperature
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
					decimal Centigrade=(Convert.ToDecimal(strid));
					ShowInfo(Centigrade);
				}
			}
		}
		
	private void ShowInfo(decimal Centigrade)
	{
		WebDemo.BLL.WebDemo.Temperature bll=new WebDemo.BLL.WebDemo.Temperature();
		WebDemo.Model.WebDemo.Temperature model=bll.GetModel(Centigrade);
		this.lblCentigrade.Text=model.Centigrade.ToString();
		this.lblDensity.Text=model.Density.ToString();
		this.lblEnthalpy.Text=model.Enthalpy.ToString();

	}


    }
}
