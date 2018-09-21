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
namespace WebDemo.Web.WebDemo.FillOperLog
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
		WebDemo.BLL.WebDemo.FillOperLog bll=new WebDemo.BLL.WebDemo.FillOperLog();
		WebDemo.Model.WebDemo.FillOperLog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblOperID.Text=model.OperID.ToString();
		this.lblOperType.Text=model.OperType;
		this.lblOperDate.Text=model.OperDate.ToString();
		this.lblOperFlag.Text=model.OperFlag.ToString();
		this.lblOperInfo.Text=model.OperInfo;
		this.lblOperatorID.Text=model.OperatorID.ToString();

	}


    }
}
