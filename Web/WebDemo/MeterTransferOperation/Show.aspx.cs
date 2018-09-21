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
namespace WebDemo.Web.WebDemo.MeterTransferOperation
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
		WebDemo.BLL.WebDemo.MeterTransferOperation bll=new WebDemo.BLL.WebDemo.MeterTransferOperation();
		WebDemo.Model.WebDemo.MeterTransferOperation model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblOldUserID.Text=model.OldUserID.ToString();
		this.lblOldUserName.Text=model.OldUserName;
		this.lblOldUserCode.Text=model.OldUserCode;
		this.lblOldLastReadNumber.Text=model.OldLastReadNumber.ToString();
		this.lblOldUserReserve.Text=model.OldUserReserve.ToString();
		this.lblNewUserID.Text=model.NewUserID.ToString();
		this.lblNewUserName.Text=model.NewUserName;
		this.lblNewUserCode.Text=model.NewUserCode;
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblBeginDate.Text=model.BeginDate.ToString();
		this.lblOperDateTime.Text=model.OperDateTime.ToString();

	}


    }
}
