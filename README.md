# Escape-Plan-VR

## Description

Il s'agit d'un jeu VR fait sous le moteur de jeu Unity. Le joueur est piégé dans une pièce et doit s'échapper en résolvant des énigmes. Le joueur peut interagir avec les objets de la pièce en les saisissant avec les contrôleurs. Il peut aussi se téléporter et se déplacer dans la pièce.

## Installation / lancement

- Cloner le dépot Git
- Créer un nouveau projet Unity `VR (Core)`
- Remplacer le dossier `Assets` du projet par celui du dépot Git
- Lancer la scene nommée `GAME`


## Sujet

**Vous devez créer une application dans laquelle le joueur peut :**
- Se déplacer dans un environnement 3D via un système de téléportation (vous pouvez utiliser
des packs 3D de l’asset Store)
- Pouvoir attraper des objets et se déplacer avec
- Pouvoir relâcher des objets dans des zones ce qui déclenche des actions (triggers)

**L’application doit présenter un mini escape game dans lequel je joueur doit passer dans 3 salles :**
- Salle 1 : le joueur doit ramasser un objet par terre dans la pièce et le déposer sur un
récepteur ce qui ouvre une porte vers la salle 2
- Salle 2 : le joueur doit mettre les bons objets au bon endroit
    - Une pyramide doit être placée dans le récepteur pyramide
    - Un cube doit être placé dans le récepteur cube
    - Une sphere doit être placée dans le récepteur sphere
    - Quand tous les éléments sont au bon endroit, la porte de la salle 3 s’ouvre
- Salle 3 : Le joueur doit déplacer des cubes pour bloquer des « rayons laser » sur la scène qui
maintiennent la porte de sortie fermée. Bloquer le rayon entre son point démission et son
point de réception permet d’ouvrir la porte et de gagner le jeu


## Résolution des niveaux

Le jeu est composé de 3 niveaux :

- Niveau 1 : Le joueur doit placer une grosse pièce d'échec dans le récepteur afin que la porte s'ouvre.
- Niveau 2 : Le joueur doit trouver et placer les objets de couleur au bon endroit afin que la porte s'ouvre.
- Niveau 3 : Le joueur doit bloquer le laser avec des cubes afin d'accéder à la dernière salle.

