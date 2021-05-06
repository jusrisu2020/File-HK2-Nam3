<?php
//Host: sql6.freesqldatabase.com
//Database name: sql6408817
//Database user: sql6408817
//Database password: r3PY33lV6M


$dbHost='sql6.freesqldatabase.com';

$dbname='sql6408817';

$dbuser='sql6408817';
$dbpassword='r3PY33lV6M';

$link=mysqli_connect($dbHost,$dbuser,$dbpassword,$dbname);

if($link)
{
	mysqli_set_charset($link, 'utf8');
	
	date_default_timezone_set('Asia/Ho_Chi_Minh');
}
else 
	echo 'Loi ket noi';


?>