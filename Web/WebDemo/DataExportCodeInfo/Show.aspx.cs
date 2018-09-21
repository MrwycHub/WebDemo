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
namespace WebDemo.Web.WebDemo.DataExportCodeInfo
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
		WebDemo.BLL.WebDemo.DataExportCodeInfo bll=new WebDemo.BLL.WebDemo.DataExportCodeInfo();
		WebDemo.Model.WebDemo.DataExportCodeInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblName.Text=model.Name;
		this.lblStrSql.Text=model.StrSql;
		this.lblShowDeptCondition.Text=model.ShowDeptCondition?"是":"否";
		this.lblInfoCondition.Text=model.InfoCondition;
		this.lblDateCondition.Text=model.DateCondition;
		this.lblExtCondition.Text=model.ExtCondition;
		this.lblAscString.Text=model.AscString;
		this.lblGridViewWidth.Text=model.GridViewWidth.ToString();
		this.lblExportType.Text=model.ExportType;
		this.lblShowHeader.Text=model.ShowHeader?"是":"否";
		this.lblSplitChar.Text=model.SplitChar;
		this.lblCreateDbfSql.Text=model.CreateDbfSql;
		this.lblDbfFileName.Text=model.DbfFileName;
		this.lblRemark.Text=model.Remark;
		this.lblEndDateCondition.Text=model.EndDateCondition;
		this.lblShowOtherHeader.Text=model.ShowOtherHeader;
		this.lblExportCols.Text=model.ExportCols;

	}


    }
}
