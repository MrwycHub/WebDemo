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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int InvoiceID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(InvoiceID);
				}
			}
		}
			
	private void ShowInfo(int InvoiceID)
	{
		WebDemo.BLL.WebDemo.InvoiceLog bll=new WebDemo.BLL.WebDemo.InvoiceLog();
		WebDemo.Model.WebDemo.InvoiceLog model=bll.GetModel(InvoiceID);
		this.lblInvoiceID.Text=model.InvoiceID.ToString();
		this.txtInvoiceCode.Text=model.InvoiceCode.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int InvoiceID=int.Parse(this.lblInvoiceID.Text);
			int InvoiceCode=int.Parse(this.txtInvoiceCode.Text);


			WebDemo.Model.WebDemo.InvoiceLog model=new WebDemo.Model.WebDemo.InvoiceLog();
			model.InvoiceID=InvoiceID;
			model.InvoiceCode=InvoiceCode;

			WebDemo.BLL.WebDemo.InvoiceLog bll=new WebDemo.BLL.WebDemo.InvoiceLog();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
