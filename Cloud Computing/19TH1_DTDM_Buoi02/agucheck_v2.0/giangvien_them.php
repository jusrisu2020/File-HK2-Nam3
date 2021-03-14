<!DOCTYPE html>
<html lang="en">
	<head>
		<!-- Required meta tags -->
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
		
		<!-- Bootstrap CSS -->
		<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" />
		<link rel="stylesheet" href="css/all.min.css" />
		
		<title>Thêm Giảng viên</title>
	</head>
	<body>
		<div class="container">
			<?php include "navbar.php"; ?>
			
			<div class="card mt-3">
				<h5 class="card-header">Thêm Giảng viên</h5>
				<div class="card-body">
						<form action="giangvien_them.php" method="post">
						  <div class="form-group">
							<label for="mgv">Mã Giảng Viên</label>
							<input type="text" class="form-control" id="mgv" name="mgv">
							
						  </div>
						  
						  <div class="form-group">
							<label for="hoten">Họ Và Tên</label>
							<input type="text" class="form-control" id="hoten" name="hoten">
						  </div>

						  <button type="submit" class="btn btn-primary">Thêm Mới</button>
						</form>
				</div>
			</div>
			
			<?php include "footer.php"; ?>
		</div>
		
		<?php include "javascript.php"; ?>
		
		<?php
		if(isset($_POST['mgv']))
		{
	?>
			<script>
				db.collection("giangvien").add({
					mgv: "<?php echo $_POST['mgv']; ?>",
					hoten:"<?php echo $_POST['hoten'];?>"
				})
				.then((docRef) => {
					//console.log("Document written with ID: ", docRef.id);
					location.href = "giangvien.php"
				})
				.catch((error) => {
					console.error("Error adding document: ", error);
				});
			</script>
		
	<?php
		}
	?>
	</body>
</html>