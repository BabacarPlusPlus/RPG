using UnityEngine;
using System.Collections;

public class Position : MonoBehaviour {

    private float _x, _y, _z;

    
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Position(float x, float y, float z)
    {
        _x = x;
        _y = y;
        _z = z;
    }
    public float Z
    {
        get { return _z; }
        set { _z = value; }
    }
    public float Y
    {
        get { return _y; }
        set { _y = value; }
    }
    public float X
    {
        get { return _x; }
        set { _x = value; }
    }

}
