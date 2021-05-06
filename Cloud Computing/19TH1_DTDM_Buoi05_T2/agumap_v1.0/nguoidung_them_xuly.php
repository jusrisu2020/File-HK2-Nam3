<!DOCTYPE html>
<html lang="en">
	<?php include "header.php"; ?>
	
	<body>
		<div class="container">
			<?php include "navbar.php"; ?>
			
			<div class="card mt-3">
				<h5 class="card-header">Xử lý thêm người dùng</h5>
				<div class="card-body">
					<?php
						include "ketnoi.php";
						include "thuvien.php";
						
						// Lấy thông tin từ form
						$ht = $_POST['ho_ten'];
						$e = $_POST['email'];
						$mk = $_POST['mat_khau'];
						$xnmk = $_POST['xac_nhan_mat_khau'];
						
						// Kiểm tra
						if(trim($ht) == "")
							ThongBaoLoi("Họ và tên không được bỏ trống.");
						elseif(trim($e) == "")
							ThongBaoLoi("Email không được bỏ trống.");
						elseif(trim($mk) == "")
							ThongBaoLoi("Mật khẩu không được bỏ trống.");
						elseif($mk != $xnmk)
							ThongBaoLoi("Xác nhận mật khẩu không chính xác.");
						else
						{
							// Mã hóa mật khẩu
							$mk = sha1($mk);
							
							// Lưu vào CSDL
							$sql = "INSERT INTO `nguoi_dung`(`ho_ten`, `email`, `mat_khau`, `quyen_han`) 
									VALUES ('$ht', '$e', '$mk', 2)";
							$kq = mysqli_query($link, $sql);
							
							if($kq)
								header("Location: nguoidung.php");
							else
								ThongBaoLoi("Lỗi truy vấn: " . mysqli_error($link));
						}
					?>
				</div>
			</div>
			
			<?php include "footer.php"; ?>
		</div>
		
		<?php include "javascript.php"; ?>
		<script>
			
		</script>
	</body>
</html>