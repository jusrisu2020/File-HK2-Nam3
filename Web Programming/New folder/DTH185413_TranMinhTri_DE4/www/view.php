<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<style>
	table {border-collapse:collapse;width:500px;margin:auto;border:solid darkgreen 1px;}
	th, td {text-align: left;padding: 8px; border-bottom:solid darkgreen 1px;}
	th{color: white;background-color:blue;}
	/*tr{border-bottom: dotted darkgreen 1px;}*/
	
	tr:hover{
		background-color: #FFFACD;
	}
	img{height:80px;border-radius:5px;}
</style>
</head>
<body>
<?php 
	$servername = "localhost";
	$username = "root";
	$password = "vertrigo";
	$dbname = "hdthuoc";

	$conn = mysqli_connect($servername,$username,$password,$dbname);
	$query = "select * from thuoc";
	$danhsach = mysqli_query($conn,$query);
?>
	<table>		
		<tr><th>Tên Thuốc</th><th>Đơn giá</th><th>Số lượng</th><th>Thành tiền</th></tr>
		<tr>			
		<?php 
                if($danhsach!=null){
                    while($dong = mysqli_fetch_assoc($danhsach)){
						$thanhTien = $dong['soluong']*$dong['dongia'];
                        echo '<tr>';
                            echo "<td>{$dong['tenthuoc']}</td>";
                            echo "<td>{$dong['dongia']}</td>";
                            echo "<td>{$dong['soluong']}</td>";
							echo "<td>".$thanhTien." vnd"."</td>";
                        echo '</tr>';
                    }
                }
            ?>	
		</tr>
	</table>
</body>
</html>