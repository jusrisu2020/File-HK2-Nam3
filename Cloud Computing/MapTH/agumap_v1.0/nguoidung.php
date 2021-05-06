<!DOCTYPE html>
<html lang="en">
	<?php include "header.php"; ?>
	
	<body>
		<div class="container">
			<?php include "navbar.php"; ?>
			
			<div class="card mt-3">
				<h5 class="card-header">Người dùng</h5>
				<div class="card-body">
					<a href="nguoidung_them.php" class="btn btn-success mb-2"><i class="fal fa-plus"></i> Thêm người dùng</a>
					<table class="table table-bordered table-hover table-sm mb-0">
						<thead>
							<tr>
								<th width="5%">#</th>
								<th width="20%">Họ và tên</th>
								<th>Email</th>
								<th width="15%">Quyền hạn</th>
								<th width="5%">Sửa</th>
								<th width="5%">Xóa</th>
							</tr>
						</thead>
						<tbody>
						<?php
						include "ketnoi.php";
						$sql = "SELECT * FROM nguoi_dung";
						$danhsach = mysqli_query($link,$sql);
						$stt= 1;
						while($dong = mysqli_fetch_array($danhsach))
						{
							echo'<tr>';
							echo'<td class="text-center">'.$stt++.'</td>';
							echo'<td class="text-center">'.$dong['ho_ten'].'</td>';
							echo'<td class="text-center">'.$dong['email'].'</td>';
							
							echo'<td>';
								if($dong['quyen_han'] ==1)
										echo'<span class="badge badge-primary">QTV</span>';
									else 
										echo'<span class="badge badge-secondary">Menber</span>';

							echo'</td>';
							echo'<td class="text-center">'.$dong['quyen_han'].'</td>';
							echo'<td class="text-center"><a href="nguoidung_sua.php"><i class ="fal fa-edit"></i></a></td>';
							echo'<td class="text-center"><a href="nguoidung_xoa.php"><i class ="fal fa-trash text-danger"></i></a></td>';
							echo'</tr>';
						}
						?>
							
						</tbody>
					</table>
				</div>
			</div>
			
			<?php include "footer.php"; ?>
		</div>
		
		<?php include "javascript.php"; ?>
	</body>
</html>