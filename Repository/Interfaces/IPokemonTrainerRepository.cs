using Poke_Api.Models;

namespace Poke_Api.Repository;

public interface IPokemonTrainerRepository
{
    Task<List<PokemonTrainer>> GetAllAsync(int id);
    Task<PokemonTrainer?> GetByIdAsync(int id);
    Task<PokemonInstance?> GetPokemonsByIdAsync(int id);
    Task AddAsync(PokemonInstance pokemonInstance);
    Task UpdateAsync(List<PokemonInstance> pokemonInstances);
    Task DeleteAsync(int id);
}