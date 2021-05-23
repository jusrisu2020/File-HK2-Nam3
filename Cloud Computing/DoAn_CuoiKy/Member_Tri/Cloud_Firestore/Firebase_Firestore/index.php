<!DOCTYPE html>
<html lang="en">
<head>
    <title>Firebase Database</title>
    <!-- Link Bootstrap -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous">
</head>
<body>
<!-- Nav Bar Menu -->
  <?php include "nav.php";?>
      Collection List <select name="collecSec" id="collecSec"></select><br><br>
      
      Document List <select name="docSec" id="docSec"></select><br><br>

      ID <input type="text" id="idbox"><br><br>
      Name <input type="text" id="namebox"><br><br>
      Age <input type="text" id="agebox"><br><br>
      School <input type="text" id="schoolbox"><br><br>
      <br><br>

      <button id="insert">INSERT</button>
      <button id="update">UPDATE</button>
      <button id="delele">DELETE</button>
      <button id="select">SELECT</button>

<?php include "Config.php";?>


  <script>
   const secCollec = document.getElementById('collecSec');
const txtId = document.getElementById('idbox');
const txtName = document.getElementById('namebox');
const txtAge = document.getElementById('agebox');
const txtSchool = document.getElementById('schoolbox');
const btnInsert = document.getElementById('insert');
const btnUpdate = document.getElementById('update');
const btnDelete = document.getElementById('delele');
const btnSelect = document.getElementById('select');
    dataBase.collection('users').get().then((querySnapshot) => {
      querySnapshot.forEach((doc) => {
          // doc.data() is never undefined for query doc snapshots
          console.log(doc.id, " => ", doc.data());
      });
    });

  dataBase.collection('users').get().then((querySnapshot) => {
      var output = "";
      querySnapshot.forEach((doc) => {
					output +='	<option>'+doc.data().Name+'</option>';
          console.log(doc.id, " => ", doc.data());
      });
      $('#collecSec').html(output);
    });
    
   

btnInsert.addEventListener('click',e =>{
    e.preventDefault();
    dataBase.collection('users2').doc(txtId.value).set({
            Name: txtName.value,
            Age: txtAge.value,
            School: txtSchool.value,
        })
        .then(() => {console.log('Insert Success!');})
        .catch(error => {console.error(error)})
});
</script>

// Link bootstrap
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-Piv4xVNRyMGpqkS2by6br4gNJ7DXjqk09RmUpJ8jgGtD7zP9yug3goQfGII0yAns" crossorigin="anonymous"></script>

</body>
</html>
