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
namespace WebDemo.Web.WebDemo.CollectServer
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
					int ServerId=(Convert.ToInt32(strid));
					ShowInfo(ServerId);
				}
			}
		}
		
	private void ShowInfo(int ServerId)
	{
		WebDemo.BLL.WebDemo.CollectServer bll=new WebDemo.BLL.WebDemo.CollectServer();
		WebDemo.Model.WebDemo.CollectServer model=bll.GetModel(ServerId);
		this.lblServerId.Text=model.ServerId.ToString();
		this.lblServerName.Text=model.ServerName;
		this.lblServerType.Text=model.ServerType.ToString();
		this.lblServerIp.Text=model.ServerIp;
		this.lblWcfUrl.Text=model.WcfUrl;
		this.lblOperTime.Text=model.OperTime.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblPort.Text=model.Port.ToString();

	}


    }
}
