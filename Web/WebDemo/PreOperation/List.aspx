<%@ Page Title="PreOperation" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.PreOperation.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="OperID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="CardID" HeaderText="一卡通卡号(卡号+卡区号不能重" SortExpression="CardID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CardSector" HeaderText="卡区号(一卡通卡区号" SortExpression="CardSector" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceTypeID" HeaderText="PriceTypeID" SortExpression="PriceTypeID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceTypeName" HeaderText="价格名称" SortExpression="PriceTypeName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price" HeaderText="单价" SortExpression="Price" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OperMoney" HeaderText="业务金额" SortExpression="OperMoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OperInt" HeaderText="业务量" SortExpression="OperInt" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OperZS" HeaderText="业务字数" SortExpression="OperZS" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FactMoney" HeaderText="实收金额" SortExpression="FactMoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LastBalance" HeaderText="上次余额" SortExpression="LastBalance" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CurrentBalance" HeaderText="本次余额" SortExpression="CurrentBalance" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TotalMoney" HeaderText="总购买金额" SortExpression="TotalMoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TotalInt" HeaderText="总购买量" SortExpression="TotalInt" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TotalBase" HeaderText="总购买字数" SortExpression="TotalBase" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OperType" HeaderText="业务类型(1-开户；2-充值；" SortExpression="OperType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PayType" HeaderText="充值类型(1-远程充值；2-写" SortExpression="PayType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InvoiceCode" HeaderText="发票号码" SortExpression="InvoiceCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OperDate" HeaderText="业务日期" SortExpression="OperDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterID" HeaderText="表编号" SortExpression="MeterID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OperatorID" HeaderText="操作员" SortExpression="OperatorID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SiteID" HeaderText="SiteID" SortExpression="SiteID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FactoryNum" HeaderText="FactoryNum" SortExpression="FactoryNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remark" HeaderText="Remark" SortExpression="Remark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RedOperId" HeaderText="RedOperId" SortExpression="RedOperId" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OperNum" HeaderText="OperNum" SortExpression="OperNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price2" HeaderText="Price2" SortExpression="Price2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price3" HeaderText="Price3" SortExpression="Price3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Divid1" HeaderText="Divid1" SortExpression="Divid1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Divid2" HeaderText="Divid2" SortExpression="Divid2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UseNumber1" HeaderText="UseNumber1" SortExpression="UseNumber1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UseNumber2" HeaderText="UseNumber2" SortExpression="UseNumber2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UseNumber3" HeaderText="UseNumber3" SortExpression="UseNumber3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CurTotalBuyNumber" HeaderText="CurTotalBuyNumber" SortExpression="CurTotalBuyNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InvoiceID" HeaderText="InvoiceID" SortExpression="InvoiceID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InvoiceType" HeaderText="InvoiceType" SortExpression="InvoiceType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WriteCardFlag" HeaderText="WriteCardFlag" SortExpression="WriteCardFlag" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TransactionId" HeaderText="TransactionId" SortExpression="TransactionId" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PayWay" HeaderText="PayWay" SortExpression="PayWay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OutTradeNo" HeaderText="OutTradeNo" SortExpression="OutTradeNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DepositDate" HeaderText="DepositDate" SortExpression="DepositDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DiscountsNum" HeaderText="DiscountsNum" SortExpression="DiscountsNum" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="OperID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="OperID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
