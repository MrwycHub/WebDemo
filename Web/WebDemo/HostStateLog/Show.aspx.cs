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
namespace WebDemo.Web.WebDemo.HostStateLog
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
		WebDemo.BLL.WebDemo.HostStateLog bll=new WebDemo.BLL.WebDemo.HostStateLog();
		WebDemo.Model.WebDemo.HostStateLog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblHostId.Text=model.HostId.ToString();
		this.lblFuncType.Text=model.FuncType.ToString();
		this.lblReadTime.Text=model.ReadTime.ToString();
		this.lblState.Text=model.State.ToString();
		this.lblDescripion.Text=model.Descripion;
		this.lblRemark.Text=model.Remark;

	}


    }
}
