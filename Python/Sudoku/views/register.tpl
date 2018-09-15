%rebase base
<form class="form-login" id="frmRegister" action="#" data-toggle="validator" id="regi_form" role="form" method="post">
	<h2 class="form-login-heading">Register now</h2>
	<label id="msg" style="color:red;"></label>
	<div class="login-wrap">
		<div class="form-group">
			<!--<label>Email:</label>-->
			<input type="email" name="txtRegEmail" placeholder="Email" class="form-control" id="txtRegEmail" data-error="Please enter Email ID" required pattern="([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+">
			<span class="help-block with-errors"></span>
		</div>
		<div class="form-group">
			<!--<label>Name</label>-->
			<input type="text" name="txtRegName" placeholder="Name" class="form-control" id="txtRegName" data-error="Please enter a valid name" required pattern="([a-zA-Z])+">
			<span class="help-block with-errors"></span>
		</div>
		<div class="form-group">
			<!--<label>Password:</label>-->
			<input type="password" name="txtRegPass" placeholder="Password" class="form-control" id="txtRegPass" data-error="Please enter New password (Minimum 8 characters)" required pattern="(?=.*[a-zA-Z0-9]).{8,}" onchange="form.txtRegConfPass.pattern = this.value;">
			<span class="help-block with-errors"></span>
		</div>
		<div class="form-group">
			<!--<label>Confirm Password:</label>-->
			<input type="password" name="txtRegConfPass" placeholder="Confirm Password" class="form-control" id="txtRegConfPass" data-error="Re-enter same password" required>
			<span class="help-block with-errors"></span>
		</div>
		<div class="form-group">
			<!--<label>Zip Code:</label>-->
			<input type="text" name="txtRegZip" placeholder="Zip Code" class="form-control" id="txtRegZip" data-error="Please enter a valid zipcode" required pattern="([0-9])+">
			<span class="help-block with-errors"></span>
		</div>
		<div class="form-group">
			<!--<label>Secret Question:</label>-->
			<input type="text" name="txtRegScrQ" placeholder="Secret Question" class="form-control" id="txtRegScrQ" data-error="Please enter Secret Question" required>
			<span class="help-block with-errors"></span>
		</div>
		<div class="form-group">
			<!--<label>Secret Answer:</label>-->
			<input type="text" name="txtRegScrA" placeholder="Secret Answer" class="form-control" id="txtRegScrA" data-error="Please enter Secret Answer" required>
			<span class="help-block with-errors"></span>
		</div>
		<button class="btn btn-theme btn-block blue" id="btnRegister" href="" type="button"><i class="fa fa-lock"></i> Register</button>
	</div>
</form>	  	
