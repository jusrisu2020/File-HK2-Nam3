<?php
	$dbhost = 'sql6.freesqldatabase.com';
	$dbname='sql6408826';
	$dbuser = 'sql6408826';
	$dbpass ='vsDW41Lkf2';
	
	$link = mysqli_connect($dbhost,$dbuser,$dbpass,$dbname);
	if($link)
	{
		mysqli_set_charset($link,'utf8');
		date_default_timezone_set('Asia/Ho_Chi_Minh');
	}
	else
		echo "Kết nói không thành công với server!"
?>