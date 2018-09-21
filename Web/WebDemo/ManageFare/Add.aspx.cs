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
namespace WebDemo.Web.WebDemo.ManageFare
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtManageFareName.Text.Trim().Length==0)
			{
				strErr+="ManageFareName不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtManageFarePrice.Text))
			{
				strErr+="ManageFarePrice格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtManageFareTypeID.Text))
			{
				strErr+="ManageFareTypeID格式错误！\\n";	
			}
			if(this.txtReMark.Text.Trim().Length==0)
			{
				strErr+="ReMark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSystemNum.Text))
			{
				strErr+="SystemNum格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ManageFareName=this.txtManageFareName.Text;
			decimal ManageFarePrice=decimal.Parse(this.txtManageFarePrice.Text);
			int ManageFareTypeID=int.Parse(this.txtManageFareTypeID.Text);
			string ReMark=this.txtReMark.Text;
			int SystemNum=int.Parse(this.txtSystemNum.Text);

			WebDemo.Model.WebDemo.ManageFare model=new WebDemo.Model.WebDemo.ManageFare();
			model.ManageFareName=ManageFareName;
			model.ManageFarePrice=ManageFarePrice;
			model.ManageFareTypeID=ManageFareTypeID;
			model.ReMark=ReMark;
			model.SystemNum=SystemNum;

			WebDemo.BLL.WebDemo.ManageFare bll=new WebDemo.BLL.WebDemo.ManageFare();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
