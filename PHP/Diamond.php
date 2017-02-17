<?php
 $n=readLine("Enters levels: ");
    readline_add_history($n);
	$levels=$n;
  $whitespaceFactor = $levels/2;
  $output = array();
  for ($i = 1; $i <= $levels; $i = $i + 2) 
  {
    $whitespace = ($levels - $i / 2) - $whitespaceFactor;
    $output[] = str_pad('', $whitespace) . str_pad('', $i, '*');
  }
  echo implode("\n", $output);
  echo "\n";
  echo implode("\n", array_reverse($output));
  echo "\n";

?>