<!DOCTYPE html>
<html lang="en">
<link rel="stylesheet" href="css/navs.css">
<body>
    <div class="menu">
        <div class="btnControl">
            <button id="btnIndex">Trang chủ</button>
            <button id="btnData">Student Data</button>
            <button id="btnInsert">Add student</button>
        </div>
    </div>

    <script>
        var btnIndex = document.getElementById("btnIndex");
        var btnData = document.getElementById("btnData");
        var btnInsert = document.getElementById("btnInsert");

        btnIndex.addEventListener("click",()=>{
            location.href = "index.php";
        });

        btnData.addEventListener("click",()=>{
            location.href = "LoadData.php";
        });

        btnInsert.addEventListener("click",()=>{
            location.href = "InsertStudent.php";
        });
    </script>
</body>
</html>