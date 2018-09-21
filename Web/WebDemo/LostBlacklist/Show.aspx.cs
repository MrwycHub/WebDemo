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
namespace WebDemo.Web.WebDemo.LostBlacklist
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
					int SaveNo=(Convert.ToInt32(strid));
					ShowInfo(SaveNo);
				}
			}
		}
		
	private void ShowInfo(int SaveNo)
	{
		WebDemo.BLL.WebDemo.LostBlacklist bll=new WebDemo.BLL.WebDemo.LostBlacklist();
		WebDemo.Model.WebDemo.LostBlacklist model=bll.GetModel(SaveNo);
		this.lblSaveNo.Text=model.SaveNo.ToString();
		this.lblCardID.Text=model.CardID.ToString();
		this.lblLostDate.Text=model.LostDate.ToString();

	}


    }
}
