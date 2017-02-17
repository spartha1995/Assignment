<?php
$arrayLen = readline("Array length: ");
for($i =0; $i < $arrayLen; $i++)
$array_input[$i] = readline("Element ".($i+1).": "); 
print_r($array_input);
$out=array_reverse($array_input,true);
print_r($out);
?>