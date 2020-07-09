// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Create connection
const connection = new signalR.HubConnectionBuilder()
    .withUrl("/game")
    .build();

// Init connection
$(document).ready(function () {
    connection.start()
        .then(function () {
            connection.invoke('getConnectionId')
                .then(function (connectionId) {
                    sessionStorage.setItem('conectionId', connectionId);
                });
            connection.invoke('renderPlayers');
        })
        .catch(err => console.error(err.toString()));
});


// Get key pressed
document.addEventListener('keydown', function (event) {
    connection.invoke("OnKeyPressed", event.keyCode)
    event.preventDefault();
});

// Render
connection.on("Render", (players, fruits) => {
    const screen = document.getElementById('screen')
    const context = screen.getContext('2d')
    var scoreTable = document.getElementById('score-table')

    let scoreTableInnerHTML = `
        <tr class="header">
            <td>Jogadores</td>
            <td>Pontos</td>
        </tr>
    `
    context.fillStyle = 'white'
    context.clearRect(0, 0, width, height)

    $.each(players, function () {
        var player = this;
        var connId = sessionStorage.getItem('conectionId')
        var isCurrentPlayer = player.connectionId === connId ? true : false

        isCurrentPlayer ? context.fillStyle = 'yellow' : context.fillStyle = 'gray'

        scoreTableInnerHTML += `
            <tr ${isCurrentPlayer ? 'class="current-player"' : ''}>
                <td>${player.playerId}</td>
                <td>${player.pontos}</td>
            </tr>
        `
        context.fillRect(player.playerX, player.playerY, 1, 1)
    });

    $.each(fruits, function () {
        var fruit = this;
        context.fillStyle = 'green'
        context.fillRect(fruit.fruitX, fruit.fruitY, 1, 1)
    });

    scoreTable.innerHTML = scoreTableInnerHTML
})