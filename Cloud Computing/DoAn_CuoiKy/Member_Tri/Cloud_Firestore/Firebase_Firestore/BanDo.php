<!DOCTYPE html>
<html lang="en">
<head>
    <title>Firebase Database</title>
    <!-- Link Bootstrap -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <link rel="preconnect" href="https://fonts.gstatic.com">
    <script src="https://kit.fontawesome.com/ab2155e76b.js" crossorigin="anonymous"></script>
<link href="https://fonts.googleapis.com/css2?family=Poppins&display=swap" rel="stylesheet">
    <link href="./GGMapAPI_ChiDuong/App.css" rel="stylesheet" />

</head>
<body>
<!-- Nav Bar Menu -->
  <?php include "nav.php";?>
  
  <div class="jumbotron">
        <div class="container-fluid">
            <h1>Find The Distance Between Two Places.</h1>
            <p>This App Will Help You Calculate Your Travelling Distances.</p>
            <form class="form-horizontal">

                <div class="form-group">
                    <label for="from" class="col-xs-2 control-label"><i class="far fa-dot-circle"></i></label>
                    <div class="col-xs-4">
                        <input type="text" id="from" placeholder="Origin" class="form-control">
                    </div>
               </div>

               <div class="form-group">
                    <label for="to" class="col-xs-2 control-label"><i class="fas fa-map-marker-alt"></i></label>
                    <div class="col-xs-4">
                        <input type="text" id="to" placeholder="Destination" class="form-control">
                    </div>
                </div>
                 
            </form>

            <div class="col-xs-offset-2 col-xs-10">
                <button class="btn btn-info btn-lg " onclick="calcRoute();"><i class="fas fa-map-signs"></i></button>
            </div>
        </div>
        
        <!-- Đổ Map -->
        <div class="container-fluid">
            <div id="googleMap">

            </div>
            <div id="output">
            </div>
        </div>
    </div>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyB3KjEa7xtALLCMJHqufeQP6AGQSwHDBTs&libraries=places&callback=initMap"></script>
    <script src="./GGMapAPI_ChiDuong/Main.js"></script>

<!-- Cấu Hình firebase -->
<?php include "Config.php";?>

<!-- Link Bootstrap -->
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-Piv4xVNRyMGpqkS2by6br4gNJ7DXjqk09RmUpJ8jgGtD7zP9yug3goQfGII0yAns" crossorigin="anonymous"></script>
</body>
</html>
