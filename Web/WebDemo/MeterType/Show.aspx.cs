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
namespace WebDemo.Web.WebDemo.MeterType
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
					int MeterTypeID=(Convert.ToInt32(strid));
					ShowInfo(MeterTypeID);
				}
			}
		}
		
	private void ShowInfo(int MeterTypeID)
	{
		WebDemo.BLL.WebDemo.MeterType bll=new WebDemo.BLL.WebDemo.MeterType();
		WebDemo.Model.WebDemo.MeterType model=bll.GetModel(MeterTypeID);
		this.lblMeterTypeID.Text=model.MeterTypeID.ToString();
		this.lblMeterTypeName.Text=model.MeterTypeName;
		this.lblRemark.Text=model.Remark;
		this.lblFlag.Text=model.Flag.ToString();

	}


    }
}
