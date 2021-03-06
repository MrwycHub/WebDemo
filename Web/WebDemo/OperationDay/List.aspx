﻿<%@ Page Title="OperationDay" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.OperationDay.List" %>
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
                            
		<asp:BoundField DataField="MeterID" HeaderText="MeterID" SortExpression="MeterID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BeginMonth" HeaderText="BeginMonth" SortExpression="BeginMonth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BeginNumber" HeaderText="BeginNumber" SortExpression="BeginNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EndMonth" HeaderText="EndMonth" SortExpression="EndMonth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EndNumber" HeaderText="EndNumber" SortExpression="EndNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UseNumber" HeaderText="UseNumber" SortExpression="UseNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceTypeID" HeaderText="PriceTypeID" SortExpression="PriceTypeID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceTypeName" HeaderText="PriceTypeName" SortExpression="PriceTypeName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price2" HeaderText="Price2" SortExpression="Price2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price3" HeaderText="Price3" SortExpression="Price3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FareMoney" HeaderText="FareMoney" SortExpression="FareMoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PayMark" HeaderText="PayMark" SortExpression="PayMark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OperType" HeaderText="OperType" SortExpression="OperType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OperDate" HeaderText="业务时间" SortExpression="OperDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OperatorID" HeaderText="OperatorID" SortExpression="OperatorID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="opermonth" HeaderText="opermonth" SortExpression="opermonth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterNumber" HeaderText="MeterNumber" SortExpression="MeterNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Divid1" HeaderText="Divid1" SortExpression="Divid1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Divid2" HeaderText="Divid2" SortExpression="Divid2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UseNumber1" HeaderText="UseNumber1" SortExpression="UseNumber1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UseNumber2" HeaderText="UseNumber2" SortExpression="UseNumber2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UseNumber3" HeaderText="UseNumber3" SortExpression="UseNumber3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ExtData1" HeaderText="ExtData1" SortExpression="ExtData1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ExtData2" HeaderText="ExtData2" SortExpression="ExtData2" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
