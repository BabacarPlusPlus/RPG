using UnityEngine;
using System.Collections;

public class Sort : MonoBehaviour {

    private int _id;
    private string _nom;
    private int _degat;
    private EnumTypeSort _typeSort;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /*contructors*/
    public Sort() { }
    public Sort(int id,string nom,int degat,EnumTypeSort ts) {

        _id = id;
        _nom = nom;
        _degat = degat;
        _typeSort = ts;
    }


    /*accessors*/
    public int getId() { return _id; }
    public string getNom() { return _nom; }
    public int getDegat() { return _degat; }
    public EnumTypeSort getTypeSort() { return _typeSort; }

    public void setId(int id) { _id =id;}
    public void setNom(string nom) { _nom = nom; }
    public void setDegat(int degat) { _degat = degat; }
    public void setTypeSort(EnumTypeSort ts) { _typeSort = ts; }

}
