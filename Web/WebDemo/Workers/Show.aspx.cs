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
namespace WebDemo.Web.WebDemo.Workers
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
					int WorkerID=(Convert.ToInt32(strid));
					ShowInfo(WorkerID);
				}
			}
		}
		
	private void ShowInfo(int WorkerID)
	{
		WebDemo.BLL.WebDemo.Workers bll=new WebDemo.BLL.WebDemo.Workers();
		WebDemo.Model.WebDemo.Workers model=bll.GetModel(WorkerID);
		this.lblWorkerID.Text=model.WorkerID.ToString();
		this.lblWorkerName.Text=model.WorkerName;
		this.lblWorkerPhone.Text=model.WorkerPhone;
		this.lblRemark.Text=model.Remark;

	}


    }
}
