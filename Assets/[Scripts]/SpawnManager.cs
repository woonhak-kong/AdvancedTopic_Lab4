using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject prefab;
    public GameObject from;
    public GameObject to;
    // Start is called before the first frame update

    private IEnumerator coroutine;
    void Start()
    {
        coroutine = SpawnGems(1.0f);
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump"))
        {
            Instantiate(prefab, new Vector3(from.transform.position.x, from.transform.position.y,0), Quaternion.identity);
        }
    }

    private IEnumerator SpawnGems(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            Instantiate(prefab, new Vector3(Random.Range(from.transform.position.x, to.transform.position.x) , from.transform.position.y, 0), Quaternion.identity);
        }
    }
}
