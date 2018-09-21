<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.PriceType.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		价格编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		价格名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		表类型编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterTypeID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		程序控制
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		单价
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		单价2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		单价3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		分界点1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDivid1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		分界点2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDivid2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceUnit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceUnit" runat="server"></asp:Label>
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
		Price4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDivid3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDivid4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDivid5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExeDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExeDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SetNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSetNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SuiteNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSuiteNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GroupPriceNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGroupPriceNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsStartStar
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsStartStar" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsStartPeople
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsStartPeople" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PeopleCheck
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPeopleCheck" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MaxPeople
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMaxPeople" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AddUseNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAddUseNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StarsLevel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStarsLevel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StarsPeriod
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStarsPeriod" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StarsCorrected
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStarsCorrected" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsStartArea
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsStartArea" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Coefficient
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCoefficient" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CalculateDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCalculateDay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StarsAreaWay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStarsAreaWay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StarsByUser
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStarsByUser" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




