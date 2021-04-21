<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="linktojson._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <table>

            <tr>
                <th>ID</th>
                <td>
                    <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                </td>
            </tr>
            <tr>
                <th>Title</th>
                <td>
                    <asp:TextBox ID="txttitle" runat="server"></asp:TextBox>
                </td>
                <td></td>
            </tr>
            <tr>
                <th>Unit_Price</th>
                <td>
                    <asp:TextBox ID="txtunit" runat="server"></asp:TextBox>
                </td>
                <td></td>
            </tr>
            <tr>
                <th>Expire</th>
                <td>
                    <asp:TextBox ID="txtexpire" runat="server"></asp:TextBox>
                </td>
                <td></td>
            </tr>
                 <tr>
                <th>Manufacture</th>
                <td>
                    <asp:TextBox ID="txtmanu" runat="server"></asp:TextBox>
                </td>
                <td></td>
            </tr>
        </tr>
                 <tr>
                <th>Stock</th>
                <td>
                    <asp:TextBox ID="txtstock" runat="server"></asp:TextBox>
                </td>
                <td></td>
            </tr>


           
            <tr>
                <td>
                    <asp:Button ID="btnAdd" runat="server" Text="ADD" OnClick="btnAdd_Click1" />
                </td>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_Click"  />
                </td>
                <td>
                    <asp:Button ID="btnDelete" runat="server" Text="DELETE" OnClick="btnDelete_Click" />
                </td>
            </tr>
       <tr>

               

                <td colspan="3">
                    <asp:TextBox ID="main" runat="server"></asp:TextBox>
                     <asp:Button ID="Button1" runat="server" Text="Save To File" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>

               

                <td colspan="3">
                    <asp:GridView ID="GridView1" runat="server" ></asp:GridView>
                </td>
            </tr>
        </table>


</asp:Content>
