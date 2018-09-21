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
namespace WebDemo.Web.WebDemo.DeptUser
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string OperatorCode = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					OperatorCode= Request.Params["id0"];
				}
				string DeptID = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					DeptID= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(OperatorCode,DeptID);
			}
		}
		
	private void ShowInfo(string OperatorCode,string DeptID)
	{
		WebDemo.BLL.WebDemo.DeptUser bll=new WebDemo.BLL.WebDemo.DeptUser();
		WebDemo.Model.WebDemo.DeptUser model=bll.GetModel(OperatorCode,DeptID);
		this.lblOperatorCode.Text=model.OperatorCode;
		this.lblDeptID.Text=model.DeptID;

	}


    }
}
