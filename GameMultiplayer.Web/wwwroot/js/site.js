// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const connection = new signalR.HubConnectionBuilder()
    .withUrl("/game")
    .build();

var connId;

// Init connection
$(document).ready(function () {
    connection.start()
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


    context.fillStyle = 'white'
    context.clearRect(0, 0, 10, 10)

    $.each(players, function () {
        var player = this;

        connection.on('ConnectionId', (connectionId) => {
            connId = connectionId
        });

        player.connectionId === connId ? context.fillStyle = 'yellow' : context.fillStyle = 'gray'      
        context.fillRect(player.playerX, player.playerY, 1, 1)
    });

    $.each(fruits, function () {
        var fruit = this;
        context.fillStyle = 'green'
        context.fillRect(fruit.fruitX, fruit.fruitY, 1, 1)
    });
})