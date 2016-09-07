<%@ Page enableEventValidation="false"  Language="C#"  AutoEventWireup="true" CodeBehind="ViewTernderapplys.aspx.cs" Inherits="AirTenderingSystem.ViewTernderapplys" %>


<!DOCTYPE HTML>
<html>
<head>
<title>E - Tendering System</title>
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all">
<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
<script src="js/jquery-1.11.0.min.js"></script>
<!-- Custom Theme files -->
<link href="css/style.css" rel="stylesheet" type="text/css" media="all"/>
<!-- Custom Theme files -->
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Shoplist Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!--Google Fonts-->
<link href='//fonts.googleapis.com/css?family=Hind:400,500,300,600,700' rel='stylesheet' type='text/css'>
<link href='//fonts.googleapis.com/css?family=Oswald:400,700,300' rel='stylesheet' type='text/css'>
<!-- start-smoth-scrolling -->
<script type="text/javascript" src="js/move-top.js"></script>
<script type="text/javascript" src="js/easing.js"></script>

<!-- //end-smoth-scrolling -->

<!-- //the jScrollPane script -->
<script src="js/simpleCart.min.js"> </script>
<script src="js/bootstrap.min.js"></script>
</head>
<body>
       <form runat="server">
<!--header strat here-->
 <div class="header">
        <div class="container">
            <div class="header-main">
                <div class="top-nav">
                    <div class="content white">
                        <nav class="navbar navbar-default" role="navigation">
                            <div class="navbar-header">
                                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                                    <span class="sr-only">Toggle navigation</span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                </button>
                                <div class="navbar-brand logo">
                                    <a href="EvaluvatorPanel.aspx"><img src="images/logo1.png" alt=""></a>
                                </div>
                            </div>
                            <!--/.navbar-header-->
                            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                            <ul class="nav navbar-nav">
                                  <li><a href="EvaluvatorPanel.aspx">Home</a></li>
                          <%--     <li><a href="AddTender.aspx">Add Tenders</a></li>--%>
                               <li><a href="ViewTernderapplys.aspx">Evaluate Tenders</a></li>
                              <li><a href="Viewitemhisty.aspx">View ItemHistry</a></li>
                                </ul>
                            </div>
                            <!--/.navbar-collapse-->
                        </nav>
                        <!--/.navbar-->
                    </div>
                </div>
                <div class="header-right">
                    <div class="search">
                        <div class="head-signin">
                            <h5><a href="Login.aspx"><i class="hd-dign"></i>Sign in</a></h5>
                        </div>
                        <div class="clearfix"> </div>
                    </div>
                </div>
                <div class="clearfix"> </div>
            </div>
        </div>
    </div>
<!--header end here-->
<!--product start here-->
<div class="product">
	<div class="container">
		<div class="product-main">
			  <div class=" product-menu-bar">
			    	<div class="col-md-3 prdt-right">
					<div class="w_sidebar">
						<section class="sky-form">
							<h4>Filter seller</h4>
								<div class="row1 row2 scroll-pane">
									<div class="col col-4">
                                        <asp:TextBox ID="itemid" runat="server" placeholder="Enter item ID"  TextMode="Number" />  <br />
                                        <asp:RadioButton ID="RadioButton1" GroupName="remark" OnCheckedChanged="RadioButton1_CheckedChanged" runat="server" AutoPostBack="True" /><i></i>Lowest Deliwary time     <br />
                                        <asp:RadioButton ID="RadioButton2" GroupName="remark" OnCheckedChanged="RadioButton2_CheckedChanged" AutoPostBack="True"  runat="server" /><i></i>Best seller
                                        <asp:Literal ID="erromessage" Text="" runat="server"/>
                                    </div>
								</div>						
						</section>
					</div>
				</div>
			  </div>	
			  <div class="col-md-9 product-block">
                  <p><asp:Literal ID="Literal8"  runat="server"/></p>
                  <asp:GridView ID="rejected" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                      <AlternatingRowStyle BackColor="White" />
                      <EditRowStyle BackColor="#2461BF" />
                      <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                      <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                      <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                      <RowStyle BackColor="#EFF3FB" />
                      <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                      <sortedascendingcellstyle backcolor="#F5F7FB" />
                      <sortedascendingheaderstyle backcolor="#6D95E1" />
                      <sorteddescendingcellstyle backcolor="#E9EBEF" />
                      <sorteddescendingheaderstyle backcolor="#4870BE" />
                  </asp:GridView>
                  <br /><br /><br />
                  <p><asp:Literal ID="Literal9"  runat="server"/></p>
                  <asp:GridView ID="noteligibel" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                      <AlternatingRowStyle BackColor="White" />
                      <EditRowStyle BackColor="#2461BF" />
                      <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                      <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                      <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                      <RowStyle BackColor="#EFF3FB" />
                      <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                      <sortedascendingcellstyle backcolor="#F5F7FB" />
                      <sortedascendingheaderstyle backcolor="#6D95E1" />
                      <sorteddescendingcellstyle backcolor="#E9EBEF" />
                      <sorteddescendingheaderstyle backcolor="#4870BE" />
                  </asp:GridView>
                  <br /><br /><br />
             <p><asp:Literal ID="Literal10"  runat="server"/></p>
			 <asp:DataList ID="itemlist" runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" RepeatColumns="3">
                <ItemTemplate>
                    <div id="g" style="height:190px ; width:370px;">
                    <p><asp:Label ID="toplabel" runat="server" Font-Bold="true" Text="Top Seller" /></p>
                    <p><asp:Label ID="username" runat="server" Font-Bold="true" Text='<%# Eval("username") %>' /></p>
                        <asp:Literal ID="ENDdate" Text="submit Date :" runat="server"/><asp:Literal ID="Literal6" Text='<%# Eval("applydate") %>' runat="server"/><br />
                        <asp:Literal ID="Literal3" Text="Price :" runat="server"/><asp:Literal ID="Literal4" Text='<%# Eval("prices") %>' runat="server"/><br />
                        <asp:Literal ID="contiti" Text="Delivery Date :" runat="server"/><asp:Literal ID="Literal1" Text='<%# Eval("DelivaeryDate") %>' runat="server"/><br />
                          <asp:Literal ID="Literal5" Text="Warantee :" runat="server"/><asp:Literal ID="Literal7" Text='<%# Eval("Waranntee") %>' runat="server"/><br />
                        <asp:Literal ID="Literal2" Text="________________________________________" runat="server"/>
                       <asp:LinkButton ID="loaditems" OnClick="loaditems_Click" CommandArgument='<%# Eval("username") %>'  runat="server" >
                       <div class="btn btn-primary btn-normal btn-inline " target="_self" title="Get It">View Profile</div>
                       </asp:LinkButton>
                    </div>
                </ItemTemplate>
           </asp:DataList>
			  </div>
		</div>
	</div>
</div>


<div class="footer">
	<div class="container">
		<div class="footer-main">
			<div class="ftr-grids-block">
				<div class="col-md-3 footer-grid">
					<ul>
						 <li><a href="product.html">Contact</a></li>
                            <li><a href="product.html">Login</a></li>
                            <li><a href="product.html">Singup</a></li>
                            <li><a href="product.html">ViewTenders</a></li>
                            <li><a href="product.html">Add tenders</a></li>
					</ul>
				</div>
				<div class="col-md-3 footer-grid">
					<ul>
						<li><a href="login.html">Your Account</a></li>
						<li><a href="contact.html">Contact Us</a></li>
						<li><a href="product.html">Store Locator</a></li>
						<li><a href="pressroom.html">Press Room</a></li>
					</ul>
				</div>
				<div class="col-md-3 footer-grid">
					<ul>
						<li><a href="terms.html">Website Terms</a></li>
						<li><select class="country">
										<option value="select your location">Select Country</option>
										<option value="saab">Australia</option>
										<option value="fiat">Singapore</option>
										<option value="audi">London</option>
									</select>
							
						</li>
						<li><a href="shortcodes.html">Short Codes</a></li>
					</ul>
				</div>
				<div class="col-md-3 footer-grid-icon">
					<ul>
						<li><a href="#"><span class="u-tub"> </span></a></li>
						<li><a href="#"><span class="instro"> </span></a></li>
						<li><a href="#"><span class="twitter"> </span></a></li>
						<li><a href="#"><span class="fb"> </span></a></li>
						<li><a href="#"><span class="print"> </span></a></li>
					</ul>
					<form>
					<input class="email-ftr" type="text" value="Newsletter" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Newsletter';}">
					<input type="submit" value="Submit"> 
					</form>
				</div>
		    <div class="clearfix"> </div>
		  </div>
		  <div class="copy-rights">
		     <p>© 2016 Shoplist. All Rights Reserved | Design by  <a href="http://w3layouts.com/" target="_blank">W3layouts</a> </p>
		   </div>
		</div>
	</div>
</div>
   </form>
</body>
</html>