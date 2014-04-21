using UnityEngine;
using System.Collections;

public class Competence : MonoBehaviour {

    private int _id;
    private string _nom;
    private string _description;
    private Detail _detail;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Competence() { }

    //construteur par copie
    public Competence( int id,string nom,string desc, Detail detail) {
        _id = id;
        _nom = nom;
        _description = desc;
        _detail = new Detail();
        _detail = detail;
    }
    public Competence(int id, string nom, string desc, int vie, int mana, int init, int force, int magie, int def, int chance)
    {
        _id = id;
        _nom = nom;
        _description = desc;
        _detail = new Detail(vie,mana,init,force,magie,def,chance);       
    }

    public int getId(){ return _id; }
    public string getNom() { return _nom; }
    public string getDescription() { return _description; }
    public Detail getDetail() { return _detail; }

    public void setId(int id) { _id=id; }
    public void setNom(string nom) { _nom = nom; }
    public void setDescription(string desc) { _description = desc; }
    public void setDetail(Detail d) { _detail=d; }

}
