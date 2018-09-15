%rebase base
<form class="form-login" id="resetPass_form" data-toggle="validator" role="form" >
	<h2 class="form-login-heading">Change Password</h2>
	<label id="msg" style="color:red;"></label>
	<div class="login-wrap">
		<div class="form-group">
			<label>New Password:</label>
			<input type="password" name="txtResetPass" placeholder="Enter new Password" class="form-control" id="txtResetPass" data-error="Please enter New password (Minimum 8 characters)" pattern="(?=.*[a-zA-Z0-9]).{8,}" onchange="form.txtResetConfPass.pattern = this.value;" required>
			<span class="help-block with-errors"></span>
		</div>
		<div class="form-group">
			<label>Confirm Password:</label>
			<input type="password" name="txtResetConfPass" placeholder="Enter new Password again" class="form-control" id="txtResetConfPass" data-error="Re-enter same password" required>
			<span class="help-block with-errors"></span>
		</div>
		
		<button class="btn btn-theme btn-block blue" name="reset_password" id="reset_password" type="submit"><i class="fa fa-lock"></i> Submit</button>
		<hr>
	</div>
</form>	  	
