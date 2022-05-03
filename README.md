# **ElRashoMcQueen**

## Préparation

    1.  Quelle est la structure de votre jeu ?

        Dans un premier temps, on arrive sur un écran avec le titre du jeu. 
        Un second écran va s'afficher dans un second temps, au bout de quelques secondes, avec le 
        menu du jeu et deux boutons "Jouer" et "Quitter". 
        En cliquant sur le bouton "Jouer", on accède ensuite à l'écran de jeu. Si on clique sur le 
        bouton "Quitter", on quitte le jeu.


    2.   Que sont les scènes, les GameObjects, les Scripts, ... ?

        On aura donc trois scènes : L'écran d'accueil du jeu, le menu et l'écran de jeu possédant 
        une caméra chacune. 
        Pour ce qui est des GameObjects, nous prévoyons pour l'écran d'accueil et le menu un cube 
        qui nous servira de background. 
        Pour l'écran de jeu, nous aurons une sphère représentant la voiture et deux cube, un pour 
        le sol et un pour la ligne d'arrivée.
        En ce qui concerne les scripts, il y aura un script qui permet de faire bouger la voiture, 
        un script pour déclencher une action lorsque que la voiture touchera la ligne d'arrivée. 
        Nous aurons également deux scripts pour les boutons du menu et enfin, un script pour passer 
        de l'écran d'accueil au menu.


    3.  Comment allez-vous répartir le travail ?

        Mathias :   Création du menu (Titre, boutons et changements de scène). 
        Florian :   Création du projet et du repo Git, création de l'écran d'accueil (Titre, noms 
                    et changement de scène).
        Cécile :    Création de l'écran de jeu (Voiture, Sol et Ligne d'arrivée avec les actions 
                    associées), rédaction du document.


    4.  Que souhaitez-vous mettre en application ? (Créer des composants, gérer les lumières, gérer 
        les Shaders)

        Nous souhaitons créer des GameObjects, leur ajouter des composants, ajouter au moins un 
        GameObject du store, créer plusieurs scènes, avoir un menu intéractif avec des switch 
        entre les scènes.
        
        
## Fin de développement

    1.  Quels problèmes avez-vous rencontré lors du développement ?
    
        Nous avons surtout rencontré des problèmes de merge avec Git. Ainsi que quelques soucis 
        avec la bibliothèce C# du Timer.
    
    
    2.  Quels concepts avez-vous mis en application ?
    
        Nous avons pu intégrer un GameObject du store ainsi que des materials, avoir plusieurs 
        scènes qui intéragissent entre elles, structurer le projet.
    
    
    3.  Si vous deviez recommencer, que feriez-vous differement ?
    
        Si on devez recommencer, avec plus de temps, nous aurions détaillé plus les scripts, 
        ajouté de l'esthétique au objet (la voiture aurait été une voiture par exemple). On 
        l'aurait vraiment fait en 3D.
        
    
    4.  Avez-vous choisi Git ou PlasticSCM ? 
    
        Nous avons choisi d'utiliser Git car nous l'utilisons régulièrement et c'était donc 
        plus efficace contenu du temps imparti pour le projet. 
    
