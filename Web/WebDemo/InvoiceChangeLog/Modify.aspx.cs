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
namespace WebDemo.Web.WebDemo.InvoiceChangeLog
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
		WebDemo.BLL.WebDemo.InvoiceChangeLog bll=new WebDemo.BLL.WebDemo.InvoiceChangeLog();
		WebDemo.Model.WebDemo.InvoiceChangeLog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtInvoiceNum.Text=model.InvoiceNum;
		this.txtOldOperator.Text=model.OldOperator;
		this.txtNewOperator.Text=model.NewOperator;
		this.txtChangeDate.Text=model.ChangeDate.ToString();
		this.txtRemark.Text=model.Remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtInvoiceNum.Text.Trim().Length==0)
			{
				strErr+="InvoiceNum不能为空！\\n";	
			}
			if(this.txtOldOperator.Text.Trim().Length==0)
			{
				strErr+="OldOperator不能为空！\\n";	
			}
			if(this.txtNewOperator.Text.Trim().Length==0)
			{
				strErr+="NewOperator不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtChangeDate.Text))
			{
				strErr+="ChangeDate格式错误！\\n";	
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
			int ID=int.Parse(this.lblID.Text);
			string InvoiceNum=this.txtInvoiceNum.Text;
			string OldOperator=this.txtOldOperator.Text;
			string NewOperator=this.txtNewOperator.Text;
			DateTime ChangeDate=DateTime.Parse(this.txtChangeDate.Text);
			string Remark=this.txtRemark.Text;


			WebDemo.Model.WebDemo.InvoiceChangeLog model=new WebDemo.Model.WebDemo.InvoiceChangeLog();
			model.ID=ID;
			model.InvoiceNum=InvoiceNum;
			model.OldOperator=OldOperator;
			model.NewOperator=NewOperator;
			model.ChangeDate=ChangeDate;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.InvoiceChangeLog bll=new WebDemo.BLL.WebDemo.InvoiceChangeLog();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
