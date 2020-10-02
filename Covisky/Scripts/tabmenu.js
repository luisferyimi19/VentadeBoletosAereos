var tabButtons = document.querySelectorAll(".tabContainer .buttonContainer button");
var tabPanels = document.querySelectorAll(".tabContainer  .tabPanel");

function showPanel(panelIndex, colorCode) {
    tabButtons.forEach(function (node) {
        node.style.backgroundColor = "";
        node.style.color = "";
    });
    tabButtons[panelIndex].style.backgroundColor = "white";
    tabButtons[panelIndex].style.color = "black";
    tabPanels.forEach(function (node) {
        node.style.display = "none";
    });
    tabPanels[panelIndex].style.display = "block";
    tabPanels[panelIndex].style.backgroundColor = colorCode;
}
showPanel(0, 'rgba(0, 0, 0, 0)');

var tabButtonsCheck = document.querySelectorAll(".tabContainerCheck .buttonContainerCheck input");
var tabPanelsCheck = document.querySelectorAll(".tabContainerCheck  .tabPanelCheck");

function showPanelCheck(panelIndexCheck, colorCode) {
    tabButtonsCheck.forEach(function (node) {
        node.style.backgroundColor = "";
        node.style.color = "";
    });
    tabButtonsCheck[panelIndexCheck].style.backgroundColor = "white";
    tabButtonsCheck[panelIndexCheck].style.color = "black";
    tabPanelsCheck.forEach(function (node) {
        node.style.display = "none";
    });
    tabPanelsCheck[panelIndexCheck].style.display = "block";
    tabPanelsCheck[panelIndexCheck].style.backgroundColor = colorCode;
}
showPanelCheck(0, 'rgba(0, 0, 0, 0)');

var tabButtonsFly = document.querySelectorAll(".tabContainerFly .buttonContainerFly input");
var tabPanelsFly = document.querySelectorAll(".tabContainerFly  .tabPanelFly");

function showPanelFly(panelIndexFly, colorCode) {
    tabButtonsFly.forEach(function (node) {
        node.style.backgroundColor = "";
        node.style.color = "";
    });
    tabButtonsFly[panelIndexFly].style.backgroundColor = "white";
    tabButtonsFly[panelIndexFly].style.color = "black";
    tabPanelsFly.forEach(function (node) {
        node.style.display = "none";
    });
    tabPanelsFly[panelIndexFly].style.display = "block";
    tabPanelsFly[panelIndexFly].style.backgroundColor = colorCode;
}
showPanelFly(0, 'rgba(0, 0, 0, 0)');

var tabButtonsReserve = document.querySelectorAll(".tabContainerReserve .buttonContainerReserve input");
var tabPanelsReserve = document.querySelectorAll(".tabContainerReserve  .tabPanelReserve");

function showPanelReserve(panelIndexReserve, colorCode) {
    tabButtonsReserve.forEach(function (node) {
        node.style.backgroundColor = "";
        node.style.color = "";
    });
    tabButtonsReserve[panelIndexReserve].style.backgroundColor = "white";
    tabButtonsReserve[panelIndexReserve].style.color = "black";
    tabPanelsReserve.forEach(function (node) {
        node.style.display = "none";
    });
    tabPanelsReserve[panelIndexReserve].style.display = "block";
    tabPanelsReserve[panelIndexReserve].style.backgroundColor = colorCode;
}
showPanelReserve(0, 'rgba(0, 0, 0, 0)');