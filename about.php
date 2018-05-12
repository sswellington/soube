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
//conteúdo 
	//testa se a varivel existe
	$home = "page/about.html";
	if ( isset( $home ) ) {
		if ($home) {
			$auxSite = $home;
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
