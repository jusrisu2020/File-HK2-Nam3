<!DOCTYPE html>
<html lang="en">
<head>
    <title>Thông tin thuốc</title>
</head>
<body>
    
    <table>
        <thead>
            <td>Mã thuốc</td>
            <td>Tên thuốc</td>
            <td>Gía bán</td>
            <td>Số lượng</td>
            <td>Địa chỉ hình ảnh</td>
        </thead>
        <tbody>
            <?php
                $conn = new mysqli("localhost","root","vertrigo","thuoc_online");
                if($conn->connect_error){
                    echo "Lỗi: " . mysqli_connect_error();
                }
                else{
                    $sql = "select * from `thuoc`";
                    $result = mysqli_query($conn,$sql);
                    if($result->num_rows > 0){
                        while($row = $result->fetch_assoc()){
                            echo "<td>" . $row['mathuoc'] ."</td>";
                            echo "<td>" . $row['mathuoc'] ."</td>";
                        }
                    }
                }
            ?>
        </tbody>
        

    </table>
</body>
</html>