<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="Dashboard">
    <meta name="keyword" content="Dashboard, Bootstrap, Admin, Template, Theme, Responsive, Fluid, Retina">

    <title>SUDOKU - SEM STARS</title>

    <!-- Bootstrap core CSS -->
    <link href="/static/css/bootstrap.css" rel="stylesheet">
    <!--external css-->
    <link href="/static/font-awesome/css/font-awesome.css" rel="stylesheet" />    
    <link rel="stylesheet" type="text/css" href="/static/js/gritter/css/jquery.gritter.css" />
    
    <!-- Custom styles for this template -->
    <link href="/static/css/style.css" rel="stylesheet">
    <link href="/static/css/style-responsive.css" rel="stylesheet">
	<link rel="stylesheet" type="text/css" href="/static/css/table.css">
    
  </head>

  <body>

  <section id="container" >
      <!-- **********************************************************************************************************************************************************
      TOP BAR CONTENT & NOTIFICATIONS
      *********************************************************************************************************************************************************** -->
      <!--header start-->
      <header class="header black-bg">
              <div class="sidebar-toggle-box">
                  <div class="fa fa-bars tooltips" data-placement="right" data-original-title="Toggle Navigation"></div>
              </div>
            <!--logo start-->
            <!-- <a href="/" class="logo"><img src="/static/img/SemStarsLogo.png" alt="Logo" /> <b>SUDOKU - SEM STARS</b></a> -->
			<a href="/" class="logo"><b>SUDOKU - SEM STARS</b></a>
            <!--logo end-->
            
            <div class="top-menu">
            	<ul class="nav pull-right top-menu" id="mnuGuest" style="{{'display:none;' if session.get('id') else ''}}">
                    <li><a id="login" href="/login">Login</a></li>
					<li><a id="register" href="/register">Register</a></li>
            	</ul>
				<ul class="nav pull-right top-menu" id="mnuUser" style="{{'display:none;' if not session.get('id') else ''}}">
					<li><a id="editProfile" href="/edit_profile">Profile</a></li>
                    <li><a id="logout" href="/logout">Logout</a></li>
            	</ul>
            </div>
        </header>
      <!--header end-->
      
      <!-- **********************************************************************************************************************************************************
      MAIN SIDEBAR MENU
      *********************************************************************************************************************************************************** -->
      <!--sidebar start-->
      <aside>
          <div id="sidebar"  class="nav-collapse ">
              <!-- sidebar menu start-->
              <ul class="sidebar-menu" id="nav-accordion">
				<div style="{{'display:none;' if not session.get('id') else ''}}">
              	  <p class="centered"><a href="edit_profile" class="semStars"><img src="static/img/SemStarsLogo.png" class="img-circle" width="100"></a></p>
              	  <h5 class="centered" id="userName">{{session.get('userName') if session.get('id') else ''}}</h5>
				  </div>
                  <!--<li class="mt">
                      <a class="active" href="index.html">
                          <i class="fa fa-dashboard"></i>
                          <span>Dashboard</span>
                      </a>
                  </li> -->
					<li class="sub-menu">
						<a href="javascript:;" >
							<i class="fa fa-cogs"></i>
							<span>Difficulty</span>
						</a>
						<ul>
							<li>
								<a href="/#easy_level" class="game_level" id="easy_level">
									<i class="fa fa-puzzle-piece"></i>
									<span>Easy</span>
								</a>
							</li>
							<li>
								<a href="/#medium_level" class="game_level" id="medium_level">
									<i class="fa fa-circle-o-notch"></i>
									<span>Medium</span>
								</a>
							</li>
							<li>
								<a href="/#hard_level" class="game_level" id="hard_level">
									<i class="fa fa-rocket"></i>
									<span>Hard</span>
								</a>
							</li>
						</ul>                  
				  </li>
                  <li class="sub-menu">
                      <a href="/rules" >
                          <i class="fa fa-magic"></i>
                          <span>Rules</span>
                      </a>                      
                  </li>
				  
				  
				  
				  <li class="sub-menu">
                      <a href="/contact_us" >
                          <i class="fa fa-users"></i>
                          <span>Contact Us</span>
                      </a>                      
                  </li>
              </ul>
              <!-- sidebar menu end-->
          </div>
      </aside>
      <!--sidebar end-->
      
      <!-- **********************************************************************************************************************************************************
      MAIN CONTENT
      *********************************************************************************************************************************************************** -->
      <!--main content start-->
		<section id="main-content">
			<section class="wrapper">
			%include
			</section>
		</section>                  
      <!-- **********************************************************************************************************************************************************
      RIGHT SIDEBAR CONTENT
      *********************************************************************************************************************************************************** -->                  
                
      <!--main content end-->
      <!--footer start-->
      <footer class="site-footer">
          <div class="text-center">
              &copy;2016 - SEM STARS
              <a href="/" class="go-top">
                  <i class="fa fa-angle-up"></i>
              </a>
          </div>
      </footer>
      <!--footer end-->
  </section>
  
    <!-- js placed at the end of the document so the pages load faster -->
    
    <script src="static/js/jquery-1.8.3.min.js"></script>
    <script src="static/js/bootstrap.min.js"></script>
	<script src="static/js/validator.min.js"></script>
	<script src="static/js/jquery.scrollTo.min.js" type="text/javascript"></script>
    <script class="include" type="text/javascript" src="static/js/jquery.dcjqaccordion.2.7.js"></script>    
	<script src="static/js/jquery.nicescroll.js" type="text/javascript"></script>
    
    <!--common script for all pages-->
    <script src="static/js/common-scripts.js"></script>
    
    <!--script required for game timers-->
    <script type="text/javascript" src="static/js/underscore-min.js"></script>
    <script type="text/javascript" src="static/js/jquery.countdown.js"></script>
    <script type="text/template" id="countdown-tpl"><%= m %>:<%= s %></script>
    
    <!--script for game pages-->
    <script type="text/javascript" src="static/js/game.js"></script>	
    <script type="text/javascript" src="static/js/edit_profile.js"></script>
    
    <script type="text/javascript" src="static/js/gritter/js/jquery.gritter.js"></script>
    <script type="text/javascript" src="static/js/gritter-conf.js"></script>
	
	<script type="text/javascript">
        $(document).ready(function () {
        var unique_id = $.gritter.add({
            // (string | mandatory) the heading of the notification
            title: 'Welcome to SUDOKU -SEM STARS!',
            // (string | mandatory) the text inside the notification
            text: 'Experience the Sudoku Game play.',
            // (string | optional) the image to display on the left
            image: 'static/img/SemStarsLogo.png',
            // (bool | optional) if you want it to fade out on its own or just sit there
            sticky: true,
            // (int | optional) the time you want it to be alive for before fading out
            time: '',
            // (string | optional) the class name you want to apply to that specific message
            class_name: 'my-sticky-class'
        });

        return false;
        });
	</script>
	
	<script type="application/javascript">
        $(document).ready(function () {
            $("#date-popover").popover({html: true, trigger: "manual"});
            $("#date-popover").hide();
            $("#date-popover").click(function (e) {
                $(this).hide();
            });
		});

    </script>
  </body>
</html>
