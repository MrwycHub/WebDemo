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
namespace WebDemo.Web.WebDemo.FailureMessage
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
		WebDemo.BLL.WebDemo.FailureMessage bll=new WebDemo.BLL.WebDemo.FailureMessage();
		WebDemo.Model.WebDemo.FailureMessage model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtFailID.Text=model.FailID.ToString();
		this.txtType.Text=model.Type.ToString();
		this.txtFlag.Text=model.Flag.ToString();
		this.txtName.Text=model.Name;
		this.txtUpLoadTime.Text=model.UpLoadTime.ToString();
		this.txtSize.Text=model.Size;
		this.txtPattern.Text=model.Pattern;
		this.txtUrl.Text=model.Url;
		this.txtLocationX.Text=model.LocationX.ToString();
		this.txtLocationY.Text=model.LocationY.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtFailID.Text))
			{
				strErr+="FailID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtType.Text))
			{
				strErr+="Type格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFlag.Text))
			{
				strErr+="Flag格式错误！\\n";	
			}
			if(this.txtName.Text.Trim().Length==0)
			{
				strErr+="Name不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpLoadTime.Text))
			{
				strErr+="UpLoadTime格式错误！\\n";	
			}
			if(this.txtSize.Text.Trim().Length==0)
			{
				strErr+="Size不能为空！\\n";	
			}
			if(this.txtPattern.Text.Trim().Length==0)
			{
				strErr+="Pattern不能为空！\\n";	
			}
			if(this.txtUrl.Text.Trim().Length==0)
			{
				strErr+="Url不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLocationX.Text))
			{
				strErr+="LocationX格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLocationY.Text))
			{
				strErr+="LocationY格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			int FailID=int.Parse(this.txtFailID.Text);
			int Type=int.Parse(this.txtType.Text);
			int Flag=int.Parse(this.txtFlag.Text);
			string Name=this.txtName.Text;
			DateTime UpLoadTime=DateTime.Parse(this.txtUpLoadTime.Text);
			string Size=this.txtSize.Text;
			string Pattern=this.txtPattern.Text;
			string Url=this.txtUrl.Text;
			decimal LocationX=decimal.Parse(this.txtLocationX.Text);
			decimal LocationY=decimal.Parse(this.txtLocationY.Text);


			WebDemo.Model.WebDemo.FailureMessage model=new WebDemo.Model.WebDemo.FailureMessage();
			model.ID=ID;
			model.FailID=FailID;
			model.Type=Type;
			model.Flag=Flag;
			model.Name=Name;
			model.UpLoadTime=UpLoadTime;
			model.Size=Size;
			model.Pattern=Pattern;
			model.Url=Url;
			model.LocationX=LocationX;
			model.LocationY=LocationY;

			WebDemo.BLL.WebDemo.FailureMessage bll=new WebDemo.BLL.WebDemo.FailureMessage();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
