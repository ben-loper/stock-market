const submitButton = document.getElementById('submit');

function updateTable() {

}


submitButton.addEventListener('click', (event) => {
    event.preventDefault();

    getStockInfo();

    event.updateTable();
});

function getStockInfo() {
    fetch('https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol=MSFT&apikey=demo')
        .then((res) => {
            return res.json();
        })
        .then(function (myJson) {
            console.log(myJson);
        })
}