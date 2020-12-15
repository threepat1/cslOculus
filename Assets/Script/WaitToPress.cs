using OculusSampleFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitToPress : MonoBehaviour
{

    private InteractableToolsInputRouter interact;
    // Start is called before the first frame update
    private void Start()
    {
        interact = GetComponent<InteractableToolsInputRouter>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DelayClick()
    {
        StartCoroutine(WaitASecToPress());
    }

    public IEnumerator WaitASecToPress()
    {
        interact.enabled = false;
        yield return new WaitForSeconds(2);
        interact.enabled = true;
    }
}