function loadXMLDoc(url)
{
	if(window.XMLHttpRequest)
	{
		//ma cho IE7+, Firefox, Chrome, opera, Safari
		xmlhttp = new XMLHttpRequest();
		xmlhttp.open("GET",url,false);
		xmlhttp.send(null);
	}
	else
	{
		//ma cho IE6, IE5
		xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
		xmlhttp.open("GET",url,false);
		//khong goi null cho ActiveX
		xmlhttp.send();					
	}
	document.getElementById('content').innerHTML = xmlhttp.responseText;				
}