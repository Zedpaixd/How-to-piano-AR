using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbDeleter : MonoBehaviour
{
    public GameObject toToggle;
    public GameObject toToggle2;
    public int maxObjects;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /// <summary>
        /// if you see this please do not ask any questions
        /// i have no ideas how to make this work any better
        /// as i have never worked with AR before and google
        /// is not helpful either. At this point only god
        /// and i knew what went on through my head when
        /// i decided to do this.
        /// </summary>


        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        toToggle.gameObject.SetActive(allObjects.Length < maxObjects ? true : false);
        toToggle2.gameObject.SetActive(allObjects.Length < maxObjects ? false : true);
    }
}
