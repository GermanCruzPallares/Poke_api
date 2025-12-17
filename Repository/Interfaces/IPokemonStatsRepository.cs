using Poke_Api.Models;

namespace Poke_Api.Repository;

public interface IPokemonStatsRepository
{
    Task<List<Pokemon>> GetAllStatsAsync();
    Task<PokemonStats?> GetStastByIdAsync(int id);
    Task UpdateAsync(PokemonStats pokemonStats);
}