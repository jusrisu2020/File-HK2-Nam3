<?php 
   $color = 'Pink';
   switch($color){
       case 'red':
            echo 'Red Color';
            break;
        case 'blue':
            echo 'Blue color';
            break;
        case 'Pink':
            echo 'Pink Color';
            break;
        default:
            echo 'Màu khác';
            break;
   }


   $nb = 0;
   while($nb<=5){
       echo '<br/>Chạy từ 0 đến: '.$nb;
       $nb++;
   }

   $nb2 = 0;
   do{
       echo 'The number is:'.$nb2.'<br>';
       $nb2++;
   }while($nb2 <= 5);


   $arr = array(1,2,3);
   var_dump($arr);
   for($i = 0;$i <= sizeof($arr)-1;$i++){
    echo $arr[$i];
   }

   foreach($arr as $value){
       echo '<br/>Foreach: '.$value.'';
   }

   
   for ($x = 0; $x < 10; $x++) {
    if ($x == 4) {
      break;
    }
    echo "The number is: $x <br>";
  }

?>