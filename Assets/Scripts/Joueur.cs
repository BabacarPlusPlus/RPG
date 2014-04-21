using UnityEngine;
using System.Collections;

public class Joueur : MonoBehaviour {

    private Position _location;
    private PersonnageJouable _personnage;
   

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Position Location
    {
        get { return _location; }
        set { _location = value; }
    }
    public Joueur(Position p, PersonnageJouable perso)
    {
        _location = p;
        _personnage = new PersonnageJouable();
        _personnage = perso;
    }
    public Joueur(float x, float y, float z, PersonnageJouable perso)
    {
        _location = new Position(x,y,z);
        _personnage = new PersonnageJouable();
        _personnage = perso;
    }

    public PersonnageJouable getPersonnageJouable() { return _personnage; }
    public void setPersonnageJouable(PersonnageJouable p) { _personnage = p; }

    public void aggro(){}
    public void discuter(Pnj p){}
    public void ramasser(Object o){}
    public void deplacer(){}

    
}
