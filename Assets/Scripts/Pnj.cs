using UnityEngine;
using System.Collections;

public class Pnj : MonoBehaviour {

    private int _id;

    
    private Position _position;

    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Pnj(int id, Position p)
    {
        _id = id;
        _position = p;
    }
    public Pnj(int id, float x, float y, float z)
    {
        _id = id;
        Position p = new Position(x, y, z);
        _position = p;
    }
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public Position Position
    {
        get { return _position; }
        set { _position = value; }
    }
}
