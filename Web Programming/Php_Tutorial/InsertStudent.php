<!DOCTYPE html>
<html lang="en">
<head>
    <title>Add Student</title>

    <style>
        *{
            margin: 0;
            padding: 0;
        }

        .container{
            position: absolute;
            top: 25%;
            left: 40%;
            height: 1000px;
        }

        .container h3{
            text-align: center;
        }
        
        .container .btnControls{
            position: absolute;
            left: 60px;
            top: 200px;
        }

        
    </style>
</head>
<body>

    <?php include "nav.php"; ?>
    <div class="container">
        <h3>ADD STUDENT</h3>
        <form action="InsertStudent.php" method="POST">

        <table>
            <tr>
                <td><label for="">ID</label></td>
                <td><input type="text"></td>
            </tr>

            <tr>
                <td><label for="">Name</label></td>
                <td><input type="text"></td>
            </tr>

            <tr>
                <td><label for="">Age</label></td>
                <td><input type="text"></td>
            </tr>

            <tr>
                <td><label for="">Address</label></td>
                <td><input type="text"></td>
            </tr>

            <tr>
                <td><label for="">Phone Number</label></td>
                <td><input type="text"></td>
            </tr>

            <tr>
                <td><label for="">Email</label></td>
                <td><input type="text"></td>
            </tr>

            <tr>
                <td colspan="2" align="center">
                    <button>Add Student</button>
                    <button type="reset">Reset</button>
                </td>
            </tr>

        </table>
        </form>
    </div>
        

    <?php
        include 'database.php';

        if($conn->connect_error){
            echo 'Connection Error';
        }
        else{
            echo 'Connection Successful!';
        }

    
    
    ?>
    
</body>
</html>