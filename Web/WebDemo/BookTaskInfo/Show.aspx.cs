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
namespace WebDemo.Web.WebDemo.BookTaskInfo
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
		WebDemo.BLL.WebDemo.BookTaskInfo bll=new WebDemo.BLL.WebDemo.BookTaskInfo();
		WebDemo.Model.WebDemo.BookTaskInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblBookID.Text=model.BookID.ToString();
		this.lblReadDate.Text=model.ReadDate;
		this.lblBookCode.Text=model.BookCode;
		this.lblBookName.Text=model.BookName;
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblRoutes.Text=model.Routes;
		this.lblUserNum.Text=model.UserNum.ToString();
		this.lblFactNum.Text=model.FactNum.ToString();
		this.lblUpdateTime.Text=model.UpdateTime.ToString();

	}


    }
}
