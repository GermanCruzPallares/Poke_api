using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
namespace Poke_Api.Models;

public class Pokemon{
    public int Id { get; }
    public string Name{get;}
    public int PokedexNumber{get;}
    //-1 = Sin género, 0 = 100% Macho, 11 = 100% Hembra
    public int GenderRate{get;set;}
    //-1 = tamaño unico, 0 no escala, 0.1 -> 1 escala de crecimiento 
    public double SizeScale{get;set;}
    public string[] Types { get; } = new string[2];    
    public string UrlImage{get;} 
    public PokemonStats PokemonStats{get;}

     public Pokemon(int id, string name, int pokedexNumber, string[] types, string urlImage,int genderRate,int sizeScale,PokemonStats stats)
    {
        this.Id = id;
        this.Name = name;
        this.GenderRate = genderRate;
        this.SizeScale = sizeScale;
        this.PokedexNumber = pokedexNumber;
        this.UrlImage = urlImage;
        this.Types = types;
        this.PokemonStats = stats;

        if (string.IsNullOrWhiteSpace(name)){
        }
        if(types != null && types.Length > 0)
        {
            this.Types[0] = types[0];
        if (types.Length > 1)
            {
            this.Types[1] = types[1];
            }
        }
    }

}