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
namespace WebDemo.Web.WebDemo.SwitchBookLog
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
		WebDemo.BLL.WebDemo.SwitchBookLog bll=new WebDemo.BLL.WebDemo.SwitchBookLog();
		WebDemo.Model.WebDemo.SwitchBookLog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtMeterID.Text=model.MeterID.ToString();
		this.txtBookIDBefore.Text=model.BookIDBefore.ToString();
		this.txtBookNumBefore.Text=model.BookNumBefore.ToString();
		this.txtBookIDAfter.Text=model.BookIDAfter.ToString();
		this.txtBookNumAfter.Text=model.BookNumAfter.ToString();
		this.txtOperTime.Text=model.OperTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMeterID.Text))
			{
				strErr+="MeterID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtBookIDBefore.Text))
			{
				strErr+="BookIDBefore格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtBookNumBefore.Text))
			{
				strErr+="BookNumBefore格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtBookIDAfter.Text))
			{
				strErr+="BookIDAfter格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtBookNumAfter.Text))
			{
				strErr+="BookNumAfter格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperTime.Text))
			{
				strErr+="OperTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			int MeterID=int.Parse(this.txtMeterID.Text);
			int BookIDBefore=int.Parse(this.txtBookIDBefore.Text);
			int BookNumBefore=int.Parse(this.txtBookNumBefore.Text);
			int BookIDAfter=int.Parse(this.txtBookIDAfter.Text);
			int BookNumAfter=int.Parse(this.txtBookNumAfter.Text);
			DateTime OperTime=DateTime.Parse(this.txtOperTime.Text);


			WebDemo.Model.WebDemo.SwitchBookLog model=new WebDemo.Model.WebDemo.SwitchBookLog();
			model.ID=ID;
			model.MeterID=MeterID;
			model.BookIDBefore=BookIDBefore;
			model.BookNumBefore=BookNumBefore;
			model.BookIDAfter=BookIDAfter;
			model.BookNumAfter=BookNumAfter;
			model.OperTime=OperTime;

			WebDemo.BLL.WebDemo.SwitchBookLog bll=new WebDemo.BLL.WebDemo.SwitchBookLog();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
