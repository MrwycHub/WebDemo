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
namespace WebDemo.Web.WebDemo.LostBlacklist
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int SaveNo=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(SaveNo);
				}
			}
		}
			
	private void ShowInfo(int SaveNo)
	{
		WebDemo.BLL.WebDemo.LostBlacklist bll=new WebDemo.BLL.WebDemo.LostBlacklist();
		WebDemo.Model.WebDemo.LostBlacklist model=bll.GetModel(SaveNo);
		this.lblSaveNo.Text=model.SaveNo.ToString();
		this.txtCardID.Text=model.CardID.ToString();
		this.txtLostDate.Text=model.LostDate.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtCardID.Text))
			{
				strErr+="CardID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLostDate.Text))
			{
				strErr+="LostDate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int SaveNo=int.Parse(this.lblSaveNo.Text);
			int CardID=int.Parse(this.txtCardID.Text);
			DateTime LostDate=DateTime.Parse(this.txtLostDate.Text);


			WebDemo.Model.WebDemo.LostBlacklist model=new WebDemo.Model.WebDemo.LostBlacklist();
			model.SaveNo=SaveNo;
			model.CardID=CardID;
			model.LostDate=LostDate;

			WebDemo.BLL.WebDemo.LostBlacklist bll=new WebDemo.BLL.WebDemo.LostBlacklist();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
