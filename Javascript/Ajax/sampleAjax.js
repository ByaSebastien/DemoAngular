 const APIKEY = '335c3887';
document.getElementById("btnSearch").addEventListener("click", function(e)
{
  e.preventDefault(); //empêche le fonctionnement par défaut du boutton

  let texte = document.getElementById("search").value;

  let xhr = new XMLHttpRequest();
  //j'écoute
  xhr.onreadystatechange= function()
  {
      //Ajouter cette ligne pour toutes vos requêtes ajax
      console.log(xhr.response);

      if(xhr.readyState==4)
      { 
          let Film = JSON.parse(xhr.responseText); // du string vers un objet javascript
          document.getElementById("Titre").innerHTML=Film.Title;
          document.getElementById("zone").setAttribute("src",Film.Poster);
      }
  }
  xhr.open("GET",`http://www.omdbapi.com/?t=${texte}&apikey=${APIKEY}`);
  xhr.send();


});


