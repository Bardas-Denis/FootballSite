const apiUrl = 'https://localhost:7233/api/League';
const apiUrlTeams = 'https://localhost:7233/api/Team';

let soccerStandingsData = [];

async function fetchData() {
    try {
        const response = await fetch(apiUrl);
        const data = await response.json();

        const selectElement = document.getElementById('leagues');
        selectElement.innerHTML = '<option selected>Choose a league</option>';
        data.forEach(league => {
          const option = document.createElement('option');
          option.text = league.name;
          selectElement.appendChild(option);
      });

    } catch (error) {
        console.error('Error fetching league data:', error);
    }
}

fetchData();
function loadTable()
{
  var tableBody = document.getElementById("soccerStandingsTable").getElementsByTagName('tbody')[0];
  var newTableBody = document.createElement('tbody');
  var index = 1;
  soccerStandingsData.sort(function(a, b) {
    return b.points - a.points; 
  });
    soccerStandingsData.forEach(function (team) {
      var row = newTableBody.insertRow(-1);
      var cell1 = row.insertCell(0);
      var cell2 = row.insertCell(1);
      var cell3 = row.insertCell(2);
      var cell4 = row.insertCell(3);
      var cell5 = row.insertCell(4);
      var cell6 = row.insertCell(5);
      var cell7 = row.insertCell(6);
      var cell8 = row.insertCell(7);
      var cell9 = row.insertCell(8);

      cell1.textContent = index;
      cell2.textContent = team.name;
      cell3.textContent = team.gamesPlayed;
      cell4.textContent = team.gamesWon;
      cell5.textContent = team.gamesDrawn;
      cell6.textContent = team.gamesLost;
      cell7.textContent = team.goalsFor;
      cell8.textContent = team.goalsAgainst;
      cell9.textContent = team.points;
      index++;
    });
  tableBody.parentNode.replaceChild(newTableBody,tableBody);
    
}
async function fetchDataTeams(i) {
  try {
      const response = await fetch(apiUrlTeams);
      const data = await response.json();

      data.forEach(t => {
        if(t.leagueId == i)
        {
        var x = new TeamData(t.name,t.gamesPlayed,t.gamesWon,t.gamesDrawn,t.gamesLost,t.goalsFor,t.goalsAgainst,t.leagueId,t.points)
        soccerStandingsData.push(x)
        }
    });
    loadTable();
  } catch (error) {
      console.error('Error fetching team data:', error);
  }
}



function submitLeague()
{ 
  soccerStandingsData = []
  var l;
  var leaguesSelect = document.getElementById('leagues');
  var selectedLeague = leaguesSelect.value;
  if (selectedLeague == 'Premier League')
  {
    l=1;
  }
  else if (selectedLeague == 'La Liga')
  {
    l=3;
  }
  else if (selectedLeague == 'Bundesliga')
  {
    l=4;
  }
  else if (selectedLeague == 'Serie A')
  {
    l=5;
  }
  else if (selectedLeague == 'Ligue 1')
  {
    l=6;
  }
  fetchDataTeams(l);
}

function back()
{
    window.location.href = '../mainpage/mainpage.html';
}