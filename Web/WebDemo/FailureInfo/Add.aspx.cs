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
namespace WebDemo.Web.WebDemo.FailureInfo
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
			if(this.txtFailurePhone.Text.Trim().Length==0)
			{
				strErr+="FailurePhone不能为空！\\n";	
			}
			if(this.txtFailureMan.Text.Trim().Length==0)
			{
				strErr+="FailureMan不能为空！\\n";	
			}
			if(this.txtFailureMemo.Text.Trim().Length==0)
			{
				strErr+="FailureMemo不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFailureType.Text))
			{
				strErr+="FailureType格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtFailureRegTime.Text))
			{
				strErr+="FailureRegTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFailureRegType.Text))
			{
				strErr+="FailureRegType格式错误！\\n";	
			}
			if(this.txtDisposeMan.Text.Trim().Length==0)
			{
				strErr+="DisposeMan不能为空！\\n";	
			}
			if(this.txtDisposeMemo.Text.Trim().Length==0)
			{
				strErr+="DisposeMemo不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtDisposeStatus.Text))
			{
				strErr+="DisposeStatus格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDisposeTime.Text))
			{
				strErr+="DisposeTime格式错误！\\n";	
			}
			if(this.txtFailureCode.Text.Trim().Length==0)
			{
				strErr+="FailureCode不能为空！\\n";	
			}
			if(this.txtAppointMan.Text.Trim().Length==0)
			{
				strErr+="AppointMan不能为空！\\n";	
			}
			if(this.txtAppointManPhone.Text.Trim().Length==0)
			{
				strErr+="AppointManPhone不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFailureSort.Text))
			{
				strErr+="FailureSort格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUsersID.Text))
			{
				strErr+="UsersID格式错误！\\n";	
			}
			if(this.txtUserCode.Text.Trim().Length==0)
			{
				strErr+="UserCode不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MeterID=int.Parse(this.txtMeterID.Text);
			string FailurePhone=this.txtFailurePhone.Text;
			string FailureMan=this.txtFailureMan.Text;
			string FailureMemo=this.txtFailureMemo.Text;
			int FailureType=int.Parse(this.txtFailureType.Text);
			DateTime FailureRegTime=DateTime.Parse(this.txtFailureRegTime.Text);
			int FailureRegType=int.Parse(this.txtFailureRegType.Text);
			string DisposeMan=this.txtDisposeMan.Text;
			string DisposeMemo=this.txtDisposeMemo.Text;
			int DisposeStatus=int.Parse(this.txtDisposeStatus.Text);
			DateTime DisposeTime=DateTime.Parse(this.txtDisposeTime.Text);
			bool sel=this.chksel.Checked;
			string FailureCode=this.txtFailureCode.Text;
			string AppointMan=this.txtAppointMan.Text;
			string AppointManPhone=this.txtAppointManPhone.Text;
			int FailureSort=int.Parse(this.txtFailureSort.Text);
			int UsersID=int.Parse(this.txtUsersID.Text);
			string UserCode=this.txtUserCode.Text;

			WebDemo.Model.WebDemo.FailureInfo model=new WebDemo.Model.WebDemo.FailureInfo();
			model.MeterID=MeterID;
			model.FailurePhone=FailurePhone;
			model.FailureMan=FailureMan;
			model.FailureMemo=FailureMemo;
			model.FailureType=FailureType;
			model.FailureRegTime=FailureRegTime;
			model.FailureRegType=FailureRegType;
			model.DisposeMan=DisposeMan;
			model.DisposeMemo=DisposeMemo;
			model.DisposeStatus=DisposeStatus;
			model.DisposeTime=DisposeTime;
			model.sel=sel;
			model.FailureCode=FailureCode;
			model.AppointMan=AppointMan;
			model.AppointManPhone=AppointManPhone;
			model.FailureSort=FailureSort;
			model.UsersID=UsersID;
			model.UserCode=UserCode;

			WebDemo.BLL.WebDemo.FailureInfo bll=new WebDemo.BLL.WebDemo.FailureInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
