namespace Poke_Api.Models;

public class PokemonTrainer{
   public int Id {get;}
   public List<string> Medallas{get;set;} = new List<string>();

   public PokemonTrainer(int id,List<string> medallas)
    {
        this.Id = id;
        this.Medallas = medallas;
    }
}