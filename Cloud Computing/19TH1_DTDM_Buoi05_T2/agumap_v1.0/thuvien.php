<?php
	function ThongBao($text)
	{
		echo '<div class="alert alert-success mb-0" role="alert">
				'.$text.'
			  </div>';
	}
	
	function ThongBaoLoi($text)
	{
		echo '<div class="alert alert-danger mb-0" role="alert">
				'.$text.'
			  </div>';
	}
?>