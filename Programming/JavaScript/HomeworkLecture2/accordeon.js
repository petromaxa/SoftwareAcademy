function DisplayAccordeon()
{
	window.document.getElementById('mainHeader').style.display = 'none';
	var accordeon = window.document.getElementById('accordeon');
	accordeon.style.display = 'block';
	var contents = document.getElementsByClassName('contents');
	for(var i = 0; i < contents.length; i++) 
	{
		contents[i].style.display = 'none';
	}
}

function DisplayEachContent(header)
{
	DisplayAccordeon();	
	var content = header.parentNode.getElementsByClassName('contents');
	content[0].style.display = 'block';
}