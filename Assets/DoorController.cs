using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator myAnimator;
    public bool IsOpen;
    public GameObject Text;

    public void OnTriggerStay(Collider other)
    {
        //Text.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("gwegwegw");
            IsOpen = !IsOpen;
            if(IsOpen == true)
            {
                myAnimator.Play("OpenDoor");
            }
            if(!IsOpen)
            {
                myAnimator.Play("CloseDoor");
            }

        }
    }


    public void OnTriggerExit(Collider other)
    {
        //Text.SetActive(false);
    }
}
