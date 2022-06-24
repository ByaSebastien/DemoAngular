﻿using ConceptTest.Models;

Formation formation;
Personne formateur = new Personne("Flavian",Status.Formateur);
Personne stagiaire = new Personne("Seb",Status.Stagiaire);
Exercice exercice = new Exercice(1, "boucles");

formateur.Statu=Status.Formateur;
formation=new Formation(formateur);
formation.Add(exercice);
formation.Add(stagiaire);
stagiaire = new Personne("Mathias", Status.Stagiaire);
exercice = new Exercice(2, "tableau");
formation.Add(exercice);
formation.Add(stagiaire);
stagiaire = new Personne("Antoine", Status.Stagiaire);
exercice = new Exercice(3, "POO");
formation.Add(exercice);
formation.Add(stagiaire);
stagiaire = new Personne("Lucas", Status.Stagiaire);
exercice = new Exercice(4, "if/else");
formation.Add(exercice);
formation.Add(stagiaire);
stagiaire = new Personne("Christopher", Status.Stagiaire);
exercice = new Exercice(5, "Delegue");
formation.Add(exercice);
formation.Add(stagiaire);
formateur.RaiseDonnerExercice(formation.Exercices, formation.Stagiaires);
Console.ReadKey();
formateur.RaiseDonnerPause(formation.Stagiaires);
Console.ReadKey();
formateur.RaiseDonnerExercice(formation.Exercices, formation.Stagiaires);
Console.ReadKey();
formateur.RaiseDonnerPause(formation.Stagiaires);
Console.ReadKey();