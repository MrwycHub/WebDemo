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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMeterId.Text))
			{
				strErr+="MeterId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCameraNo.Text))
			{
				strErr+="CameraNo格式错误！\\n";	
			}
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
			int MeterId=int.Parse(this.txtMeterId.Text);
			int CameraNo=int.Parse(this.txtCameraNo.Text);
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
