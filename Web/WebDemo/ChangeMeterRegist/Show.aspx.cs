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
namespace WebDemo.Web.WebDemo.ChangeMeterRegist
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
		WebDemo.BLL.WebDemo.ChangeMeterRegist bll=new WebDemo.BLL.WebDemo.ChangeMeterRegist();
		WebDemo.Model.WebDemo.ChangeMeterRegist model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblUsersID.Text=model.UsersID.ToString();
		this.lblUserCode.Text=model.UserCode;
		this.lblOldNumber.Text=model.OldNumber.ToString();
		this.lblNewMeterAddr.Text=model.NewMeterAddr;
		this.lblRemark.Text=model.Remark;
		this.lblStatus.Text=model.Status.ToString();
		this.lblImagePath.Text=model.ImagePath;
		this.lblOperatorCode.Text=model.OperatorCode;
		this.lblNewNumber.Text=model.NewNumber.ToString();
		this.lblNewMeterId.Text=model.NewMeterId.ToString();
		this.lblInsertDate.Text=model.InsertDate.ToString();
		this.lblChangeMeterDate.Text=model.ChangeMeterDate.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();

	}


    }
}
