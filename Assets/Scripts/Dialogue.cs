using UnityEngine;
using System.Collections;

public class Dialogue : MonoBehaviour {

	// Use this for initialization
   
    private int _id;
    private Pnj _pnj;
    private string _texte;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void setId(int id) { _id = id; }
    public void setPnj(Pnj p) { _pnj = p; }
    public void setTexte(string t) { _texte = t; }

    public int getId() { return _id; }
    public Pnj getPnj() { return _pnj; }
    public string getTexte() { return _texte; }

    public Dialogue()  { }
    public Dialogue(int d, Pnj pnj, string t)
    {
        _id = d;
        _pnj = pnj;
        _texte = t;
    }
    public Dialogue(int d,  string t, Position p, int id)
    {
        _id = d;
        _pnj = new Pnj(id, p);
        _texte = t;        
    }
}
