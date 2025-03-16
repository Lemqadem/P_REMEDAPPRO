@ -1,93 +1,115 @@
# Suivi des activités

## 31 Janvier 2025

- Feedback XCL
    - Le contrat est OK
    - Commencez à coder le mastermind

## 7 Février 2025

- Feedback XCL
    - Le journal de travail de la semaine passée est absent. Attention à ne pas réitérer ce genre d'oubli, cela peut avoir des conséquences.

- Journal de travail
    - ajouter l'option pour consulter les règles et mise au propre des méthodes ----->40minutes
    - ajout du retour au menu après consultations des règles--->30minutes
    - absence pour rdv médical le restant du cours --->60minutes

## 14 Février 2025

- Feedback XCL
    - Votre programme n'est pas bien structuré. Il ne faut pas appeler `Main()` pour revenir en arrière, il faut que votre programme tourne en boucle tant que l'utilisateur ne lui dit pas qu'il veut quitter
    - Notez vos absences dans le journal de travail, pour que l'on comprenne pourquoi le total n'est pas juste

- Journal de travail
    - correction de la structure du programme énumérée dans le dernier feedback.--->60minutes ( un peu long car j'avais oublié le fonctionnement des bool dans une boucle while)
    - sorti du cours à 15h30 pour Rendez-vous médical --> jusqu'a la fin du cours ---->65minutes

## 28 février 2025

- Feedback XCL
    - Il n'est pas normal que la correction de la structure de votre programme vous prenne une heure. Cela aurait dû prendre au maximum 15 minutes.
        - Soit vous n'avez pas travaillé (pas concentré ou avez fait autre chose) pendant 45 minutes et il vous faut changer d'attitude
        - Soit vous avez eu besoin de tout ce temps pour comprendre quelque chose d'élémentaire et il va falloir travailler fort pour combler votre retard avant que vous n'abordiez des sujets plus compliqués dans les prochains cours.
     
    - Vos objectifs minimaux pour ce jour:
        1. Créer aléatoirement une combinaison à trouver, sous la forme d'un tableau de 4 entiers (`int[]`)
        2. Afficher cette combinaison dans un tableau genre:
            ```
            ╔═══╦═══╦═══╦═══╗  
            ║   ║   ║   ║   ║  
            ╚═══╩═══╩═══╩═══╝  
            ```
           Les couleurs à mettre dans les cases:  
             1 = Blanc  
             2 = Bleu  
             3 = Rouge  
             4 = Vert  
             5 = Jaune  
             6 = Noir  

- Journal de travail

  - 10minutes--> explications du prof etc...  
  - 30minutes--> rétrospective  
  - 60minutes--> création de la page de jeu et création du tableau color( cela m'as pris énormement de temps car je rencontre un problème que je ne peux résoudre: quand je vais sur la methode Game, le menu s'efface partiellement ce qui rend incormpréhensible l'interface)  
  - 15minutes--> M.Carrel est venu m'aider pour comprendre pourquoi mon code avait le comportement cité plus haut.
  - 15minutes--> je me suis renseigné sur la création de combinaison aleatoire sur c#


## 7.3

- Feedback XCL
    - Quel a été le résultat de la retrospective ? cela doit être visible dans votre jdt
    - Ce n'est qu'en allant regarder dans votre repo que j'ai fini par comprendre.
    - Le document retrospective est bien. Dommage: ce n'est pas sous cette forme que je vous demandais de me le transmettre

- Journal de travail

- 15min--->théorie de M.Carrel
- 20minutes---->retrospective correction
- 25minutes--> continuer de me renseigner sur les suites aleatoire c#
- 30minutes----> ajout d'un nombre maximum de tentatives (10)
- 20minutes---->optmisation d'interface de jeu
- 30minutes---->ajout de commentaires
- 15minutes----> conseils d'un collègue quant au focntionnement de l'algorythme


## 12.3
- Journal de travail

- 5minutes--> modifications du texte des règles du jeu
- 25minutes-->création du system de génération aleatoie de suite de nombre qui se stock dans une variable tableau
-65minutes--> création d'une boucle permettant de saisir 4chiffres pour 10 essai et en verifiant a chaque fois que la combinaison est valide ( j'ai pris enormement de temps pour faire cela car j'ai pris du temps a comprendre comment cela fonctionnait en regardant notamment des videos youtube tuto en paralelle)

## 13.3
- Journal de travail
- 60 minutes--> correction de mon code car dans le code que j'ai fait hier, il restait des erreurs, j'ai donc corrigé et simplifié le code ( cela m'a pris beaucoup de temps car j'ai peiné a comprendre comment rendre le code plus simpl et corriger l'erreur)

## 14.3
-journal de travai
-65minutes--> création du mechanisme de verification de combinaison, si il y a des chiffres justes et bien placé ou des chiffres justes mais mal placé+ ajout et mise au propre des commentaires 
30minutes--->affichage de la combinaison secrete quand les 10 essai sont écoulé + propisition de rejouer ou de quitter + mise au propre du code en enlevant les variables inutilisés et en ajoutant des commentaires
30minutes--->affichage de la combinaison secrete quand les 10 essai sont écoulé + propisition de rejouer ou de quitter + mise au propre du code en enlevant les variables inutilisés et en ajoutant des commentaires


## 14.3

- Feedback XCL
    - Commits: le nom ne devrait pas dépasser 50 caractères. C'est bien de vouloir en mettre plus, mais il vous faut alors le faire dans la description (pas dans le nom)
    - Journal: très bien!
    - Le programme est bien, je ne comprends pas pourquoi vous ne marquez pas vos objectifs 3 et 4 comme atteints
    - Le jeu n'est pas très "user friendly". Vous pouvez l'améliorer, par exemple en créant et en utilisant une fonction supplémentaire:
    ```csharp
            // Retourne un chiffre entre 1 et 6 tapé pr l'utilisateur au clavier, sans rien afficher à l'écran
        static int GetNumber()
        {
            int res = 0;
            // ...
            return res;
        }

    ```

- Journal de travail 
    - 10minutes-->discours professeur
    - 10minutes-->j'ai du résoudre les conflit sur le programme comme sur le jdt qui s'est chargé a moitié
    - 30 minutes-->ajout de la posibilité de rejouer après la victoire
    - 15minutes--> test du programme par des collègue afin d'avoir un avis supplémentaire
    - 10inutes--> discussion avec m.carrel par rapport au feedback
    - 30 minutes---> test du code + ajout de texte a la victoire comme à la défaite
 
# Conclusion

Vos objectifs ont été atteints, votre journal de travail est satisfaisant. Le projet est donc validé.

Je vous suggère fortement toutefois de ne pas relâcher vos efforts car le programme que vous avez fourni départ d'une très grande qualité technique.

D'autre part, je constate que vous avez fait un effort au niveau du nommage commits. Il reste néanmoins quelques progrès à faire en suivant la syntaxe demandée avec les parenthèses et les deuxpoints. En d'autres termes: "feat (program): Ajout de la posibilité de rejouer après la victoire" au lieu de "feat program ajout de la posibilité de rejouer après la victoir.

Comme discuté en classe, la saisie des données n'est pas très "user friendly". Cela a été dicté par un choix technique qui simplifie l'écriture du code au détriment de l'expérience de l'utilisateur. Il est important d'arriver à inverser cet approche : on doit d'abord penser aux besoins de l'utilisateur et ensuite trouver les moyens techniques pour les satisfaire. C'est cette étape qu'il faut que vous arriviez à franchir en améliorant vos compétences techniques.
