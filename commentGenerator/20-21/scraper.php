<html>
<head>
	<title>Progress Tracker</title>	
</head>

<body>
	<div id="output">

		<?php
			
			if (($handle = fopen("data.csv", "r")) !== FALSE) {
			  while (($data = fgetcsv($handle, 1000, "\n")) !== FALSE) {

			    for ($c=0; $c < count($data); $c++) {

			    	$firstName = explode(",", $data[$c])[0];
			    	$lastName = explode(",", $data[$c])[1];
			    	$knowre = explode(",", $data[$c])[3];

			    	echo "<div id='" . $lastName . ", " . $firstName . "'>" . $knowre . "</div>";			        
			    }
			  }
			  fclose($handle);
			}
		?>

	</div>
</body>

</html>