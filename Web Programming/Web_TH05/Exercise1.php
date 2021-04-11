<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Exercise1</title>
</head>
<body>
	
		<?php
		$a = 1;
		$b = 2;
		$Array = array("XML","33");
		echo "Array: ";
		echo "<select>";
		for ($i=0; $i < count($Array); $i++) { 
			echo "<option>".$Array[$i]."</option>";
		}
		echo "</select>";
	 ?>

	
</body>
</html>