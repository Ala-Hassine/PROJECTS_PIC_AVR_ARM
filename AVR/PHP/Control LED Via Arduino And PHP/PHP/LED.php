<!DOCTYPE html>
<html>
<head>
	<title>Control LED</title>
	<style type="text/css">
		body {
		background-color: #737373;
		}
		input {
			border-radius: 10px;
		}
		td {
			padding-top: 4px;
		}
		.lbl {
			padding: 4px;
			border-radius: 24px;
			font-size: 30px;
			background-color: navy;
			color: white;
			border:2px solid navy;
			font-family: 'Tahoma' , bold;
			width: 600px;
			height: 100%;
			margin-top: 6px;
			padding-top: 2px;
		}
		.page {
			width: 660px;
			height: 470px;
			background-color: #6BA7D6;
			margin: auto;
			border : 7px solid #9bef05;
			border-radius: 40px;
		}
		.btn {
			background:darkred;
			color: pink;
			width: 200px;
			height: 50px;
			cursor: pointer;
			text-align: center;
			font-size: 20pt;
			margin-top: 5px;
			margin-bottom: 5px;
			border:2px solid navy;
			font-weight: bold;
			font-family: 'Tahoma';
		}
		.btn:hover {
			color:yellow;
		}
	</style>
</head>
<body>
	<div class="page">
		<form method="POST" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">
			<table align="center">
				<tr>
				<tr>
					<td colspan="2" align="center">
						<marquee behavior="alternate" class="lbl">Control LED Via Arduino And PHP</marquee>
					</td>
				</tr>
				<tr>
					<td align="center">
						<input type="submit" name="led1on" class="btn" value="LED 1 ON" />
					</td>
					<td align="center">
						<input type="submit" name="led1off" class="btn" value="LED 1 OFF" />
					</td>
				</tr>
				<tr>
					<td align="center">
						<input type="submit" name="led2on" class="btn" value="LED 2 ON" />
					</td>
					<td align="center">
						<input type="submit" name="led2off" class="btn" value="LED 2 OFF" />
					</td>
				</tr>
				<tr>
					<td align="center">
						<input type="submit" name="led3on" class="btn" value="LED 3 ON" />
					</td>
					<td align="center">
						<input type="submit" name="led3off" class="btn" value="LED 3 OFF" />
					</td>
				</tr>
				<tr>
					<td align="center">
						<input type="submit" name="led4on" class="btn" value="LED 4 ON" />
					</td>
					<td align="center">
						<input type="submit" name="led4off" class="btn" value="LED 4 OFF" />
					</td>
				</tr>
				<tr>
					<td align="center">
						<input type="submit" name="allon" class="btn" value="All LED ON" />
					</td>
					<td align="center">
						<input type="submit" name="alloff" class="btn" value="All LED OFF" />
					</td>
				</tr>
                <tr>
					<td colspan="2" align="center">
						<marquee behavior="scroll" class="lbl">EMBEDDED SYSTEM</marquee>
					</td>
				</tr>
			</table>
		</form>
 	</div>

<?php

$PortCOM = "COM2";

	switch($_POST)
	{
		case isset($_POST['led1on']):
			exec("ECHO 1 > $PortCOM"); // Turn On LED 1
			break;
		case isset($_POST['led1off']):
			exec("ECHO 2 > $PortCOM "); // Turn Off LED 1
			break;
		case isset($_POST['led2on']):
			exec("ECHO 3 > $PortCOM"); // Turn On LED 2
			break;
		case isset($_POST['led2off']):
			exec("ECHO 4 > $PortCOM"); // Turn Off LED 1
			break;
		case isset($_POST['led3on']):
			exec("ECHO 5 > $PortCOM"); // Turn On LED 3
			break;
		case isset($_POST['led3off']):
			exec("ECHO 6 > $PortCOM"); // Turn Off LED 1
			break;
		case isset($_POST['led4on']):
			exec("ECHO 7 > $PortCOM"); // Turn On LED 4
			break;
		case isset($_POST['led4off']):
			exec("ECHO 8 > $PortCOM"); // Turn Off LED 1
			break;
		case isset($_POST['allon']):
			exec("ECHO 1,3,5,7 > $PortCOM"); // Turn All On
			break;
		case isset($_POST['alloff']):
			exec("ECHO 2,4,6,8 > $PortCOM"); // Turn All Off
			break;
	}
?>

</body>
</html>