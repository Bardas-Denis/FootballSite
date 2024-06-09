const apiUrlTeams = 'https://localhost:7233/api/Team';
const apiUrlPlayers = 'https://localhost:7233/api/Player';
var topScorersData = [];

function loadTable()
{
  var tableBody = document.getElementById("topScorersTable").getElementsByTagName('tbody')[0];
  while (tableBody.firstChild) {
    tableBody.removeChild(tableBody.firstChild);
  }
 var i = 1;
 topScorersData.sort(function(a, b) {
  return b.goals - a.goals; 
});
  topScorersData.forEach(function (player) {
    var row = tableBody.insertRow(-1);
    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);
    var cell3 = row.insertCell(2);

    cell1.textContent = i;
    cell2.textContent = player.name;
    cell3.textContent = player.goals;
    i++;
  });
}

async function fetchDataPlayers() {
  try {
      const response = await fetch(apiUrlPlayers);
      const data = await response.json();

      data.forEach(p => {
        var x = new PlayerData(p.name,p.age,p.goals,p.height,p.position,p.weight);
        topScorersData.push(x)
    });
    loadTable();
  } catch (error) {
      console.error('Error fetching player data:', error);
  }
}

document.addEventListener("DOMContentLoaded", function () {

  fetchDataPlayers();
});

function back()
{
    window.location.href = '../mainpage/mainpage.html';
}