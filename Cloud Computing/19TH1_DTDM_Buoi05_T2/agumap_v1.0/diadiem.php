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
					<table id="PhanTrang" class="table table-bordered table-hover table-sm mb-0">
						<thead>
							<tr>
								<th width="5%">#</th>
								<th width="12%">Loại địa điểm</th>
								<th width="12%">Người đăng</th>
								<th>Thông tin địa điểm</th>
								<th width="10%">Tọa độ</th>
								<th width="5%">Sửa</th>
								<th width="5%">Xóa</th>
							</tr>
						</thead>
						<tbody>
						
							<?php
							
								include 'KetNoi.php';
								$sql='SELECT * 
								FROM dia_diem d, loai_dia_diem l, nguoi_dung n
								where d.id_loai=l.id and d.id_user=n.id';
								$danhsach= mysqli_query($link, $sql);
								$stt=1;
								while($row = mysqli_fetch_array($danhsach))
								{
								   echo'<tr>';
										echo'<td>'.$stt++.'</td>';
										echo'<td>'.$row['dien_giai'].'</td>';
										echo'<td>'.$row['ho_ten'].'</td>';
										$diachi='';
										if(!empty($row['so_duong'])) $diachi .= $row['so_duong']. ',';
										if(!empty($row['ten_duong'])) $diachi .= $row['ten_duong']. ',';
										if(!empty($row['ap_khom'])) $diachi .= $row['ap_khom']. ',';
										if(!empty($row['xa_phuong'])) $diachi .= $row['xa_phuong']. ',';
										if(!empty($row['huyen_thi'])) $diachi .= $row['huyen_thi'];
										
										
										echo'<td>';
											echo '<span class="d-block text-danger font-weight-bold">'.$row['ten_dia_diem'].'</span>';
											echo '<span class="d-block small"> Địa chỉ: '.$diachi.'</span>';
										echo'</td>';
										
										echo'<td>';
											echo '<span class="d-block text-monospace">'.$row['vi_do'].'</span>';
											echo '<span class="d-block text-monospace">'.$row['kinh_do'].'</span>';
										echo'</td>';
										
										
										
										echo	'	<td class="text-center" ><i class="fad fa-edit" ></i></td>';
									  echo	'	<td class="text-center text-danger" ><i class=" fad fa-trash-alt"></i></td>';
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
		
		<script>
			$(document).ready( function () {
				$('#PhanTrang').DataTable();
			} );
					
		</script>
	</body>
</html>