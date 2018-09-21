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
namespace WebDemo.Web.WebDemo.RemnantTbl
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
		WebDemo.BLL.WebDemo.RemnantTbl bll=new WebDemo.BLL.WebDemo.RemnantTbl();
		WebDemo.Model.WebDemo.RemnantTbl model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.txtRemnant.Text=model.Remnant.ToString();
		this.txtReadDate.Text=model.ReadDate.ToString();
		this.txtCollectorReadDate.Text=model.CollectorReadDate.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDecimal(txtRemnant.Text))
			{
				strErr+="Remnant格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtReadDate.Text))
			{
				strErr+="ReadDate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCollectorReadDate.Text))
			{
				strErr+="CollectorReadDate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			int MeterID=int.Parse(this.lblMeterID.Text);
			decimal Remnant=decimal.Parse(this.txtRemnant.Text);
			DateTime ReadDate=DateTime.Parse(this.txtReadDate.Text);
			DateTime CollectorReadDate=DateTime.Parse(this.txtCollectorReadDate.Text);


			WebDemo.Model.WebDemo.RemnantTbl model=new WebDemo.Model.WebDemo.RemnantTbl();
			model.ID=ID;
			model.MeterID=MeterID;
			model.Remnant=Remnant;
			model.ReadDate=ReadDate;
			model.CollectorReadDate=CollectorReadDate;

			WebDemo.BLL.WebDemo.RemnantTbl bll=new WebDemo.BLL.WebDemo.RemnantTbl();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
