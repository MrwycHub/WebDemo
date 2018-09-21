<%@ Page Title="DataExportCodeInfo" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.DataExportCodeInfo.List" %>
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
                            
		<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="StrSql" HeaderText="StrSql" SortExpression="StrSql" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ShowDeptCondition" HeaderText="ShowDeptCondition" SortExpression="ShowDeptCondition" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InfoCondition" HeaderText="InfoCondition" SortExpression="InfoCondition" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DateCondition" HeaderText="DateCondition" SortExpression="DateCondition" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ExtCondition" HeaderText="ExtCondition" SortExpression="ExtCondition" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AscString" HeaderText="AscString" SortExpression="AscString" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GridViewWidth" HeaderText="GridViewWidth" SortExpression="GridViewWidth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ExportType" HeaderText="ExportType" SortExpression="ExportType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ShowHeader" HeaderText="ShowHeader" SortExpression="ShowHeader" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SplitChar" HeaderText="SplitChar" SortExpression="SplitChar" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CreateDbfSql" HeaderText="CreateDbfSql" SortExpression="CreateDbfSql" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DbfFileName" HeaderText="DbfFileName" SortExpression="DbfFileName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remark" HeaderText="Remark" SortExpression="Remark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EndDateCondition" HeaderText="EndDateCondition" SortExpression="EndDateCondition" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ShowOtherHeader" HeaderText="ShowOtherHeader" SortExpression="ShowOtherHeader" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ExportCols" HeaderText="ExportCols" SortExpression="ExportCols" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
