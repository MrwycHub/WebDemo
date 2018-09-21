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
namespace WebDemo.Web.WebDemo.ReportFiles
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
		WebDemo.BLL.WebDemo.ReportFiles bll=new WebDemo.BLL.WebDemo.ReportFiles();
		WebDemo.Model.WebDemo.ReportFiles model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtReportID.Text=model.ReportID;
		this.lblReportName.Text=model.ReportName;
		this.txtReportType.Text=model.ReportType;
		this.txtReportFileName.Text=model.ReportFileName;
		this.txtReportDbType.Text=model.ReportDbType.ToString();
		this.txtReportSql.Text=model.ReportSql;
		this.txtReportServiceUrl.Text=model.ReportServiceUrl;
		this.txtReportRole.Text=model.ReportRole.ToString();
		this.txtOperatorID.Text=model.OperatorID.ToString();
		this.txtInsDate.Text=model.InsDate.ToString();
		this.txtRemark.Text=model.Remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtReportID.Text.Trim().Length==0)
			{
				strErr+="ReportID不能为空！\\n";	
			}
			if(this.txtReportType.Text.Trim().Length==0)
			{
				strErr+="ReportType不能为空！\\n";	
			}
			if(this.txtReportFileName.Text.Trim().Length==0)
			{
				strErr+="ReportFileName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtReportDbType.Text))
			{
				strErr+="ReportDbType格式错误！\\n";	
			}
			if(this.txtReportSql.Text.Trim().Length==0)
			{
				strErr+="ReportSql不能为空！\\n";	
			}
			if(this.txtReportServiceUrl.Text.Trim().Length==0)
			{
				strErr+="ReportServiceUrl不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtReportRole.Text))
			{
				strErr+="ReportRole格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtInsDate.Text))
			{
				strErr+="InsDate格式错误！\\n";	
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
			string ReportID=this.txtReportID.Text;
			string ReportName=this.lblReportName.Text;
			string ReportType=this.txtReportType.Text;
			string ReportFileName=this.txtReportFileName.Text;
			int ReportDbType=int.Parse(this.txtReportDbType.Text);
			string ReportSql=this.txtReportSql.Text;
			string ReportServiceUrl=this.txtReportServiceUrl.Text;
			int ReportRole=int.Parse(this.txtReportRole.Text);
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			DateTime InsDate=DateTime.Parse(this.txtInsDate.Text);
			string Remark=this.txtRemark.Text;


			WebDemo.Model.WebDemo.ReportFiles model=new WebDemo.Model.WebDemo.ReportFiles();
			model.ID=ID;
			model.ReportID=ReportID;
			model.ReportName=ReportName;
			model.ReportType=ReportType;
			model.ReportFileName=ReportFileName;
			model.ReportDbType=ReportDbType;
			model.ReportSql=ReportSql;
			model.ReportServiceUrl=ReportServiceUrl;
			model.ReportRole=ReportRole;
			model.OperatorID=OperatorID;
			model.InsDate=InsDate;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.ReportFiles bll=new WebDemo.BLL.WebDemo.ReportFiles();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
