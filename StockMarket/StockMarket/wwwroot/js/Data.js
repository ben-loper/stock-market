
function getStockInfo() {
    return fetch('https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol=MSFT&apikey=demo')
        .then((res) => {
            return res.json();
        })
        .then(function (myJson) {
            console.log(myJson["Time Series (Daily)"]["2018-11-02"]);
        });
}

function updateTable(jsonObject) {
    // Get the table by id


    // Create a new table row

    // For each JSON property, Create a td 

        // Attach to the td node the td for each value

    // Attach the table row to the table

}


document.addEventListener('DOMContentLoaded', () => {

    const submitButton = document.getElementById('submit');

    submitButton.addEventListener('click', (event) => {
        event.preventDefault();

        let jsonObject = getStockInfo();

        updateTable(jsonObject);
    });

});