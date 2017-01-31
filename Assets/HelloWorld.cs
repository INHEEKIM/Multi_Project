using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

    GameObject cube;

	// Use this for initialization
	void Start () {
        cube = GameObject.Find("Cube");
        Debug.Log(cube.gameObject.name);

        Debug.Log("hi");
    }
	
	// Update is called once per frame
	void Update () {

	
	}

    public void click()
    {

    }
}
