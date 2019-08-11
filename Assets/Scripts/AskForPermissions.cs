using UnityEngine;
using UnityEngine.Android;


public class MicrophoneTest : MonoBehaviour
{
    GameObject dialog = null;

    void Start()
    {

        if (!Permission.HasUserAuthorizedPermission(Permission.Microphone))
        {
            Permission.RequestUserPermission(Permission.Microphone);

            if (!Permission.HasUserAuthorizedPermission(Permission.Microphone))
            {
                // The user has not authorized use of the microphone.
                Application.Quit();
            }
            dialog = new GameObject();
        }

    }

    // Now you can do things with the microphone

}