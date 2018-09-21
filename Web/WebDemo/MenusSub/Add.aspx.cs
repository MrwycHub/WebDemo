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
namespace WebDemo.Web.WebDemo.MenusSub
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMenuID.Text))
			{
				strErr+="MenuID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUpperID.Text))
			{
				strErr+="UpperID格式错误！\\n";	
			}
			if(this.txtMenuName.Text.Trim().Length==0)
			{
				strErr+="MenuName不能为空！\\n";	
			}
			if(this.txtUrlAddr.Text.Trim().Length==0)
			{
				strErr+="UrlAddr不能为空！\\n";	
			}
			if(this.txtUrlTarget.Text.Trim().Length==0)
			{
				strErr+="UrlTarget不能为空！\\n";	
			}
			if(this.txtImageUrl.Text.Trim().Length==0)
			{
				strErr+="ImageUrl不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFlag.Text))
			{
				strErr+="Flag格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrdernum.Text))
			{
				strErr+="Ordernum格式错误！\\n";	
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
			int MenuID=int.Parse(this.txtMenuID.Text);
			int UpperID=int.Parse(this.txtUpperID.Text);
			string MenuName=this.txtMenuName.Text;
			string UrlAddr=this.txtUrlAddr.Text;
			string UrlTarget=this.txtUrlTarget.Text;
			string ImageUrl=this.txtImageUrl.Text;
			int Flag=int.Parse(this.txtFlag.Text);
			int Ordernum=int.Parse(this.txtOrdernum.Text);
			int SystemNum=int.Parse(this.txtSystemNum.Text);

			WebDemo.Model.WebDemo.MenusSub model=new WebDemo.Model.WebDemo.MenusSub();
			model.MenuID=MenuID;
			model.UpperID=UpperID;
			model.MenuName=MenuName;
			model.UrlAddr=UrlAddr;
			model.UrlTarget=UrlTarget;
			model.ImageUrl=ImageUrl;
			model.Flag=Flag;
			model.Ordernum=Ordernum;
			model.SystemNum=SystemNum;

			WebDemo.BLL.WebDemo.MenusSub bll=new WebDemo.BLL.WebDemo.MenusSub();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
