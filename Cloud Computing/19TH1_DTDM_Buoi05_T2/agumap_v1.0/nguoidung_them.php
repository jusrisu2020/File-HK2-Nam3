<!DOCTYPE html>
<html lang="en">
	<?php include "header.php"; ?>
	
	<body>
		<div class="container">
			<?php include "navbar.php"; ?>
			
			<div class="card mt-3">
				<h5 class="card-header">Thêm người dùng</h5>
				<div class="card-body">
					<form action="nguoidung_them_xuly.php" method="post">
						<div class="form-group">
							<label for="ho_ten">Họ và tên</label>
							<input type="text" class="form-control" id="ho_ten" name="ho_ten" required />
						</div>
						<div class="form-group">
							<label for="email">Email</label>
							<input type="email" class="form-control" id="email" name="email" required />
						</div>
						<div class="form-group">
							<label for="mat_khau">Mật khẩu</label>
							<input type="password" class="form-control" id="mat_khau" name="mat_khau" required />
						</div>
						<div class="form-group">
							<label for="xac_nhan_mat_khau">Xác nhận mật khẩu</label>
							<input type="password" class="form-control" id="xac_nhan_mat_khau" name="xac_nhan_mat_khau" required />
						</div>
						
						<button type="submit" class="btn btn-primary"><i class="fal fa-user-plus"></i> Đăng ký</button>
					</form>
				</div>
			</div>
			
			<?php include "footer.php"; ?>
		</div>
		
		<?php include "javascript.php"; ?>
	</body>
</html>