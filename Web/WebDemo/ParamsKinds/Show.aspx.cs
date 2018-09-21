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
namespace WebDemo.Web.WebDemo.ParamsKinds
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
					int Pid=(Convert.ToInt32(strid));
					ShowInfo(Pid);
				}
			}
		}
		
	private void ShowInfo(int Pid)
	{
		WebDemo.BLL.WebDemo.ParamsKinds bll=new WebDemo.BLL.WebDemo.ParamsKinds();
		WebDemo.Model.WebDemo.ParamsKinds model=bll.GetModel(Pid);
		this.lblPid.Text=model.Pid.ToString();
		this.lblParamName.Text=model.ParamName;
		this.lblPTypeNum.Text=model.PTypeNum;
		this.lblPDisplayValue.Text=model.PDisplayValue;
		this.lblRemark.Text=model.Remark;
		this.lblFlag.Text=model.Flag.ToString();
		this.lblPTypeValue.Text=model.PTypeValue;

	}


    }
}
