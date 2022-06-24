
(function (phrase)
{
    phrase+="erg";
});

let f = "Hello ";
console.log(VerfiMoi(f));


let MONQI=150; //Ceci est une CONTANTE!!!!!
const SONQUI=456; //CECI est UNE VRAI CONSTANTE!!!
 
var texte = "Lionel";
let Score = 3.65;
let age = parseInt(texte); //Le Let
var rep;
console.log(age);
if(isNaN(age))
{
alert("C'est pas un NOMBRE!!!!!!");
}
let texte2 = "Richie";
alert("ATTENTION!!!!! Y'a du JS AAAAAAAhhhh");
if(confirm("T'es sûr de vouloir lancer du js ??????"))
{
     alert("Yes");
     rep='yes';
     SONQUI+=456;
}
else
{
     alert('Vous êtes donc Shaco ?');
     MONQI = 12;
}

let reponse = prompt('COmbien voulez-vous de bitcoin?');

let total = parseInt(reponse)*30000;
rep = 2;
if(rep === undefined)
{
    console.log('Vide');
}

if('12' == 12) //Fonctionne car compare la valeur uniquement
{
    console.log("même val");
}

if('12' === 12) //Ne fonctionne pas car pas même type
{
    console.log("pas la même chose");
}

if('12' !== 12){ console.log('OK')}
if('12' != 12){ console.log('Pas OK')}

if('12'>=12){console.log("Trop grand")}  //  du coup on est FOUTU!!!!

console.log(rep);

//Les typages
let birth_date = new Date(1965,2,12);
console.log( typeof birth_date);
console.log( birth_date.constructor);