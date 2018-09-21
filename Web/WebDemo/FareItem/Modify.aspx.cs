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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int FareID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(FareID);
				}
			}
		}
			
	private void ShowInfo(int FareID)
	{
		WebDemo.BLL.WebDemo.FareItem bll=new WebDemo.BLL.WebDemo.FareItem();
		WebDemo.Model.WebDemo.FareItem model=bll.GetModel(FareID);
		this.lblFareID.Text=model.FareID.ToString();
		this.txtCycNumber.Text=model.CycNumber.ToString();
		this.txtFareName.Text=model.FareName;
		this.txtFareMoney.Text=model.FareMoney.ToString();
		this.txtFareMemo.Text=model.FareMemo;
		this.txtFareMark.Text=model.FareMark.ToString();
		this.txtPriceUnit.Text=model.PriceUnit;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
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
			int FareID=int.Parse(this.lblFareID.Text);
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
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
