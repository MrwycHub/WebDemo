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
namespace WebDemo.Web.WebDemo.FailureInfo
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
		WebDemo.BLL.WebDemo.FailureInfo bll=new WebDemo.BLL.WebDemo.FailureInfo();
		WebDemo.Model.WebDemo.FailureInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblFailurePhone.Text=model.FailurePhone;
		this.lblFailureMan.Text=model.FailureMan;
		this.lblFailureMemo.Text=model.FailureMemo;
		this.lblFailureType.Text=model.FailureType.ToString();
		this.lblFailureRegTime.Text=model.FailureRegTime.ToString();
		this.lblFailureRegType.Text=model.FailureRegType.ToString();
		this.lblDisposeMan.Text=model.DisposeMan;
		this.lblDisposeMemo.Text=model.DisposeMemo;
		this.lblDisposeStatus.Text=model.DisposeStatus.ToString();
		this.lblDisposeTime.Text=model.DisposeTime.ToString();
		this.lblsel.Text=model.sel?"是":"否";
		this.lblFailureCode.Text=model.FailureCode;
		this.lblAppointMan.Text=model.AppointMan;
		this.lblAppointManPhone.Text=model.AppointManPhone;
		this.lblFailureSort.Text=model.FailureSort.ToString();
		this.lblUsersID.Text=model.UsersID.ToString();
		this.lblUserCode.Text=model.UserCode;

	}


    }
}
