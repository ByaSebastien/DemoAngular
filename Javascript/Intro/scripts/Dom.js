document.write("<h1 class='rrr'>LOL</h1>");
document.write("<h1 class='rrr'>MDR</h1>");
document.write("<h1 class='rrr'>PTDR</h1>");

// let lep = document.getElementById('display');
// lep.innerHTML="ICI";
// console.log(lep);

 let img = document.getElementById('rubber');
// console.log(img);
// img.src="./images/batman.jpg";

// img.outerHTML="<p>Censuré</p>";

// let classRRR = document.getElementsByClassName('rrr');
// for(let indice in classRRR)
// {
//     classRRR[indice].outerHTML="<h3>Zip</h3>";
// }

let itbe = document.createElement("input");
itbe.setAttribute('type','button');
console.log(itbe.attributes);
itbe.value="Zorro";
console.log(itbe);

itbe.addEventListener("click", function(e){ console.log(e);  });
img.addEventListener('click',function(e)
{ 
    let parentbt = itbe.parentNode;
    let parentimg= img.parentNode;
    parentimg.removeChild(img);
    parentbt.removeChild(itbe);
    parentimg.appendChild(itbe);    
    parentbt .appendChild(img);
});


//je vais chercher ma div
document.getElementById("Ado").appendChild(itbe); 
 

 