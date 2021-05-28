<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Thêm lĩnh vực</title>
</head>
<body>
    <?php
        $servername = "localhost";
        $username = "root";
        $password = "vertrigo";
        $dbname = "quanli_tin";
        $malv = $_POST["txtMaLinhVuc"];
        $tenlv = $_POST["txtTenLinhVuc"];

        if((trim($malv)=="") || (trim($tenlv)=="")){
            echo 'Phải nhập đầy đủ thông tin!';
        }
        else{
            if(isset($malv) && isset($tenlv)){
                $conn = mysqli_connect($servername,$username,$password,$dbname);
                $query = "insert into LinhVuc(MaLinhVuc,TenLinhVuc) values('$malv','$tenlv')";
                if(!$conn){
                    die('Lỗi: ' . mysqli_connect_error());
                }
                if(mysqli_query($conn,$query)){
                    header("Location: hienthi.php");
                }
                else{
                    echo 'Lỗi: ' . $query . '<br/>' . mysqli_error($conn); 
                }
                mysqli_close($conn);
            }
        }
    ?>
    <p><a href="formlinhvuc.php">Nhập m</a></p>
</body>
</html>