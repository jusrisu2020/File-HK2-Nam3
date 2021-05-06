<!DOCTYPE html>
<html lang="en">
	<?php include "header.php"; ?>
	
	<body>
		<div class="container">
			<?php include "navbar.php"; ?>
			
			<div class="card mt-3">
				<h5 class="card-header">Nhập địa điểm</h5>
				<div class="card-body">
					<?php
						$link=mysqli_connect("127.0.0.1","root","vertrigo","agumap");
						mysqli_set_charset($link, "utf8");
						
						$sql="Select * FROM `dia_diem` where 1";
						$danhsach=mysqli_query($link,$sql);
						
						$dsdiadiem=[];
						while($dong=mysqli_fetch_array($danhsach))
						{
							
							$diadiem['TenDiaDiem']=$dong['ten_dia_diem'];
							$diadiem['KinhDo']=$dong['kinh_do'];
							$diadiem['ViDo']=$dong['vi_do'];
							
							$diachi='';
							if(!empty($dong['so_duong'])) $diachi .=$dong['so_duong'].', ';
							if(!empty($dong['ten_duong'])) $diachi .=$dong['ten_duong'].', ';
							
							if(!empty($dong['ap_khom'])) $diachi .=$dong['ap_khom'].', ';
							
							if(!empty($dong['huyen_thi'])) $diachi .=$dong['huyen_thi'];
						
							$diadiem['DiaChi']=$diachi;
							
							$dsdiadiem[]=$diadiem;
							
						}
						var_dump($dsdiadiem);
					?>
					<div id="KetQua">
						<div class="alert alert-warning alert-dismissible fade show mb-0" role="alert">
							<span id="ThongBao"></span>
							<button type="button" class="close" data-dismiss="alert" aria-label="Close">
								<span aria-hidden="true">&times;</span>
							</button>
						</div>
					</div>
				</div>
			</div>
			
			<?php include "footer.php"; ?>
		</div>
		
		<?php include "javascript.php"; ?>
		<script>
			// Get a new write batch
			$('#KetQua').hide();
			var batch = db.batch();
			<?php
				foreach($dsdiadiem as $value)
				{
			?>
				var docRef=db.collection("diadiem").doc();
				batch.set(docRef,{
						TenDiaDiem:"<?php echo $value['TenDiaDiem']; ?>",
						DiaChi:"<?php echo $value['DiaChi']; ?>",
				ToaDo:new firebase.firestore.GeoPoint(<?php echo $value['ViDo']; ?>,<?php echo $value['KinhDo']; ?>)
				
				});
						
			<?php
				}	
			?>
			

			// Commit the batch
			batch.commit().then(() => {
				$('#KetQua').show();
				$('#ThongBao').html('Đã nhập thành công!');
			}) .catch(error =>{
				$('#KetQua').show();
				$('#ThongBao').html("Lỗi".error);
			});
		</script>
	</body>
</html>