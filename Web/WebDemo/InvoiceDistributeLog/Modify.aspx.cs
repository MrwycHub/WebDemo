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
namespace WebDemo.Web.WebDemo.InvoiceDistributeLog
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int DisId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(DisId);
				}
			}
		}
			
	private void ShowInfo(int DisId)
	{
		WebDemo.BLL.WebDemo.InvoiceDistributeLog bll=new WebDemo.BLL.WebDemo.InvoiceDistributeLog();
		WebDemo.Model.WebDemo.InvoiceDistributeLog model=bll.GetModel(DisId);
		this.lblDisId.Text=model.DisId.ToString();
		this.txtBatchId.Text=model.BatchId.ToString();
		this.txtInCode.Text=model.InCode;
		this.txtStartNum.Text=model.StartNum;
		this.txtEndNum.Text=model.EndNum;
		this.txtOperatorID.Text=model.OperatorID.ToString();
		this.txtAssignDate.Text=model.AssignDate.ToString();
		this.txtAssignOperator.Text=model.AssignOperator;
		this.txtState.Text=model.State.ToString();
		this.txtRemark.Text=model.Remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtBatchId.Text))
			{
				strErr+="BatchId格式错误！\\n";	
			}
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
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtAssignDate.Text))
			{
				strErr+="AssignDate格式错误！\\n";	
			}
			if(this.txtAssignOperator.Text.Trim().Length==0)
			{
				strErr+="AssignOperator不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtState.Text))
			{
				strErr+="State格式错误！\\n";	
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
			int DisId=int.Parse(this.lblDisId.Text);
			int BatchId=int.Parse(this.txtBatchId.Text);
			string InCode=this.txtInCode.Text;
			string StartNum=this.txtStartNum.Text;
			string EndNum=this.txtEndNum.Text;
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			DateTime AssignDate=DateTime.Parse(this.txtAssignDate.Text);
			string AssignOperator=this.txtAssignOperator.Text;
			int State=int.Parse(this.txtState.Text);
			string Remark=this.txtRemark.Text;


			WebDemo.Model.WebDemo.InvoiceDistributeLog model=new WebDemo.Model.WebDemo.InvoiceDistributeLog();
			model.DisId=DisId;
			model.BatchId=BatchId;
			model.InCode=InCode;
			model.StartNum=StartNum;
			model.EndNum=EndNum;
			model.OperatorID=OperatorID;
			model.AssignDate=AssignDate;
			model.AssignOperator=AssignOperator;
			model.State=State;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.InvoiceDistributeLog bll=new WebDemo.BLL.WebDemo.InvoiceDistributeLog();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
