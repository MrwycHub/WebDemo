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
namespace WebDemo.Web.WebDemo.InvoiceGet
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int InID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(InID);
				}
			}
		}
			
	private void ShowInfo(int InID)
	{
		WebDemo.BLL.WebDemo.InvoiceGet bll=new WebDemo.BLL.WebDemo.InvoiceGet();
		WebDemo.Model.WebDemo.InvoiceGet model=bll.GetModel(InID);
		this.lblInID.Text=model.InID.ToString();
		this.txtInCode.Text=model.InCode;
		this.txtStartNum.Text=model.StartNum.ToString();
		this.txtEndNum.Text=model.EndNum.ToString();
		this.txtOperatorName.Text=model.OperatorName;
		this.txtInDate.Text=model.InDate.ToString();
		this.txtSiteID.Text=model.SiteID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtInCode.Text.Trim().Length==0)
			{
				strErr+="InCode不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtStartNum.Text))
			{
				strErr+="StartNum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtEndNum.Text))
			{
				strErr+="EndNum格式错误！\\n";	
			}
			if(this.txtOperatorName.Text.Trim().Length==0)
			{
				strErr+="OperatorName不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtInDate.Text))
			{
				strErr+="InDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSiteID.Text))
			{
				strErr+="SiteID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int InID=int.Parse(this.lblInID.Text);
			string InCode=this.txtInCode.Text;
			int StartNum=int.Parse(this.txtStartNum.Text);
			int EndNum=int.Parse(this.txtEndNum.Text);
			string OperatorName=this.txtOperatorName.Text;
			DateTime InDate=DateTime.Parse(this.txtInDate.Text);
			int SiteID=int.Parse(this.txtSiteID.Text);


			WebDemo.Model.WebDemo.InvoiceGet model=new WebDemo.Model.WebDemo.InvoiceGet();
			model.InID=InID;
			model.InCode=InCode;
			model.StartNum=StartNum;
			model.EndNum=EndNum;
			model.OperatorName=OperatorName;
			model.InDate=InDate;
			model.SiteID=SiteID;

			WebDemo.BLL.WebDemo.InvoiceGet bll=new WebDemo.BLL.WebDemo.InvoiceGet();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
