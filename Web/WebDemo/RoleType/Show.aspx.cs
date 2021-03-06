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
namespace WebDemo.Web.WebDemo.RoleType
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int RoleID=(Convert.ToInt32(strid));
					ShowInfo(RoleID);
				}
			}
		}
		
	private void ShowInfo(int RoleID)
	{
		WebDemo.BLL.WebDemo.RoleType bll=new WebDemo.BLL.WebDemo.RoleType();
		WebDemo.Model.WebDemo.RoleType model=bll.GetModel(RoleID);
		this.lblRoleID.Text=model.RoleID.ToString();
		this.lblRoleName.Text=model.RoleName;
		this.lblRemark.Text=model.Remark;
		this.lblPriority.Text=model.Priority.ToString();

	}


    }
}
