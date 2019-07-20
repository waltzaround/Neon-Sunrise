using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCapsule : MonoBehaviour
{
    AudioClip microphoneInput;
    bool microphoneInitialized;

    // How sensitive the microphone is, as a percentage
    public float sensitivity;
    // How many frames to wait before shooting again
    public int timeoutFrames;

    // Only needed for demo movement of pill
    string lastMoved;
    // Keeps track of how many frames have passed since we last shot
    int TimeoutFramecounter;

    // Start is called before the first frame update
    void Start()
    {
        
        // lastMoved is only needed for the demo pill
        lastMoved = "left";

        // Initialise to zero to start
        TimeoutFramecounter = 0;
    }

    private void Awake()
    {
        //init microphone input
        if (Microphone.devices.Length > 0)
        {
            microphoneInput = Microphone.Start(Microphone.devices[0], true, 999, 44100);
            microphoneInitialized = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (TimeoutFramecounter == 0)
        {
            // Mic Stuff
            //get mic volume samples
            int dec = 64;
            float[] waveData = new float[dec];
            int micPosition = Microphone.GetPosition(null) - (dec + 1); // null means the first microphone
            microphoneInput.GetData(waveData, micPosition);

            // Getting a peak on the samples
            float levelMax = 0;
            for (int i = 0; i < dec; i++)
            {
                float wavePeak = waveData[i] * waveData[i];
                if (levelMax < wavePeak)
                {
                    levelMax = wavePeak;
                }
            }
            // Normalise the input to a nice 0-1ish level number
            float level = Mathf.Sqrt(Mathf.Sqrt(levelMax));

            if (level > sensitivity / 100)
            {
                Move();
                // Don't shoot again until the TimeoutFrameCounter is reaced.
                TimeoutFramecounter = 1;
            }

        // Increment to continue the timeout
        } else if (TimeoutFramecounter > 0)
        {
            TimeoutFramecounter++;
        }

        // If we've reached our timeout, go ahead and run on the next frame
        if (TimeoutFramecounter > timeoutFrames)
        {
            TimeoutFramecounter = 0;
        }

    }

    void Move() // Just decrement or increment the x position of the object to show the mic input is working
    {
        if (lastMoved == "left")
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
            lastMoved = "right";
        }
        else if (lastMoved == "right")
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
            lastMoved = "left";
        }
    }
}
