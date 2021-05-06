<!DOCTYPE html>
<html lang="en">
	<?php include "header.php"; ?>
	
	<body>
		<div class="container">
			<?php include "navbar.php"; ?>
			
			<div class="card mt-3">
				<h5 class="card-header">Thêm loại địa điểm</h5>
				<div class="card-body">
					<form action="loaidiadiem_them_xuly.php" method="post">
						<div class="form-group">
							<label for="dien_giai">Tên loại địa điểm</label>
							<input type="text" class="form-control" id="dien_giai" name="dien_giai" required />
						</div>
						<div class="form-group">
							<label for="bieu_tuong_web">Biểu tượng dùng trên web</label>
							<input type="text" class="form-control" id="bieu_tuong_web" name="bieu_tuong_web" required />
						</div>
						<div class="form-group">
							<label for="bieu_tuong_map">Biểu tượng dùng trên bản đồ</label>
							<input type="text" class="form-control" id="bieu_tuong_map" name="bieu_tuong_map" required />
						</div>
						
						<button type="submit" class="btn btn-primary"><i class="fal fa-save"></i> Thêm vào CSDL</button>
					</form>
				</div>
			</div>
			
			<?php include "footer.php"; ?>
		</div>
		
		<?php include "javascript.php"; ?>
	</body>
</html>