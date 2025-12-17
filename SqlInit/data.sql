DROP DATABASE IF EXISTS PokeBBDD;
create DATABASE PokeBBDD;
USE PokeBBDD;

CREATE TABLE Pokemon(
       id INT AUTO_INCREMENT PRIMARY KEY,
       name VARCHAR(100) NOT NULL, 
       pokedexNumber INT NOT NULL,
       genderRate INT NOT NULL,
       sizeScale DECIMAL(1,1) NOT NULL,
       urlImage INT NOT NULL,
);
CREATE TABLE Types(
       idPokemon INT NOT NULL,
       type1 INT NOT NULL, 
       type2 INT,
       FOREIGN KEY (id) REFERENCES Pokemon(id)
);
CREATE TABLE PokemonStats(
       pokedexNumber INT NOT NULL,
       hp INT NOT NULL,
       defense INT NOT NULL,
       attack INT NOT NULL,
       spAttack INT NOT NULL,
       spDeef INT NOT NULL,
       speed INT NOT NULL,
       FOREIGN KEY (pokedexNumber) REFERENCES Pokemon(pokedexNumber)
);
CREATE TABLE PokemonInstance(
       id INT PRIMARY KEY IDENTITY(1,1),
       trainerId INT NOT NULL,
       objet VARCHAR (100) NOT NULL,
       shiny BOOLEAN NOT NULL,
       gender INT NOT NULL, 
       height DECIMAL NOT NULL,
       level INT NOT NULL,
       expNextLevel DECIMAL NOT NULL,
       pokemonCageId INT,
       idPokemon INT,
       FOREIGN KEY (pokemonCageId) REFERENCES PokemonCage(trainerId),
       FOREIGN KEY (idPokemon) REFERENCES Pokemon(id)
);
CREATE TABLE PokemonCage(
       id INT PRIMARY KEY IDENTITY(1,1),
       trainerId INT NOT NULL,
);


