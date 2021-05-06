<!DOCTYPE html>
<html lang="en">
	<?php include "header.php"; ?>
	
	<body>
		<div class="container">
			<?php include "navbar.php"; ?>
			
			<div class="card mt-3">
				<h5 class="card-header">Thêm địa điểm</h5>
				<div class="card-body">
					<form action="diadiem_them_xuly.php" method="post">
						<div class="form-group">
							<label for="TenDiaDiem">Tên địa điểm</label>
							<input type="text" class="form-control" id="TenDiaDiem" name="TenDiaDiem" required />
						</div>
						<div class="form-group">
							<label for="DiaChi">Địa chỉ</label>
							<input type="text" class="form-control" id="DiaChi" name="DiaChi" required />
						</div>
						<div class="form-group">
							<label for="ViDo">Vĩ độ</label>
							<input type="text" class="form-control" id="ViDo" name="ViDo" required />
						</div>
						<div class="form-group">
							<label for="KinhDo">Kinh độ</label>
							<input type="text" class="form-control" id="KinhDo" name="KinhDo" required />
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