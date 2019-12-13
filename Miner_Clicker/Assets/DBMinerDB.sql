CREATE TABLE minerals (
id_mineral INT UNSIGNED NOT NULL PRIMARY KEY,
name VARCHAR (48) NOT NULL,
hardness INT NOT NULL,
probabilityAppear INT NOT NULL,
timeToFoundation INT NOT NULL,
chanceOfSmelting INT NOT NULL,
imageMineralOre VARCHAR (48) NOT NULL,
imageMineral VARCHAR (48) NOT NULL);
CREATE TABLE tools (
id_tool INT UNSIGNED NOT NULL PRIMARY KEY,
name VARCHAR (48) NOT NULL,
hardness INT NOT NULL,
durability INT NOT NULL,
hability INT NOT NULL,
imageTool VARCHAR (48) NOT NULL);