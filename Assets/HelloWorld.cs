using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

    GameObject cube;

	// Use this for initialization
	void Start () {
        Debug.Log("Hi");
        //StartCoroutine("click");
        StartCoroutine(this.click());
       
    }
	
	// Update is called once per frame
	void Update () {

	
	}

    IEnumerator click()
    {
        Debug.Log("before");
        while (true) { 
            yield return new WaitForSeconds(2.0f);
            Debug.Log("after");
        }
        
    }
}
