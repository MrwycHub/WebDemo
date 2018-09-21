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
namespace WebDemo.Web.WebDemo.ClientEnvironmentInfo
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
					long Id=(Convert.ToInt64(strid));
					ShowInfo(Id);
				}
			}
		}
		
	private void ShowInfo(long Id)
	{
		WebDemo.BLL.WebDemo.ClientEnvironmentInfo bll=new WebDemo.BLL.WebDemo.ClientEnvironmentInfo();
		WebDemo.Model.WebDemo.ClientEnvironmentInfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblDanWeiName.Text=model.DanWeiName;
		this.lblJiQiMa.Text=model.JiQiMa;
		this.lblOperatorCode.Text=model.OperatorCode;
		this.lblIP.Text=model.IP;
		this.lblBrowserName.Text=model.BrowserName;
		this.lblBrowerVersion.Text=model.BrowerVersion;
		this.lblOSName.Text=model.OSName;
		this.lblCreateTime.Text=model.CreateTime.ToString();

	}


    }
}
