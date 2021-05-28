<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href="css/style.css">
<style type="text/css">
table{
	border: 1px groove maroon;
	font-family: Arial;
	font-size: 10pt;
	border-collapse: separate; 
	border-spacing: 0px; 
	display: block;
	width: 800px;
	margin: 20px 100px;
}
td{
	border: thin dotted maroon;
	padding: 5px;	
	text-align: justify;
}
th{ 
	color: #FFFFFF;	
	font-size: 11pt;
	font-weight:bold;
	text-align:center;
	background-color: #FF0000;
	border: thin solid #FFFFFF;
}
</style>
</head>
<body>
	<?php 
		$servername = "localhost";
		$username = "root";
		$password = "vertrigo";
		$dbname = "qlhanghoa";
		$conn = mysqli_connect($servername,$username,$password,$dbname);
		$chuyenmuc = $_POST['oCM'];
		$noidung = $_POST['tND'];
		$diadiem = $_POST['oDD'];
		$email = $_POST['tEM'];

		$queryThem = "insert into baidang(chuyenmuc,noidung,diadiem,email) values('$chuyenmuc','$noidung','$diadiem','$email')";
		$queryLoad = "select * from baidang";
			if(trim($chuyenmuc) == "" || trim($noidung) == "" || trim($diadiem) == "" || trim($email) == ""){
				echo 'Nhập đầy đủ thông tin';
			}
			else{
				if(isset($chuyenmuc) && isset($noidung) && isset($diadiem) && isset($email)){
					if(!$conn){
						die("Lỗi: " . mysqli_connect_error());
					}
					else if(mysqli_query($conn,$queryThem)){
						$danhsach = mysqli_query($conn,$queryLoad);
	?>
						<table>
							<tr>
								<td>Mã Số</td>
								<td>Chuyên mục</td>
								<td>Nội dung</td>
								<td>Địa điểm</td>
								<td>Email</td>
							</tr>

	<?php
					while($dong = mysqli_fetch_assoc($danhsach)){
						echo '<tr>';
							echo "<td>{$dong['maso']}</td>";
							echo "<td>{$dong['chuyenmuc']}</td>";
							echo "<td>{$dong['noidung']}</td>";
							echo "<td>{$dong['diadiem']}</td>";
							echo "<td>{$dong['email']}</td>";
						echo '</tr>';
					}
				}
				else{
					echo 'Lỗi ' . $query . mysqli_error($conn); 
				}
				mysqli_close($conn);
			}
		}
    ?>
						</table>
						
		<p align="right" style="font-size:9pt;font-weight:bold;padding:5px;">
		<a href="trangtin.html">Trang chủ</a> | 
		<a href="dangtin.php">Đăng tin</a>
		</p>
</body>
<html>