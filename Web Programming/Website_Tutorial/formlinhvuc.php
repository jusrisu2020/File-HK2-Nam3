<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Form Lĩnh Vực</title>

    <style>
        form{
            position: absolute;
            left:30%;
            border:solid pink;
        }
        form input[type="submit"],input[type="reset"]{
            position: relative;
            left: 80px;
        }
    </style>
</head>
<body>
    <form name="fLinhVuc" action="themlinhvuc.php" method="POST">
    <table>
        <thead>
            <td colspan="2" align="center">THÊM LĨNH VỰC</td>
        </thead>
        <tbody>
            <tr>
                <td>Mã lĩnh vực</td>
                <td><input type="text" name="txtMaLinhVuc"></td>
            </tr>
            <tr>
                <td>Tên lĩnh vực</td>
                <td><input type="text" name="txtTenLinhVuc"></td>
            </tr>
            <tr>
                <td>
                    <input type="submit">
                    <input type="reset">
                </td>
            </tr>
        </tbody>
    </table>
        
            
    </form>
</body>
</html>