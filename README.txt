Jeu FlappyBird

1. Ce qui a été intégré :
	- 5 scènes : intro, menu, réglages, jeu, gameover
	- musique d'intro
	- musique de jeu qui continue au gameover
	- son au saut de l'oiseau
	- score + meilleur score 
	- possibilité de changer d'oiseau en jeu avec un clic droit
	- une pause en appuyant sur ECHAP ou P
	- le défilement du background, des pipes qui étaient proposés dans le TP.
	- une augmentation de la difficulté à un score de 10 (augmentation de la vitesse, une seule fois).
	- un bouton Facebook

2. Ce qui aurait pu être intégré / Pourquoi ce n'est pas présent :
	- animation de l'oiseau quand il meurt : j'ai réussi à faire tournoyer l'oiseau, à stopper une paire de pipe, mais je n'ai pas réussi à stopper le défilement des deux pairs de pipes.
Ce qui a pour conséquence que les pipes poussent l'oiseau et on ne voit pas l'animation : il aurait fallu que les pipes s'arrêtent et que l'oiseau tombe en s'animant, collé au pipe.
	- moins de linéarité dans le jeu : plus de difficulté au fil du temps en jouant sur plusieurs facteur différents tels que la vitesse, la force du saut, des ennemis qui sortes des pipes, peut être même la taille de l'oiseau.
La faute, probablement à mon manque d'organisation dans le travail à la maison (le confinement ne me réussi pas), je n'ai pas implémenté tout cela, mais je le ferai quand j'aurai du temps libre pour mes connaissances personnelles, 
car ça me plait assez de travailler sur Unity.


3. Les difficultés rencontrées et comment vous êtes sortis de ces difficultés : 

	- Son qui continue dans la scène de gameover mais qui repare au début quand on relance une partie
		-> J'ai fais un singleton avec un DontDestroyOnLoad(), idée trouvée sur internet. 
 	- Avant, quand on était dans la scène de gameover, on pouvait relancer une partie en cliquant sur l'écran ou en appuyant sur la touche espace.
Cependant, par la suite, j'ai intégré un bouton "Menu" pour revenir au menu principal. Le problème était que le clic sur le bouton menu passait en second plan, derrière le clic sur l'écran pour rejouer,
donc mon clic sur le bouton menu relancait une partie. Je n'ai pas trouvé de vraie solution à ça, j'ai donc supprimé le clic pour rejoué, et donc seulement laissé la touche Espace.
	- Choix de son oiseau dans les réglages : Je voulais que l'on puisse cliquer sur l'oiseau de notre choix dans les réglages, et qu'en fonction de notre choix, on joue avec celui choisi.
Je n'ai pas réussi à faire cela, je pense qu'un dontDestroyOnLoad se cachait dans le problème mais c'était plus compliqué que pour la musique.
J'ai donc choisi de laisser les différents oiseaux dans les réglages, mais le changement se fait in-game en faisant un clic droit. Je trouve finalement cette solution meilleure et originale.

4. sources

	- https://upln.fr/game-pause-unity3d/
	- https://docs.unity3d.com/ScriptReference/AudioSource.Play.html
	- https://www.auboutdufil.com/index.php?tag=instrumental
	- https://forum.unity.com/threads/how-do-i-call-on-animations-for-idle-walk-and-run.438843/
	- https://stackoverflow.com/questions/44070207/how-to-switch-between-two-animations-in-unity
	- N'ayant pas noter mes sources au fil du temps, j'en oublie probablement et je m'en excuse.
