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
namespace WebDemo.Web.WebDemo.Menus
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
					int MenuID=(Convert.ToInt32(strid));
					ShowInfo(MenuID);
				}
			}
		}
		
	private void ShowInfo(int MenuID)
	{
		WebDemo.BLL.WebDemo.Menus bll=new WebDemo.BLL.WebDemo.Menus();
		WebDemo.Model.WebDemo.Menus model=bll.GetModel(MenuID);
		this.lblMenuID.Text=model.MenuID.ToString();
		this.lblUpperID.Text=model.UpperID.ToString();
		this.lblMenuName.Text=model.MenuName;
		this.lblUrlAddr.Text=model.UrlAddr;
		this.lblUrlTarget.Text=model.UrlTarget;
		this.lblImageUrl.Text=model.ImageUrl;
		this.lblFlag.Text=model.Flag.ToString();
		this.lblOrdernum.Text=model.Ordernum.ToString();
		this.lblSystemNum.Text=model.SystemNum.ToString();
		this.lblPayType.Text=model.PayType;
		this.lblReMark.Text=model.ReMark;
		this.lblPayTypeBak.Text=model.PayTypeBak;

	}


    }
}
