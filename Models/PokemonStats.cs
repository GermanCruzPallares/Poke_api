namespace Poke_Api.Models;

public class PokemonStats{
    public int IdPokemon{get;}
    public int HP{get;}
    public int Defense{get;}
    public int Attack{get;}
    public int SpAttack{get;} 
    public int SpDeef{get;} 
    public int Speed {get;}

    public  PokemonStats(int idPokemon, int hp, int defense, int attack,int spAttack,int spSpeed,int speed){
        this.IdPokemon = idPokemon;
        this.HP = hp;
        this.Defense = defense;
        this.Attack = attack;
        this.SpAttack = spAttack;
        this.SpDeef = spSpeed;
        this.Speed = speed;
    }
}