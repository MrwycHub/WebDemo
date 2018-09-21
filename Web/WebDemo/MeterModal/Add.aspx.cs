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
namespace WebDemo.Web.WebDemo.MeterModal
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtModalid.Text))
			{
				strErr+="型号编号格式错误！\\n";	
			}
			if(this.txtModalname.Text.Trim().Length==0)
			{
				strErr+="型号名称不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtUseProtocol.Text))
			{
				strErr+="UseProtocol格式错误！\\n";	
			}
			if(this.txtFactoryCode.Text.Trim().Length==0)
			{
				strErr+="FactoryCode不能为空！\\n";	
			}
			if(this.txtFactoryName.Text.Trim().Length==0)
			{
				strErr+="FactoryName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMaxValue.Text))
			{
				strErr+="MaxValue格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMaxYear.Text))
			{
				strErr+="MaxYear格式错误！\\n";	
			}
			if(this.txtCaliber.Text.Trim().Length==0)
			{
				strErr+="Caliber不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMaxFlow.Text))
			{
				strErr+="MaxFlow格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterHeaderType.Text))
			{
				strErr+="MeterHeaderType格式错误！\\n";	
			}
			if(this.txtMeterStatusCode.Text.Trim().Length==0)
			{
				strErr+="MeterStatusCode不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Modalid=int.Parse(this.txtModalid.Text);
			string Modalname=this.txtModalname.Text;
			string Remark=this.txtRemark.Text;
			int UseProtocol=int.Parse(this.txtUseProtocol.Text);
			string FactoryCode=this.txtFactoryCode.Text;
			string FactoryName=this.txtFactoryName.Text;
			int MaxValue=int.Parse(this.txtMaxValue.Text);
			int MaxYear=int.Parse(this.txtMaxYear.Text);
			string Caliber=this.txtCaliber.Text;
			decimal MaxFlow=decimal.Parse(this.txtMaxFlow.Text);
			int MeterHeaderType=int.Parse(this.txtMeterHeaderType.Text);
			string MeterStatusCode=this.txtMeterStatusCode.Text;

			WebDemo.Model.WebDemo.MeterModal model=new WebDemo.Model.WebDemo.MeterModal();
			model.Modalid=Modalid;
			model.Modalname=Modalname;
			model.Remark=Remark;
			model.UseProtocol=UseProtocol;
			model.FactoryCode=FactoryCode;
			model.FactoryName=FactoryName;
			model.MaxValue=MaxValue;
			model.MaxYear=MaxYear;
			model.Caliber=Caliber;
			model.MaxFlow=MaxFlow;
			model.MeterHeaderType=MeterHeaderType;
			model.MeterStatusCode=MeterStatusCode;

			WebDemo.BLL.WebDemo.MeterModal bll=new WebDemo.BLL.WebDemo.MeterModal();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
