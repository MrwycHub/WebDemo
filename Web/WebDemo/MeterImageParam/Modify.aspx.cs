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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace WebDemo.Web.WebDemo.MeterImageParam
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int Id=(Convert.ToInt32(Request.Params["id"]));
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
		this.txtNumberCount.Text=model.NumberCount.ToString();
		this.txtCaptureStartPixs.Text=model.CaptureStartPixs.ToString();
		this.txtUpClipPixs.Text=model.UpClipPixs.ToString();
		this.txtDownClipPixs.Text=model.DownClipPixs.ToString();
		this.txtLeftClipPixs.Text=model.LeftClipPixs.ToString();
		this.txtRightClipPixs.Text=model.RightClipPixs.ToString();
		this.txtCircumgyrateDegree.Text=model.CircumgyrateDegree.ToString();
		this.txtInclineDegree.Text=model.InclineDegree.ToString();
		this.txtModelHeight.Text=model.ModelHeight.ToString();
		this.txtModelWidth.Text=model.ModelWidth.ToString();
		this.txtModelOneWidth.Text=model.ModelOneWidth.ToString();
		this.txtNumberSpace.Text=model.NumberSpace.ToString();
		this.txtBitValueLimen.Text=model.BitValueLimen.ToString();
		this.txtBitValueRadius.Text=model.BitValueRadius.ToString();
		this.txtBitValueBlackProportion.Text=model.BitValueBlackProportion.ToString();
		this.txtMorphologicFilterParam.Text=model.MorphologicFilterParam.ToString();
		this.txtSearchlimitParam.Text=model.SearchlimitParam.ToString();
		this.txtWindowHeight.Text=model.WindowHeight.ToString();
		this.txtLastOperDate.Text=model.LastOperDate.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtNumberCount.Text))
			{
				strErr+="NumberCount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCaptureStartPixs.Text))
			{
				strErr+="CaptureStartPixs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUpClipPixs.Text))
			{
				strErr+="UpClipPixs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDownClipPixs.Text))
			{
				strErr+="DownClipPixs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtLeftClipPixs.Text))
			{
				strErr+="LeftClipPixs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtRightClipPixs.Text))
			{
				strErr+="RightClipPixs格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCircumgyrateDegree.Text))
			{
				strErr+="CircumgyrateDegree格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtInclineDegree.Text))
			{
				strErr+="InclineDegree格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtModelHeight.Text))
			{
				strErr+="ModelHeight格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtModelWidth.Text))
			{
				strErr+="ModelWidth格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtModelOneWidth.Text))
			{
				strErr+="ModelOneWidth格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtNumberSpace.Text))
			{
				strErr+="NumberSpace格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtBitValueLimen.Text))
			{
				strErr+="BitValueLimen格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtBitValueRadius.Text))
			{
				strErr+="BitValueRadius格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtBitValueBlackProportion.Text))
			{
				strErr+="BitValueBlackProportion格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMorphologicFilterParam.Text))
			{
				strErr+="MorphologicFilterParam格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSearchlimitParam.Text))
			{
				strErr+="SearchlimitParam格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtWindowHeight.Text))
			{
				strErr+="WindowHeight格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLastOperDate.Text))
			{
				strErr+="LastOperDate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			int MeterId=int.Parse(this.lblMeterId.Text);
			int CameraNo=int.Parse(this.lblCameraNo.Text);
			int NumberCount=int.Parse(this.txtNumberCount.Text);
			int CaptureStartPixs=int.Parse(this.txtCaptureStartPixs.Text);
			int UpClipPixs=int.Parse(this.txtUpClipPixs.Text);
			int DownClipPixs=int.Parse(this.txtDownClipPixs.Text);
			int LeftClipPixs=int.Parse(this.txtLeftClipPixs.Text);
			int RightClipPixs=int.Parse(this.txtRightClipPixs.Text);
			int CircumgyrateDegree=int.Parse(this.txtCircumgyrateDegree.Text);
			int InclineDegree=int.Parse(this.txtInclineDegree.Text);
			int ModelHeight=int.Parse(this.txtModelHeight.Text);
			int ModelWidth=int.Parse(this.txtModelWidth.Text);
			int ModelOneWidth=int.Parse(this.txtModelOneWidth.Text);
			int NumberSpace=int.Parse(this.txtNumberSpace.Text);
			int BitValueLimen=int.Parse(this.txtBitValueLimen.Text);
			int BitValueRadius=int.Parse(this.txtBitValueRadius.Text);
			int BitValueBlackProportion=int.Parse(this.txtBitValueBlackProportion.Text);
			int MorphologicFilterParam=int.Parse(this.txtMorphologicFilterParam.Text);
			int SearchlimitParam=int.Parse(this.txtSearchlimitParam.Text);
			int WindowHeight=int.Parse(this.txtWindowHeight.Text);
			DateTime LastOperDate=DateTime.Parse(this.txtLastOperDate.Text);


			WebDemo.Model.WebDemo.MeterImageParam model=new WebDemo.Model.WebDemo.MeterImageParam();
			model.Id=Id;
			model.MeterId=MeterId;
			model.CameraNo=CameraNo;
			model.NumberCount=NumberCount;
			model.CaptureStartPixs=CaptureStartPixs;
			model.UpClipPixs=UpClipPixs;
			model.DownClipPixs=DownClipPixs;
			model.LeftClipPixs=LeftClipPixs;
			model.RightClipPixs=RightClipPixs;
			model.CircumgyrateDegree=CircumgyrateDegree;
			model.InclineDegree=InclineDegree;
			model.ModelHeight=ModelHeight;
			model.ModelWidth=ModelWidth;
			model.ModelOneWidth=ModelOneWidth;
			model.NumberSpace=NumberSpace;
			model.BitValueLimen=BitValueLimen;
			model.BitValueRadius=BitValueRadius;
			model.BitValueBlackProportion=BitValueBlackProportion;
			model.MorphologicFilterParam=MorphologicFilterParam;
			model.SearchlimitParam=SearchlimitParam;
			model.WindowHeight=WindowHeight;
			model.LastOperDate=LastOperDate;

			WebDemo.BLL.WebDemo.MeterImageParam bll=new WebDemo.BLL.WebDemo.MeterImageParam();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
