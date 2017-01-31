using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

    GameObject cube;

	// Use this for initialization
	void Start () {
        cube = GameObject.Find("Cube");
        Debug.Log("hi");
        Debug.Log("Bye");

       
    }
	
	// Update is called once per frame
	void Update () {

	
	}

    public void click()
    {

    }
}
