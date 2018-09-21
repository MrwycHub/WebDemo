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
namespace WebDemo.Web.WebDemo.InvoiceNumInfo
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
		WebDemo.BLL.WebDemo.InvoiceNumInfo bll=new WebDemo.BLL.WebDemo.InvoiceNumInfo();
		WebDemo.Model.WebDemo.InvoiceNumInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtDisId.Text=model.DisId.ToString();
		this.txtBatchId.Text=model.BatchId.ToString();
		this.txtInCode.Text=model.InCode;
		this.txtInvoiceNum.Text=model.InvoiceNum;
		this.txtOrderNum.Text=model.OrderNum;
		this.txtMark.Text=model.Mark.ToString();
		this.txtSubFlag.Text=model.SubFlag.ToString();
		this.txtOperatorID.Text=model.OperatorID.ToString();
		this.txtAssignOperator.Text=model.AssignOperator;
		this.txtAssignDate.Text=model.AssignDate.ToString();
		this.txtOperDate.Text=model.OperDate.ToString();
		this.txtRemark.Text=model.Remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtDisId.Text))
			{
				strErr+="DisId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtBatchId.Text))
			{
				strErr+="BatchId格式错误！\\n";	
			}
			if(this.txtInCode.Text.Trim().Length==0)
			{
				strErr+="InCode不能为空！\\n";	
			}
			if(this.txtInvoiceNum.Text.Trim().Length==0)
			{
				strErr+="InvoiceNum不能为空！\\n";	
			}
			if(this.txtOrderNum.Text.Trim().Length==0)
			{
				strErr+="OrderNum不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMark.Text))
			{
				strErr+="Mark格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSubFlag.Text))
			{
				strErr+="SubFlag格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(this.txtAssignOperator.Text.Trim().Length==0)
			{
				strErr+="AssignOperator不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtAssignDate.Text))
			{
				strErr+="AssignDate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperDate.Text))
			{
				strErr+="OperDate格式错误！\\n";	
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
			int DisId=int.Parse(this.txtDisId.Text);
			int BatchId=int.Parse(this.txtBatchId.Text);
			string InCode=this.txtInCode.Text;
			string InvoiceNum=this.txtInvoiceNum.Text;
			string OrderNum=this.txtOrderNum.Text;
			int Mark=int.Parse(this.txtMark.Text);
			int SubFlag=int.Parse(this.txtSubFlag.Text);
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			string AssignOperator=this.txtAssignOperator.Text;
			DateTime AssignDate=DateTime.Parse(this.txtAssignDate.Text);
			DateTime OperDate=DateTime.Parse(this.txtOperDate.Text);
			string Remark=this.txtRemark.Text;


			WebDemo.Model.WebDemo.InvoiceNumInfo model=new WebDemo.Model.WebDemo.InvoiceNumInfo();
			model.ID=ID;
			model.DisId=DisId;
			model.BatchId=BatchId;
			model.InCode=InCode;
			model.InvoiceNum=InvoiceNum;
			model.OrderNum=OrderNum;
			model.Mark=Mark;
			model.SubFlag=SubFlag;
			model.OperatorID=OperatorID;
			model.AssignOperator=AssignOperator;
			model.AssignDate=AssignDate;
			model.OperDate=OperDate;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.InvoiceNumInfo bll=new WebDemo.BLL.WebDemo.InvoiceNumInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
