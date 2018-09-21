<%@ Page Title="CompanyInfo" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.CompanyInfo.List" %>
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
                    BorderWidth="1px" DataKeyNames="ID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CompanyNo" HeaderText="CompanyNo" SortExpression="CompanyNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Pwd" HeaderText="Pwd" SortExpression="Pwd" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AuthorizationCode" HeaderText="AuthorizationCode" SortExpression="AuthorizationCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IDCode" HeaderText="IDCode" SortExpression="IDCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EFileCode" HeaderText="EFileCode" SortExpression="EFileCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TaxAgencyCode" HeaderText="TaxAgencyCode" SortExpression="TaxAgencyCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AgentMark" HeaderText="AgentMark" SortExpression="AgentMark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ProjectName" HeaderText="ProjectName" SortExpression="ProjectName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ProjectCode" HeaderText="ProjectCode" SortExpression="ProjectCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AccountBank" HeaderText="AccountBank" SortExpression="AccountBank" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AccountNumber" HeaderText="AccountNumber" SortExpression="AccountNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CompanyAddress" HeaderText="CompanyAddress" SortExpression="CompanyAddress" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CompanyPhone" HeaderText="CompanyPhone" SortExpression="CompanyPhone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SleepTime" HeaderText="SleepTime" SortExpression="SleepTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UpdateTime" HeaderText="UpdateTime" SortExpression="UpdateTime" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
