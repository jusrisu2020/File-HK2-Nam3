<!DOCTYPE html>
<html lang="en">
<head>
    <title>Thông tin thuốc</title>
    <style>
        *{
            margin: 0;
            padding: 0;
        }

        table thead td{
            margin-left: 50px;
            border: 1px solid red;
            text-align: center;
        }

        table td{
            padding-left: 50px;
        }
    </style>
</head>
<body>
    
    <table>
        <thead>
            <tr>
                <td>Mã thuốc</td>
                <td>Tên thuốc</td>
                <td>Hoạt chất</td>
                <td>Đơn giá</td>
                <td>Số lượng</td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <?php
                    $conn = new mysqli("localhost","root","vertrigo","hdthuoc");
                    if($conn->connect_error){
                        echo "Lỗi: " . mysqli_connect_error();
                    }
                    else{
                        $sql = "select * from `thuoc`";
                        $result = mysqli_query($conn,$sql);
                        if($result->num_rows > 0){
                            while($row = $result->fetch_assoc()){
                                echo "<tr>";
                                echo "<td>" . $row['mathuoc'] . "</td>";
                                echo "<td>" . $row['tenthuoc'] . "</td>";
                                echo "<td>" . $row['hoatchat'] . "</td>";
                                echo "<td>" . $row['dongia'] . ".000" . "vnd" . "</td>";
                                echo "<td>" . $row['soluong'] . "</td>";
                                echo "</tr>";
                            }
                        }
                    }
                ?>
            </tr>
        </tbody>
    </table>
</body>
</html>