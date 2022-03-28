using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DeerScript : MonoBehaviour
{
    public static Animator deerAnim;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(DeerPose());
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(DeerPose());
        //this.gameObject.transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
    }
    bool TryAgain = false;
    IEnumerator DeerPose()
    {
        if (TryAgain == false)
        {
            TryAgain = true;
            print(this.gameObject.transform.position);
            this.gameObject.transform.DOLocalMove(new Vector3(3.26f, transform.position.y, -9.844561f), 3f);
            yield return new WaitForSeconds(2.5f);
            this.gameObject.transform.DORotate(new Vector3(0, 169.24f, 0), 0.5f);
            yield return new WaitForSeconds(0.5f);
            this.transform.DOLocalMove(new Vector3(3.5f, transform.position.y, -11.024561f), 1f);
            yield return new WaitForSeconds(1f);
            this.transform.DORotate(new Vector3(0, 255, 0), 0.5f);
            yield return new WaitForSeconds(0.5f);
            this.transform.DOLocalMove(new Vector3(-4.57f, transform.position.y, -13.57f), 3f);
            yield return new WaitForSeconds(2.5f);
            this.transform.DORotate(new Vector3(0, 332.22f, 0), 0.5f);
            yield return new WaitForSeconds(0.5f);
            this.transform.DOLocalMove(new Vector3(-4.57f, transform.position.y, -14.18f), 1f);
            yield return new WaitForSeconds(0.8f);
            this.transform.DORotate(new Vector3(0, 75, 0), 0.5f);
            TryAgain = false;
        }

    }
}
