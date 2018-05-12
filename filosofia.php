<?php
	//testa se a varivel existe
	$head = "head.html";
	if ( isset( $head ) ) {
		if ($head) {
			$auxSite = $head;
			include $auxSite;
		}
	} else {
		
		echo "Error : 404";
	}
?>

<?php

	$discipline="filosofia";
	
	$headExam = "page/{$discipline}.html";
	if ( isset( $headExam ) ) {
		if ($headExam) {
			$auxSite = $headExam;
			include $auxSite;
		}
	} else {
		echo "Error : 404";
	}

	//content 

	for ($quest = 1; $quest < 1 ; $quest++) {

		$content = "page/exam/{$discipline}/{$quest}.html";

		if ( isset( $content ) ) {
			if ($content) {
				$auxSite = $content;
				include $auxSite;
			}
		} else {
			echo "Error : 404";
		}
		
	}
?>

<?php
//headExam 
	//testa se a varivel existe
	$footerExam = "page/footer.html";
	if ( isset( $footerExam ) ) {
		if ($footerExam) {
			$auxSite = $footerExam;
			include $auxSite;
		}
	} else {
		echo "Error : 404";
	}
?>

<?php
	//testa se a varivel existe
	$footer = "footer.html";
	if ( isset( $footer ) ) {
		if ($footer) {
			$auxSite = $footer;
			include $auxSite;
		}
	} else {
		echo "Error : 404";
	}
?>