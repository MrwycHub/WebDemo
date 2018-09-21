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
namespace WebDemo.Web.WebDemo.InvoiceList
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int InID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(InID);
				}
			}
		}
			
	private void ShowInfo(int InID)
	{
		WebDemo.BLL.WebDemo.InvoiceList bll=new WebDemo.BLL.WebDemo.InvoiceList();
		WebDemo.Model.WebDemo.InvoiceList model=bll.GetModel(InID);
		this.lblInID.Text=model.InID.ToString();
		this.txtInCode.Text=model.InCode;
		this.txtInNumber.Text=model.InNumber.ToString();
		this.txtSiteID.Text=model.SiteID.ToString();
		this.txtOperatorName.Text=model.OperatorName;
		this.txtGetDate.Text=model.GetDate.ToString();
		this.txtPayID.Text=model.PayID.ToString();
		this.txtPrintDate.Text=model.PrintDate.ToString();
		this.txtInMoney.Text=model.InMoney.ToString();
		this.txtInMark.Text=model.InMark.ToString();
		this.txtSendMark.Text=model.SendMark.ToString();
		this.txtSendDate.Text=model.SendDate.ToString();
		this.txtprintMan.Text=model.printMan;
		this.txtzfDate.Text=model.zfDate.ToString();
		this.txtzfInCode.Text=model.zfInCode;
		this.txtzfInNumber.Text=model.zfInNumber;
		this.txtUName.Text=model.UName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtInCode.Text.Trim().Length==0)
			{
				strErr+="InCode不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtInNumber.Text))
			{
				strErr+="InNumber格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSiteID.Text))
			{
				strErr+="SiteID格式错误！\\n";	
			}
			if(this.txtOperatorName.Text.Trim().Length==0)
			{
				strErr+="OperatorName不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtGetDate.Text))
			{
				strErr+="GetDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayID.Text))
			{
				strErr+="PayID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtPrintDate.Text))
			{
				strErr+="PrintDate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtInMoney.Text))
			{
				strErr+="InMoney格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtInMark.Text))
			{
				strErr+="InMark格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSendMark.Text))
			{
				strErr+="SendMark格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSendDate.Text))
			{
				strErr+="SendDate格式错误！\\n";	
			}
			if(this.txtprintMan.Text.Trim().Length==0)
			{
				strErr+="printMan不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtzfDate.Text))
			{
				strErr+="zfDate格式错误！\\n";	
			}
			if(this.txtzfInCode.Text.Trim().Length==0)
			{
				strErr+="zfInCode不能为空！\\n";	
			}
			if(this.txtzfInNumber.Text.Trim().Length==0)
			{
				strErr+="zfInNumber不能为空！\\n";	
			}
			if(this.txtUName.Text.Trim().Length==0)
			{
				strErr+="UName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int InID=int.Parse(this.lblInID.Text);
			string InCode=this.txtInCode.Text;
			int InNumber=int.Parse(this.txtInNumber.Text);
			int SiteID=int.Parse(this.txtSiteID.Text);
			string OperatorName=this.txtOperatorName.Text;
			DateTime GetDate=DateTime.Parse(this.txtGetDate.Text);
			int PayID=int.Parse(this.txtPayID.Text);
			DateTime PrintDate=DateTime.Parse(this.txtPrintDate.Text);
			decimal InMoney=decimal.Parse(this.txtInMoney.Text);
			int InMark=int.Parse(this.txtInMark.Text);
			int SendMark=int.Parse(this.txtSendMark.Text);
			DateTime SendDate=DateTime.Parse(this.txtSendDate.Text);
			string printMan=this.txtprintMan.Text;
			DateTime zfDate=DateTime.Parse(this.txtzfDate.Text);
			string zfInCode=this.txtzfInCode.Text;
			string zfInNumber=this.txtzfInNumber.Text;
			string UName=this.txtUName.Text;


			WebDemo.Model.WebDemo.InvoiceList model=new WebDemo.Model.WebDemo.InvoiceList();
			model.InID=InID;
			model.InCode=InCode;
			model.InNumber=InNumber;
			model.SiteID=SiteID;
			model.OperatorName=OperatorName;
			model.GetDate=GetDate;
			model.PayID=PayID;
			model.PrintDate=PrintDate;
			model.InMoney=InMoney;
			model.InMark=InMark;
			model.SendMark=SendMark;
			model.SendDate=SendDate;
			model.printMan=printMan;
			model.zfDate=zfDate;
			model.zfInCode=zfInCode;
			model.zfInNumber=zfInNumber;
			model.UName=UName;

			WebDemo.BLL.WebDemo.InvoiceList bll=new WebDemo.BLL.WebDemo.InvoiceList();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
