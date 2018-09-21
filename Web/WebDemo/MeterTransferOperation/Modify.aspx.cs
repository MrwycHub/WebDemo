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
namespace WebDemo.Web.WebDemo.MeterTransferOperation
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		WebDemo.BLL.WebDemo.MeterTransferOperation bll=new WebDemo.BLL.WebDemo.MeterTransferOperation();
		WebDemo.Model.WebDemo.MeterTransferOperation model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtMeterID.Text=model.MeterID.ToString();
		this.txtOldUserID.Text=model.OldUserID.ToString();
		this.txtOldUserName.Text=model.OldUserName;
		this.txtOldUserCode.Text=model.OldUserCode;
		this.txtOldLastReadNumber.Text=model.OldLastReadNumber.ToString();
		this.txtOldUserReserve.Text=model.OldUserReserve.ToString();
		this.txtNewUserID.Text=model.NewUserID.ToString();
		this.txtNewUserName.Text=model.NewUserName;
		this.txtNewUserCode.Text=model.NewUserCode;
		this.txtOperatorID.Text=model.OperatorID.ToString();
		this.txtBeginDate.Text=model.BeginDate.ToString();
		this.txtOperDateTime.Text=model.OperDateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMeterID.Text))
			{
				strErr+="MeterID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOldUserID.Text))
			{
				strErr+="OldUserID格式错误！\\n";	
			}
			if(this.txtOldUserName.Text.Trim().Length==0)
			{
				strErr+="OldUserName不能为空！\\n";	
			}
			if(this.txtOldUserCode.Text.Trim().Length==0)
			{
				strErr+="OldUserCode不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtOldLastReadNumber.Text))
			{
				strErr+="OldLastReadNumber格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtOldUserReserve.Text))
			{
				strErr+="OldUserReserve格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtNewUserID.Text))
			{
				strErr+="NewUserID格式错误！\\n";	
			}
			if(this.txtNewUserName.Text.Trim().Length==0)
			{
				strErr+="NewUserName不能为空！\\n";	
			}
			if(this.txtNewUserCode.Text.Trim().Length==0)
			{
				strErr+="NewUserCode不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBeginDate.Text))
			{
				strErr+="BeginDate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperDateTime.Text))
			{
				strErr+="OperDateTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			int MeterID=int.Parse(this.txtMeterID.Text);
			int OldUserID=int.Parse(this.txtOldUserID.Text);
			string OldUserName=this.txtOldUserName.Text;
			string OldUserCode=this.txtOldUserCode.Text;
			decimal OldLastReadNumber=decimal.Parse(this.txtOldLastReadNumber.Text);
			decimal OldUserReserve=decimal.Parse(this.txtOldUserReserve.Text);
			int NewUserID=int.Parse(this.txtNewUserID.Text);
			string NewUserName=this.txtNewUserName.Text;
			string NewUserCode=this.txtNewUserCode.Text;
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			DateTime BeginDate=DateTime.Parse(this.txtBeginDate.Text);
			DateTime OperDateTime=DateTime.Parse(this.txtOperDateTime.Text);


			WebDemo.Model.WebDemo.MeterTransferOperation model=new WebDemo.Model.WebDemo.MeterTransferOperation();
			model.ID=ID;
			model.MeterID=MeterID;
			model.OldUserID=OldUserID;
			model.OldUserName=OldUserName;
			model.OldUserCode=OldUserCode;
			model.OldLastReadNumber=OldLastReadNumber;
			model.OldUserReserve=OldUserReserve;
			model.NewUserID=NewUserID;
			model.NewUserName=NewUserName;
			model.NewUserCode=NewUserCode;
			model.OperatorID=OperatorID;
			model.BeginDate=BeginDate;
			model.OperDateTime=OperDateTime;

			WebDemo.BLL.WebDemo.MeterTransferOperation bll=new WebDemo.BLL.WebDemo.MeterTransferOperation();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
