//A special Animation Libary independent from Jquery 


//Use this function to change the background of any css property 
function changeBackground(id, ele)
{
	//Get the  ID of the element you want to chagne 
	var elem = document.getElementById(id);
	// Create the animation 
	elem.transision = "background 1.0s linear 0s";
	elem.style.background = ele; //apply the new background


}

