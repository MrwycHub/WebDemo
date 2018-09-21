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
namespace WebDemo.Web.WebDemo.ManageFareList
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
		
	private void ShowInfo()
	{
		WebDemo.BLL.WebDemo.ManageFareList bll=new WebDemo.BLL.WebDemo.ManageFareList();
		WebDemo.Model.WebDemo.ManageFareList model=bll.GetModel();
		this.lblUsersID.Text=model.UsersID.ToString();
		this.lblManageFareID.Text=model.ManageFareID.ToString();
		this.lblLastMonth.Text=model.LastMonth;
		this.lblThisMonth.Text=model.ThisMonth;
		this.lblManageFarePrice.Text=model.ManageFarePrice.ToString();
		this.lblOperMoney.Text=model.OperMoney.ToString();
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblOperDate.Text=model.OperDate.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblOperID.Text=model.OperID.ToString();
		this.lblOperType.Text=model.OperType.ToString();
		this.lblRcvFareNum.Text=model.RcvFareNum.ToString();

	}


    }
}
