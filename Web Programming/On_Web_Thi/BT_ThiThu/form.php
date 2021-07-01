<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Bài 3 Form</title>
</head>

<style>
   


</style>
<body>
    <form action="form.php" method="POST">
        <table>
            <caption>THÊM THUỐC</caption>
            <tr>
                <td><label for="">Mã thuốc</label></td>
                <td><input type="text" name="ipMaThuoc" value=""></td>
            </tr>

            <tr>
                <td><label for="">Tên thuốc</label></td>
                <td><input type="text" name="ipTenThuoc" value=""></td>
            </tr>
            
            <tr>
                <td><label for="">Hoạt chất</label></td>
                <td><textarea name="ipHoatChat" cols="40" rows="5"></textarea></td>
            </tr>

            <tr>
                <td><label for="">Nhóm thuốc</label></td>
                <td><select name="ipNhomThuoc" id=""><option>1</option></select></td>
            </tr>

            <tr>
                <td><label for="">Chỉ định</label></td>
                <td><textarea name="ChiDinh" cols="40" rows="5"></textarea></td> 
            </tr>

            <tr>
                <td colspan="2"><button type="submit">Thêm</button></td>
            </tr>
        </table>
    </form>

    


    <?php
        
        if($_SERVER["REQUEST_METHOD"] == "POST"){
             $TenThuoc = $_POST["ipTenThuoc"];
             $HoatChat = $_POST["ipHoatChat"];
             $NhomThuoc = $_POST["ipNhomThuoc"];
             $ChiDinh = $_POST["ChiDinh"];

            $conn = mysqli_connect("localhost","root","vertrigo","qlthuoc");
    
            if($conn->connect_error){
                echo "Lỗi: " . mysqli_connect_error();
            }
            else{
                $sql = "insert into `hdthuoc`(tenthuoc, hoatchat, nhomthuoc, chidinh) values ('$TenThuoc','$HoatChat','$NhomThuoc','$ChiDinh')";
                if ($conn->query($sql) === true) {
                    echo "New record created successfully";
                } else {
                    echo "Error: " . $sql . "<br>" . $conn->error;
                }
            }
            $conn->close();
        }
        
    ?>
</body>
</html>