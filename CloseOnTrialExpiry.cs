using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseOnTrialExpiry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5); 

        Application.Quit();
    }
}
