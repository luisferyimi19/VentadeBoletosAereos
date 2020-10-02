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