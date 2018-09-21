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
namespace WebDemo.Web.WebDemo.ManageUser
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				int UsersID = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					UsersID=(Convert.ToInt32(Request.Params["id0"]));
				}
				string ManageFareID = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					ManageFareID= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(UsersID,ManageFareID);
			}
		}
		
	private void ShowInfo(int UsersID,string ManageFareID)
	{
		WebDemo.BLL.WebDemo.ManageUser bll=new WebDemo.BLL.WebDemo.ManageUser();
		WebDemo.Model.WebDemo.ManageUser model=bll.GetModel(UsersID,ManageFareID);
		this.lblUsersID.Text=model.UsersID.ToString();
		this.lblManageFareID.Text=model.ManageFareID;
		this.lblChargeDate.Text=model.ChargeDate.ToString();
		this.lblLastDate.Text=model.LastDate.ToString();
		this.lblReMark.Text=model.ReMark;
		this.lblStatus.Text=model.Status.ToString();

	}


    }
}
