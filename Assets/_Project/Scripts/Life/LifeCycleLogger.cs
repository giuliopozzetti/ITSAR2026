using UnityEngine;


public class LifeCycleLogger : MonoBehaviour
{
    void Awake()
    {
        Debug.Log($"eseguo Awake{gameObject.name}");
    }
    void OnEnable()
    {
        Debug.Log($"eseguo OnEnable{gameObject.name}");
    }





    void Start()
    {
        Debug.Log($"eseguo Start{gameObject.name}");
    }



    void Update()
    {
        Debug.Log($"eseguo Update{gameObject.name}");
    }


    void FixedUpdate()
    {
        Debug.Log($"eseguo FixedUpdate{gameObject.name}");
    }


    void LateUpdate()
    {
        Debug.Log($"eseguo LateUpdate{gameObject.name}");
    }


    void OnDisable()
    {
        Debug.Log($"eseguo OnDisable{gameObject.name}");
    }




    void OnDestroy()
    {
        Debug.Log($"eseguo OnDestroy{gameObject.name}");
    }
}