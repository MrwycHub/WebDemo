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
namespace WebDemo.Web.WebDemo.OperMenuSet
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				int OperatorID = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					OperatorID=(Convert.ToInt32(Request.Params["id0"]));
				}
				int MenuID = -1;
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					MenuID=(Convert.ToInt32(Request.Params["id1"]));
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(OperatorID,MenuID);
			}
		}
			
	private void ShowInfo(int OperatorID,int MenuID)
	{
		WebDemo.BLL.WebDemo.OperMenuSet bll=new WebDemo.BLL.WebDemo.OperMenuSet();
		WebDemo.Model.WebDemo.OperMenuSet model=bll.GetModel(OperatorID,MenuID);
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblMenuID.Text=model.MenuID.ToString();
		this.txtOrderNo.Text=model.OrderNo.ToString();
		this.txtFlag.Text=model.Flag.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtOrderNo.Text))
			{
				strErr+="OrderNo格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFlag.Text))
			{
				strErr+="Flag格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int OperatorID=int.Parse(this.lblOperatorID.Text);
			int MenuID=int.Parse(this.lblMenuID.Text);
			int OrderNo=int.Parse(this.txtOrderNo.Text);
			int Flag=int.Parse(this.txtFlag.Text);


			WebDemo.Model.WebDemo.OperMenuSet model=new WebDemo.Model.WebDemo.OperMenuSet();
			model.OperatorID=OperatorID;
			model.MenuID=MenuID;
			model.OrderNo=OrderNo;
			model.Flag=Flag;

			WebDemo.BLL.WebDemo.OperMenuSet bll=new WebDemo.BLL.WebDemo.OperMenuSet();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
