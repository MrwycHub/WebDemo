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
namespace WebDemo.Web.WebDemo.CommandType
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
					int CommandID=(Convert.ToInt32(strid));
					ShowInfo(CommandID);
				}
			}
		}
		
	private void ShowInfo(int CommandID)
	{
		WebDemo.BLL.WebDemo.CommandType bll=new WebDemo.BLL.WebDemo.CommandType();
		WebDemo.Model.WebDemo.CommandType model=bll.GetModel(CommandID);
		this.lblCommandID.Text=model.CommandID.ToString();
		this.lblCommandName.Text=model.CommandName;
		this.lblFlag.Text=model.Flag.ToString();

	}


    }
}
