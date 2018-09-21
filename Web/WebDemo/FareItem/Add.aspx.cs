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
namespace WebDemo.Web.WebDemo.FareItem
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtFareID.Text))
			{
				strErr+="FareID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCycNumber.Text))
			{
				strErr+="CycNumber格式错误！\\n";	
			}
			if(this.txtFareName.Text.Trim().Length==0)
			{
				strErr+="FareName不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFareMoney.Text))
			{
				strErr+="单价格式错误！\\n";	
			}
			if(this.txtFareMemo.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFareMark.Text))
			{
				strErr+="是否启用 1启用 2不启用格式错误！\\n";	
			}
			if(this.txtPriceUnit.Text.Trim().Length==0)
			{
				strErr+="单位不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int FareID=int.Parse(this.txtFareID.Text);
			int CycNumber=int.Parse(this.txtCycNumber.Text);
			string FareName=this.txtFareName.Text;
			decimal FareMoney=decimal.Parse(this.txtFareMoney.Text);
			string FareMemo=this.txtFareMemo.Text;
			int FareMark=int.Parse(this.txtFareMark.Text);
			string PriceUnit=this.txtPriceUnit.Text;

			WebDemo.Model.WebDemo.FareItem model=new WebDemo.Model.WebDemo.FareItem();
			model.FareID=FareID;
			model.CycNumber=CycNumber;
			model.FareName=FareName;
			model.FareMoney=FareMoney;
			model.FareMemo=FareMemo;
			model.FareMark=FareMark;
			model.PriceUnit=PriceUnit;

			WebDemo.BLL.WebDemo.FareItem bll=new WebDemo.BLL.WebDemo.FareItem();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
