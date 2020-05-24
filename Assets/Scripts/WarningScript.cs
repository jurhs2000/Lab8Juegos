using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningScript : MonoBehaviour
{
    public Animator warningAnimator;
    public Animator warningAnimator1;
    public Animator warningAnimator2;
    private bool isInRoom = false;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("WarningTrigger"))
        {
            if (isInRoom)
            {
                warningAnimator.Play("WarningOff");
                warningAnimator1.Play("WarningOff");
                warningAnimator2.Play("WarningOff");
                isInRoom = false;
            }
            else
            {
                warningAnimator.Play("WarningAnimator");
                warningAnimator1.Play("WarningAnimator");
                warningAnimator2.Play("WarningAnimator");
                isInRoom = true;
            }
        }
    }
}
