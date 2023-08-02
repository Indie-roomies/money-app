function baseFunction() {
    var appBase = document.createElement("base");
    console.log(appBase.href.indexOf("localhost"))
    if (window.location.href.indexOf("localhost") != -1) {
        appBase.href = "/";
    }
}


baseFunction();