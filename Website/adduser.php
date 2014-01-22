<?php

$username = $_GET['user'];
$file = 'donations.txt';
$content = file_get_contents($file);
$content .= $username . "\r\n";
file_put_contents($file, $content);

?>