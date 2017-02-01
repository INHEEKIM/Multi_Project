using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

    GameObject cube;
    IEnumerator ienumerator;

	// Use this for initialization
	void Start () {
        Debug.Log("Hi");

        ienumerator = click();
        //StartCoroutine("click");
        //StartCoroutine(this.click());
        StartCoroutine(ienumerator);
       
    }
	
	// Update is called once per frame
	void Update () {

        //StopCoroutine(ienumerator); //멈출 때 이런 식으로.
	}

    //오브젝트가 비활성되면 자동으로 소멸.
    IEnumerator click()
    {
        Debug.Log("before");
        while (true) { 
            yield return new WaitForSeconds(2.0f);
            Debug.Log("after");
        }
        
    }
}
