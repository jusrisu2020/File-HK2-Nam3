<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hiển thị dữ liệu</title>
    <style>
        #datatb{
            border: solid black;
            margin: auto;
        }
    </style>
</head>
<body>

    <?php 
         $servername = "localhost";
         $username = "root";
         $password = "vertrigo";
         $dbname = "quanli_tin";

         $conn = mysqli_connect($servername,$username,$password,$dbname);
         $query = "select * from LinhVuc";
         $danhsach = mysqli_query($conn,$query);
    ?>

    <table id="datatb">
        <caption>DANH SÁCH LĨNH VỰC</caption>
        <thead>
            <td>STT</td>
            <td>MÃ LĨNH VỰC</td>
            <td>TÊN LĨNH VỰC</td>
        </thead>
        <tbody>
            <?php 
                if($danhsach!=null){
                    $stt = 1;
                    while($dong = mysqli_fetch_assoc($danhsach)){
                        echo '<tr>';
                            echo "<td>{$stt}</td>";
                            echo "<td>".$dong['MaLinhVuc']."</td>";
                            echo "<td>".$dong['TenLinhVuc']."</td>";
                        echo '</tr>';
                        $stt++;
                    }
                }
            ?>
            <td colspan="8">
                <a href="formlinhvuc.php">Thêm Lĩnh Vực</a>
            </td>
        </tbody>
    </table>
</body>
</html>