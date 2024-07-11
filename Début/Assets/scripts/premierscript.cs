using UnityEngine;

public class premierscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("test");


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                print("OK");
            }
        }
            
    }
}
