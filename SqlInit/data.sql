DROP DATABASE IF EXISTS PokeBBDD;
create DATABASE PokeBBDD;
USE PokeBBDD;

CREATE TABLE Pokemon(
       id INT PRIMARY KEY IDENTITY(1,1),
       name VARCHAR(100) NOT NULL, 
       pokedexNumber INT NOT NULL,
       genderRate INT NOT NULL,
       sizeScale DECIMAL(1,1) NOT NULL,
       urlImage INT NOT NULL,
       pokemonCageId Int,
       FOREIGN KEY (pokemonCageId) REFERENCES PokemonCage(trainerId)

);
CREATE TABLE Types(
       idPokemon INT NOT NULL,
       type1 INT NOT NULL, 
       type2 INT,
       FOREIGN KEY (id) REFERENCES Pokemon(id)
);
CREATE TABLE PokemonStats(
        idPokemon INT NOT NULL,
        hp INT NOT NULL,
        defense INT NOT NULL,
        attack INT NOT NULL,
        spAttack INT NOT NULL,
        spDeef INT NOT NULL,
        speed INT NOT NULL,
);
CREATE TABLE PokemonCage(
       pokemonCageId INT NOT NULL,
       trainerId INT NOT NULL,
);
CREATE TABLE PokemonInstance(
       pokemonCageId INT NOT NULL,
       trainerId INT NOT NULL,
);

