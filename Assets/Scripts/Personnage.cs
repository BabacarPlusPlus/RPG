using UnityEngine;
using System.Collections;


public abstract class Personnage : MonoBehaviour,IJeuJoueur {

    protected int _id;
    protected string _nom;
    protected int _lvl;
    protected int _exp;
    protected Sort[] _sort;
    protected EnumTypePersonnage _typePersonnage;
    protected Equipement _equipement;
    protected CaracteristiquesPersonnage _CPersonnage;
    


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public virtual void attaquer()
    {
        throw new System.NotImplementedException();
    }

    public virtual void defendre()
    {
        throw new System.NotImplementedException();
    }

    public virtual void sac()
    {
        throw new System.NotImplementedException();
    }

    public virtual void fuir()
    {
        throw new System.NotImplementedException();
    }

    public virtual void sort()
    {
        throw new System.NotImplementedException();
    }

   }
