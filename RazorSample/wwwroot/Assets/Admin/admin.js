function openTab(id)
{
	var maindiv = document.getElementsByClassName("main")[0].getElementsByTagName("DIV");
	for (var i = 0; i<maindiv.length; i++) {
    	maindiv[i].style.display = "none";
	}
	document.getElementsByClassName(id)[0].style.display = "block";
	if (document.getElementsByClassName(id)[0].getElementsByClassName("table-content").length != 0)
		document.getElementsByClassName(id)[0].getElementsByClassName("table-content")[0].style.display = "block";
}