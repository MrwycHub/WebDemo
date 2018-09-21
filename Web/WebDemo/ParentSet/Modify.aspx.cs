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
namespace WebDemo.Web.WebDemo.ParentSet
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int MeterID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(MeterID);
				}
			}
		}
			
	private void ShowInfo(int MeterID)
	{
		WebDemo.BLL.WebDemo.ParentSet bll=new WebDemo.BLL.WebDemo.ParentSet();
		WebDemo.Model.WebDemo.ParentSet model=bll.GetModel(MeterID);
		this.lblMeterID.Text=model.MeterID.ToString();
		this.txtParentID.Text=model.ParentID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtParentID.Text))
			{
				strErr+="ParentID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MeterID=int.Parse(this.lblMeterID.Text);
			int ParentID=int.Parse(this.txtParentID.Text);


			WebDemo.Model.WebDemo.ParentSet model=new WebDemo.Model.WebDemo.ParentSet();
			model.MeterID=MeterID;
			model.ParentID=ParentID;

			WebDemo.BLL.WebDemo.ParentSet bll=new WebDemo.BLL.WebDemo.ParentSet();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
