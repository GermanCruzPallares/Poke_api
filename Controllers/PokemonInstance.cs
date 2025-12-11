using System.ComponentModel.DataAnnotations;
namespace Poke_Api.Models;

public class PokemonInstance{
    public int Id {get;}
    public int IdTrainer{get; set;}
    public string Objet{get; set;}
    public bool Shiny {get; set;}
    public int Gender {get;set;}
    // La altura se muk
    public double Height{get;set;}
    public int Level{get;set;}
    public double ExpNextLevel{get;set;}

     public PokemonInstance(int idTrainer, int id)
    {
        this.IdTrainer = idTrainer;
        this.Id = id;
    }
    public PokemonInstance(int idTrainer, int id,string objet,bool shiny,int gender,double height,int level,double expNextLevel)
    {
        this.IdTrainer = idTrainer;
        this.Objet = objet;
        this.Shiny = shiny;
        this.Gender = gender;
        this.Height = height;
        this.Level = level;
        this.ExpNextLevel = expNextLevel; 
    }
}