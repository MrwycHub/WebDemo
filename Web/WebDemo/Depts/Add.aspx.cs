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
namespace WebDemo.Web.WebDemo.Depts
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDeptID.Text.Trim().Length==0)
			{
				strErr+="部门编号(编码由数字组成不能为空！\\n";	
			}
			if(this.txtDeptName.Text.Trim().Length==0)
			{
				strErr+="部门名称不能为空！\\n";	
			}
			if(this.txtUpperDept.Text.Trim().Length==0)
			{
				strErr+="上级部门代码(为空说明为第一级不能为空！\\n";	
			}
			if(this.txtAddress.Text.Trim().Length==0)
			{
				strErr+="Address不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtimgIndex.Text))
			{
				strErr+="imgIndex格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSelectimgIndex.Text))
			{
				strErr+="SelectimgIndex格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}
			if(this.txtCustomCode.Text.Trim().Length==0)
			{
				strErr+="CustomCode不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtDeptType.Text))
			{
				strErr+="DeptType格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLocationX.Text))
			{
				strErr+="LocationX格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLocationY.Text))
			{
				strErr+="LocationY格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdateTime.Text))
			{
				strErr+="UpdateTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrderNum.Text))
			{
				strErr+="OrderNum格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string DeptID=this.txtDeptID.Text;
			string DeptName=this.txtDeptName.Text;
			string UpperDept=this.txtUpperDept.Text;
			string Address=this.txtAddress.Text;
			int imgIndex=int.Parse(this.txtimgIndex.Text);
			int SelectimgIndex=int.Parse(this.txtSelectimgIndex.Text);
			string Remark=this.txtRemark.Text;
			string CustomCode=this.txtCustomCode.Text;
			int DeptType=int.Parse(this.txtDeptType.Text);
			decimal LocationX=decimal.Parse(this.txtLocationX.Text);
			decimal LocationY=decimal.Parse(this.txtLocationY.Text);
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);
			int OrderNum=int.Parse(this.txtOrderNum.Text);

			WebDemo.Model.WebDemo.Depts model=new WebDemo.Model.WebDemo.Depts();
			model.DeptID=DeptID;
			model.DeptName=DeptName;
			model.UpperDept=UpperDept;
			model.Address=Address;
			model.imgIndex=imgIndex;
			model.SelectimgIndex=SelectimgIndex;
			model.Remark=Remark;
			model.CustomCode=CustomCode;
			model.DeptType=DeptType;
			model.LocationX=LocationX;
			model.LocationY=LocationY;
			model.UpdateTime=UpdateTime;
			model.OrderNum=OrderNum;

			WebDemo.BLL.WebDemo.Depts bll=new WebDemo.BLL.WebDemo.Depts();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
