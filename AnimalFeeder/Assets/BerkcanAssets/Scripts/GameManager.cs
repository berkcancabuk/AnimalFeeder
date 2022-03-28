using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class GameManager : MonoBehaviour
{
    [SerializeField] public Player player;
    [SerializeField] public GameObject cowThink1, cowThink2, cowThink3, cowThink4, cowThink5;
    [SerializeField] public GameObject CowEffect;
    [SerializeField] public GameObject trueTick, CowTick;
    [SerializeField] public GameObject fishHead;
    [SerializeField] public GameObject TakeObjectEffect;
    
    [SerializeField] public Animator CowAnim;
    [SerializeField] public GameObject CMvcam1;
    [SerializeField] public GameObject CMCowCam;
    [SerializeField] public GameObject plant;

    // Start is called before the first frame update
    void Start()
    {
        GameObject playerGameobje = GameObject.Find("Player");
        player = playerGameobje.GetComponent<Player>();


        StartCoroutine(ColorAlphaDown());
        CMvcam1 = GameObject.Find("CM vcam1");
        CMvcam1.GetComponent<GameObject>();

        //CMCowCam = GameObject.Find("Level2CowCam");
        //CMCowCam.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator ColorAlphaDown()
    {
        cowThink1.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        cowThink2.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        cowThink3.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        cowThink4.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        cowThink5.SetActive(true);

        yield return new WaitForSeconds(2f);
        for (float i = 0.1f; i < 0.4; i += 0.1f)
        {
            cowThink1.GetComponent<SpriteRenderer>().color = new Color(cowThink1.GetComponent<SpriteRenderer>().color.r, cowThink1.GetComponent<SpriteRenderer>().color.g, cowThink1.GetComponent<SpriteRenderer>().color.b, cowThink1.GetComponent<SpriteRenderer>().color.a - i);
            cowThink2.GetComponent<SpriteRenderer>().color = new Color(cowThink2.GetComponent<SpriteRenderer>().color.r, cowThink2.GetComponent<SpriteRenderer>().color.g, cowThink2.GetComponent<SpriteRenderer>().color.b, cowThink2.GetComponent<SpriteRenderer>().color.a - i);
            cowThink3.GetComponent<SpriteRenderer>().color = new Color(cowThink3.GetComponent<SpriteRenderer>().color.r, cowThink3.GetComponent<SpriteRenderer>().color.g, cowThink3.GetComponent<SpriteRenderer>().color.b, cowThink3.GetComponent<SpriteRenderer>().color.a - i);
            cowThink4.GetComponent<SpriteRenderer>().color = new Color(cowThink4.GetComponent<SpriteRenderer>().color.r, cowThink4.GetComponent<SpriteRenderer>().color.g, cowThink4.GetComponent<SpriteRenderer>().color.b, cowThink4.GetComponent<SpriteRenderer>().color.a - i);
            cowThink5.GetComponent<SpriteRenderer>().color = new Color(cowThink5.GetComponent<SpriteRenderer>().color.r, cowThink5.GetComponent<SpriteRenderer>().color.g, cowThink5.GetComponent<SpriteRenderer>().color.b, cowThink5.GetComponent<SpriteRenderer>().color.a - i);
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator EffectCow()
    {
        if (player.LevelValue == 1)
        {
            player.transform.DOLocalMove(new Vector3(-1.312f, -1.203f, -24.889f), 1f);
        }
        if (player.LevelValue == 2)
        {
            player.transform.DOLocalMove(new Vector3(-4.156f, -2.72f, -46.603f), 1f);
        }
        if (player.LevelValue ==3 || player.LevelValue==4|| player.LevelValue == 5) 
        {
            player.transform.DOLocalMove(new Vector3(-0.616f, -2.697413f, -47.558f), 1f);
            player.transform.DOLocalRotate(new Vector3(0, 135, 0),1f);
        }

        yield return new WaitForSeconds(0.5f);
        player.playerAnim.SetBool("StandToSit", true);
        if (player.LevelValue == 4)
        {
            player.game_manager.CowAnim.SetBool("Sheep", true);
        }
        else if (player.LevelValue ==1 || player.LevelValue == 2 || player.LevelValue == 3 )
        {
            player.game_manager.CowAnim.SetBool("Food", true);
        }
        else if (player.LevelValue == 5)
        {
            player.game_manager.CowAnim.SetBool("Goat", true);
        }
        
        player.game_manager.CMvcam1.SetActive(false);
        player.game_manager.CMCowCam.SetActive(true);
        yield return new WaitForSeconds(2f);
        CowEffect.SetActive(true);
        yield return new WaitForSeconds(1f);
        player.UI_manager.soil.SetActive(true);
        CowTick.SetActive(true);
        yield return new WaitForSeconds(1f);
        player.UI_manager.basket.SetActive(true);
        player.UI_manager.LevelComplate.SetActive(true);
        player.UI_manager.TapToContinue.SetActive(true);
        //player.playerAnim.SetBool("Idle", true);
        //player.playerAnim.SetBool("Run", false);
        //player.playerAnim.SetBool("RunDrop", false);
        //player.playerAnim.SetBool("StandToSit", false);
        //player.isTouchActive = true;
    }
}
