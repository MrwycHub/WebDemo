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
namespace WebDemo.Web.WebDemo.CollectorsLineLog
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
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		WebDemo.BLL.WebDemo.CollectorsLineLog bll=new WebDemo.BLL.WebDemo.CollectorsLineLog();
		WebDemo.Model.WebDemo.CollectorsLineLog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblCollectorID.Text=model.CollectorID.ToString();
		this.lblLineType.Text=model.LineType.ToString();
		this.lblOperTime.Text=model.OperTime.ToString();
		this.lblRemark.Text=model.Remark;

	}


    }
}
