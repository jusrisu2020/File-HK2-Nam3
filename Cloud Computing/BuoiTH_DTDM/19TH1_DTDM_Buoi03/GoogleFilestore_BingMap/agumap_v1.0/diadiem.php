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
						<tbody id="HienThi">
							<tr>
								
							</tr>
						</tbody>
					</table>
				</div>
			</div>
			
			<?php include "footer.php"; ?>
		</div>
		
		<?php include "javascript.php"; ?>
		<script>
		
			db.collection("diadiem").get().then((querySnapshot) => {
				var stt=1;
				var output='';
			querySnapshot.forEach((doc) => {
				//console.log(`${doc.id} => ${doc.data()}`);
			output+='<tr>';
				output+='<td>'+stt+'</td>';
				output+='<td>'+doc.data().TenDiaDiem+'</td>';
				output+='<td>'+doc.data().DiaChi+'</td>';
				output+='<td>'+doc.data().ToaDo.latitude+'</td>';
				output+='<td>'+doc.data().ToaDo.longitude+'</td>';
				output+='<td>Sửa</td>';
				output+='<td>Xóa</td>';
			output+='</tr>';
			stt++;	
			});
			$('#HienThi').html(output);
		});
		</script>
	</body>
</html>