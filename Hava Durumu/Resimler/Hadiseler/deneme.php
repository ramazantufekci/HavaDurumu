<?php

$requestHeaders = ["User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:59.0) Gecko/20100101 Firefox/59.0"];
function Getir($url,$post=false,$message=null)
{
	global $requestHeaders;
	$ch = curl_init($url);
	curl_setopt($ch, CURLOPT_SSL_VERIFYPEER, false);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    //curl_setopt($ch,CURLOPT_VERBOSE,true);
    curl_setopt($ch, CURLOPT_HTTPHEADER, $requestHeaders);
	if($post)
	{
		curl_setopt($ch, CURLOPT_POST, 1);
		curl_setopt($ch, CURLOPT_POSTFIELDS, $message);
		array_push($requestHeaders,"Accept:application/json, text/javascript, */*; q=0.01");
		array_push($requestHeaders,"Content-Type: application/x-www-form-urlencoded; charset=UTF-8");
		array_push($requestHeaders,"Referer: https://www.istanbuleczaciodasi.org.tr/nobetci-eczane/");
		array_push($requestHeaders,"X-Requested-With: XMLHttpRequest");
	}
    else
	{
		$response = curl_exec($ch);
		curl_close($ch);
		return $response;
	}
	//$response = curl_exec($ch);
	//curl_close($ch);
	//var_export($response);
}
$derya = array("A","AB","PB","CB","HY","Y","KY","KKY","HKY","K","KYK","HSY","SY","KSY","MSY","DY","GSY","KGSY","SIS","PUS","DNM","KF","R","GKR","KKR","SCK","SGK","HHY");
//foreach($derya as $ramazan)
//{
	file_put_contents("KGY.svg",Getir("https://www.mgm.gov.tr/Images_Sys/hadiseler/KGY.svg"));
	//sleep(5);
//}
 