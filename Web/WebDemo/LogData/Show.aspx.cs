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
namespace WebDemo.Web.WebDemo.LogData
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
					int LogID=(Convert.ToInt32(strid));
					ShowInfo(LogID);
				}
			}
		}
		
	private void ShowInfo(int LogID)
	{
		WebDemo.BLL.WebDemo.LogData bll=new WebDemo.BLL.WebDemo.LogData();
		WebDemo.Model.WebDemo.LogData model=bll.GetModel(LogID);
		this.lblLogID.Text=model.LogID.ToString();
		this.lblLogTitle.Text=model.LogTitle;
		this.lblLogType.Text=model.LogType;
		this.lblLogDate.Text=model.LogDate.ToString();
		this.lblLogMemo.Text=model.LogMemo;
		this.lblLogData.Text=model.LogData;
		this.lblLogOperator.Text=model.LogOperator;

	}


    }
}
