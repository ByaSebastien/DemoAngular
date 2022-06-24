using Delegue;
using Delegue.Delegate;
using Delegue.Models;

string numPlaque;
Voiture voiture = new Voiture("1-Bel-123");
Carwash carwash=new Carwash();
MyDelegate laver = delegate (Voiture v)
{
    carwash.Traiter(v);
};
laver(voiture);