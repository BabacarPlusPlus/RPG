using UnityEngine;
using System.Collections;

public class Sac : MonoBehaviour {

    private int _argent;   
    private Objet[] _objets;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public int Argent
    {
        get { return _argent; }
        set { _argent = value; }
    }

    public Sac()
    {
        _argent = 0;
        _objets = new Objet[20];
    }
    public Sac(int argent,Objet[] obj  )
    {
        _argent = argent;
        _objets = new Objet[20];

        int i = 0;
        foreach (Objet o in obj)
        {
            _objets[i] = o;
            i++;
        }
    }

    public void ajouterArgent(int argent)
    {
        _argent += argent;
    }
    public void retraitArgent(int argent)
    {
        _argent -= argent;
    }
    public void ajouterObjet(Objet obj) {
      
        for (int i = 0; i < _objets.Length; i++)
        {
            if (_objets[i] == null)
            {
                _objets[i] = obj;
            }  
        }        
    }
    public void retirerObjetAtIndex(Objet obj, int i)
    {
        try
        {
            if ((i < _objets.Length) && (i >= 0) && (_objets[i] != null))
                _objets[i] = null;
        }
        catch (MissingReferenceException ex)
        {
            Debug.Log("Une erreur s'est produite dans retirerObjetAtIndex(Objet obj, int i) :" + ex.Message);
        }
    }
    public void vendreObjet(Objet obj, int i)
    {
        try
        {
            if ((i < _objets.Length) && (i >= 0) && (_objets[i] != null))
            {
                _argent += _objets[i].getValeur();
                _objets[i] = null;

            }
        }
        catch (MissingReferenceException ex)
        {
            Debug.Log("Une erreur s'est produite dans vendreObjet(Objet obj, int i) :" + ex.Message);
        }
    }
}
