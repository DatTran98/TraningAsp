<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListUser.aspx.cs" Inherits="Adonet.ListUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align: center;">Danh sách User Gridview</h1>
            <br />
            <asp:GridView ID="GridViewUser" runat="server" Width="100%" CellPadding="4" ForeColor="#333333" DataKeyNames="ID" AutoGenerateColumns="false" OnRowEditing="GridViewUser_RowEditing"
                OnRowCancelingEdit="GridViewUser_RowCancelingEdit" OnRowUpdating="GridViewUser_RowUpdating">
                <Columns>
                    <asp:CommandField ShowEditButton="true" />
                    <asp:BoundField DataField="NAME" HeaderText="Name" />
                    <asp:BoundField DataField="BIRTH_DAY" HeaderText="BirthDay" />
                    <asp:BoundField DataField="BIRTH_PLACE" HeaderText="BirthPalce" />
                    <asp:BoundField DataField="ID" HeaderText="ID" Visible="false" />
                </Columns>
            </asp:GridView>
            <br />
            <h1 style="text-align: center;">Danh sách User Datalist</h1>
            <asp:DataList ID="DataListUser" runat="server" DataKeyField="ID" Width="100%"
                OnEditCommand="DataListUser_EditCommand"
                OnUpdateCommand="DataListUser_UpdateCommand"
                OnCancelCommand="DataListUser_CancelCommand">

                <HeaderTemplate>
                    <table style="width: 100%; border: 1px solid black;">
                        <tr>
                            <th style="align-content: center; width: 50px; border: 1px solid black;"></th>
                            <th style="align-content: center; width: 120px; border: 1px solid black;">Name</th>
                            <th style="align-content: center; width: 120px; border: 1px solid black;">BirthDay</th>
                            <th style="align-content: center; width: 120px; border: 1px solid black;">BirthPlace</th>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                    <table style="width: 100%;">
                        <tr>
                            <td style="align-content: center; width: 50px;">
                                <asp:LinkButton
                                    ID="cmdEdit" CommandName="Edit" Text="Edit" ForeColor="Black" runat="server"></asp:LinkButton>
                            </td>
                            <td style="align-content: center; width: 120px;">
                                <asp:Label ID="lbName" runat="server" Text='<%# Eval("NAME") %>' />
                            </td>
                            <td style="align-content: center; width: 120px;">
                                <asp:Label ID="lbBirthDay" runat="server" Text='<%# Eval("BIRTH_DAY") %>' />
                            </td>
                            <td style="align-content: center; width: 120px;">
                                <asp:Label ID="lbBirthPlace" runat="server" Text='<%# Eval("BIRTH_PLACE") %>' />
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
                <EditItemTemplate>
                    <table style="width: 100%;">
                        <tr>
                            <td style="align-content: center; width: 50px;">
                                <asp:LinkButton ID="cmdUpdate" CommandName="Update" Text="Update" runat="server"></asp:LinkButton>
                                <asp:LinkButton ID="cmdCancel" CommandName="Cancel" Text="Cancel" runat="server"></asp:LinkButton>
                            </td>
                            <td style="align-content: center; width: 120px;">
                                <asp:Label ID="lblID_Edit" runat="server" Visible="false" Text='<%# Eval("ID") %>' />
                                <asp:TextBox ID="txtName" Width="100px" runat="server" Text='<%# Bind("NAME") %>' />
                            </td>
                            <td style="align-content: center; width: 120px;">
                                <asp:TextBox ID="txtBirthday" runat="server" Width="150px" Text='<%# Bind("BIRTH_DAY") %>' />
                            </td>
                            <td style="align-content: center; width: 120px;">
                                <asp:TextBox ID="txtBirthPlace" runat="server" Width="100px" Text='<%# Bind("BIRTH_PLACE") %>' />
                            </td>
                        </tr>
                    </table>
                </EditItemTemplate>
            </asp:DataList>

        </div>
    </form>
</body>
</html>
