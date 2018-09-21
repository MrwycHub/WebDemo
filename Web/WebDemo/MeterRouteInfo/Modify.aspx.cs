﻿using System;
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
namespace WebDemo.Web.WebDemo.MeterRouteInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string MeterAddr= Request.Params["id"];
					ShowInfo(MeterAddr);
				}
			}
		}
			
	private void ShowInfo(string MeterAddr)
	{
		WebDemo.BLL.WebDemo.MeterRouteInfo bll=new WebDemo.BLL.WebDemo.MeterRouteInfo();
		WebDemo.Model.WebDemo.MeterRouteInfo model=bll.GetModel(MeterAddr);
		this.lblMeterAddr.Text=model.MeterAddr;
		this.txtMeterNo.Text=model.MeterNo.ToString();
		this.txtNode1.Text=model.Node1;
		this.txtDepth1.Text=model.Depth1.ToString();
		this.txtNode2.Text=model.Node2;
		this.txtDepth2.Text=model.Depth2.ToString();
		this.txtNode3.Text=model.Node3;
		this.txtDepth3.Text=model.Depth3.ToString();
		this.txtNode4.Text=model.Node4;
		this.txtDepth4.Text=model.Depth4.ToString();
		this.chkResult.Checked=model.Result;
		this.txtCollectorId.Text=model.CollectorId.ToString();
		this.txtMeterId.Text=model.MeterId.ToString();
		this.txtReadTime.Text=model.ReadTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMeterNo.Text))
			{
				strErr+="MeterNo格式错误！\\n";	
			}
			if(this.txtNode1.Text.Trim().Length==0)
			{
				strErr+="Node1不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtDepth1.Text))
			{
				strErr+="Depth1格式错误！\\n";	
			}
			if(this.txtNode2.Text.Trim().Length==0)
			{
				strErr+="Node2不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtDepth2.Text))
			{
				strErr+="Depth2格式错误！\\n";	
			}
			if(this.txtNode3.Text.Trim().Length==0)
			{
				strErr+="Node3不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtDepth3.Text))
			{
				strErr+="Depth3格式错误！\\n";	
			}
			if(this.txtNode4.Text.Trim().Length==0)
			{
				strErr+="Node4不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtDepth4.Text))
			{
				strErr+="Depth4格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCollectorId.Text))
			{
				strErr+="CollectorId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterId.Text))
			{
				strErr+="MeterId格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtReadTime.Text))
			{
				strErr+="ReadTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string MeterAddr=this.lblMeterAddr.Text;
			int MeterNo=int.Parse(this.txtMeterNo.Text);
			string Node1=this.txtNode1.Text;
			int Depth1=int.Parse(this.txtDepth1.Text);
			string Node2=this.txtNode2.Text;
			int Depth2=int.Parse(this.txtDepth2.Text);
			string Node3=this.txtNode3.Text;
			int Depth3=int.Parse(this.txtDepth3.Text);
			string Node4=this.txtNode4.Text;
			int Depth4=int.Parse(this.txtDepth4.Text);
			bool Result=this.chkResult.Checked;
			int CollectorId=int.Parse(this.txtCollectorId.Text);
			int MeterId=int.Parse(this.txtMeterId.Text);
			DateTime ReadTime=DateTime.Parse(this.txtReadTime.Text);


			WebDemo.Model.WebDemo.MeterRouteInfo model=new WebDemo.Model.WebDemo.MeterRouteInfo();
			model.MeterAddr=MeterAddr;
			model.MeterNo=MeterNo;
			model.Node1=Node1;
			model.Depth1=Depth1;
			model.Node2=Node2;
			model.Depth2=Depth2;
			model.Node3=Node3;
			model.Depth3=Depth3;
			model.Node4=Node4;
			model.Depth4=Depth4;
			model.Result=Result;
			model.CollectorId=CollectorId;
			model.MeterId=MeterId;
			model.ReadTime=ReadTime;

			WebDemo.BLL.WebDemo.MeterRouteInfo bll=new WebDemo.BLL.WebDemo.MeterRouteInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
