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
namespace WebDemo.Web.WebDemo.MeterImageParam
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
		WebDemo.BLL.WebDemo.MeterImageParam bll=new WebDemo.BLL.WebDemo.MeterImageParam();
		WebDemo.Model.WebDemo.MeterImageParam model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblMeterId.Text=model.MeterId.ToString();
		this.lblCameraNo.Text=model.CameraNo.ToString();
		this.lblNumberCount.Text=model.NumberCount.ToString();
		this.lblCaptureStartPixs.Text=model.CaptureStartPixs.ToString();
		this.lblUpClipPixs.Text=model.UpClipPixs.ToString();
		this.lblDownClipPixs.Text=model.DownClipPixs.ToString();
		this.lblLeftClipPixs.Text=model.LeftClipPixs.ToString();
		this.lblRightClipPixs.Text=model.RightClipPixs.ToString();
		this.lblCircumgyrateDegree.Text=model.CircumgyrateDegree.ToString();
		this.lblInclineDegree.Text=model.InclineDegree.ToString();
		this.lblModelHeight.Text=model.ModelHeight.ToString();
		this.lblModelWidth.Text=model.ModelWidth.ToString();
		this.lblModelOneWidth.Text=model.ModelOneWidth.ToString();
		this.lblNumberSpace.Text=model.NumberSpace.ToString();
		this.lblBitValueLimen.Text=model.BitValueLimen.ToString();
		this.lblBitValueRadius.Text=model.BitValueRadius.ToString();
		this.lblBitValueBlackProportion.Text=model.BitValueBlackProportion.ToString();
		this.lblMorphologicFilterParam.Text=model.MorphologicFilterParam.ToString();
		this.lblSearchlimitParam.Text=model.SearchlimitParam.ToString();
		this.lblWindowHeight.Text=model.WindowHeight.ToString();
		this.lblLastOperDate.Text=model.LastOperDate.ToString();

	}


    }
}
