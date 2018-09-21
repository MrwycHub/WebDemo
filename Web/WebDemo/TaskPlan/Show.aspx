<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.TaskPlan.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		任务编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTaskID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		集中器编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCollectorID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		任务名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTaskName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		指令编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCommandID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommandInfo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCommandInfo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterAddr
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterAddr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		抄表数据项
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterItem" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		冻结日
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFreezeDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		执行月份(0表示每个月)
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTaskMonth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		执行日期(0表示每天)
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTaskDay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		执行时
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTaskHour" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		执行分
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTaskMinute" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		执行标志(1-未执行；2-已执
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExeMark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		执行时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExeDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		重试次数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExeError" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		启动任务(1-启动 2 不启动
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTaskMark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		任务类型
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTaskType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TaskError
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTaskError" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		重试次数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTryNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		采集器地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHostAddr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InsDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInsDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		任务类型
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTaskFrequency" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExeInfo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExeInfo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OperatorID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperatorID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DeptID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDeptID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TaskWeek
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTaskWeek" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ServerId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblServerId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExeType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExeType" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




