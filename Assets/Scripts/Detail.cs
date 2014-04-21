using UnityEngine;
using System.Collections;

public class Detail : MonoBehaviour {

    private int _vie;
    private int _mana;
    private int _initiative;
    private int _force;
    private int _magie;
    private int _defense;
    private int _chance;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Detail() { }
    public Detail(int vie, int mana, int init, int force, int magie, int def, int chance)
    {
        _vie=vie;
        _mana = mana;
        _initiative = init;
        _force = force;
        _magie = magie;
        _defense = def;
        _chance = chance;
    }

    public int getVie() { return _vie; }
    public int getMana() { return _mana; }
    public int getInitiative() { return _initiative; }
    public int getForce() { return _force; }
    public int getMagie() { return _magie; }
    public int getDefense() { return _defense; }
    public int getChance() { return _chance;  }

    public void setVie(int vie) { _vie = vie; }
    public void setMana(int mana) { _mana = mana; }
    public void setInitiative(int init) { _initiative = init; }
    public void setForce(int force) { _force = force; }
    public void setMagie(int magie) { _magie = magie; }
    public void setDefense(int def) { _defense = def; }
    public void setChance(int chance) { _chance = chance; }



}
