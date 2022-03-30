<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Buy.aspx.cs" Inherits="BidAndBuy.Buy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="content" style="margin-top: 30px;">
            <table>
                <tr>
                    <td style="text-align: center; font-weight: bold;" colspan="6">Buy</td>
                </tr>

                <tr>
                    <td colspan="3">
                        <table>
                            <tr>
                                <td>Item code</td>
                                <td>
                                    <asp:TextBox ID="ItemCode" runat="server" TextMode="SingleLine" Width="80px" IsRequiredField="True"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td colspan="2">
                                    <asp:RequiredFieldValidator ID="RequiredFieldItemCode" ControlToValidate="ItemCode" runat="server" Text="Bạn phải nhập ItemCode" BackColor="Red"></asp:RequiredFieldValidator></td>
                            </tr>
                            <tr>
                                <td>Item name</td>
                                <td colspan="2">
                                    <asp:TextBox ID="ItemName" runat="server" TextMode="SingleLine" Width="120px" IsRequiredField="True"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td colspan="2">
                                    <asp:RequiredFieldValidator ID="RequiredFieldItemName" ControlToValidate="ItemName" runat="server" Text="Bạn phải nhập ItemName" BackColor="Red"></asp:RequiredFieldValidator></td>
                            </tr>
                            <tr>
                                <td>Quantity</td>
                                <td colspan="2">
                                    <asp:TextBox ID="Quatity" runat="server" TextMode="Number" Width="80px" IsRequiredField="True"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td colspan="2">
                                    <asp:RequiredFieldValidator ID="RequiredFieldQuatity" ControlToValidate="Quatity" runat="server" Text="Bạn phải nhập Quatity" BackColor="Red"></asp:RequiredFieldValidator></td>
                            </tr>
                            <tr>
                                <td>price</td>
                                <td colspan="2">
                                    <asp:TextBox ID="Price" runat="server" TextMode="SingleLine" Width="80px" IsRequiredField="True"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td colspan="2">
                                    <asp:RequiredFieldValidator ID="RequiredFieldVPrice" ControlToValidate="Price" runat="server" Text="Bạn phải nhập Price" BackColor="Red"></asp:RequiredFieldValidator></td>
                            </tr>
                            <tr>
                                <td>Bid End Date</td>
                                <td colspan="2">
                                    <asp:Calendar ID="Date" runat="server" BackColor="#33ccff" Width="120px" Height="120px" IsRequiredField="True"></asp:Calendar>
                                </td>
                            </tr>

                        </table>
                    </td>
                    <td colspan="3">
                        <table runat="server" id="TblCart" visible="false" style="text-align: start;" border="1">
                            <tr>
                                <td colspan="3" style="text-align: center; font-weight: bold; border: none;">Credit Card No</td>
                            </tr>
                            <tr>
                                <td colspan="3" style="text-align: right; border: none;">
                                    <asp:TextBox ID="CartNumber" runat="server" TextMode="Number" Width="120px" IsRequiredField="True"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td colspan="2" style="border: none;">Required quantity</td>
                                <td style="border: none;">
                                    <asp:TextBox ID="NumberRequire" runat="server" TextMode="Number" Width="80px" IsRequiredField="True"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td colspan="3" style="border: none;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldCartNumber" ControlToValidate="CartNumber" runat="server" Text="Bạn phải nhập CartNumber" BackColor="Red"></asp:RequiredFieldValidator></td>
                            </tr>
                            <tr>
                                <td colspan="3" style="border: none;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldNumberRequire" ControlToValidate="NumberRequire" runat="server" Text="Bạn phải nhập NumberRequire" BackColor="Red"></asp:RequiredFieldValidator></td>
                            </tr>
                            <tr>
                                <td style="border: none;"></td>
                                <td style="border: none;">
                                    <asp:Button ID="ButtonConfirm" OnClick="ButtonConfirm_Click" runat="server" Text="Confirm" /></td>
                                <td style="border: none;">
                                    <asp:Button ID="ButtonCancel" OnClick="ButtonCancel_Click" runat="server" Text="Cancel" /></td>
                            </tr>

                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table>
                            <tr>
                                <td>Product Image</td>
                                <td rowspan="3">
                                    <img src="resource/img.jpg" style="height: 80px; width: 200px" /></td>
                            </tr>
                        </table>
                    </td>
                    <td>
                        <asp:Button ID="ButtonBuy" OnClick="ButtonBuy_Click" runat="server" Text="Buy" /></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Message" runat="server"></asp:Label></td>
                </tr>
            </table>
        </div>

    </form>
</body>
</html>
