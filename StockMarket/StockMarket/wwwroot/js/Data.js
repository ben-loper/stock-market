﻿
//const request = async () => {
//    const response = await fetch('https://api.com/values/1');
//    const json = await response.json();
//    console.log(json);
//}

//request();






function getStockInfo() {
    const symbolInput = document.getElementById('symbol').value;
    const dateInput = document.getElementById('date').value;


    fetch(`https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol=${symbolInput}&apikey=V8392HVZ3MRY8A4V`)
     //fetch('/js/dummy-data.json')
        .then((res) => {
            return res.json();
        })
         .then(function (myJson) {

             const stockInfo = {}

             //stockInfo.symbol = myJson["Meta Data"]["2. Symbol"];
             stockInfo.symbol = symbolInput;

             stockInfo.date = dateInput;

             //stockInfo.financialInfo = myJson["Time Series (Daily)"]["2018-11-02"];
             stockInfo.financialInfo = myJson["Time Series (Daily)"][`${dateInput}`];

             return stockInfo;
         })
         .then(function updateTable(jsonObject) {

             const tableNode = document.getElementById('dataTable');

             const tableBody = tableNode.childNodes[3];

             const tableRowNode = document.createElement('tr');

             const stockSymbol = jsonObject.symbol;
             const symbolDataNode = document.createElement('td');
             symbolDataNode.innerText = stockSymbol;
             tableRowNode.insertAdjacentElement('beforeend', symbolDataNode);

             const stockDate = jsonObject.date;
             const stockDateDataNode = document.createElement('td');
             stockDateDataNode.innerText = stockDate;
             tableRowNode.insertAdjacentElement('beforeend', stockDateDataNode);

             const stockOpen = jsonObject.financialInfo["1. open"];
             const openDataNode = document.createElement('td');
             openDataNode.innerText = stockOpen;
             tableRowNode.insertAdjacentElement('beforeend', openDataNode);

             const stockHigh = jsonObject.financialInfo["2. high"];
             const highDataNode = document.createElement('td');
             highDataNode.innerText = stockHigh;
             tableRowNode.insertAdjacentElement('beforeend', highDataNode);

             const stockLow = jsonObject.financialInfo["3. low"];
             const lowDataNode = document.createElement('td');
             lowDataNode.innerText = stockLow;
             tableRowNode.insertAdjacentElement('beforeend', lowDataNode);

             const stockClose = jsonObject.financialInfo["4. close"];
             const closeDataNode = document.createElement('td');
             closeDataNode.innerText = stockClose;
             tableRowNode.insertAdjacentElement('beforeend', closeDataNode);

             const stockVolume = jsonObject.financialInfo["5. volume"];
             const volumeDataNode = document.createElement('td');
             volumeDataNode.innerText = stockVolume;
             tableRowNode.insertAdjacentElement('beforeend', volumeDataNode);
    
             
             // Attach the table row to the table
             tableBody.insertAdjacentElement('beforeend', tableRowNode);
         });
}

//function updateTable(jsonObject) {
//    // Get the table by id
//    const tableNode = document.getElementById('dataTable');

//    // Create a new table row
//    const tableRowNode = document.createElement('tr');

//    // For each JSON property, Create a td 
//    const tableDataNode = document.createElement('td');
//    jsonObject.forEach((element) => {
//        tableDataNode.innerText = element;

//        // Attach to the td node the td for each value
//        tableRowNode.insertAdjacentElement('beforeend', tableDataNode);
//    });       
//    // Attach the table row to the table
//    tableNode.insertAdjacentElement('beforeend', tableRowNode);
//}


document.addEventListener('DOMContentLoaded', () => {

    const submitButton = document.getElementById('submit');

    submitButton.addEventListener('click', (event) => {
        event.preventDefault();


        getStockInfo();

    });

});