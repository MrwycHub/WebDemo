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
namespace WebDemo.Web.WebDemo.DbUpdateLog
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
		WebDemo.BLL.WebDemo.DbUpdateLog bll=new WebDemo.BLL.WebDemo.DbUpdateLog();
		WebDemo.Model.WebDemo.DbUpdateLog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtVer.Text=model.Ver.ToString();
		this.txtUpdateContent.Text=model.UpdateContent;
		this.txtUpdateDate.Text=model.UpdateDate.ToString();
		this.txtRemark.Text=model.Remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtVer.Text))
			{
				strErr+="Ver格式错误！\\n";	
			}
			if(this.txtUpdateContent.Text.Trim().Length==0)
			{
				strErr+="UpdateContent不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdateDate.Text))
			{
				strErr+="UpdateDate格式错误！\\n";	
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
			long Ver=long.Parse(this.txtVer.Text);
			string UpdateContent=this.txtUpdateContent.Text;
			DateTime UpdateDate=DateTime.Parse(this.txtUpdateDate.Text);
			string Remark=this.txtRemark.Text;


			WebDemo.Model.WebDemo.DbUpdateLog model=new WebDemo.Model.WebDemo.DbUpdateLog();
			model.ID=ID;
			model.Ver=Ver;
			model.UpdateContent=UpdateContent;
			model.UpdateDate=UpdateDate;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.DbUpdateLog bll=new WebDemo.BLL.WebDemo.DbUpdateLog();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
