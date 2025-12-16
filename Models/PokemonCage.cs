namespace Poke_Api.Models;

public class PokemonCage{
public int Id {get;set;}
   public int TrainerId {get;set;}
   public List<int> IdPokemon {get;set;}
   
   public PokemonCage(int id,int trainerId, List<int> idPokemon )
    {
        this.Id = id;
        this.IdPokemon = idPokemon;
        this.TrainerId = trainerId;
    }
}