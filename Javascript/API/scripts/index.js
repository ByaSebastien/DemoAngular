document.getElementById("btnSearch").addEventListener("click", function (e) {
    e.preventDefault(); //empêche le fonctionnement par défaut du boutton

    let texte = document.getElementById("search").value;

    let xhr = new XMLHttpRequest();
    //j'écoute
    xhr.onreadystatechange = function () {
        //Ajouter cette ligne pour toutes vos requêtes ajax
        // console.log(xhr.response);

        if (xhr.readyState == 4) {
            let pokemon = JSON.parse(xhr.responseText); // du string vers un objet javascript
            console.log(pokemon);
        }
    }
    xhr.open("GET", `https://pokeapi.co/api/v2/pokemon/${texte}`);
    xhr.send();
    // xhr.open("GET", `http://www.omdbapi.com/?t=${texte}&apikey=${APIKEY}`);
    // xhr.send();


});