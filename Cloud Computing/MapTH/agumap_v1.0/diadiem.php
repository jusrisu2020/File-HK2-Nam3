<!DOCTYPE html>
<html lang="en">
	<?php include "header.php"; ?>
	
	<body>
		<div class="container">
			<?php include "navbar.php"; ?>
			
			<div class="card mt-3">
				<h5 class="card-header">Địa điểm</h5>
				<div class="card-body">
					<a href="diadiem_them.php" class="btn btn-success mb-2"><i class="fal fa-plus"></i> Thêm địa điểm</a>
					<table class="table table-bordered table-hover table-sm mb-0">
						<thead>
							<tr>
								<th width="5%">#</th>
								<th width="20%">Tên địa điểm</th>
								<th>Địa chỉ</th>
								<th width="15%">Vĩ độ</th>
								<th width="15%">Kinh độ</th>
								<th width="5%">Sửa</th>
								<th width="5%">Xóa</th>
							</tr>
						</thead>
						<tbody>
						<?php
						include "ketnoi.php";
						$sql = "SELECT * 
								FROM nguoi_dung n, dia_diem d , loai_dia_diem l
								WHERE d.id_loai= l.id AND d.id_user = n.id";
						$danhsach = mysqli_query($link,$sql);
						$stt = 1;
						while($dong = mysqli_fetch_array($danhsach))
						{
						echo'<tr>';
								echo'<td>'.$stt++.'</td>';
								echo'<td>'.$dong['ten_dia_diem'].'</td>';
								$diachi='';
								if(!empty ($dong['so_duong'])) $diachi .= $dong['so_duong'] . ', ';
								if(!empty ($dong['ten_duong'])) $diachi .= $dong['ten_duong'] . ', ';
								if(!empty ($dong['ap_khom'])) $diachi .= $dong['ap_khom'] . ', ';
								if(!empty ($dong['xa_phuong'])) $diachi .= $dong['xa_phuong'] . ', ';
								if(!empty ($dong['huyen_thi'])) $diachi .= $dong['huyen_thi'] . ', ';
								
								echo'<td>'.$diachi.'</td>';
								echo'<td>'.$dong['vi_do'].'</td>';
								echo'<td>'.$dong['kinh_do'].'</td>';
								echo'<td class="text-center"><a href="diadiem_sua.php"><i class ="fal fa-edit"></i></a></td>';
							echo'<td class="text-center"><a href="diadiem_xoa.php"><i class ="fal fa-trash text-danger"></i></a></td>';
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