
function a(id) {
	return document.getElementById(id);
}

function astyle(id) {
	return document.getElementById(id).style;
}
function html(id, spit) {
	a(id).innerHTML = spit;
}
function ahtml(id, spit) {

	a(id).innerHTML += spit;
}

function aclick(id, event) {
	a(id).addEventListener("click", event);

}

function forEach(array, e) {
	for (var i = 0; i < array.length; i++) {
		e(array[i]);
	}
}

function ashowhide(id) {


	if (astyle(id).display == "block") {
		astyle(id).display = "none";
	}
	else {
		astyle(id).display = "block";

	}


}

