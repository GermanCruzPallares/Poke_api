using Poke_Api.Models;

namespace Poke_Api.Repository;

public interface IPokemonCageRepository
{
    Task<List<PokemonInstance>> GetAllAsync(int IdTrainer);
    Task<PokemonInstance?> GetByIdAsync(int id);
    Task AddAsync(PokemonInstance pokemonInstance);
    Task UpdateAsync(PokemonInstance pokemonInstance);
    Task DeleteAsync(int id);
}