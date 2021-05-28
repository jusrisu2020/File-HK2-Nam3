<html>
	<head>
		<style>
			table {border-collapse:collapse;width:400px;margin:auto;border:solid green 1px;}
			tr:hover{background-color: #FFFACD;}					
		</style>
	</head>
	<body>
		<form name="fLinhVuc" method="POST" action="themlinhvuc.php">
			<table align="center">
				<tr>
					<td colspan="2" align="center">THÊM LĨNH VỰC</td>
				</tr>
				<tr>
					<td>Mã lĩnh vực</td><td><input type="text" name="txtMaLinhVuc"/></td>
				</tr>
				<tr>
					<td>Tên lĩnh vực</td><td><input type="text" name="txtTenLinhVuc"/></td>
				</tr>
				<tr>
					<td colspan="2" align="center">
						<input type="submit" name="btnLuu" value="Lưu"/>
						<input type="reset" name="btnXoa" value="Xóa"/>
					</td>
				</tr>
			</table>    
	</form>
	</body>
</html>
