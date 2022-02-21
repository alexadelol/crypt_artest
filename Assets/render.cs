using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class render : MonoBehaviour
{

    public Object[] textures;

    Texture t;

    int currentFrame = 0;
    // Start is called before the first frame update
    void Start()
    {
        textures = Resources.LoadAll("P2", typeof(Texture2D));
        foreach (var t in textures)
        {
            Debug.Log(t.name);
        }
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
       Animate();
    }

    public virtual void Animate()
    {
        if (currentFrame >= textures.Length)
        {
            currentFrame = 0;
        }

        gameObject.GetComponent<MeshRenderer>().material.mainTexture = (Texture2D)textures[currentFrame];
        currentFrame++;

    }

    //void OnGUI()
    //{
    //    if (GUI.Button(new Rect(10, 70, 150, 30), "Change texture"))
    //    {
    //        // change texture on cube
    //        Texture2D texture = (Texture2D)textures[Random.Range(0, textures.Length)];
    //        //.GetComponent<Renderer>().material.mainTexture = texture;
    //    }
    //}
}
