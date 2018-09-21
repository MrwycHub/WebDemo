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
namespace WebDemo.Web.WebDemo.UserRegist
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
		WebDemo.BLL.WebDemo.UserRegist bll=new WebDemo.BLL.WebDemo.UserRegist();
		WebDemo.Model.WebDemo.UserRegist model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblRegistPhone.Text=model.RegistPhone;
		this.lblPassWord.Text=model.PassWord;
		this.lblIdentityCard.Text=model.IdentityCard;
		this.lblFlag.Text=model.Flag.ToString();
		this.lblRegistName.Text=model.RegistName;
		this.lblHeadImgPath.Text=model.HeadImgPath;
		this.lblUpdateTime.Text=model.UpdateTime.ToString();
		this.lblSecurityId.Text=model.SecurityId.ToString();
		this.lblSecurityAnswer.Text=model.SecurityAnswer;
		this.lblRandomStr.Text=model.RandomStr;
		this.lblAppType.Text=model.AppType.ToString();
		this.lblPayIntegration.Text=model.PayIntegration.ToString();
		this.lblTotalMoney.Text=model.TotalMoney.ToString();

	}


    }
}
