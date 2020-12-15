using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorMenu : MonoBehaviour
{
    public GameObject panel;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggleOnOff()
    {

        if (panel != null)
        {
            anim = panel.GetComponent<Animator>();
            if (anim != null)
            {
                bool isOpen = anim.GetBool("Menu");

                anim.SetBool("Menu", !isOpen);

            }
        }

    }
}
