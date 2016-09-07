<%@ Page Language="C#" EnableViewState="true" AutoEventWireup="true" CodeBehind="criteria selection.aspx.cs" Inherits="AirTenderingSystem.criteria_selection" %>


<!DOCTYPE html>
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
<script src="js/simpleCart.min.js"> </script>
<script src="js/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 240px;
        }
        .auto-style2 {
            width: 239px;
        }
        .auto-style3 {
            width: 239px;
            font-weight: bold;
        }
        .auto-style4 {
            width: 240px;
            font-weight: bold;
        }
    </style>
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
                                    <a href="adminpanel.aspx"><img src="images/logo1.png" alt=""></a>
                                </div>
                            </div>
                            <!--/.navbar-header-->
                            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                           <ul class="nav navbar-nav">
                                  <li><a href="adminpanel.aspx">Admin Home</a></li>
					        	    
						            <li><a href="Login.aspx">Login</a></li>
                                    <li><a href="Addadmins.aspx">Add Admin</a></li>
                                   <%--  <li><a href="TenderList.aspx">Evaluate Tenders</a></li>--%>
                                   <li><a href="ViewTernderapplys.aspx">View Evaluation Result</a></li>
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
<!--sign in start here-->
<div class="signin">
	<div class="container">
		<div class="signin-main">
			<h1>Supplier Eligibility</h1><br/>
            
            <div style="padding-left:200px"> 
                  <asp:DropDownList ID="username"  runat="server" Height="25px" Width="450px"/><br/>
		    <table class="nav-justified" border="1">
                <tr>
                    <td class="auto-style4">Criteria</td>
                    <td class="auto-style3">Yes</td>
                    <td><b>No</b></td>
                </tr>
                <tr>
                    <td class="auto-style1">(1) Availability of valid MOD registration (2016) in the appropriate Category as required by the tender conditions </td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton1" GroupName="1" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton2" GroupName="1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">(2) Availability of the required licenses and the following approvals for the Overhaul {
                    a. Interstate Aviation Committee Authority
                    b. OEM’s approval to conduct overhaul. 
                    c. Approval of the Ministry of Defence of the country of the bidder. 
                    d. Air agency approval by the local aviation authority. Example: FAA, EASA, CAA or Country’s Aviation Authority
                    e. Any other eligibilities of the bidder/repair plant.
                    f. Past performance in conducting same type overhaul.
                    }</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton3" GroupName="2" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton4" GroupName="2" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">(3) Initial inspection has been carried out by the bidders representative at SLAF facility</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton5" GroupName="3" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton6" GroupName="3" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">(4) Agreed to Overhaul in accordance with the current, manufacturer-approved overhaul manual.  </td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton7" GroupName="4" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton8" GroupName="4" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">(5) Agreed to use manufacture approved brand new parts during Overhaul PMA parts are not accepted by the SLAF. </td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton9" GroupName="5" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton10" GroupName="5" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">(6) Agreed to provide full TBO as per the SLAF work scope after overhaul.</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton11" GroupName="6" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton12" GroupName="6" runat="server" />
                    </td>
                </tr>

             
                <tr>
                    <td class="auto-style1">(7) Agreed to provide following documents, in the event on item/component declared as BER. {
                        (a)   Internal defects/ wear/  malfunction of each sub component
                        (b)   Supportive extract from the repair/overhaul manuals to justify the defect/ wear/declared as BER/Scrap.
                        (c)  Clear digital photos of each sub components to illustrate the defect
                        (d)  Cost breakdown with replacement/ rework required on each sub components.
                        }</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton13" GroupName="7" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton14" GroupName="7" runat="server" />
                    </td>
                </tr>
                    <tr>
                    <td class="auto-style1">(8) Agreed to provide following certificates along with consignment after completion of required work as per the SLAF work scope {
                        (a)  Certificate of origin and warranty
                        (b)  Conformity certificate for the goods dispatched confirming they are in strict conformity with specifications set out in the supplier’s Pro-forma Invoice
                        (c)  The quality and the quantity on the invoice, forwarded to the bank, is to be same as given in the packing list and also is as per the Pro-forma Invoice.
                        d) The certificate of conformity/release along with the WP-7B Engine as  per the Country Civil Aviation Authority, Manufactures  authority/Interstate Aviation Committee Authority/Ministry of Defense Authority EASA form 1 / CAA leaflets No.17/FAA from   8130-3. ( As applicable)
                        }</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton15" GroupName="8" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton16" GroupName="8" runat="server" />
                    </td>
                </tr>
                    <tr>
                    <td class="auto-style1">(9) Agreed to provide comprehensive Overhaul report (in the form of a booklet) furnished by the overhaul agency on completion of the Overhaul. The report should include the following {
                    (a) Release certificates / serviceable  tags of replaced parts indicating the condition 	of the spare
                    (b)  Test cell performance report of 
                    (c) Details of SBs incorporated during the Overhaul
                    }</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton17" GroupName="9" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton18" GroupName="9" runat="server" />
                    </td>
                </tr>
                    <tr>
                    <td class="auto-style1">(10) Agreed to provide validity of the offer as per the tender condition</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton19" GroupName="10" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton20" GroupName="10" runat="server" />
                    </td>
                </tr>
                    <tr>
                    <td class="auto-style1">(11) Agreed with the SLAF Payment terms</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton21" GroupName="11" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton22" GroupName="11" runat="server" />
                    </td>
                </tr>
                    <tr>
                    <td class="auto-style1">(12) Agreed to be indicated the remaining life available of the components (Life components), which are fitted during the Overhaul</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton23" GroupName="12" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton24" GroupName="12" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">(13) Packing of the items for delivery to SLAF should be according to BS1133 Section 1-22 as applicable or equivalent to ISO/EN or TQ standard.</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton25" GroupName="13" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton26" GroupName="13" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">(14) If the item found BER agreed to dispatch the component in its complete assemble condition.    </td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton27" GroupName="14" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton28" GroupName="14" runat="server" />
                    </td>
                </tr>
                   <tr>
                    <td class="auto-style1">(15) Agreed to make applicable entries on the Log book/Passport or Historical card with respect to overhaul.</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton29" GroupName="15" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton30" GroupName="15" runat="server" />
                    </td>
                </tr>
                   <tr>
                    <td class="auto-style1">(16) Availability of the Bid Bond if the Bid Value exceeds USD. 52,000.00 as specified in the SLAF tender enquiry</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton31" GroupName="16" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton32" GroupName="16" runat="server" />
                    </td>
                </tr>
                   <tr>
                    <td class="auto-style1">(17) Agreement to receive the payment by means of an irrevocable unconfirmed Letter of Credit if the value exceeds USD. 10,000.00</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton33" GroupName="17" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton34" GroupName="17" runat="server" />
                    </td>
                </tr>
                   <tr>
                    <td class="auto-style1">(18) The bidder shall agreed to provide a Performance Bond  for 10% of the Order Value and sign a contract with SLAF.</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton35" GroupName="18" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton36" GroupName="18" runat="server" />
                    </td>
                </tr>
                     <tr>
                    <td class="auto-style1">(19) Consent to sign an agreement with the SLAF in compliance to the requirements promulgated by the GOSL (the general conditions of contract appear on the Official website of the Sri Lanka Air Force).</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="RadioButton37" GroupName="19" runat="server" />
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton38" GroupName="19" runat="server" />
                    </td>
                </tr>
            </table>
                <asp:Button ID="Button1" runat="server" Text="Next" OnClick="Button1_Click" />
           </div>
		</div>
	</div>
</div>
<!--sign in end here-->
<!--footer strat here-->
<div class="footer">
	<div class="container">
		<div class="footer-main">
			<div class="ftr-grids-block">
				<div class="col-md-3 footer-grid">
					<ul>
					         <li>
                            <a href="product.html">Contact</a></li>
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
				
				</div>
		    <div class="clearfix"> </div>
		  </div>
		  <div class="copy-rights">
		     <p>© 2016 Shoplist. All Rights Reserved | Design by Vinu wejeshinha</a> </p>
		   </div>
		</div>
	</div>
</div>
<!--footer end here-->
        		</form>
</body>
</html>
