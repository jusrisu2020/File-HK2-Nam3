<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href="dinhdang/mystyle.css">

</head>

<body>		
		<form name="f" method="post" action="" >
			<table class="bieumau">
				<tr> 
				  <td colspan="3" class="canhgiua"><h2>PHIẾU MUA HÀNG TRẢ GÓP</h2></td>
				</tr>
				
				<tr> 
				  <td colspan="3" class="tieude">THÔNG TIN SẢN PHẨM</td>
				</tr>
				<tr> 
				  <td>Chọn sản phẩm</td>
				  <td>

				  <select>
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
								while($dong = mysqli_fetch_assoc($danhsach)){
									echo '<option>';
									echo "{$dong['TenHang']}";
									echo '</option>';
								}
							}
							mysqli_close($conn);
						?>
					</select>


				  </td>
					
					<!-- BỔ SUNG CODE TẠI ĐÂY-->




					<td>&nbsp;</td>
				</tr>
				<tr> 
				  <td>Thời hạn trả</td>
				  <td>  <input type="radio" name="radThoiHan" value="1">6 tháng	    
						<input type="radio" name="radThoiHan" value="2">12 tháng</td>
				  <td>&nbsp;</td>
				</tr>       
				  <td>&nbsp;</td>
				  <td><input type="checkbox" name="chkGiaoHang">
					  Giao hàng tận nơi</td>
				  <td>&nbsp;</td>
				</tr>
				<tr> 
				  <td colspan="3" class="tieude">THÔNG TIN KHÁCH HÀNG</td>
				</tr>
				<tr> 
				  <td>Họ tên</td>
				  <td><input type="text" name="txtHoTen" onchange="ktHoTen();"></td>
				  <td>*</td>
				</tr>
				<tr> 
				  <td>Năm sinh</td>
				  <td>
					<select name="optNamSinh">
						<option>---Chọn---</option>
						<script>
						var d = new Date();
						var namht = d.getYear()+1900;
						for(i=namht;i>=1900;i--)
							document.write("<option>"+i+"</option>");
						</script>
					</select>
				  </td>
				  <td>&nbsp;</td>
				</tr>
				
				<tr> 
				  <td colspan="3" class="canhgiua"> 
					  <input type="button" name="btnXacNhan" value="Xác nhận" onclick="ktXacNhan();">
					  <input type="reset" name="btnKhong" value="Không">
				  </td>
				</tr>
			</table>
		</form>

		
</body>
</html>
