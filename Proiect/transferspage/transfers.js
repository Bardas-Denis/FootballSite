
const apiUrl = 'https://localhost:7233/api/Transfer';
const apiUrlPlayer = 'https://localhost:7233/api/Player';
const apiUrlTeam = 'https://localhost:7233/api/Team';
let transfers = [];
let data = [];
var a;var b;var c;

function populateTable(data2) {
    

  var tableBody = document.getElementById("transfersTable").getElementsByTagName('tbody')[0];
  var index = 0;
  data2.forEach(d=> {
    if(d.playerName)
    {
      var row = tableBody.insertRow(-1);
      var cell1 = row.insertCell(0);
      var cell2 = row.insertCell(1);
      var cell3 = row.insertCell(2);
      var cell4 = row.insertCell(3);
  
      cell1.textContent = index + 1;
      cell2.textContent = d.playerName;
      cell3.textContent = d.lastTeamName;
      cell4.textContent = d.newTeamName;
      index++;
    }
  });
}

async function fetchData() {
    try {
        const response = await fetch(apiUrl);
        const data = await response.json();

        data.forEach(t => {
            const transfer = new Transfer(t.id, t.playerId, t.lastTeamId, t.newTeamId);
            transfers.push(transfer);
        });


        for (const transfer of transfers) {
            try {
                const playerResponse = await fetch(`${apiUrlPlayer}/${transfer.playerId}`);
                const playerData = await playerResponse.json();
                a=playerData.name;
            } catch (error) {
                console.error('Error fetching player data:', error);
            }
            try {
              const teamResponse = await fetch(`${apiUrlTeam}/${transfer.lastTeamId}`);
              const lastTeamData = await teamResponse.json();
              b = lastTeamData.name;
            } catch (error) {
              console.error('Error fetching last team data:', error);
            }
            try {
              const teamResponse = await fetch(`${apiUrlTeam}/${transfer.newTeamId}`);
              const newTeamData = await teamResponse.json();
              c=newTeamData.name;
              var x = new TransferData(a,b,c)
              data.push(x)
              

            } catch (error) {
              console.error('Error fetching last team data:', error);
            }
        }
        populateTable(data);
    } catch (error) {
        console.error('Error fetching transfer data:', error);
    }
}

document.addEventListener("DOMContentLoaded", function () {

  fetchData();
});

  

function back()
{
    window.location.href = '../mainpage/mainpage.html';
}