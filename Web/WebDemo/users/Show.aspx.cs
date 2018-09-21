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
namespace WebDemo.Web.WebDemo.users
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
					int UsersID=(Convert.ToInt32(strid));
					ShowInfo(UsersID);
				}
			}
		}
		
	private void ShowInfo(int UsersID)
	{
		WebDemo.BLL.WebDemo.users bll=new WebDemo.BLL.WebDemo.users();
		WebDemo.Model.WebDemo.users model=bll.GetModel(UsersID);
		this.lblUsersID.Text=model.UsersID.ToString();
		this.lblUserCode.Text=model.UserCode;
		this.lblUserName.Text=model.UserName;
		this.lblDoorplate.Text=model.Doorplate;
		this.lblPaperType.Text=model.PaperType;
		this.lblPaperNo.Text=model.PaperNo;
		this.lblAddress.Text=model.Address;
		this.lblPhone.Text=model.Phone;
		this.lblTel.Text=model.Tel;
		this.lblAcreage.Text=model.Acreage.ToString();
		this.lblChargeAcreage.Text=model.ChargeAcreage.ToString();
		this.lblReserve.Text=model.Reserve.ToString();
		this.lblSex.Text=model.Sex;
		this.lblPopulace.Text=model.Populace.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblMark.Text=model.Mark.ToString();
		this.lblDeptID.Text=model.DeptID;
		this.lblUserFloor.Text=model.UserFloor;
		this.lblHouseDir.Text=model.HouseDir;
		this.lblUserType.Text=model.UserType;
		this.lblClientId.Text=model.ClientId;
		this.lblRemnant.Text=model.Remnant.ToString();
		this.lblRemnant2.Text=model.Remnant2.ToString();
		this.lblRemnant3.Text=model.Remnant3.ToString();
		this.lblUpdateTime.Text=model.UpdateTime.ToString();
		this.lblRegistPhone.Text=model.RegistPhone;
		this.lblEInvoiceType.Text=model.EInvoiceType.ToString();

	}


    }
}
