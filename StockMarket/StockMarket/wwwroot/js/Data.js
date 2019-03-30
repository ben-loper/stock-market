
//const request = async () => {
//    const response = await fetch('https://api.com/values/1');
//    const json = await response.json();
//    console.log(json);
//}

//request();




function getStockInfo() {
    return fetch('/js/dummy-data.json')
        .then((res) => {
            return res.json();
        })
        .then(function (myJson) {
            return myJson["Time Series (Daily)"]["2018-11-02"];
        });
}

function updateTable(jsonObject) {
    // Get the table by id
    const tableNode = document.getElementById('dataTable');

    // Create a new table row
    const tableRowNode = document.createElement('tr');

    // For each JSON property, Create a td 
    const tableDataNode = document.createElement('td');
    jsonObject.forEach((element) => {
        tableDataNode.innerText = element;

        // Attach to the td node the td for each value
        tableRowNode.insertAdjacentElement('beforeend', tableDataNode);
    });       
    // Attach the table row to the table
    tableNode.insertAdjacentElement('beforeend', tableRowNode);
}


document.addEventListener('DOMContentLoaded', () => {

    const submitButton = document.getElementById('submit');

    submitButton.addEventListener('click', (event) => {
        event.preventDefault();


        let jsonObject = getStockInfo();



        updateTable(jsonObject);
    });

});