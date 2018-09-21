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
namespace WebDemo.Web.WebDemo.HostsCH
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
		WebDemo.BLL.WebDemo.HostsCH bll=new WebDemo.BLL.WebDemo.HostsCH();
		WebDemo.Model.WebDemo.HostsCH model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblHostID.Text=model.HostID.ToString();
		this.lblChNo.Text=model.ChNo.ToString();
		this.lblFactCode.Text=model.FactCode;
		this.lblDataID.Text=model.DataID;
		this.lblChBand.Text=model.ChBand.ToString();
		this.lblChBtyeType.Text=model.ChBtyeType;

	}


    }
}
