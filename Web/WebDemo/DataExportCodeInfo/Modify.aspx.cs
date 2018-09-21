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
namespace WebDemo.Web.WebDemo.DataExportCodeInfo
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
		WebDemo.BLL.WebDemo.DataExportCodeInfo bll=new WebDemo.BLL.WebDemo.DataExportCodeInfo();
		WebDemo.Model.WebDemo.DataExportCodeInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtName.Text=model.Name;
		this.txtStrSql.Text=model.StrSql;
		this.chkShowDeptCondition.Checked=model.ShowDeptCondition;
		this.txtInfoCondition.Text=model.InfoCondition;
		this.txtDateCondition.Text=model.DateCondition;
		this.txtExtCondition.Text=model.ExtCondition;
		this.txtAscString.Text=model.AscString;
		this.txtGridViewWidth.Text=model.GridViewWidth.ToString();
		this.txtExportType.Text=model.ExportType;
		this.chkShowHeader.Checked=model.ShowHeader;
		this.txtSplitChar.Text=model.SplitChar;
		this.txtCreateDbfSql.Text=model.CreateDbfSql;
		this.txtDbfFileName.Text=model.DbfFileName;
		this.txtRemark.Text=model.Remark;
		this.txtEndDateCondition.Text=model.EndDateCondition;
		this.txtShowOtherHeader.Text=model.ShowOtherHeader;
		this.txtExportCols.Text=model.ExportCols;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtName.Text.Trim().Length==0)
			{
				strErr+="Name不能为空！\\n";	
			}
			if(this.txtStrSql.Text.Trim().Length==0)
			{
				strErr+="StrSql不能为空！\\n";	
			}
			if(this.txtInfoCondition.Text.Trim().Length==0)
			{
				strErr+="InfoCondition不能为空！\\n";	
			}
			if(this.txtDateCondition.Text.Trim().Length==0)
			{
				strErr+="DateCondition不能为空！\\n";	
			}
			if(this.txtExtCondition.Text.Trim().Length==0)
			{
				strErr+="ExtCondition不能为空！\\n";	
			}
			if(this.txtAscString.Text.Trim().Length==0)
			{
				strErr+="AscString不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtGridViewWidth.Text))
			{
				strErr+="GridViewWidth格式错误！\\n";	
			}
			if(this.txtExportType.Text.Trim().Length==0)
			{
				strErr+="ExportType不能为空！\\n";	
			}
			if(this.txtSplitChar.Text.Trim().Length==0)
			{
				strErr+="SplitChar不能为空！\\n";	
			}
			if(this.txtCreateDbfSql.Text.Trim().Length==0)
			{
				strErr+="CreateDbfSql不能为空！\\n";	
			}
			if(this.txtDbfFileName.Text.Trim().Length==0)
			{
				strErr+="DbfFileName不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(this.txtEndDateCondition.Text.Trim().Length==0)
			{
				strErr+="EndDateCondition不能为空！\\n";	
			}
			if(this.txtShowOtherHeader.Text.Trim().Length==0)
			{
				strErr+="ShowOtherHeader不能为空！\\n";	
			}
			if(this.txtExportCols.Text.Trim().Length==0)
			{
				strErr+="ExportCols不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string Name=this.txtName.Text;
			string StrSql=this.txtStrSql.Text;
			bool ShowDeptCondition=this.chkShowDeptCondition.Checked;
			string InfoCondition=this.txtInfoCondition.Text;
			string DateCondition=this.txtDateCondition.Text;
			string ExtCondition=this.txtExtCondition.Text;
			string AscString=this.txtAscString.Text;
			int GridViewWidth=int.Parse(this.txtGridViewWidth.Text);
			string ExportType=this.txtExportType.Text;
			bool ShowHeader=this.chkShowHeader.Checked;
			string SplitChar=this.txtSplitChar.Text;
			string CreateDbfSql=this.txtCreateDbfSql.Text;
			string DbfFileName=this.txtDbfFileName.Text;
			string Remark=this.txtRemark.Text;
			string EndDateCondition=this.txtEndDateCondition.Text;
			string ShowOtherHeader=this.txtShowOtherHeader.Text;
			string ExportCols=this.txtExportCols.Text;


			WebDemo.Model.WebDemo.DataExportCodeInfo model=new WebDemo.Model.WebDemo.DataExportCodeInfo();
			model.ID=ID;
			model.Name=Name;
			model.StrSql=StrSql;
			model.ShowDeptCondition=ShowDeptCondition;
			model.InfoCondition=InfoCondition;
			model.DateCondition=DateCondition;
			model.ExtCondition=ExtCondition;
			model.AscString=AscString;
			model.GridViewWidth=GridViewWidth;
			model.ExportType=ExportType;
			model.ShowHeader=ShowHeader;
			model.SplitChar=SplitChar;
			model.CreateDbfSql=CreateDbfSql;
			model.DbfFileName=DbfFileName;
			model.Remark=Remark;
			model.EndDateCondition=EndDateCondition;
			model.ShowOtherHeader=ShowOtherHeader;
			model.ExportCols=ExportCols;

			WebDemo.BLL.WebDemo.DataExportCodeInfo bll=new WebDemo.BLL.WebDemo.DataExportCodeInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
