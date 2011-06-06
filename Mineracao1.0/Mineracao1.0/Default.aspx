<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mineracao1._0._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <link href="css/cssReset.css" rel="stylesheet" type="text/css" />
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
                            ForeColor="#FFFF99" Width="281px"></asp:TextBox>
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
        
        <div id="divTodoConteudo">
        
            <div class="conteudo">
                    <asp:image ID="Image5" runat="server" ImageUrl="~/Imagens/divulgacao2.png"></asp:image>
                    
                    <br />
                    <div style="background-color:White">
                        
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>    
                                            
                        <asp:ImageButton ID="ImageButton2" runat="server" 
                            ImageUrl="Imagens/setaBaixo.png"/>
                    
                    </div>
                    
                    
                </div>
                
                <div class="conteudo">
                    <asp:image ID="Image10" runat="server" ImageUrl="~/Imagens/retweetes2.png"></asp:image>
                    <br />
                    <div style="background-color:White">
                        <div id="div8" style="border-bottom-style:solid; border-bottom-color:Black;">
                            <div style="float:left; width:20%">
                                <asp:image ID="Image11" runat="server" ImageUrl="~/Imagens/foto.png"></asp:image>
                            </div>
                            <div style="width:80%;padding-left:4px;">
                                <a id="A8" target="_blank" href="http://twitter.com/@marinaalecrim" class="linksTweet">@marinaalecrim</a>
                                <br />
                                <label id="label8">Flashmob pela Educação no Marco Zero, Recife, PE</label>
                            </div>
                            <br />
                        </div>
                        
                        
                        <div id="div9" style="border-bottom-style:solid; border-bottom-color:Black;">
                            <div style="float:left; width:20%">
                                <asp:image ID="Image12" runat="server" ImageUrl="~/Imagens/foto.png"></asp:image>
                            </div>
                            <div style="width:80%;padding-left:4px;">
                                <a id="A9" target="_blank" href="http://twitter.com/@marinaalecrim" class="linksTweet">@marinaalecrim</a>
                                <br />
                                <label id="label9">Flashmob pela Educação no Marco Zero, Recife, PE</label>
                            </div>
                            <br />
                        </div>
                        
                        <div id="div10" style="border-bottom-style:solid; border-bottom-color:Black;">
                            <div style="float:left; width:20%">
                                <asp:image ID="Image13" runat="server" ImageUrl="~/Imagens/foto.png"></asp:image>
                            </div>
                            <div style="width:80%;padding-left:4px;">
                                <a id="A10" target="_blank" href="http://twitter.com/@marinaalecrim" class="linksTweet">@marinaalecrim</a>
                                <br />
                                <label id="label10">Flashmob pela Educação no Marco Zero, Recife, PE</label>
                            </div>
                            <br />
                        </div>
                        
                        <div id="div11" style="border-bottom-style:solid; border-bottom-color:Black;">
                            <div style="float:left; width:20%">
                                <asp:image ID="Image14" runat="server" ImageUrl="~/Imagens/foto.png"></asp:image>
                            </div>
                            <div style="width:80%;padding-left:4px;">
                                <a id="A11" target="_blank" href="http://twitter.com/@marinaalecrim" class="linksTweet">@marinaalecrim</a>
                                <br />
                                <label id="label11">Flashmob pela Educação no Marco Zero, Recife, PE</label>
                            </div>
                            <br />
                        </div>
                        
                        <div id="div2" style="border-bottom-style:solid; border-bottom-color:Black;">
                            <div style="float:left; width:20%">
                                <asp:image ID="Image2" runat="server" ImageUrl="~/Imagens/foto.png"></asp:image>
                            </div>
                            <div style="width:80%;padding-left:4px;">
                                <a id="A2" target="_blank" href="http://twitter.com/@marinaalecrim" class="linksTweet">@marinaalecrim</a>
                                <br />
                                <label id="label2">Flashmob pela Educação no Marco Zero, Recife, PE</label>
                            </div>
                            <br />
                        </div>
                        
                        <asp:ImageButton ID="ImageButton3" runat="server" 
                            ImageUrl="Imagens/setaBaixo.png"/>
                    
                    </div>
                    
                    
                </div>
                
                <div class="conteudo">
                    <asp:image ID="Image15" runat="server" ImageUrl="~/Imagens/descontos2.png"></asp:image>
                    <br />
                    <div style="background-color:White">
                        <div id="div12" style="border-bottom-style:solid; border-bottom-color:Black;">
                            <div style="float:left; width:20%">
                                <asp:image ID="Image16" runat="server" ImageUrl="~/Imagens/foto.png"></asp:image>
                            </div>
                            <div style="width:80%;padding-left:4px;">
                                <a id="A12" target="_blank" href="http://twitter.com/@marinaalecrim" class="linksTweet">@marinaalecrim</a>
                                <br />
                                <label id="label12">Flashmob pela Educação no Marco Zero, Recife, PE</label>
                            </div>
                            <br />
                        </div>
                        
                        
                        <div id="div13" style="border-bottom-style:solid; border-bottom-color:Black;">
                            <div style="float:left; width:20%">
                                <asp:image ID="Image17" runat="server" ImageUrl="~/Imagens/foto.png"></asp:image>
                            </div>
                            <div style="width:80%;padding-left:4px;">
                                <a id="A13" target="_blank" href="http://twitter.com/@marinaalecrim" class="linksTweet">@marinaalecrim</a>
                                <br />
                                <label id="label13">Flashmob pela Educação no Marco Zero, Recife, PE</label>
                            </div>
                            <br />
                        </div>
                        
                        <div id="div14" style="border-bottom-style:solid; border-bottom-color:Black;">
                            <div style="float:left; width:20%">
                                <asp:image ID="Image18" runat="server" ImageUrl="~/Imagens/foto.png"></asp:image>
                            </div>
                            <div style="width:80%;padding-left:4px;">
                                <a id="A14" target="_blank" href="http://twitter.com/@marinaalecrim" class="linksTweet">@marinaalecrim</a>
                                <br />
                                <label id="label14">Flashmob pela Educação no Marco Zero, Recife, PE</label>
                            </div>
                            <br />
                        </div>
                        
                        <div id="div15" style="border-bottom-style:solid; border-bottom-color:Black;">
                            <div style="float:left; width:20%">
                                <asp:image ID="Image19" runat="server" ImageUrl="~/Imagens/foto.png"></asp:image>
                            </div>
                            <div style="width:80%;padding-left:4px;">
                                <a id="A15" target="_blank" href="http://twitter.com/@marinaalecrim" class="linksTweet">@marinaalecrim</a>
                                <br />
                                <label id="label15">Flashmob pela Educação no Marco Zero, Recife, PE</label>
                            </div>
                            <br />
                        </div>
                        
                        <div id="div1" style="border-bottom-style:solid; border-bottom-color:Black;">
                            <div style="float:left; width:20%">
                                <asp:image ID="Image1" runat="server" ImageUrl="~/Imagens/foto.png"></asp:image>
                            </div>
                            <div style="width:80%;padding-left:4px;">
                                <a id="A1" target="_blank" href="http://twitter.com/@marinaalecrim" class="linksTweet">@marinaalecrim</a>
                                <br />
                                <label id="label1">Flashmob pela Educação no Marco Zero, Recife, PE</label>
                            </div>
                            <br />
                        </div>
                        
                        
                        
                        <asp:ImageButton ID="ImageButton4" runat="server" 
                            ImageUrl="Imagens/setaBaixo.png"/>
                    
                    </div>
                    
                    
                </div>
        
        
        </div>
        
        </form>
    
    </div>

    
</body>
</html>
