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
namespace WebDemo.Web.WebDemo.Depts
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
					string DeptID= strid;
					ShowInfo(DeptID);
				}
			}
		}
		
	private void ShowInfo(string DeptID)
	{
		WebDemo.BLL.WebDemo.Depts bll=new WebDemo.BLL.WebDemo.Depts();
		WebDemo.Model.WebDemo.Depts model=bll.GetModel(DeptID);
		this.lblDeptID.Text=model.DeptID;
		this.lblDeptName.Text=model.DeptName;
		this.lblUpperDept.Text=model.UpperDept;
		this.lblAddress.Text=model.Address;
		this.lblimgIndex.Text=model.imgIndex.ToString();
		this.lblSelectimgIndex.Text=model.SelectimgIndex.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblCustomCode.Text=model.CustomCode;
		this.lblDeptType.Text=model.DeptType.ToString();
		this.lblLocationX.Text=model.LocationX.ToString();
		this.lblLocationY.Text=model.LocationY.ToString();
		this.lblUpdateTime.Text=model.UpdateTime.ToString();
		this.lblOrderNum.Text=model.OrderNum.ToString();

	}


    }
}
