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
namespace WebDemo.Web.WebDemo.FailureMessage
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
		WebDemo.BLL.WebDemo.FailureMessage bll=new WebDemo.BLL.WebDemo.FailureMessage();
		WebDemo.Model.WebDemo.FailureMessage model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblFailID.Text=model.FailID.ToString();
		this.lblType.Text=model.Type.ToString();
		this.lblFlag.Text=model.Flag.ToString();
		this.lblName.Text=model.Name;
		this.lblUpLoadTime.Text=model.UpLoadTime.ToString();
		this.lblSize.Text=model.Size;
		this.lblPattern.Text=model.Pattern;
		this.lblUrl.Text=model.Url;
		this.lblLocationX.Text=model.LocationX.ToString();
		this.lblLocationY.Text=model.LocationY.ToString();

	}


    }
}
