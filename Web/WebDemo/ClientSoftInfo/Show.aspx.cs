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
namespace WebDemo.Web.WebDemo.ClientSoftInfo
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
					int Id=(Convert.ToInt32(strid));
					ShowInfo(Id);
				}
			}
		}
		
	private void ShowInfo(int Id)
	{
		WebDemo.BLL.WebDemo.ClientSoftInfo bll=new WebDemo.BLL.WebDemo.ClientSoftInfo();
		WebDemo.Model.WebDemo.ClientSoftInfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblDanWeiName.Text=model.DanWeiName;
		this.lblJiQiMa.Text=model.JiQiMa;
		this.lblRenZhengMa.Text=model.RenZhengMa;
		this.lblSoftName.Text=model.SoftName;
		this.lblSoftHao.Text=model.SoftHao;
		this.lblUsePassword.Text=model.UsePassword;
		this.lblJieTiCalDate.Text=model.JieTiCalDate;
		this.lblSqlVersion.Text=model.SqlVersion.ToString();
		this.lblMeterTypes.Text=model.MeterTypes;
		this.lblCardTypes.Text=model.CardTypes;
		this.lblPayTypes.Text=model.PayTypes;
		this.lblUpdateTime.Text=model.UpdateTime.ToString();

	}


    }
}
