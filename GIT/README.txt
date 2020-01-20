git branch -a : affiche les branches + indique sur laquelle on est. 

git branch "xxx" -> crée une branche de nom "xxx" 
git checkout "xxx" -> fait basculer sur la branche "xxx" 
A la place de faire "git branch" puis "git checkout" on peut faire directement : 
	git checkout -b "xxx" 


git add . 
git commit -m "..." 



git branch -D "branchname" -> supprime la branche "branchname" 
git branch -d "branchname" supprime la branche "branchname" uniquement sur les branches merged. 


git merge "branchname" -> il faut se placer dans la branche master à laquelle on veut merge la branche "branchname" 
Si on modifie la masterbranch (on rajoute "prout" dans le fichier "eoh") et qu'ensuite on merge une branche (dans laquelle
on a modifié des éléments du fichier "eoh") il va y avoir conflit puisque Git ne va pas savoir quelle version est à garder.
On va avoir dans notre fichier "eoh" qqch du genre : 
<<<<<<<<<<HEAD 

============

>>>>>>>>>>"branchname" 
Il faut supprimer tout ça pour obtenir le code que l'on veut. 
Puis "git add ." -> "git commit" -> Ecran bizzard avec conflicts -> ":wq" 


Fast-forward // recursive strategy -> juste des indications sans conséquences 

LES MESSAGES DE COMMIT SONT SUPER IMPORTANTS POUR LES FEEDBACK PTN !!! 