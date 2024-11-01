using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenricMonoSingleton<T> : MonoBehaviour where T : GenricMonoSingleton<T>
{
    public static T Instance { get {  return instance; } }
    private static T instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = (T)this;
        }
        else
        {
            Destroy(this.gameObject);
            Debug.LogError((T)this + " trying to create second instance ");
        }
    }
}
