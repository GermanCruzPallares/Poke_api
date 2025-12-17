using Poke_Api.Models;

namespace Poke_Api.Repository;

public interface IPokemonInstanceRepository
{
    Task<List<PokemonInstance>> GetAllAsync(int id);
    Task<PokemonInstance?> GetByIdAsync(int id);
    Task<Pokemon?> GetPokemonByIdAsync(int id);
    Task AddAsync(PokemonInstance pokemonInstance);
    Task UpdateAsync(PokemonInstance pokemonInstance);
    Task DeleteAsync(int id);
}