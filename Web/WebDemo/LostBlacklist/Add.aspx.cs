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
namespace WebDemo.Web.WebDemo.LostBlacklist
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtSaveNo.Text))
			{
				strErr+="SaveNo格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCardID.Text))
			{
				strErr+="CardID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLostDate.Text))
			{
				strErr+="LostDate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int SaveNo=int.Parse(this.txtSaveNo.Text);
			int CardID=int.Parse(this.txtCardID.Text);
			DateTime LostDate=DateTime.Parse(this.txtLostDate.Text);

			WebDemo.Model.WebDemo.LostBlacklist model=new WebDemo.Model.WebDemo.LostBlacklist();
			model.SaveNo=SaveNo;
			model.CardID=CardID;
			model.LostDate=LostDate;

			WebDemo.BLL.WebDemo.LostBlacklist bll=new WebDemo.BLL.WebDemo.LostBlacklist();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
