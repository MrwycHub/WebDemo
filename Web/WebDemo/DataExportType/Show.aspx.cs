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
namespace WebDemo.Web.WebDemo.DataExportType
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
		WebDemo.BLL.WebDemo.DataExportType bll=new WebDemo.BLL.WebDemo.DataExportType();
		WebDemo.Model.WebDemo.DataExportType model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblName.Text=model.Name;
		this.lblIsShow.Text=model.IsShow?"是":"否";
		this.lblOrderNum.Text=model.OrderNum.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblConnString.Text=model.ConnString;
		this.lblTableName.Text=model.TableName;

	}


    }
}
