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
namespace WebDemo.Web.WebDemo.MultiUser
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
					int MultiUserID=(Convert.ToInt32(strid));
					ShowInfo(MultiUserID);
				}
			}
		}
		
	private void ShowInfo(int MultiUserID)
	{
		WebDemo.BLL.WebDemo.MultiUser bll=new WebDemo.BLL.WebDemo.MultiUser();
		WebDemo.Model.WebDemo.MultiUser model=bll.GetModel(MultiUserID);
		this.lblMultiUserID.Text=model.MultiUserID.ToString();
		this.lblUserCode.Text=model.UserCode;
		this.lblUserName.Text=model.UserName;
		this.lblDeptID.Text=model.DeptID;
		this.lblCardId.Text=model.CardId.ToString();
		this.lblCardSector.Text=model.CardSector.ToString();
		this.lblCardSn.Text=model.CardSn;
		this.lblMark.Text=model.Mark.ToString();
		this.lblSex.Text=model.Sex;
		this.lblPhone.Text=model.Phone;
		this.lblPaperType.Text=model.PaperType.ToString();
		this.lblPaperNo.Text=model.PaperNo;
		this.lbluAccount.Text=model.uAccount;
		this.lblOpenTime.Text=model.OpenTime.ToString();
		this.lblValidDate.Text=model.ValidDate.ToString();
		this.lblLastMoney.Text=model.LastMoney.ToString();
		this.lblTotalMoney.Text=model.TotalMoney.ToString();
		this.lblReMark.Text=model.ReMark;

	}


    }
}
