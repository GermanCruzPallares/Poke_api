using Poke_Api.Models;

namespace Poke_Api.Repository;

public interface IPokemonRepository
{
    Task<List<Pokemon>> GetAllAsync();
    Task<Pokemon?> GetByIdAsync(int id);
}