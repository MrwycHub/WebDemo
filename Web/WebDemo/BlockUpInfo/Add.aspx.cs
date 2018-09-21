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
namespace WebDemo.Web.WebDemo.BlockUpInfo
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
			if(!PageValidate.IsNumber(txtStopYear.Text))
			{
				strErr+="StopYear格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperDate.Text))
			{
				strErr+="OperDate格式错误！\\n";	
			}
			if(this.txtStopReason.Text.Trim().Length==0)
			{
				strErr+="StopReason不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MeterID=int.Parse(this.txtMeterID.Text);
			int StopYear=int.Parse(this.txtStopYear.Text);
			DateTime OperDate=DateTime.Parse(this.txtOperDate.Text);
			string StopReason=this.txtStopReason.Text;
			int OperatorID=int.Parse(this.txtOperatorID.Text);

			WebDemo.Model.WebDemo.BlockUpInfo model=new WebDemo.Model.WebDemo.BlockUpInfo();
			model.MeterID=MeterID;
			model.StopYear=StopYear;
			model.OperDate=OperDate;
			model.StopReason=StopReason;
			model.OperatorID=OperatorID;

			WebDemo.BLL.WebDemo.BlockUpInfo bll=new WebDemo.BLL.WebDemo.BlockUpInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
