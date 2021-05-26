﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const buttonClick = code => {
    alert(code);
    document.getElementById("callButton").value = code;
    if (code == "endGame") {
        window.close();
    }
    else {
        document.getElementById("submitButton").click();
    }
}