// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class SpawnBubLvl1 : MonoBehaviour
// {

//     [SerializeField]
//     public GameObject bub1;
//     public GameObject bub2;
//     public GameObject bub3;
//     public GameObject bub4;
//     public GameObject bub5;
//     public GameObject bub6;
//     public GameObject bub7;
//     public GameObject bub8;

//     void Start()
//     {
//         StartCoroutine (Spawn ());
//     }

//     IEnumerator Spawn () {
//         if (CountUp.score < 30) {
//             while (!Player.lose)
//             {
//                 Instantiate (bub1, new Vector2 (Random.Range (-2.5f, 2.5f), -4.5f), Quaternion.identity);
//                 yield return new WaitForSeconds (Random.Range (0.5f, 1.0f));

//                 Instantiate (bub2, new Vector2 (Random.Range (-2.5f, 2.5f), -4.5f), Quaternion.identity);
//                 yield return new WaitForSeconds (Random.Range (0.5f, 1.0f));

//                 Instantiate (bub3, new Vector2 (Random.Range (-2.5f, 2.5f), -4.5f), Quaternion.identity);
//                 yield return new WaitForSeconds (Random.Range (0.5f, 1.0f));

//                 Instantiate (bub4, new Vector2 (Random.Range (-2.5f, 2.5f), -4.5f), Quaternion.identity);
//                 yield return new WaitForSeconds (Random.Range (0.5f, 1.0f));
//             }
//         } else if (CountUp.score >= 30 && CountUp.score < 60)
//             {
//                 while (!Player.lose)
//                 {
//                     Instantiate (bub1, new Vector2 (Random.Range (-2.5f, 2.5f), -4.5f), Quaternion.identity);
//                     yield return new WaitForSeconds (Random.Range (0.25f, 0.5f));

//                     Instantiate (bub2, new Vector2 (Random.Range (-2.5f, 2.5f), -4.5f), Quaternion.identity);
//                     yield return new WaitForSeconds (Random.Range (0.25f, 0.5f));

//                     Instantiate (bub3, new Vector2 (Random.Range (-2.5f, 2.5f), -4.5f), Quaternion.identity);
//                     yield return new WaitForSeconds (Random.Range (0.25f, 0.5f));

//                     Instantiate (bub4, new Vector2 (Random.Range (-2.5f, 2.5f), -4.5f), Quaternion.identity);
//                     yield return new WaitForSeconds (Random.Range (0.25f, 0.5f));

//                     Instantiate (bub5, new Vector2 (Random.Range (-2.5f, 2.5f), -4.5f), Quaternion.identity);
//                     yield return new WaitForSeconds (Random.Range (0.25f, 0.5f));
//                 }
//             } else if (CountUp.score >= 60 && CountUp.score < 100) {
//                 while (!Player.lose)
//                 {
//                     Instantiate (bub1, new Vector2 (Random.Range (-2.5f, 2.5f), -4.5f), Quaternion.identity);
//                     yield return new WaitForSeconds (Random.Range (0.125f, 0.25f));

//                     Instantiate (bub2, new Vector2 (Random.Range (-2.5f, 2.5f), -4.5f), Quaternion.identity);
//                     yield return new WaitForSeconds (Random.Range (0.125f, 0.25f));

//                     Instantiate (bub3, new Vector2 (Random.Range (-2.5f, 2.5f), -4.5f), Quaternion.identity);
//                     yield return new WaitForSeconds (Random.Range (0.125f, 0.25f));

//                     Instantiate (bub4, new Vector2 (Random.Range (-2.5f, 2.5f), -4.5f), Quaternion.identity);
//                     yield return new WaitForSeconds (Random.Range (0.125f, 0.25f));

//                     Instantiate (bub5, new Vector2 (Random.Range (-2.5f, 2.5f), -4.5f), Quaternion.identity);
//                     yield return new WaitForSeconds (Random.Range (0.125f, 0.25f));

//                     Instantiate (bub6, new Vector2 (Random.Range (-2.5f, 2.5f), -4.5f), Quaternion.identity);
//                     yield return new WaitForSeconds (Random.Range (0.125f, 0.25f));
//                 }
//             }
//     }
// }
