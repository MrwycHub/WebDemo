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
namespace WebDemo.Web.WebDemo.InvoiceRangeInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int BatchId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(BatchId);
				}
			}
		}
			
	private void ShowInfo(int BatchId)
	{
		WebDemo.BLL.WebDemo.InvoiceRangeInfo bll=new WebDemo.BLL.WebDemo.InvoiceRangeInfo();
		WebDemo.Model.WebDemo.InvoiceRangeInfo model=bll.GetModel(BatchId);
		this.lblBatchId.Text=model.BatchId.ToString();
		this.txtInCode.Text=model.InCode;
		this.txtStartNum.Text=model.StartNum;
		this.txtEndNum.Text=model.EndNum;
		this.txtOperatorName.Text=model.OperatorName;
		this.txtGetDateTime.Text=model.GetDateTime.ToString();
		this.txtInDate.Text=model.InDate.ToString();
		this.txtSiteID.Text=model.SiteID.ToString();
		this.txtRemark.Text=model.Remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtInCode.Text.Trim().Length==0)
			{
				strErr+="InCode不能为空！\\n";	
			}
			if(this.txtStartNum.Text.Trim().Length==0)
			{
				strErr+="StartNum不能为空！\\n";	
			}
			if(this.txtEndNum.Text.Trim().Length==0)
			{
				strErr+="EndNum不能为空！\\n";	
			}
			if(this.txtOperatorName.Text.Trim().Length==0)
			{
				strErr+="OperatorName不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtGetDateTime.Text))
			{
				strErr+="GetDateTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtInDate.Text))
			{
				strErr+="InDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSiteID.Text))
			{
				strErr+="SiteID格式错误！\\n";	
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
			int BatchId=int.Parse(this.lblBatchId.Text);
			string InCode=this.txtInCode.Text;
			string StartNum=this.txtStartNum.Text;
			string EndNum=this.txtEndNum.Text;
			string OperatorName=this.txtOperatorName.Text;
			DateTime GetDateTime=DateTime.Parse(this.txtGetDateTime.Text);
			DateTime InDate=DateTime.Parse(this.txtInDate.Text);
			int SiteID=int.Parse(this.txtSiteID.Text);
			string Remark=this.txtRemark.Text;


			WebDemo.Model.WebDemo.InvoiceRangeInfo model=new WebDemo.Model.WebDemo.InvoiceRangeInfo();
			model.BatchId=BatchId;
			model.InCode=InCode;
			model.StartNum=StartNum;
			model.EndNum=EndNum;
			model.OperatorName=OperatorName;
			model.GetDateTime=GetDateTime;
			model.InDate=InDate;
			model.SiteID=SiteID;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.InvoiceRangeInfo bll=new WebDemo.BLL.WebDemo.InvoiceRangeInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
