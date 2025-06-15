using System.Collections;
using Unity.Android.Gradle;
using UnityEngine;

public class BoruSpawner : MonoBehaviour
{
    public Baty BatScript;

    public GameObject Borular;

    public float height;
    public float time;
    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }


    public IEnumerator SpawnObject(float time)
    {
        while (!BatScript.isDead)
        {
            Instantiate(Borular, new Vector3(6, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }


}
