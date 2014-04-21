using UnityEngine;
using System.Collections;

public class CaracteristiquesPersonnage : MonoBehaviour {

    private int _vie;
    private int _mana;
    private int _initiative;
    private int _force;   
    private int _magie;    
    private int _defense;    
    private int _chance;  

    private int _vieBonus;    
    private int _manaBonus;    
    private int _initiativeBonus;    
    private int _forceBonus;   
    private int _magieBonus;    
    private int _defenseBonus;    
    private int _chanceBonus;    


    // Use this for initialization
	void Start () {
        
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public CaracteristiquesPersonnage() { }
    public CaracteristiquesPersonnage(int vie,int mana,int init,int force,int magie, int defense, int chance) {
    
        _vie=vie;
        _mana=mana;
        _initiative = init;
        _force=force;   
        _magie=magie;    
        _defense=defense;    
        _chance=chance;

        _vieBonus = 0;
        _manaBonus = 0;
        _initiativeBonus = 0;
        _forceBonus = 0;
        _magieBonus = 0;
        _defenseBonus = 0;
        _chanceBonus = 0;
    }
    public CaracteristiquesPersonnage(int vie, int mana, int init, int force, int magie, int defense, int chance, int vieb, int manab, int initb, int forceb, int magieb, int defenseb, int chanceb)
    {
        _vie = vie;
        _mana = mana;
        _initiative = init;
        _force = force;
        _magie = magie;
        _defense = defense;
        _chance = chance;

        _vieBonus = vieb;
        _manaBonus = manab;
        _initiativeBonus = initb;
        _forceBonus = forceb;
        _magieBonus = magieb;
        _defenseBonus = defenseb;
        _chanceBonus = chanceb; 

    }


    public int Vie
    {
        get { return _vie; }
        set { _vie = value; }
    }
    public int Mana
    {
        get { return _mana; }
        set { _mana = value; }
    }
    public int Initiative
    {
        get { return _initiative; }
        set { _initiative = value; }
    }
    public int Force
    {
        get { return _force; }
        set { _force = value; }
    }
    public int Magie
    {
        get { return _magie; }
        set { _magie = value; }
    }
    public int Defense
    {
        get { return _defense; }
        set { _defense = value; }
    }
    public int Chance
    {
        get { return _chance; }
        set { _chance = value; }
    }
    public int VieBonus
    {
        get { return _vieBonus; }
        set { _vieBonus = value; }
    }
    public int ManaBonus
    {
        get { return _manaBonus; }
        set { _manaBonus = value; }
    }
    public int InitiativeBonus
    {
        get { return _initiativeBonus; }
        set { _initiativeBonus = value; }
    }
    public int ForceBonus
    {
        get { return _forceBonus; }
        set { _forceBonus = value; }
    }
    public int MagieBonus
    {
        get { return _magieBonus; }
        set { _magieBonus = value; }
    }
    public int DefenseBonus
    {
        get { return _defenseBonus; }
        set { _defenseBonus = value; }
    }
    public int ChanceBonus
    {
        get { return _chanceBonus; }
        set { _chanceBonus = value; }
    }
    
}
