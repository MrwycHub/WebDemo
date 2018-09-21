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
namespace WebDemo.Web.WebDemo.LocationInfo
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
		WebDemo.BLL.WebDemo.LocationInfo bll=new WebDemo.BLL.WebDemo.LocationInfo();
		WebDemo.Model.WebDemo.LocationInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblDateTime.Text=model.DateTime.ToString();
		this.lblLocationX.Text=model.LocationX.ToString();
		this.lblLocationY.Text=model.LocationY.ToString();

	}


    }
}
