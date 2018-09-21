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
namespace WebDemo.Web.WebDemo.Workers
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int WorkerID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(WorkerID);
				}
			}
		}
			
	private void ShowInfo(int WorkerID)
	{
		WebDemo.BLL.WebDemo.Workers bll=new WebDemo.BLL.WebDemo.Workers();
		WebDemo.Model.WebDemo.Workers model=bll.GetModel(WorkerID);
		this.lblWorkerID.Text=model.WorkerID.ToString();
		this.txtWorkerName.Text=model.WorkerName;
		this.txtWorkerPhone.Text=model.WorkerPhone;
		this.txtRemark.Text=model.Remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtWorkerName.Text.Trim().Length==0)
			{
				strErr+="WorkerName不能为空！\\n";	
			}
			if(this.txtWorkerPhone.Text.Trim().Length==0)
			{
				strErr+="WorkerPhone不能为空！\\n";	
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
			int WorkerID=int.Parse(this.lblWorkerID.Text);
			string WorkerName=this.txtWorkerName.Text;
			string WorkerPhone=this.txtWorkerPhone.Text;
			string Remark=this.txtRemark.Text;


			WebDemo.Model.WebDemo.Workers model=new WebDemo.Model.WebDemo.Workers();
			model.WorkerID=WorkerID;
			model.WorkerName=WorkerName;
			model.WorkerPhone=WorkerPhone;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.Workers bll=new WebDemo.BLL.WebDemo.Workers();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
