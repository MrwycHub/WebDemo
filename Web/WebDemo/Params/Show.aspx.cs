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
namespace WebDemo.Web.WebDemo.Params
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
					int ParamID=(Convert.ToInt32(strid));
					ShowInfo(ParamID);
				}
			}
		}
		
	private void ShowInfo(int ParamID)
	{
		WebDemo.BLL.WebDemo.Params bll=new WebDemo.BLL.WebDemo.Params();
		WebDemo.Model.WebDemo.Params model=bll.GetModel(ParamID);
		this.lblParamID.Text=model.ParamID.ToString();
		this.lblParamName.Text=model.ParamName;
		this.lblParamValue.Text=model.ParamValue;
		this.lblRemark.Text=model.Remark;
		this.lblIsShow.Text=model.IsShow?"是":"否";
		this.lblIsEdit.Text=model.IsEdit?"是":"否";

	}


    }
}
