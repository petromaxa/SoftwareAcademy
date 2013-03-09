function ChangeBWColor(button4)
{
	var buttons = window.document.getElementsByTagName('button');
	if(button4.style.backgroundColor == 'rgb(0, 0, 0)')
	{
		for (var i = 0; i < buttons.length; i++) {
			buttons[i].style.backgroundColor = '#ffffff';
		}
	}
	else
	{
		for (var i = 0; i < buttons.length; i++) {
			buttons[i].style.backgroundColor = '#000000';
		}
	}
}