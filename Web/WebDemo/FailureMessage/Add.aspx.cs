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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
