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
namespace WebDemo.Web.WebDemo.InvoiceLog
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtInvoiceCode.Text))
			{
				strErr+="InvoiceCode格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int InvoiceCode=int.Parse(this.txtInvoiceCode.Text);

			WebDemo.Model.WebDemo.InvoiceLog model=new WebDemo.Model.WebDemo.InvoiceLog();
			model.InvoiceCode=InvoiceCode;

			WebDemo.BLL.WebDemo.InvoiceLog bll=new WebDemo.BLL.WebDemo.InvoiceLog();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
