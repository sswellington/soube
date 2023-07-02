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
	//get variable by parameter
	$nrquest = 1;
	$discipline = "filosofia";
	$headExam = "../page/{$discipline}.html";

	if ( isset( $headExam ) ) {
		if ($headExam) {
			$auxSite = $headExam;
			include $auxSite;
		}
	} else {
		echo "Error : 404";
	}

	//questionario
	//$feedback = array($nrquest);
	$marked = array($nrquest);
	$right = array($nrquest);
	$score = 30;

	for ($i = 1; $i < $nrquest; $i++) {
		$quest = $i;
		$answer = $_POST[ ($discipline . $quest) ];
		
		if (!(isset($answer) && ($answer))) {
			echo " Questão $i : Em branco ";
		} else {
			echo " Questão $i :  " ;
			$right[$i] = substr($answer,0,1);
			//echo " $right \n";
			$marked[$i] = substr($answer,1);
			//echo " $marked ";
			if ( $right[$i] == $marked[$i] ) {
				//$feedback[$i] = 1;
				$score = $score + 3;
				echo " Acertou.";
			} else {
				//$feedback[$i] = 0;
				$score = $score - 1;
				echo "Errou. Alternativa correta é a letra $right[$i]. ";
			}
			echo "<br>";	
		}
	}
	echo "<h1> Pontuação atingida é: $score  </h1>";
?>
</body>
</html>