using System.Collections;
using UnityEngine;

public class SpawnBub : MonoBehaviour
{
    public GameObject bub1;
    public GameObject bub2;
    public GameObject bub3;
    public GameObject bub4;
    public GameObject bub5;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(bub1, new Vector2(Random.Range(-2.5f, 2.5f), -3.7f), Quaternion.identity);
            yield return new WaitForSeconds(1.3f);

            Instantiate(bub2, new Vector2(Random.Range(-2.5f, 2.5f), -3.7f), Quaternion.identity);
            yield return new WaitForSeconds(1.1f);

            Instantiate(bub3, new Vector2(Random.Range(-2.5f, 2.5f), -3.7f), Quaternion.identity);
            yield return new WaitForSeconds(0.9f);

            Instantiate(bub4, new Vector2(Random.Range(-2.5f, 2.5f), -3.7f), Quaternion.identity);
            yield return new WaitForSeconds(0.7f);

            Instantiate(bub5, new Vector2(Random.Range(-2.5f, 2.5f), -3.7f), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
