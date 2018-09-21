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
namespace WebDemo.Web.WebDemo.ReportFiles
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
		WebDemo.BLL.WebDemo.ReportFiles bll=new WebDemo.BLL.WebDemo.ReportFiles();
		WebDemo.Model.WebDemo.ReportFiles model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblReportID.Text=model.ReportID;
		this.lblReportName.Text=model.ReportName;
		this.lblReportType.Text=model.ReportType;
		this.lblReportFileName.Text=model.ReportFileName;
		this.lblReportDbType.Text=model.ReportDbType.ToString();
		this.lblReportSql.Text=model.ReportSql;
		this.lblReportServiceUrl.Text=model.ReportServiceUrl;
		this.lblReportRole.Text=model.ReportRole.ToString();
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblInsDate.Text=model.InsDate.ToString();
		this.lblRemark.Text=model.Remark;

	}


    }
}
