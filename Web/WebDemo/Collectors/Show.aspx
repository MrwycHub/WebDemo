<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.Collectors.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		集中器编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCollectorID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		集中器名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCollectorName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		集中器地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCollectorAddr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		集中器类型(1-电话线方式；2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCollectorType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		部门编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDeptID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		电话号码(电话线方式时使用)
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPhoneNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		超时时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCollOverTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IP地址(以太网方式时使用)
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIPNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		端口号(以太网方式时使用)
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPortNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Gprs心跳周期
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGprsCycle" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		冻结日
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFreezeDay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		冻结时
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFreezeHour" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		抄表日
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblReadDay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		登录时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLoginDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		更新时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUpdateDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		登录IP
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLoginIP" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		登录端口
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLoginPort" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		终端状态(0-离线；1-在线)
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注信息
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		集中器版本
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCollectorVer" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		集中器型号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCollectorModel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CollectorAPN
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCollectorAPN" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsServerMode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsServerMode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWorkTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NetWorkTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNetWorkTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FactoryCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFactoryCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FramesType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFramesType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterAddrFormat
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterAddrFormat" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GprsPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGprsPhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExpireTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExpireTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkMode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWorkMode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Lng
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLng" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Lat
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLat" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




