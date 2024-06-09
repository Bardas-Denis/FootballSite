function back()
{
    window.location.href = '../mainpage/mainpage.html';
}


function submitLeague()
{
    var leaguesSelect = document.getElementById('leagues');

    var selectedLeague = leaguesSelect.value;
    var selectedText = leaguesSelect.options[leaguesSelect.selectedIndex].text;
   
    console.log('Selected League:', selectedLeague);
    console.log('Selected league', selectedText);

    populateTeams(selectedLeague);
}

function populateTeams(selectedLeague)
{
    var teamSelect = document.getElementById('teams');
    teamSelect.innerHTML = '<option selected>Choose a team</option>';
    teamSelect.disabled = false;
  
    if (selectedLeague === '1') {
        teamSelect.options.add(new Option('Barcelona', '1'));
        teamSelect.options.add(new Option('Real Madrid', '2'));
        teamSelect.options.add(new Option('Sevilla', '3'));
    } else if (selectedLeague === '2') {
        teamSelect.options.add(new Option('Manchester United', '4'));
        teamSelect.options.add(new Option('Liverpool', '5'));
        teamSelect.options.add(new Option('Chelsea', '6'));
    } else if (selectedLeague === '3') {
        teamSelect.options.add(new Option('Juventus', '7'));
        teamSelect.options.add(new Option('Inter Milan', '8'));
        teamSelect.options.add(new Option('AC Milan', '9'));
    }
}

function submitTeam()
{
    var teamSelect = document.getElementById('teams');

    var selectedTeam = teamSelect.value;
    populatePlayerCarousel(selectedTeam);
    
}

function populatePlayerCarousel(team) {
    
    var playerCarouselInner = document.getElementById('playerCarouselInner');
    var prev = document.getElementById('prev');
    prev.removeAttribute('hidden');
    var next = document.getElementById('next');
    next.removeAttribute('hidden');
    playerCarouselInner.innerHTML = '';
    console.log(team)
    if (team === '1') {
        addPlayerToCarousel('Robert Lewandowski', '../images/Lewandowski.jpg');
        addPlayerToCarousel('Pedri', '../images/Pedri.jpg');
        addPlayerToCarousel('Gavi', '../images/Gavi.jpg');
    } else if (team === '2') {
        addPlayerToCarousel('Jude Bellingham', '../images/Jude.jpg');
        addPlayerToCarousel('Rudiger', '../images/Rudiger.jpg');
        addPlayerToCarousel('Luka Modric', '../images/Modric.jpg');
    } else if (team === '3') {
        addPlayerToCarousel('Lucas Ocampos', '../images/Ocampos.jpg');
        addPlayerToCarousel('Ivan Rakitic', '../images/Rakitic.jpg');
        addPlayerToCarousel('Loic Bade', '../images/Bade.jpg');
    }
    else if (team === '4') {
        addPlayerToCarousel('Bruno Fernandes', '../images/Bruno.jpg');
        addPlayerToCarousel('Marcus Rashford', '../images/Rashford.jpg');
        addPlayerToCarousel('Andre Onana', '../images/Onana.jpg');
    }
    else if (team === '5') {
        addPlayerToCarousel('Mohamed Salah', '../images/Salah.jpg');
        addPlayerToCarousel('Virgil van Dijk', '../images/VanDijk.jpg');
        addPlayerToCarousel('Trent Alexander-Arnold', '../images/TAA.jpg');
    }
    else if (team === '6') {
        addPlayerToCarousel('Cole Palmer', '../images/Palmer.jpg');
        addPlayerToCarousel('Levi Colwill', '../images/Colwill.jpg');
        addPlayerToCarousel('Thiago Silva', '../images/Silva.jpg');
    }
    else if (team === '7') {
        addPlayerToCarousel('Federico Chiesa', '../images/Chiesa.jpg');
        addPlayerToCarousel('Dusan Vlahovic', '../images/Vlahovic.jpg');
        addPlayerToCarousel('Adrien Rabiot', '../images/Rabiot.jpg');
    }
    else if (team === '8') {
        addPlayerToCarousel('Lautaro Martinez', '../images/Lautaro.jpg');
        addPlayerToCarousel('Nicolo Barella', '../images/Barella.jpg');
        addPlayerToCarousel('Benjamin Pavard', '../images/Pavard.jpg');
    }
    else if (team === '9') {
        addPlayerToCarousel('Rafael Leao', '../images/Leao.jpg');
        addPlayerToCarousel('Olivier Giroud', '../images/Giroud.jpg');
        addPlayerToCarousel('Christian Pulisic', '../images/Pulisic.jpg');
    }

}

function addPlayerToCarousel(playerName, imageUrl) {
    var playerCarouselInner = document.getElementById('playerCarouselInner');

    var carouselItem = document.createElement('figure');
    carouselItem.classList.add('carousel-item');

    //image for carousel
    var img = document.createElement('img');
    img.classList.add('figure-img','img-fluid','rounded');
    img.src = imageUrl;
    img.alt = playerName;
    img.classList.add('d-block', 'w-100');

    //caption with player stats
    var carouselCaption = document.createElement('figcaption');
    carouselCaption.classList.add('figure-caption');
    carouselCaption.style.background = 'rgba(0, 0, 0, 0.7)';
    carouselCaption.style.color = 'white';
    carouselCaption.style.marginLeft = '5%';
    carouselCaption.style.marginRight = '5%';
    carouselCaption.innerHTML = `<p>Name: ${playerName}, Games: 20, Goals: 12, Assists: 15</p>`;

    carouselItem.appendChild(img);
    carouselItem.appendChild(carouselCaption);
    playerCarouselInner.appendChild(carouselItem);

    if (playerCarouselInner.children.length === 1) {
        carouselItem.classList.add('active');
    }
}

function nextSlide() {
    var playerCarousel = new bootstrap.Carousel(document.getElementById('playerCarousel'));
    playerCarousel.next();
}

// Function to go to the previous slide
function prevSlide() {
    var playerCarousel = new bootstrap.Carousel(document.getElementById('playerCarousel'));
    playerCarousel.prev();
    
}
