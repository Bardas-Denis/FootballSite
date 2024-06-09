const apiUrl = 'https://localhost:7233/api/User';

async function fetchDataUsersRegister(user,pass) {
    try {
        const response = await fetch(apiUrl);
        const data = await response.json();

        var x = true;
        data.forEach(p => {
        console.log(p.name,user)
        if(p.name == user)
        {
            console.log(1);
            x = false;
        }
      });
      console.log(x);
      if(x)
        {
            console.log(2);
            addUser(user,pass);
        }
        else{
            var x = document.getElementById("errorMessage");
            x.textContent = "Username already exist";
            x.style.display = "block";

        }
    } catch (error) {
        console.error('Error fetching player data:', error);
    }
  }

function addUser(username,password)
{
    var userData = {
      id: username,
      name: username,
      password: password
    };

    fetch(apiUrl, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(userData),
    })
    .then(data => {
      console.log('Registration successful:', data);
    })
    .catch((error) => {
      console.error('Error:', error);
    });
}

function registerUser() {
    var username = document.getElementById("user").value;
    var password = document.getElementById("pass").value;
    fetchDataUsersRegister(username,password);
  }


  async function fetchDataUsersLogin(user,pass) {
    try {
        const response = await fetch(apiUrl);
        const data = await response.json();

        var x = false;
        data.forEach(p => {
        console.log(p.name,user)
        console.log(p.password,pass)
        if(p.name == user && p.password == pass)
        {
            console.log(1);
            x = true;
        }
      });
      console.log(x);
      if(x)
        {
            window.location.href = '../mainpage/mainpage.html'
        }
        else{
            document.getElementById("errorMessage").style.display = "block";
            
        }
    } catch (error) {
        console.error('Error fetching player data:', error);
    }
  }

function login() {
    var username = document.getElementById("user").value;
    var password = document.getElementById("pass").value;
    fetchDataUsersLogin(username,password);
}