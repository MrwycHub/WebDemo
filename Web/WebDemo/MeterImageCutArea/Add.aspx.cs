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
namespace WebDemo.Web.WebDemo.MeterImageCutArea
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
			if(!PageValidate.IsNumber(txtCutLocationX.Text))
			{
				strErr+="CutLocationX格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCutLocationY.Text))
			{
				strErr+="CutLocationY格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCutWidth.Text))
			{
				strErr+="CutWidth格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCutHeight.Text))
			{
				strErr+="CutHeight格式错误！\\n";	
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
			int CutLocationX=int.Parse(this.txtCutLocationX.Text);
			int CutLocationY=int.Parse(this.txtCutLocationY.Text);
			int CutWidth=int.Parse(this.txtCutWidth.Text);
			int CutHeight=int.Parse(this.txtCutHeight.Text);
			DateTime LastOperDate=DateTime.Parse(this.txtLastOperDate.Text);

			WebDemo.Model.WebDemo.MeterImageCutArea model=new WebDemo.Model.WebDemo.MeterImageCutArea();
			model.MeterId=MeterId;
			model.CameraNo=CameraNo;
			model.CutLocationX=CutLocationX;
			model.CutLocationY=CutLocationY;
			model.CutWidth=CutWidth;
			model.CutHeight=CutHeight;
			model.LastOperDate=LastOperDate;

			WebDemo.BLL.WebDemo.MeterImageCutArea bll=new WebDemo.BLL.WebDemo.MeterImageCutArea();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
