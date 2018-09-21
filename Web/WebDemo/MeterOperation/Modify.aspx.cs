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
namespace WebDemo.Web.WebDemo.MeterOperation
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int OperID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(OperID);
				}
			}
		}
			
	private void ShowInfo(int OperID)
	{
		WebDemo.BLL.WebDemo.MeterOperation bll=new WebDemo.BLL.WebDemo.MeterOperation();
		WebDemo.Model.WebDemo.MeterOperation model=bll.GetModel(OperID);
		this.lblOperID.Text=model.OperID.ToString();
		this.txtOperType.Text=model.OperType;
		this.txtOperDate.Text=model.OperDate.ToString();
		this.txtMeterIDOld.Text=model.MeterIDOld.ToString();
		this.txtMeterIDNew.Text=model.MeterIDNew.ToString();
		this.txtUseNumberOld.Text=model.UseNumberOld.ToString();
		this.txtStatFlag.Text=model.StatFlag.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtOperType.Text.Trim().Length==0)
			{
				strErr+="业务类型不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperDate.Text))
			{
				strErr+="业务日期格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterIDOld.Text))
			{
				strErr+="老表ID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterIDNew.Text))
			{
				strErr+="新表ID格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtUseNumberOld.Text))
			{
				strErr+="UseNumberOld格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtStatFlag.Text))
			{
				strErr+="StatFlag格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int OperID=int.Parse(this.lblOperID.Text);
			string OperType=this.txtOperType.Text;
			DateTime OperDate=DateTime.Parse(this.txtOperDate.Text);
			int MeterIDOld=int.Parse(this.txtMeterIDOld.Text);
			int MeterIDNew=int.Parse(this.txtMeterIDNew.Text);
			decimal UseNumberOld=decimal.Parse(this.txtUseNumberOld.Text);
			int StatFlag=int.Parse(this.txtStatFlag.Text);


			WebDemo.Model.WebDemo.MeterOperation model=new WebDemo.Model.WebDemo.MeterOperation();
			model.OperID=OperID;
			model.OperType=OperType;
			model.OperDate=OperDate;
			model.MeterIDOld=MeterIDOld;
			model.MeterIDNew=MeterIDNew;
			model.UseNumberOld=UseNumberOld;
			model.StatFlag=StatFlag;

			WebDemo.BLL.WebDemo.MeterOperation bll=new WebDemo.BLL.WebDemo.MeterOperation();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
