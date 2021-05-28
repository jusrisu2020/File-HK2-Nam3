<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href="dinhdang/mystyle.css">
</head>

<body>
	<table class="bieumau1" border="1">
		<tr> 
		  <td colspan="6" class="canhgiua"><h2>Danh mục sản phẩm</h2></td>
		</tr>
		<tr>
			<td>STT</td>
			<td>Tên Sản Phẩm</td>
			<td>Hình ảnh</td>
			<td>Giá bán</td>
			<td>Giá gốc</td>
			<td>Hình Ảnh</td>
		</tr>
		<tr> 
			<?php 
				$servername = "localhost";
				$username = "root";
				$password = "vertrigo";
				$dbname = "qlhanghoa";
				$conn = mysqli_connect($servername,$username,$password,$dbname);

				$query = "select * from mathang";
				$danhsach = mysqli_query($conn,$query);
				if(!$conn){
					die("Lỗi: " . mysqli_connect_error());
				}
				else if(mysqli_num_rows($danhsach) > 0){
					$stt = 1;
					while($dong = mysqli_fetch_assoc($danhsach)){
						echo '<tr>';
							echo "<td>{$stt}</td>";
							echo "<td>{$dong['MaHang']}</td>";
							echo "<td>{$dong['TenHang']}</td>";
							echo "<td>{$dong['GiaGoc']}</td>";
							echo "<td>{$dong['GiaBan']}</td>";
							echo "<td><img src=".$dong['HinhAnh']."></td>";
							echo '</tr>';
						$stt++;
					}
				}
				mysqli_close($conn);
			?>
		</tr>
	</table>
</body>
</html>