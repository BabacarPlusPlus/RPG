using UnityEngine;
using System.Collections;

public abstract class Objet : MonoBehaviour {

    protected int _id;
    protected string _nom;
    protected int _valeur;
    protected string _description;
    protected Detail _detail;
    protected EnumTypeObjet _typeObjet;

   

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void setId(int id) { _id = id; }
    public void setNom(string nom) { _nom = nom; }
    public void getDescription(string desc) { _description = desc; }
    public void setDetail(Detail detail) { _detail = detail; }
    public void setTypeObjet(EnumTypeObjet tp) { _typeObjet = tp; }

    public int getId() { return _id; }
    public string getNom() { return _nom; }
    public int getValeur() { return _valeur; }
    public string getDescription() { return _description; }
    public Detail getDetail() { return _detail; }
    public EnumTypeObjet getTypeObjet() { return _typeObjet; }
}
