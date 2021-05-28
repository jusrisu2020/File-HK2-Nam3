<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Html and Css Tutorial</title>
</head>
<body>

    <?php echo "Hello!" ?>

    <div class="container">

        <div class="menu">
            <ul>
                <li><a href="#">SIGN IN</a></li>
                <li><a href="#">SIGN UP</a></li>
            </ul>
        </div>
        <div class="boxSignIn">
            <form class="box" action="#" method="POST">
                <p id="boxName">User name</p>
                <input type="text" name="userName" id="userName">
                <p id="boxName">Password</p>
                <input type="password" name="userName" id="userName"><br>
                <input type="checkbox" name="chkBox" id="chkBox"><p id="contentCheck">KEEP ME SIGNED IN</p><br>
                <input type="button" value="GO">
            </form>
        </div>
        
        <br>
        <br>

        <div class="forgotPass">
            <hr/>
            <a href="#">Forgot your password</a>
        </div>

    </div>
        
    

</body>
</html>