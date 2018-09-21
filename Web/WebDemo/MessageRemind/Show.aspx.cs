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
namespace WebDemo.Web.WebDemo.MessageRemind
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
		WebDemo.BLL.WebDemo.MessageRemind bll=new WebDemo.BLL.WebDemo.MessageRemind();
		WebDemo.Model.WebDemo.MessageRemind model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblRemindType.Text=model.RemindType.ToString();
		this.lblRemindContent.Text=model.RemindContent;
		this.lblOperatorIDStr.Text=model.OperatorIDStr;
		this.lblReadedStr.Text=model.ReadedStr;
		this.lblUpdateTime.Text=model.UpdateTime.ToString();

	}


    }
}
