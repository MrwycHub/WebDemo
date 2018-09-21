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
namespace WebDemo.Web.WebDemo.RatePrice
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				int GroupPriceNo = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					GroupPriceNo=(Convert.ToInt32(Request.Params["id0"]));
				}
				int FareRateNo = -1;
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					FareRateNo=(Convert.ToInt32(Request.Params["id1"]));
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(GroupPriceNo,FareRateNo);
			}
		}
			
	private void ShowInfo(int GroupPriceNo,int FareRateNo)
	{
		WebDemo.BLL.WebDemo.RatePrice bll=new WebDemo.BLL.WebDemo.RatePrice();
		WebDemo.Model.WebDemo.RatePrice model=bll.GetModel(GroupPriceNo,FareRateNo);
		this.lblGroupPriceNo.Text=model.GroupPriceNo.ToString();
		this.lblFareRateNo.Text=model.FareRateNo.ToString();
		this.txtFareName.Text=model.FareName;
		this.txtPrice.Text=model.Price.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtFareName.Text.Trim().Length==0)
			{
				strErr+="FareName不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice.Text))
			{
				strErr+="Price格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int GroupPriceNo=int.Parse(this.lblGroupPriceNo.Text);
			int FareRateNo=int.Parse(this.lblFareRateNo.Text);
			string FareName=this.txtFareName.Text;
			decimal Price=decimal.Parse(this.txtPrice.Text);


			WebDemo.Model.WebDemo.RatePrice model=new WebDemo.Model.WebDemo.RatePrice();
			model.GroupPriceNo=GroupPriceNo;
			model.FareRateNo=FareRateNo;
			model.FareName=FareName;
			model.Price=Price;

			WebDemo.BLL.WebDemo.RatePrice bll=new WebDemo.BLL.WebDemo.RatePrice();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
