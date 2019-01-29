

<img src="/media/image1.png" alt="Résultat de recherche d&#39;images pour &quot;elasticsearch&quot;" style="width:6.3in;height:3.27914in"/>

# Qu’est-ce que Elasticsearch ?

**ElasticSearch** est un moteur de stockage et de recherche de données puissant basé sur **Lucène** (un projet d'**Apache Software Foundation**). **ElasticSearch** a été développé en Java et est distribué de façon **open source sous licence Apache 2.0**. Il fournit un moteur de **recherche "full-text"** multitenant avec une **API RESTFul** et dont les entités sont sauvegardées sous forme de **documents JSON**. Il a été conçu dans l'optique d'être évolutif, avec un système de clustering, de loadbalancing et est capable de reconstruire les données perdues dû à, par exemple, un nœud défectueux.

<img src="/media/image2.jpeg" alt="Résultat de recherche d&#39;images pour &quot;elasticsearch&quot;" style="width:6.3in;height:3.501in" />

# Terminologies

**Cluster :** Un cluster est une collection de nœuds qui partagent des données.

**Nœud :** Un nœud est un serveur unique qui fait partie du cluster, stocke les données et participe aux capacités d'indexation et de recherche du cluster.

**Index :** Un index est un ensemble de documents ayant des caractéristiques similaires. Un index est plus équivalent à un schéma dans le SGBDR.

**Type :** Il peut y avoir plusieurs types dans un index. Par exemple, une application de e-commerce peut avoir utilisé des produits dans un type et de nouveaux produits dans un autre type du même index. Un index peut avoir plusieurs types comme plusieurs tables dans une base de données.

**Document :** Un document est une unité d'information de base qui peut être indexée. C'est comme un enregistrement dans une table SQL.

**Shards et Replicas :** Les index de Elastic Search sont divisés en plusieurs parties appelées Shards, ce qui permet à l'index d'évoluer horizontalement. Elastic Search nous permet également de faire des copies de Shards d'index, que l'on appelle des Replicas.

**Load balancer** : C’est un serveur qui va rediriger entre les différents serveurs qui se trouvent dans le nœud.

<img src="/media/image3.jpeg" style="width:6.3in;height:4.72298in" />

​				*La signification des mots en comparaison à une base de donnée relationnelle*

### Shards et replicas (schéma)

<img src="/media/image4.png" style="width:4.60417in;height:6.08403in" />

Voyons un peu comment les données sont distribuées sur un cluster ElasticSearch. Le modèle employé est celui du *sharding* : cela consiste à distribuer les données par bloc (*shard*) entre les différents nœuds du cluster. Un index est donc décomposé en shards, qui contiennent eux-mêmes les documents :

-   Un index contient un ou plusieurs shards (5 par défaut).

-   À chaque shard correspond un shard primaire et zéro ou plus *replica shards* (1 par défaut), tous stockés sur des nœuds différents.

-   Chaque shard primaire contient les mêmes documents que ses replica shards.

# Avantages de ElasticSearch

**LUCENE** - Construit sur Lucène, il offre les fonctions de recherche plein texte les plus puissantes.

**DOCUMENT-ORIENTE** - Il stocke les entités complexes sous forme de documents JSON structurés et indexe tous les champs par défaut, offrant une performance supérieure.

**SCHEMA FREE** - Il stocke une grande quantité de données semi-structurées (JSON) de manière distribuée. Il tente également de détecter la structure des données, d'indexer les données présentes et de faciliter les recherches.

**RECHERCHE TEXTE COMPLET** - Elasticsearch effectue des recherches linguistiques sur les documents et retourne les documents qui correspondent à la condition de recherche. La pertinence des résultats pour la requête donnée est calculée à l'aide de l'algorithme TF/IDF comme Google.

**RESTFUL API** - Elasticsearch supporte REST API qui est un protocole léger. Nous pouvons interroger Elasticsearch en utilisant l'API REST avec Kibana.

# Qu’est-ce que le Mapping ?

Nous avons le shéma de base en JSON mais Elasticsearch demande un mapping pour faciliter la recherche mais aussi car cette structure permet, comme dans une base de donnée MYSQL, de définir le type, les propriétés, les colonnes etc... Mais concrètement, qu’est-ce que c’est ? Lucene a besoin, pour effectuer des recherches, de savoir comment lire les données. Par défaut, le texte sera décomposé en mots-clés, les nombres et les dates restants dans leur format d’origine (*long*, *int*, *date*…).

Les mappages sont comme un moyen de définir comment mapper les données à un certain type de données et comment les données doivent être indexées. Les mappages sont importants parce que lorsque nous indexons les données, nous nous attendons à pouvoir accéder aux données dans un format lisible et logique. Ici sur l’image ci-dessous, nous pouvons voir un simple mapping sur un document JSON avec une propriété \`\`name\`\`, une colonne \`\`first\`\` et une valeur \`\`John\`\`

<img src="/media/image5.png" style="width:6.30208in;height:4.10417in" />

Après le mapping de notre JSON, nous pouvons voir que nous avons une structure différente.

Dans l'exemple ci-dessus, nous voyons que le champs name.first diffère du reste de la structure car il définit un type. Le type key est utilisée sur les niveaux de feuille pour indiquer à Elasticsearch comment gérer le champ au niveau donné dans le document JSON. Si le type key est omis, comme dans le cas des types sans feuilles, Elasticsearch suppose qu'il est du type objet.

Le type string est l'un des types de noyau intégrés, et Elasticsearch prend en charge de nombreux types différents, tels que geo\_point et ip, qui peuvent être utilisés pour indexer et rechercher efficacement les emplacements géographiques et les adresses IPv4 respectivement. En utilisant le type multi\_field, nous pouvons même indexer un seul champ dans plusieurs champs virtuels.

# Comparaison entre Elasticsearch et mongoDB

<img src="/media/image6.jpeg" alt="Résultat de recherche d&#39;images pour &quot;elasticsearch schema&quot;" style="width:5.20833in;height:2.89583in" />

Nous remarquons tout de suite que les forces d’ElasticSearch résident dans le fait qu’il permet de stocker une grosse quantité de données et rechercher rapidement des données qui se trouvent sur son serveur. La scalabilité reste plus simple, c’est-à-dire que l’ajout de serveurs se fait facilement.

Ses faiblesses résident sur le schéma (Mapping) qui doit être fait au début mais qui va permettre de rechercher plus facilement des données et sur sa gestion des utilisateurs.

# Installation ElasticSearch (MSI)

Pour commencer, nous allons devoir installer Elasticsearch. Nous avons pris la version 6.5.4 et l’installateur en .msi qui se trouve ici :

Nous voici sur la première page qui va définir où nous devons installer Elasticsearch.

<img src="/media/image7.png" style="width:6.29167in;height:4.19792in" />

Nous ne changeons rien ici.

Ensuite, nous allons choisir de ne pas installer Elasticsearch comme un service mais pouvoir le lancer manuellement.

<img src="/media/image8.png" style="width:6.29167in;height:4.20833in" />

Nous allons maintenant donner un nom au cluster et au node (nœud). Vous pouvez mettre ce que vous voulez mais il faudra les appeler plus tard dans le code. Network host est par défaut localhost.

<img src="/media/image9.png" style="width:6.29167in;height:4.20833in" />

Puis ce qui concerne les plugins, nous allons laisser tels quels.

<img src="/media/image10.png" style="width:6.29167in;height:4.19792in" />

Nous allons rester sur licence Basic de X-Pack.

<img src="/media/image11.png" style="width:6.29167in;height:4.19792in" />

Pour lancer Elasticsearch, il faut aller dans son dossier racine. Ouvrez votre terminal et entrez cette commande :

cd C:\\Program Files\\Elastic\\Elasticsearch\\6.5.4

Puis pour lancer le service Elasticsearch :

.\\bin\\elasticsearch.exe

Vous avez juste à entrer l’url : [<span class="underline">http://localhost:9200/</span>](http://localhost:9200/)

Si une page comme celle-ci s’affiche, c’est que le serveur fonctionne comme il faut.

<img src="/media/image12.png" style="width:6.01042in;height:4.13542in" />

# Comment fonctionne le CRUD (Create/index, Read, update et delete) Et le search

Nous avons 4 APIs essentiels pour performer l’opération CRUD :

-   Index API

-   Get API

-   Update API

-   Delete API

## CREATE

Dans sa forme la plus simple, vous pouvez spécifier l'index sur lequel enregistrer les données, le type d'objet enregistré et l'ID de l'objet que vous enregistrez. En général, ceci ressemblera à ceci :

```
curl –XPUT http://server\_name.com:9200/index/type/object\_id -d'{ \<données du document\> }''
```

Dans ce scénario, l'index peut être considéré comme une base de données. Il s'agit de l'unité structurelle de niveau supérieur qui peut séparer certaines informations des autres. Vous pouvez l'utiliser pour séparer des données d'application ou de site, par exemple.

Le type est une catégorisation de type arbitraire. Il peut être n'importe quoi, mais peut être utilisé pour regrouper certaines informations. Par exemple, vous pourriez avoir un type de données "utilisateurs" ou "documents".

L'identifiant peut être spécifié si vous le créez à l'aide d'une commande PUT, ou laissé à la génération automatique si vous choisissez d'utiliser une commande POST.

Après l’option -d, vous passez dans l'objet que vous souhaitez stocker. C'est un objet de type JSON avec un format flexible. Les catégories sont créées à la volée, vous pouvez donc spécifier ce que vous voulez.

Par exemple, si nous construisons un index pour nos équipements de terrain de jeux, nous pouvons indexer un toboggan comme celui-ci :

```
curl -XPUT "http://localhost:9200/playground/equipment/1" -d ' { "type" : "diapositive", "quantité" : 2 }
```

Vous devriez recevoir une réponse indiquant que l'opération a réussi :

> {"ok":true,"\_index" : "playground","\_type" : "equipment","\_id" : "1","\_version":1}
>

Comme vous pouvez le constater, cela vous indique essentiellement qu'il a été indexé avec l'information que vous avez fournie. Vous remarquerez peut-être aussi que vos renseignements sont mis à jour. Ceci peut être utile pour les requêtes ultérieures.

Comme la commande PUT peut être utilisée pour mettre à jour les informations ainsi que pour les créer, vous voudrez peut-être spécifier que vous voulez créer un enregistrement et non pas mettre à jour un enregistrement qui existe déjà. Pour ce faire, ajoutez simplement /\_create à la fin de votre URI :

```
curl -XPUT "http://localhost:9200/playground/equipment/1/\_create" -d'{"type" : "slide", "quantity" : 2 }
```

L'appel de l'API renvoie alors une erreur si le document existe déjà :

> {"error" : "DocumentAlreadyExistsExistsException\[\[playground\]\[2\]\[equipment\]\[1\] : document already exists\]", "status":409}
>

## READ

Le but de l'ajout de données à l'index est d'obtenir la possibilité de récupérer ces données à un moment ultérieur. Nous accédons à l'API en utilisant la méthode HTTP GET pour lire le contenu.

La façon la plus simple de récupérer les données est de spécifier l'objet exact par l'index, le type et l'identifiant :

```
curl -XGET "http://localhost:9200/playground/equipment/1"
```

Vous obtiendrez ainsi les informations sur le document que nous avons reçu lors de la création de l'objet. Une clé appelée \_source est ajoutée à cette sortie et contient le document lui-même comme valeur :

> "\_index" : "playground","\_type" : "equipment","\_id" : "1","\_version":2, "exists":true,"\_source" : {"type" : "slide", "quantity" : 1 }}
>

Pour nos besoins, nous voulons probablement que le résultat soit plus humain, de sorte que nous puissions l'ajouter à la fin de la demande :

```
curl -XGET "http://localhost:9200/playground/equipment/1?pretty"
```

> {
>
> "\_index" : "playground",
>
> "type" : "equipement",
>
> "\_id" : "1",
>
> "version" : 2,
>
> "exists" : true, "\_source" : { "type" : "slide", "quantity" : 1 }
>
> }
>

Souvent, nous voulons seulement que le document lui-même nous soit retourné. Nous pouvons le faire en ajoutant /\_source à la chaîne de requête :

```
curl -XGET "http://localhost:9200/playground/equipment/1/\_source?pretty"
```

> {"type" : "diapositive", "quantité" : 1 }
>

Si nous ne voulons retourner que des champs spécifiques, nous pouvons le faire en ajoutant un

?fields=\<field1\>,\<field1\> à la fin de la requête :

```
curl -XGET "http://localhost:9200/playground/equipment/1?fields=type"
```

Ceci ajoutera une clé appelée champs qui contient un objet JSON avec la \_source filtrée :

> "\_index" : "playground","\_type" : "equipment","\_id" : "1","\_version":2, "exists":true, "fields":{"type" : "slide"}}}
>

## UPDATE

Nous pouvons facilement mettre à jour le contenu en utilisant la commande HTTP POST. Cela nous permettra de modifier les données à l'aide de scripts et de paramètres en ligne. L'autre option est d'utiliser simplement une commande PUT et de "recréer" l'objet avec un objet de remplacement (mis à jour).

Nous pouvons mettre à jour un objet de données en utilisant la commande POST et en ajoutant /\_update à l'URI. Nous lui passons un objet avec le script keys et les paramètres. Il peut référencer les clés définies en interne dans le document en utilisant le préfixe ctx.\_source.

Par exemple, pour mettre à jour la quantité de toboggans sur notre terrain de jeux, nous pourrions taper quelque chose comme ceci :

```
curl -XPOST "http://localhost:9200/playground/equipment/1/\_update" -d'{"script" : "ctx.\_source.quantity += step", "params" : {"step" : 1 } }'
```

Si nous lisons les données après avoir fait cette opération, nous pouvons voir que la "quantité" a été incrémentée :

```
curl -XGET "http://localhost:9200/playground/equipment/1/\_source"
```

> {"type" : "slide", "quantity":3}
>

Nous pouvons ajouter de nouveaux champs arbitraires en mettant simplement à jour l'objet et en assignant une valeur à une nouvelle clé :

```
curl -XPOST "http://localhost:9200/playground/equipment/1/\_update" -d'{"script" : "ctx.\_source.name\_of\_new\_key = \\"value of new field\\"" }'
```

Notez qu'il se peut que vous deviez échapper à certains guillemets pour éviter de confondre le moteur.

Nous pouvons également supprimer des champs en appelant la méthode .remove de la source et en passant le nom du champ :

```
curl -XPOST "http://localhost:9200/playground/equipment/1/\_update" -d'{"script" : "ctx.\_source.remove(\\"nom\_de\_la\_nouvelle\_clé")"" }'
```

Si passer un script est trop complexe pour les opérations que vous essayez de faire, vous pouvez aussi simplement référencer le champ que vous voulez mettre à jour et passer la nouvelle valeur en utilisant la clé "doc" plutôt que le "script" des précédents exemples :

```
curl -XPOST "http://localhost:9200/playground/equipment/1/\_update" -d'{ "doc" : { "type" : "swing" } }'
```

Maintenant, nous pouvons retrouver le document, et son "type" a été remplacé par "swing" :

```
curl -XGET "http://localhost:9200/playground/equipment/1/\_source"
```

> {"type" : "swing", "quantity":3}
>

## DELETE

L'opération de suppression dans ElasticSearch est assez simple. Il supprime simplement un document avec l'ID correspondant. Nous pouvons y avoir accès par HTTP en utilisant la commande DELETE.

Par exemple, pour supprimer un document de notre index de terrain de jeu avec l'ID de 36, nous pouvons utiliser cette commande :

```
curl -XDELETE "http://localhost:9200/playground/equipment/36"
```

> {"ok":true, "found":true,"\_index" : "playground","\_type" : "equipment","\_id" : "36","\_version":2}}
>

Cela indique que l'opération a réussi. S'il n'y avait pas d'objet correspondant à la commande, vous obtiendriez plutôt une réponse ressemblant à ceci :

> {"ok":true, "found":false,"\_index" : "playground","\_type" : "equipment","\_id" : "36","\_version":1}}
>

La clé "trouvé" est celle qui indique si l'objet correspondant a été trouvé et traité.

## SEARCH

Nous pouvons rechercher nos objets en passant le composant /\_search URI. Cela peut être utilisé après le serveur lui-même, après l'index, ou après le type, selon la catégorie de données que vous souhaitez rechercher.

Par exemple, pour rechercher sur le serveur une quantité de "4", on peut utiliser une chaîne de recherche comme celle-ci :

```
curl -XGET "http://localhost:9200/\_search?q=quantity:4''.
```

> "take":5, "timed\_out":false,"\_shards":{"total":25, "successful":25, "failed":0}, "hits":{"total":1, "max\_score":1.0, "hits" :\[{"\_index" : "playground","\_type" : "equipment","\_id" : "1","\_score":1.0,"\_source" : {"type" : "slide", "quantity":4}}}\]} } }}
>

C'est un autre cas où le passage du paramètre "pretty" peut être utile :

```
curl -XGET "http://localhost:9200/\_search?q=quantity:4&pretty"
```

> {
>
> "took" : 14,
>
> "timed\_out" : false,
>
> "\_shards" : { {
>
> "total" : 25,
>
> "successful" : 25,
>
> "failed" : 0
>
> },
>
> "Hits" : {
>
> "total" : 1,
>
> "max\_score" : 1.0,
>
> "Hits" : : \[ { {
>
> "\_index" : "playground",
>
> "type" : "equipement",
>
> "\_id" : "1",
>
> "\_score" : 1.0, "\_source" : {"type" : "slide", "quantity":4}
>
> } \]
>
> }
>
> }
>

Si vous souhaitiez effectuer une recherche uniquement dans les équipements d'aires de jeux et exclure d'autres catégories, vous pouvez modifier le domaine de recherche en incluant l'index et le type dans l'URI :

```
curl -XGET "http://localhost:9200/playground/equipment/\_search?q=quantity:4&pretty"
```

Si vous voulez spécifier le type, mais exclure l'index, vous pouvez remplacer l'index par \_all :

```
curl -XGET "http://localhost:9200/\_all/equipment/\_search?q=quantity:4&pretty"
```

Vous pouvez également effectuer une recherche en utilisant le langage spécifique au domaine ElasticSearch, qui est transmis comme un document ressemblant beaucoup au JSON standard :

```
curl -XGET "http://localhost:9200/playground/equipment/\_search" -d'{"query" : {"term" : {"type" : "slide" } } }'
```

Il existe de nombreuses autres options de recherche et de filtrage des résultats, mais cela constitue une bonne base pour récupérer les données que vous avez stockées.

# Utilisation de Kibana

Nous allons utiliser Kibana qui va nous permettre de gérer notre base de donnée que nous avons au préalable importé sur notre serveur REST API.

Nous avons la version 6.5.4 de Kibana qui se trouve ici : [<span class="underline">https://www.elastic.co/fr/downloads/kibana</span>](https://www.elastic.co/fr/downloads/kibana)

Pour installer Kibana, il faudra extraire le dossier que vous avez téléchargé dans le répertoire que vous voulez.

Ensuite, vous devez aller à la racine du dossier Kibana que vous avez précédement extrait.

-   Ouvrir config/kibana.yml

-   Vérifier que elasticsearch.url pointe sur votre instance Elasticsearch

Finalement, il ne reste plus qu’à lancer kibana en ligne de commande (toujours dans la racine).

bin\\kibana.bat

Entrez cette adresse pour arriver sur l’interface de Kibana.

[<span class="underline">http://localhost:5601</span>](http://localhost:5601)

Il faut obligatoirement avoir son serveur Elasticsearch fini.

<img src="/media/image13.png" style="width:7.3384in;height:3.89583in" />

Vous pouvez trouver une documentation complète ici : [<span class="underline">https://www.elastic.co/guide/en/kibana/current/index.html</span>](https://www.elastic.co/guide/en/kibana/current/index.html)

# ElasticSearch avec C\# et NEST

Elasticsearch.Net est un client de très bas niveau, sans dépendance, qui n'a aucune idée de la façon dont vous construisez et représentez vos requêtes et réponses. Il est suffisamment abstrait pour que tous les points finaux de l'API Elasticsearch soient représentés comme des méthodes mais pas trop pour gêner la façon dont vous voulez construire vos objets json/request/response. Il est également livré avec des mécanismes de cluster intégrés, modifiables et configurables.

NEST est un client de haut niveau qui a l'avantage d'avoir mappé tous les objets de requête et de réponse. Il vient avec une requête DSL fortement typée qui mappe 1 à 1 avec la requête DSL Elasticsearch, et tire parti des fonctionnalités spécifiques de .NET comme les résultats covariants et la cartographie automatique des POCOs. NEST utilise en interne et expose toujours le client Elasticsearch.Net de bas niveau.

# Conclusion

Nous avons vu que l'installation et la configuration d'Elasticsearch est très simple. Les options de configuration par défaut sont parfaites pour commencer à travailler avec. Elasticsearch n'a pas besoin d'un fichier de schéma et expose une API HTTP conviviale basée sur JSON pour sa configuration, son indexation et sa recherche. Le moteur est optimisé pour fonctionner avec une grande quantité de données.

Nous avons utilisé un client .NET de haut niveau pour communiquer avec Elasticsearch afin qu'il s'intègre parfaitement dans un projet.NET. Cela nous a permis de définir notre index en utilisant des classes POCO avec peu de travail de configuration. Nous choisissons également d'utiliser une syntaxe fluide pour construire des requêtes, mais la syntaxe d'initialisation d'objet est également disponible.

# Annexe

code + installation : [<span class="underline">https://github.com/XSchwab/ElasticSearchProject</span>](https://github.com/XSchwab/ElasticSearchProject)

# Références

Kibana : [<span class="underline">https://www.elastic.co/guide/en/kibana/current/index.html</span>](https://www.elastic.co/guide/en/kibana/current/index.html)

ElasticSearch : [<span class="underline">https://openclassrooms.com/fr/courses/4462426-maitrisez-les-bases-de-donnees-nosql/4474691-etudiez-le-fonctionnement-d-elasticsearch</span>](https://openclassrooms.com/fr/courses/4462426-maitrisez-les-bases-de-donnees-nosql/4474691-etudiez-le-fonctionnement-d-elasticsearch)
