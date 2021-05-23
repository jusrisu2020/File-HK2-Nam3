<!DOCTYPE html>
<html lang="en">
<head>
    <title>Firebase Database</title>
    <!-- Link Bootstrap -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous">
    <style>
      .container{
        width: 800px;
      }
    </style>
</head>
<body>
<!-- Nav Bar Menu -->
  <?php include "nav.php";?>

 
<div class="container">
<form>
  <div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Doc ID</label>
    <input type="text" class="form-control" aria-describedby="emailHelp" id="DocId">
  </div>
  <div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Tên Tỉnh</label>
    <input type="text" class="form-control" aria-describedby="emailHelp" id="TenTinh">
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Vĩ độ</label>
    <input type="text" class="form-control" id="ViDo">
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label" >Kinh độ</label>
    <input type="text" class="form-control" id="KinhDo">
  </div>
  <button class="btn btn-primary" id="btnThem">Thêm</button>
</form>

<br><br><br><br><br>

<!-- Data Table -->
<table class="table table-striped table-hover" style="width: 800px; margin:auto">
  <thead>
    <tr>
      <th>STT</th>
      <th>Tên Tỉnh</th>
      <th>Vĩ Độ</th>
      <th>Kinh Độ</th>
    </tr>
  </thead>

  <tbody>
  <tr>
  <td>1</td>
    <td>2</td>
    <td>3</td>
    <td>4</td>
  </tr>
    
    <tr>
      <td>1</td>
      <td>2</td>
      <td>3</td>
      <td>4</td>
    </tr>


  </tbody>
</table>
</div>  

<?php include "Config.php";?>

<script>
      // dataBase.collection('PosTinhThanh').get().then((querySnapshot) => {
      //     var output = "";
      //     querySnapshot.forEach((doc) => {
      // 				output +='	<option>'+doc.data().Name+'</option>';
      //         console.log(doc.id, " => ", doc.data());
      //     });
      //     $('#collecSec').html(output);
      //   });


    const txtDocId = document.getElementById('DocId');
    const txtTenTinh = document.getElementById('TenTinh');
    const txtVidDo = document.getElementById('ViDo');
    const txtKinhDo = document.getElementById('KinhDo');
    const btnThem = document.getElementById('btnThem');


    const PosTinhThanhDB = dataBase.collection('PosTinhThanh');

    btnThem.addEventListener('click',e =>{
        e.preventDefault();
        dataBase.collection('PosTinhThanh').doc(txtTenTinh.value).set({
                TenTinh: txtTenTinh.value,
                ViDo: txtVidDo.value,
                KinhDo: txtKinhDo.value
            })
            .then(() => {console.log('Insert Success!');})
            .catch(error => {console.error(error)})
    });
</script>



<!-- Link Bootstrap -->
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-Piv4xVNRyMGpqkS2by6br4gNJ7DXjqk09RmUpJ8jgGtD7zP9yug3goQfGII0yAns" crossorigin="anonymous"></script>
</body>
</html>
