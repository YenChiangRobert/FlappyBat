using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pippe : MonoBehaviour
{
    public GameObject obj_pipe;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("PipeG", 1, 2);
    }
    void PipeG()
    {
        float y;
        y = Random.Range(-0.4f, 1.0f);
        GameObject obs = Instantiate(obj_pipe, new Vector3(0, y, 0), Quaternion.identity);
        Destroy(obs, 15);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
