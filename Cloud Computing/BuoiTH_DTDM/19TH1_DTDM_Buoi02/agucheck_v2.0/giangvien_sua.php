<!DOCTYPE html>
<html lang="en">
	<head>
		<!-- Required meta tags -->
		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
		
		<!-- Bootstrap CSS -->
		<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" />
		<link rel="stylesheet" href="css/all.min.css" />
		
		<title>Sửa Giảng viên</title>
	</head>
	<body>
		<div class="container">
			<?php include "navbar.php"; ?>
			
			<div class="card mt-3">
				<h5 class="card-header">Sửa Giảng viên</h5>
				<div class="card-body">
						<form action="giangvien_sua.php" method="post">
							<input type="text" id="id" name="id" hidden>
						  <div class="form-group">
							<label for="mgv">Mã Giảng Viên</label>
							<input type="text" class="form-control" id="mgv" name="mgv">
							
						  </div>
						  
						  <div class="form-group">
							<label for="hoten">Họ Và Tên</label>
							<input type="text" class="form-control" id="hoten" name="hoten">
						  </div>

						  <button type="submit" class="btn btn-primary">Cập Nhật</button>
						</form>
				</div>
			</div>
			
			<?php include "footer.php"; ?>
		</div>
		
		<?php include "javascript.php"; ?>
		
			<?php
		if(isset($_GET['id']))
		{
	?>
		
		<script>

			/*----------------------------------------------------------------------------------------------------------------------------------*/
		
			var docRef = db.collection("giangvien").doc("<?php echo $_GET['id']; ?>");
			
			docRef.get().then((doc) => {
				if (doc.exists) {
					//console.log("Document data:", doc.data());
					$('#id').val(doc.id);
					$('#mgv').val(doc.data().mgv);
					$('#hoten').val(doc.data().hoten);
					
				} else {
					// doc.data() will be undefined in this case
					console.log("No such document!");
				}
			}).catch((error) => {
				console.log("Error getting document:", error);
			});
		</script>
		
			<?php
		}
		?>
		
		<?php
		if(isset($_POST['mgv']))
		{
	?>
			<script>
				var docRef = db.collection("giangvien").doc("<?php echo $_POST['id']; ?>");

			// Set the "capital" field of the city 'DC'
			docRef.update({
				mgv: "<?php echo $_POST['mgv']; ?>",
				hoten:"<?php echo $_POST['hoten'];?>"
			})
			.then(() => {
				//console.log("Document successfully updated!");
				location.href = "giangvien.php"
			})
			.catch((error) => {
				// The document probably doesn't exist.
				console.error("Error updating document: ", error);
			});
			
			</script>
		
	<?php
		}
	?>
	</body>
</html>