<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="WebDemo.Web.WebDemo.Collectors.Add" Title="增加页" %>

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
		<asp:TextBox id="txtCollectorID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		集中器名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCollectorName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		集中器地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCollectorAddr" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		集中器类型(1-电话线方式；2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCollectorType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		部门编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDeptID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		电话号码(电话线方式时使用)
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPhoneNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		超时时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCollOverTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IP地址(以太网方式时使用)
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIPNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		端口号(以太网方式时使用)
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPortNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Gprs心跳周期
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtGprsCycle" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		冻结日
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFreezeDay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		冻结时
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFreezeHour" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		抄表日
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtReadDay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		登录时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtLoginDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		更新时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtUpdateDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		登录IP
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLoginIP" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		登录端口
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLoginPort" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		终端状态(0-离线；1-在线)
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注信息
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRemark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		集中器版本
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCollectorVer" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		集中器型号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCollectorModel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CollectorAPN
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCollectorAPN" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsServerMode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIsServerMode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWorkTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NetWorkTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtNetWorkTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FactoryCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFactoryCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FramesType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFramesType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterAddrFormat
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterAddrFormat" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GprsPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtGprsPhone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExpireTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtExpireTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkMode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWorkMode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Lng
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLng" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Lat
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLat" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
