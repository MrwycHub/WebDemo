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
namespace WebDemo.Web.WebDemo.CollectorWork
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				int CollectorID = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					CollectorID=(Convert.ToInt32(Request.Params["id0"]));
				}
				int WorkID = -1;
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					WorkID=(Convert.ToInt32(Request.Params["id1"]));
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(CollectorID,WorkID);
			}
		}
			
	private void ShowInfo(int CollectorID,int WorkID)
	{
		WebDemo.BLL.WebDemo.CollectorWork bll=new WebDemo.BLL.WebDemo.CollectorWork();
		WebDemo.Model.WebDemo.CollectorWork model=bll.GetModel(CollectorID,WorkID);
		this.lblCollectorID.Text=model.CollectorID.ToString();
		this.lblWorkID.Text=model.WorkID.ToString();
		this.txtWorkTime.Text=model.WorkTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtWorkTime.Text))
			{
				strErr+="时段区间格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int CollectorID=int.Parse(this.lblCollectorID.Text);
			int WorkID=int.Parse(this.lblWorkID.Text);
			int WorkTime=int.Parse(this.txtWorkTime.Text);


			WebDemo.Model.WebDemo.CollectorWork model=new WebDemo.Model.WebDemo.CollectorWork();
			model.CollectorID=CollectorID;
			model.WorkID=WorkID;
			model.WorkTime=WorkTime;

			WebDemo.BLL.WebDemo.CollectorWork bll=new WebDemo.BLL.WebDemo.CollectorWork();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
