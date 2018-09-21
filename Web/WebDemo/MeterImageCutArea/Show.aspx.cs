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
namespace WebDemo.Web.WebDemo.MeterImageCutArea
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
		WebDemo.BLL.WebDemo.MeterImageCutArea bll=new WebDemo.BLL.WebDemo.MeterImageCutArea();
		WebDemo.Model.WebDemo.MeterImageCutArea model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblMeterId.Text=model.MeterId.ToString();
		this.lblCameraNo.Text=model.CameraNo.ToString();
		this.lblCutLocationX.Text=model.CutLocationX.ToString();
		this.lblCutLocationY.Text=model.CutLocationY.ToString();
		this.lblCutWidth.Text=model.CutWidth.ToString();
		this.lblCutHeight.Text=model.CutHeight.ToString();
		this.lblLastOperDate.Text=model.LastOperDate.ToString();

	}


    }
}
