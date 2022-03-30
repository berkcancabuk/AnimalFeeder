using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class GameManager : MonoBehaviour
{
    public GameObject trueTick, CowTick, trueTick2;
    [SerializeField] public Player player;
    [SerializeField] public GameObject cowThink1, cowThink2, cowThink3, cowThink4, cowThink5;
    [SerializeField] public GameObject cowThink6, cowThink7, cowThink8, cowThink9, cowThink10;
    [SerializeField] public GameObject CowEffect;
    //public static GameObject trueTick, CowTick,trueTick2;
    [SerializeField] public GameObject fishHead;
    [SerializeField] public GameObject TakeObjectEffect;
    [SerializeField] public static GameObject pepper1, pepper2;
    [SerializeField] public Animator CowAnim;
    [SerializeField] public Animator CowAnim2;
    [SerializeField] public GameObject CMvcam1;
    [SerializeField] public GameObject CMCowCam, CMCow2Cam;
    [SerializeField] public GameObject plant;
    // Start is called before the first frame update
    void Start()
    {
       
        GameObject playerGameobje = GameObject.Find("Player");
        player = playerGameobje.GetComponent<Player>();


        StartCoroutine(ColorAlphaDown1());
        if (Player.LevelValue == 6 || Player.LevelValue == 7 || Player.LevelValue == 8 || Player.LevelValue == 9)
        {
            StartCoroutine(ColorAlphaDown2());
        }
       
        CMvcam1 = GameObject.Find("CM vcam1");
        CMvcam1.GetComponent<GameObject>();
        player.OneMoreLoop = false;
        //CMCowCam = GameObject.Find("Level2CowCam");
        //CMCowCam.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator ColorAlphaDown1()
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
    IEnumerator ColorAlphaDown2()
    {
        cowThink6.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        cowThink7.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        cowThink8.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        cowThink9.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        cowThink10.SetActive(true);

        yield return new WaitForSeconds(2f);
        for (float i = 0.1f; i < 0.4; i += 0.1f)
        {
            cowThink6.GetComponent<SpriteRenderer>().color = new Color(cowThink6.GetComponent<SpriteRenderer>().color.r, cowThink6.GetComponent<SpriteRenderer>().color.g, cowThink6.GetComponent<SpriteRenderer>().color.b, cowThink6.GetComponent<SpriteRenderer>().color.a - i);
            cowThink7.GetComponent<SpriteRenderer>().color = new Color(cowThink7.GetComponent<SpriteRenderer>().color.r, cowThink7.GetComponent<SpriteRenderer>().color.g, cowThink7.GetComponent<SpriteRenderer>().color.b, cowThink7.GetComponent<SpriteRenderer>().color.a - i);
            cowThink8.GetComponent<SpriteRenderer>().color = new Color(cowThink8.GetComponent<SpriteRenderer>().color.r, cowThink8.GetComponent<SpriteRenderer>().color.g, cowThink8.GetComponent<SpriteRenderer>().color.b, cowThink8.GetComponent<SpriteRenderer>().color.a - i);
            cowThink9.GetComponent<SpriteRenderer>().color = new Color(cowThink9.GetComponent<SpriteRenderer>().color.r, cowThink9.GetComponent<SpriteRenderer>().color.g, cowThink9.GetComponent<SpriteRenderer>().color.b, cowThink9.GetComponent<SpriteRenderer>().color.a - i);
            cowThink10.GetComponent<SpriteRenderer>().color = new Color(cowThink10.GetComponent<SpriteRenderer>().color.r, cowThink10.GetComponent<SpriteRenderer>().color.g, cowThink10.GetComponent<SpriteRenderer>().color.b, cowThink10.GetComponent<SpriteRenderer>().color.a - i);
            yield return new WaitForSeconds(0.3f);
        }
    }
    public IEnumerator EffectCow2()
    {
        if (Player.LevelValue == 6 || Player.LevelValue == 7 || Player.LevelValue == 8 || Player.LevelValue == 9)
        {
            if (Player.LevelValue != 8)
            {
                player.transform.DOLocalMove(new Vector3(0.394f, -2.72f, -48.866f), 1f);
                player.transform.DOLocalRotate(new Vector3(0, 135, 0), 1f);
            }
            else if (Player.LevelValue == 8)
            {
                player.transform.DOLocalMove(new Vector3(1.841f, -1.316f, -23.895f), 1f);
                player.transform.DOLocalRotate(new Vector3(0, -220.526f, 0), 1f);
            }
            
            
            yield return new WaitForSeconds(0.5f);
            Player.playerAnim.SetBool("StandToSit", true);
            player.game_manager.CowAnim.SetBool("Goat", true);
            player.game_manager.CMvcam1.SetActive(false);
            player.game_manager.CMCowCam.SetActive(true);

            yield return new WaitForSeconds(1f);
            Player.isPepper1 = false;
            CowEffect.SetActive(true);
            yield return new WaitForSeconds(1f);
            player.plantOnHandPepperPlayer.SetActive(false);
            player.plantOnHandTomatoPlayer.SetActive(false);
            player.plantOnHandLemonPlayer.SetActive(false);
            player.plantOnHandGreenPlayer.SetActive(false);
            player.plantOnHandRaddishPlayer.SetActive(false);
            player.plantOnHandPlantPlayer.SetActive(false);
            if (LeftAnimal.LeftAnimalFood == true)
            {
                yield return new WaitForSeconds(1f);
                player.UI_manager.soil.SetActive(true);
                CowTick.SetActive(true);
                yield return new WaitForSeconds(1f);
                player.UI_manager.basket.SetActive(true);
                player.UI_manager.LevelComplate.SetActive(true);
                player.UI_manager.TapToContinue.SetActive(true);
            }
            else
            {
                Player.playerAnim.SetBool("StandToSit", false);
                Player.playerAnim.SetBool("Run", false);
                Player.playerAnim.SetBool("RunDrop", false);
                Player.playerAnim.SetBool("Idle", true);
                player.isTouchActive = true;
                player.game_manager.TakeObjectEffect.SetActive(false);
                yield return new WaitForSeconds(0.5f);
                player.game_manager.CowAnim.speed = 0;
                
                    player.game_manager.CMvcam1.SetActive(true);
                    player.game_manager.CMCowCam.SetActive(false);
                
            }

        }
    }
    public IEnumerator EffectCow()
    {
        if (Player.LevelValue == 1)
        {
            player.transform.DOLocalMove(new Vector3(-1.312f, -1.203f, -24.889f), 1f);
        }
        if (Player.LevelValue == 2 ||Player.LevelValue == 10)
        {
            player.transform.DOLocalMove(new Vector3(-4.156f, -2.72f, -46.603f), 1f);
        }
        if (Player.LevelValue == 3 || Player.LevelValue == 4 || Player.LevelValue == 5 )
        {
            print("Kac kere girdi");
            player.transform.DOLocalMove(new Vector3(-0.616f, -2.697413f, -47.558f), 1f);
            player.transform.DOLocalRotate(new Vector3(0, 135, 0), 1f);
        }
        if (Player.LevelValue==6 ||Player.LevelValue == 7 || Player.LevelValue == 9)
        {
            player.transform.DOLocalMove(new Vector3(-3.284f, -3.017283f, -48.974f), 1f);
        }
        if ( Player.LevelValue == 8)
        {
            player.transform.DOLocalMove(new Vector3(-2.229f, -1.371f, -24.004f), 1f);
            player.transform.DOLocalRotate(new Vector3(0, -145.526f, 0), 1f);
        }
        yield return new WaitForSeconds(0.5f);
        Player.playerAnim.SetBool("StandToSit", true);
        if (Player.LevelValue == 4)
        {
            player.game_manager.CowAnim.SetBool("Sheep", true);
        }
        else if (Player.LevelValue == 1 || Player.LevelValue == 2 || Player.LevelValue == 3)
        {
            player.game_manager.CowAnim.SetBool("Food", true);
        }
        else if (Player.LevelValue == 5)
        {
            player.game_manager.CowAnim.SetBool("Goat", true);
        }
        else if (Player.LevelValue == 6 || Player.LevelValue == 7 || Player.LevelValue == 8 || Player.LevelValue == 9)
        {
            player.game_manager.CowAnim2.SetBool("Food", true);
            CMCow2Cam.SetActive(true);
        }
        if ((Player.LevelValue == 6 || Player.LevelValue == 7 || Player.LevelValue == 8 || Player.LevelValue == 9) && RightAnimal.RightAnimalFood == false)
        {
            print("Kac kere girdi level 6 oncesi");
            yield return new WaitForSeconds(1f);
            player.plantOnHandPepperPlayer.SetActive(false);
            player.plantOnHandTomatoPlayer.SetActive(false);
            player.plantOnHandLemonPlayer.SetActive(false);
            player.plantOnHandGreenPlayer.SetActive(false);
            player.plantOnHandRaddishPlayer.SetActive(false);
            player.plantOnHandPlantPlayer.SetActive(false);
            Player.playerAnim.SetBool("StandToSit", false);
            Player.playerAnim.SetBool("Run", false);
            Player.playerAnim.SetBool("RunDrop", false);
            Player.playerAnim.SetBool("Idle", true);
            player.isTouchActive = true;
            player.game_manager.TakeObjectEffect.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            player.game_manager.CowAnim.speed = 0;
            player.game_manager.CMvcam1.SetActive(true);
            player.game_manager.CMCow2Cam.SetActive(false);
        }
        else
        {
            if (Player.LevelValue == 6 || Player.LevelValue == 7 || Player.LevelValue == 8 || Player.LevelValue == 9)
            {
                player.game_manager.CMvcam1.SetActive(false);
                player.game_manager.CMCow2Cam.SetActive(true);
            }
            else
            {
                player.game_manager.CMvcam1.SetActive(false);
                player.game_manager.CMCowCam.SetActive(true);
            }
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
}
