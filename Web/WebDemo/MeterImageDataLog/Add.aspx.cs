﻿using System;
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
namespace WebDemo.Web.WebDemo.MeterImageDataLog
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMeterID.Text))
			{
				strErr+="MeterID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtReadTime.Text))
			{
				strErr+="ReadTime格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtVoltage.Text))
			{
				strErr+="Voltage格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtValveState.Text))
			{
				strErr+="ValveState格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtImageQuality.Text))
			{
				strErr+="ImageQuality格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtInsertDate.Text))
			{
				strErr+="InsertDate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFreezeNumber.Text))
			{
				strErr+="FreezeNumber格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MeterID=int.Parse(this.txtMeterID.Text);
			DateTime ReadTime=DateTime.Parse(this.txtReadTime.Text);
			decimal Voltage=decimal.Parse(this.txtVoltage.Text);
			int ValveState=int.Parse(this.txtValveState.Text);
			bool LowVoltage=this.chkLowVoltage.Checked;
			bool MagneticDisturb=this.chkMagneticDisturb.Checked;
			int ImageQuality=int.Parse(this.txtImageQuality.Text);
			bool EnableUpload=this.chkEnableUpload.Checked;
			byte[] MeterImage= new UnicodeEncoding().GetBytes(this.txtMeterImage.Text);
			DateTime InsertDate=DateTime.Parse(this.txtInsertDate.Text);
			decimal FreezeNumber=decimal.Parse(this.txtFreezeNumber.Text);
			byte[] LeftMeterImage= new UnicodeEncoding().GetBytes(this.txtLeftMeterImage.Text);
			byte[] RightMeterImage= new UnicodeEncoding().GetBytes(this.txtRightMeterImage.Text);

			WebDemo.Model.WebDemo.MeterImageDataLog model=new WebDemo.Model.WebDemo.MeterImageDataLog();
			model.MeterID=MeterID;
			model.ReadTime=ReadTime;
			model.Voltage=Voltage;
			model.ValveState=ValveState;
			model.LowVoltage=LowVoltage;
			model.MagneticDisturb=MagneticDisturb;
			model.ImageQuality=ImageQuality;
			model.EnableUpload=EnableUpload;
			model.MeterImage=MeterImage;
			model.InsertDate=InsertDate;
			model.FreezeNumber=FreezeNumber;
			model.LeftMeterImage=LeftMeterImage;
			model.RightMeterImage=RightMeterImage;

			WebDemo.BLL.WebDemo.MeterImageDataLog bll=new WebDemo.BLL.WebDemo.MeterImageDataLog();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
