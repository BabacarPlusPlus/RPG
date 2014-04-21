using UnityEngine;
using System.Collections;

public class ArbreCompetence : MonoBehaviour {

    private int _id;
    private Competence[] _competences;
    private int _nbCompetences;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public ArbreCompetence() { }
    public ArbreCompetence(int id) {
        _id = id;
        _competences = new Competence[20];
        _nbCompetences = 0;
    }
    public ArbreCompetence(int id, Competence [] abc)
    {
        _id = id;
        _competences = new Competence[20];
        _nbCompetences = 0;

        int i = 0;
        foreach (Competence c in abc)
        {
            _competences[i] = c;
            i++;
        }
    }

    public int getId() { return _id; }
    public int getNbCompetences() { return _nbCompetences; }
    public Competence[] getCompetences(){ return _competences; }
    public int getNumberCompetences()
    {
        return _nbCompetences;
    }
    public Competence gteCompetenceAtIndex( int i)
    {
        if ((i > 0) && (i < _nbCompetences))
            return _competences[i];
        else return null;
    }
    public void addCompetence(Competence c)
    {
        _competences[_nbCompetences] = c;
        _nbCompetences++;
    }

    public void setId(int id) { _id = id; }
    public void setCompetences(Competence[] c)
    {
        int i =0;
        foreach (Competence cmp in c)
        {
            _competences[i] = cmp;
            i++;
        }
        for (int j = i; j < _competences.Length; j++)
        {
            _competences[j] = null;
        }
    }
    public void setNbCompetences(int nb)
    {
        _nbCompetences = nb;
    }

}
