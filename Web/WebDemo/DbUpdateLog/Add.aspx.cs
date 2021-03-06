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
namespace WebDemo.Web.WebDemo.DbUpdateLog
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtVer.Text.Trim().Length==0)
			{
				strErr+="Ver不能为空！\\n";	
			}
			if(this.txtUpdateContent.Text.Trim().Length==0)
			{
				strErr+="UpdateContent不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdateDate.Text))
			{
				strErr+="UpdateDate格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Ver=this.txtVer.Text;
			string UpdateContent=this.txtUpdateContent.Text;
			DateTime UpdateDate=DateTime.Parse(this.txtUpdateDate.Text);
			string Remark=this.txtRemark.Text;

			WebDemo.Model.WebDemo.DbUpdateLog model=new WebDemo.Model.WebDemo.DbUpdateLog();
			model.Ver=Ver;
			model.UpdateContent=UpdateContent;
			model.UpdateDate=UpdateDate;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.DbUpdateLog bll=new WebDemo.BLL.WebDemo.DbUpdateLog();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
