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
namespace WebDemo.Web.WebDemo.BookInfo
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
					int BookID=(Convert.ToInt32(strid));
					ShowInfo(BookID);
				}
			}
		}
		
	private void ShowInfo(int BookID)
	{
		WebDemo.BLL.WebDemo.BookInfo bll=new WebDemo.BLL.WebDemo.BookInfo();
		WebDemo.Model.WebDemo.BookInfo model=bll.GetModel(BookID);
		this.lblBookID.Text=model.BookID.ToString();
		this.lblDeptIDs.Text=model.DeptIDs;
		this.lblBookName.Text=model.BookName;
		this.lblWorkerID.Text=model.WorkerID.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblBookCode.Text=model.BookCode;
		this.lblRoutes.Text=model.Routes;
		this.lblReadDay.Text=model.ReadDay.ToString();
		this.lblReadType.Text=model.ReadType.ToString();
		this.lblUserNum.Text=model.UserNum.ToString();
		this.lblUpdateTime.Text=model.UpdateTime.ToString();
		this.lblAutoReadBeginDate.Text=model.AutoReadBeginDate;
		this.lblAutoReadEndDate.Text=model.AutoReadEndDate;

	}


    }
}
