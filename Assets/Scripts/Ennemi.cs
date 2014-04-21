using UnityEngine;
using System.Collections;

public class Ennemi : Personnage {

    private EnumStatusEnnemi _status;
    private Ia _ia;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void attaquer()
    {
        throw new System.NotImplementedException();
    }

    public override void defendre()
    {
        throw new System.NotImplementedException();
    }

    public override void sac()
    {
        throw new System.NotImplementedException();
    }

    public override void fuir()
    {
        throw new System.NotImplementedException();
    }

    public override void sort()
    {
        throw new System.NotImplementedException();
    }


    /***constructeurs ****/
    public Ennemi() {  }
    public Ennemi(int id, string nom, int lvl, int exp, EnumTypePersonnage tp, Equipement eq, CaracteristiquesPersonnage cp, EnumStatusEnnemi st, Ia ia)
    {

        _id = id;
        _nom = nom;
        _lvl = lvl;
        _exp = exp;
        _sort = new Sort[20];
        _typePersonnage = tp;
        _equipement = eq;
        _CPersonnage = cp;
        _status = st;
        _ia = ia;
    
    }
    public Ennemi(int id, string nom, int lvl, int exp, EnumTypePersonnage tp, Equipement eq, CaracteristiquesPersonnage cp,Sort [] s, EnumStatusEnnemi st, Ia ia)
    {

        _id = id;
        _nom = nom;
        _lvl = lvl;
        _exp = exp;
        _sort = new Sort[20];
        _typePersonnage = tp;
        _equipement = eq;
        _CPersonnage = cp;
        _status = st;
        _ia = ia;

        int i = 0;
        foreach (Sort sort in s)
        {
            _sort[i] = sort;
            i++;
        }
    }

    /***accesseurs ***/

    public int getId() { return _id; }
    public string getNom() { return _nom; }
    public int getLvl() { return _lvl; }
    public int getExp() { return _exp; }
    public Sort[] getSort() { return _sort; }
    public EnumTypePersonnage getEnumTypePersonnage() { return _typePersonnage; }
    public Equipement getEqsuipement() { return _equipement; }
    public CaracteristiquesPersonnage getCaracteristiquesPersonnage() { return _CPersonnage; }
    public EnumStatusEnnemi getEnumStatusEnnemi() { return _status; }
    public Ia getIa() { return _ia; } 

    public void setId(int id) { _id = id; }
    public void setNom(string nom) { _nom = nom; }
    public void setLvl(int lvl) { _lvl = lvl; }
    public void setExp(int exp) { _exp = exp; }
    public void setSort(Sort[] s) { _sort = s; }
    public void setEnumTypePersonnage(EnumTypePersonnage e) { _typePersonnage = e; }
    public void setEquipement(Equipement e) { _equipement = e; }
    public void setCaracteristiquesPersonnage(CaracteristiquesPersonnage c) { _CPersonnage = c; }
    public void setEnumStatusEnnemi(EnumStatusEnnemi es) { _status = es; }
    public void setIa(Ia ia) { _ia = ia; }
}
