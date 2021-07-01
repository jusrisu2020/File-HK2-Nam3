<!DOCTYPE html>
<html lang="en">
<head>
    <title>Student Data</title>
    <style>
        *{
            margin: 0;
            padding: 0;
        }
        .container{
            position: absolute;
            top: 100px;
            height: 1000px;
            left: 25%;
        }

        .container table td{
            border: 1px solid black;
            padding: 10px;
        }

        .container table tbody td{
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <?php include "nav.php" ?>
    <div class="container">
        <table class="tbStudent">
            <thead>
                <td>ID</td>
                <td>NAME</td>
                <td>AGE</td>
                <td>ADDRESS</td>
                <td>PHONE NUMBER</td>
                <td>EMAIL</td>
            </thead>
           
            <tbody id="DataStudent">
                <?php
                    include 'database.php';

                    if($conn->connect_error){
                        echo "Lỗi: ". mysqli_connect_error();
                    }
                    else{
                        echo 'Connection successful!';
                        $sql = "select * from `sinhvien`";
                        $result = $conn->query($sql);

                        if($result->num_rows > 0){
                            while($row = $result->fetch_assoc()){
                                echo '<td>' . $row['id'] . '</td>';
                                echo '<td>' . $row['name'] . '</td>';
                                echo '<td>' . $row['age'] . '</td>';
                                echo '<td>' . $row['address'] . '</td>';
                                echo '<td>' . $row['phone'] . '</td>';
                                echo '<td>' . $row['Email'] . '</td>';
                            }
                        }
                    }
                ?>
            </tbody>
            
        </table>

    </div>
</body>
</html>






