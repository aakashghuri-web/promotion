<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PromoTweet._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <link href="css/css.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <div id="divTudo">
        <form id="form1" runat="server" >
            <div style="padding-left:20px; padding-top:10px;">
                <asp:ImageButton ID="ImageButtonLogo" runat="server" 
                    ImageUrl="~/Imagens/logoPromotion2.png" />
            </div>
            <div align="center" style="margin-top:10px">
                <div align="center" style="width:400px;">
                    <div style="float:left; margin-top:33px">
                        <asp:TextBox ID="TextBoxSearch" runat="server" BorderStyle="None" 
                            Font-Bold="True" Font-Names="Consolas" Font-Size="Larger" 
                            ForeColor="#FFFF99" Width="270px" Height="54px"></asp:TextBox>
                    </div>
                    <div style="float:left">
                        <asp:ImageButton ID="ImageButtonSearch" runat="server" 
                            ImageUrl="~/Imagens/botaoSearch2.png" />
                    </div>
                    <div style="clear:left;"></div>
                    <br />
                    <br />
                </div>
            </div>
        <table>
            <tr>
                <td>
                    <div class="conteudo">
                        <asp:image ID="Image5" runat="server" ImageUrl="~/Imagens/divulgacao2.png"></asp:image>
                        <div class="tweetContainer">
                            <asp:Label ID="divulgacao" runat="server" Text=""></asp:Label>    
                        </div>
                    </div>
                </td>
                <td>
                    <div class="conteudo">
                        <asp:image ID="Image10" runat="server" ImageUrl="~/Imagens/retweetes2.png"></asp:image>
                        <div style="background-color:White">
                            <asp:Label ID="retweets" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </td>
                <td>
                    <div class="conteudo">
                        <asp:image ID="Image15" runat="server" ImageUrl="~/Imagens/descontos2.png"></asp:image>
                        <div style="background-color:White">
                            <asp:Label ID="descontos" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </td>
            </tr>
        </table>
        </form>
    </div>
</body>
</html>
