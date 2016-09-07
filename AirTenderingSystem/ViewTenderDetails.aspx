<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTenderDetails.aspx.cs" Inherits="AirTenderingSystem.ViewTenderDetails" %>


<!DOCTYPE HTML>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
	<script type="text/javascript">
			jQuery(document).ready(function($) {
				$(".scroll").click(function(event){		
					event.preventDefault();
					$('html,body').animate({scrollTop:$(this.hash).offset().top},1000);
				});
			});
	</script>
<!-- //end-smoth-scrolling -->
<!-- the jScrollPane script -->
<script type="text/javascript" src="js/jquery.jscrollpane.min.js"></script>
		<script type="text/javascript" id="sourcecode">
			$(function()
			{
				$('.scroll-pane').jScrollPane();
			});
		</script>
<!-- //the jScrollPane script -->
<script src="js/simpleCart.min.js"> </script>
<script src="js/bootstrap.min.js"></script>
</head>
<body>
<form runat="server"> 
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
                                    <a href="index.aspx"><img src="images/logo1.png" alt=""></a>
                                </div>
                            </div>
				   <!--/.navbar-header-->
                            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                                   <ul class="nav navbar-nav">
                                  <li><a href="EvaluvatorPanel.aspx">Evaluvator Home</a></li>
					        	
						            <li><a href="Login.aspx">Login</a></li>
                                 <%--   <li><a href="Addadmins.aspx">Add Admin</a></li>--%>
                                     <li><a href="TenderList.aspx">Evaluate Tenders</a></li>
                                   <li><a href="ViewTernderapplys.aspx">View Evaluation Result</a></li>
                                </ul>
                            </div>
					    <!--/.navbar-collapse-->
		</nav>
					<!--/.navbar-->
				</div>
			</div>
	
		 <div class="clearfix"> </div>
		</div>
	</div>
</div>

<div class="product">
	<div class="container">
		<div class="product-main">
            <asp:DataList ID="itemlist" runat="server" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" RepeatColumns="3">
                <ItemTemplate>
                    <div id="g" style="height:190px ; width:370px;">
                        <asp:Literal ID="ENDdate" Text="UserID :" runat="server"/><asp:Literal ID="Literal6" Text='<%# Eval("userID") %>' runat="server"/><br />
                        <asp:Literal ID="Literal3" Text="Person Username:" runat="server"/><asp:Literal ID="Literal4" Text='<%# Eval("username") %>' runat="server"/><br />
                        <asp:Literal ID="contiti" Text="Person Password:" runat="server"/><asp:Literal ID="Literal1" Text='<%# Eval("password") %>' runat="server"/><br />
                          <asp:Literal ID="Literal5" Text="Person Email:" runat="server"/><asp:Literal ID="Literal7" Text='<%# Eval("email") %>' runat="server"/><br />
                        <asp:Literal ID="Literal2" Text="________________________________________" runat="server"/>
                  <asp:LinkButton ID="stopdentering" OnClick="stopdentering_Click" CommandArgument='<%# Eval("userID") %>'  runat="server" >
                       <div class="btn btn-primary btn-normal btn-inline " target="_self" title="Get It">Confirm Seller</div>
                       </asp:LinkButton>
                    </div>
                </ItemTemplate>
           </asp:DataList>
		</div>
	</div>
</div>

<div class="footer">
	<div class="container">
		<div class="footer-main">
			<div class="ftr-grids-block">
				<div class="col-md-3 footer-grid">
					<ul>
						<li><a href="product.html">Accessories</a></li>
						<li><a href="product.html">Hand bags</a></li>
						<li><a href="product.html">Clothing</a></li>
						<li><a href="product.html">Brands</a></li>
						<li><a href="product.html">Watches</a></li>
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
				
				</div>
		    <div class="clearfix"> </div>
		  </div>
		  <div class="copy-rights">
		     <p>© 2016 Shoplist. All Rights Reserved | Design by  <a href="http://w3layouts.com/" target="_blank">W3layouts</a> </p>
		   </div>
		</div>
	</div>
</div>
<!--footer end here-->
    </form>
</body>
</html>