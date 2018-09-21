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
namespace WebDemo.Web.WebDemo.GridViewType
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
					int GridViewTypeID=(Convert.ToInt32(strid));
					ShowInfo(GridViewTypeID);
				}
			}
		}
		
	private void ShowInfo(int GridViewTypeID)
	{
		WebDemo.BLL.WebDemo.GridViewType bll=new WebDemo.BLL.WebDemo.GridViewType();
		WebDemo.Model.WebDemo.GridViewType model=bll.GetModel(GridViewTypeID);
		this.lblGridViewTypeID.Text=model.GridViewTypeID.ToString();
		this.lblGridViewTypeName.Text=model.GridViewTypeName;
		this.lblIsEdit.Text=model.IsEdit?"是":"否";
		this.lblIsShow.Text=model.IsShow?"是":"否";
		this.lblOrderNum.Text=model.OrderNum.ToString();
		this.lblRemark.Text=model.Remark;

	}


    }
}
