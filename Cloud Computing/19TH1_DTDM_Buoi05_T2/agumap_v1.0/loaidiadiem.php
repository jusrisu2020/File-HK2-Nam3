<!DOCTYPE html>
<html lang="en">
	<?php include "header.php"; ?>
	
	<body>
		<div class="container">
			<?php include "navbar.php"; ?>
			
			<div class="card mt-3">
				<h5 class="card-header">Loại địa điểm</h5>
				<div class="card-body">
					<a href="loaidiadiem_them.php" class="btn btn-success mb-2"><i class="fal fa-plus"></i> Thêm loại địa điểm</a>
					<table class="table table-bordered table-hover table-sm mb-0">
						<thead>
							<tr>
								<th width="5%">#</th>
								<th>Tên loại địa điểm</th>
								<th width="20%">Biểu tượng trên web</th>
								<th width="20%">Biểu tượng trên bản đồ</th>
								<th width="5%">Sửa</th>
								<th width="5%">Xóa</th>
							</tr>
						</thead>
						<tbody>
						
							<?php
							
								include 'KetNoi.php';
								$sql='SELECT * FROM `loai_dia_diem` WHERE 1';
								$danhsach= mysqli_query($link, $sql);
								$stt=1;
								while($row = mysqli_fetch_array($danhsach))
								{
								   echo	'<tr>';
									  echo	'	<td>'.$stt++.'</td>';
									  echo	'	<td>'.$row['dien_giai'].'"</td>';
									  echo	'	<td class="text-center"><img src="images/web_icons/'.$row['bieu_tuong_web'].'" width="50"/></td>';
									  echo	'	<td class="text-center"><img src="images/map_icons/'.$row['bieu_tuong_map'].'"/></td>';
									  echo	'	<td class="text-center"><i class="fad fa-edit"></i></td>';
									  echo	'	<td class="text-center"><i class=" fad fa-trash-alt"></i></td>';
								  echo	'</tr>';
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