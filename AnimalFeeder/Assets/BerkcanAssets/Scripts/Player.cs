using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    [SerializeField] public GameManager game_manager;
    [SerializeField] public UImanager UI_manager;
    //[SerializeField] GameObject trueTick,CowTick;
    [SerializeField] public int LevelValue=1;
    public DynamicJoystick dynamicJoystick;
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed = 0;
    [SerializeField] float turnspeed = 0;
    [SerializeField] public Animator playerAnim;
    //[SerializeField] Animator CowAnim;
    //[SerializeField] GameObject CMvcam1;
    //[SerializeField] GameObject CMCowCam;
    //[SerializeField] GameObject plant;
    //[SerializeField] GameObject plantOnHandPlayer;
    //[SerializeField] GameObject failLevel;
    //[SerializeField] GameObject taptorestart;
    //[SerializeField] GameObject Effect;
    //[SerializeField] GameObject CowEffect;
    bool isCamPosForward = true;
    //[SerializeField] GameObject soil, basket;
    //[SerializeField] GameObject fishHead;
    //[SerializeField] GameObject cowThink1, cowThink2, cowThink3, cowThink4, cowThink5;

    //karakterin birdHouse dönüþüm objeleri
    [SerializeField] GameObject BirdHouse,playerEffect,coverrals,stickman, playerEffect2;
    [SerializeField] public GameObject plantOnHandPlantPlayer, plantOnHandRaddishPlayer, plantOnHandBeetRootPlayer;
    // Start is called before the first frame update
    void Start()
    {


        //LevelValue = PlayerPrefs.GetInt("SavedScene");
        //SceneManager.LoadScene(LevelValue);

        GameObject UImanagerGameObject = GameObject.Find("Canvas");
        UI_manager = UImanagerGameObject.GetComponent<UImanager>();
        CheckGameManager();
        GameObject dynamicjoystickss = GameObject.Find("Dynamic Joystick");
        dynamicJoystick = dynamicjoystickss.GetComponent<DynamicJoystick>();
        print(dynamicJoystick + "null mu deðil mi");
        UI_manager.checkplayer();
        dynamicJoystick.StartOpenJoystick();
        //cowThink1 = GetComponent<Image>();
        //cowThink2 = GetComponent<Image>();
        //cowThink3 = GetComponent<Image>();
        //cowThink4 = GetComponent<Image>();
        //cowThink5 = GetComponent<Image>();

        //CMvcam1 = GameObject.Find("CM vcam1");
        //CMvcam1.GetComponent<GameObject>();
        //cowThink1 = GameObject.Find("111");
        //cowThink1.GetComponent<GameObject>();
        //cowThink2 = GameObject.Find("2222");
        //cowThink2.GetComponent<GameObject>();
        //cowThink3 = GameObject.Find("112");
        //cowThink3.GetComponent<GameObject>();
        //cowThink4 = GameObject.Find("444");
        //cowThink4.GetComponent<GameObject>();
        //cowThink5 = GameObject.Find("3333");
        //cowThink5.GetComponent<GameObject>();

        rb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        //joy = GetComponent<Joystick>();
        //StartCoroutine(CameraDelay());


    }
    public void CheckGameManager()
    {
        GameObject gamemanagerObject = GameObject.Find("GameManager");
        game_manager = gamemanagerObject.GetComponent<GameManager>();
    }
    //public bool isNextLevel = false;
    private void Update()
    {
        
        //if (isNextLevel == true)
        //{
        //    GameObject gamemanagerObject = GameObject.Find("GameManager");
        //    game_manager = gamemanagerObject.GetComponent<GameManager>();
        //    print("update");
        //    StartCoroutine(IsNextLevelTrue());
        //}

    }
    //IEnumerator IsNextLevelTrue()
    //{
    //    yield return new WaitForSeconds(0.5f);
    //    //isNextLevel = false;
    //}
    //IEnumerator ColorAlphaDown()
    //{
    //    cowThink1.SetActive(true);
    //    yield return new WaitForSeconds(0.3f);
    //    cowThink2.SetActive(true);
    //    yield return new WaitForSeconds(0.3f);
    //    cowThink3.SetActive(true);
    //    yield return new WaitForSeconds(0.3f);
    //    cowThink4.SetActive(true);
    //    yield return new WaitForSeconds(0.3f);
    //    cowThink5.SetActive(true);

    //    yield return new WaitForSeconds(2f);
    //    for (float i = 0.1f; i < 0.4; i += 0.1f)
    //    {
    //        cowThink1.GetComponent<SpriteRenderer>().color = new Color(cowThink1.GetComponent<SpriteRenderer>().color.r, cowThink1.GetComponent<SpriteRenderer>().color.g, cowThink1.GetComponent<SpriteRenderer>().color.b, cowThink1.GetComponent<SpriteRenderer>().color.a - i);
    //        cowThink2.GetComponent<SpriteRenderer>().color = new Color(cowThink2.GetComponent<SpriteRenderer>().color.r, cowThink2.GetComponent<SpriteRenderer>().color.g, cowThink2.GetComponent<SpriteRenderer>().color.b, cowThink2.GetComponent<SpriteRenderer>().color.a - i);
    //        cowThink3.GetComponent<SpriteRenderer>().color = new Color(cowThink3.GetComponent<SpriteRenderer>().color.r, cowThink3.GetComponent<SpriteRenderer>().color.g, cowThink3.GetComponent<SpriteRenderer>().color.b, cowThink3.GetComponent<SpriteRenderer>().color.a - i);
    //        cowThink4.GetComponent<SpriteRenderer>().color = new Color(cowThink4.GetComponent<SpriteRenderer>().color.r, cowThink4.GetComponent<SpriteRenderer>().color.g, cowThink4.GetComponent<SpriteRenderer>().color.b, cowThink4.GetComponent<SpriteRenderer>().color.a - i);
    //        cowThink5.GetComponent<SpriteRenderer>().color = new Color(cowThink5.GetComponent<SpriteRenderer>().color.r, cowThink5.GetComponent<SpriteRenderer>().color.g, cowThink5.GetComponent<SpriteRenderer>().color.b, cowThink5.GetComponent<SpriteRenderer>().color.a - i);
    //        yield return new WaitForSeconds(0.3f);
    //    }
    //}
    //IEnumerator CameraDelay()
    //{
    //    CMvcam1.transform.DOMove(new Vector3(CMvcam1.transform.position.x, CMvcam1.transform.position.y, 14f), 10f);
    //    //yield return new WaitForSeconds(10f);
    //    //CMvcam1.transform.DOMove(new Vector3(CMvcam1.transform.position.x, CMvcam1.transform.position.y, -11.35f), 10f);
    //}
    // Update is called once per frame
    void FixedUpdate()
    {
        touchCont();
        //joystickMovement();
        //Vector3 force = new Vector3(joy.Horizontal * speed, 0f, joy.Vertical * speed);
        //rb.AddForce(force * Time.fixedDeltaTime);
    }
    public void joystickMovement()
    {
        float horizontal = dynamicJoystick.Horizontal;
        float vertical = dynamicJoystick.Vertical;
        Vector3 addedPos = new Vector3(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime);
        transform.position += addedPos;

        Vector3 direction = Vector3.forward * vertical + Vector3.right * horizontal;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), turnspeed * Time.deltaTime);
    }
    public bool isRun = true;
    public bool isTouchActive = true;
    public void touchCont()
    {
        if (isTouchActive)
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = true;
            if (isBird==true)
            {
                StartCoroutine(BirdToHuman());
                isBird = false;

            }
            if (Input.touchCount > 0)
            {
                


                if (isCamPosForward)
                {
                    //CMvcam1.transform.DOMove(new Vector3(CMvcam1.transform.position.x, CMvcam1.transform.position.y, 14f), 10f);
                    //StartCoroutine(CameraDelay());
                    isCamPosForward = false;
                }

                Touch t = Input.GetTouch(0);
                if (t.phase == TouchPhase.Began)
                {
                   
                    playerAnim.SetBool("Idle", false);
                    if (isRun == true)
                    {
                        playerAnim.SetBool("Run", true);
                    }
                    else
                    {
                        playerAnim.SetBool("RunDrop", true);
                    }

                    joystickMovement();
                }
                else if ((t.phase == TouchPhase.Moved || t.phase == TouchPhase.Stationary))
                {
                   
                    playerAnim.SetBool("Idle", false);
                    if (isRun == true)
                    {
                        playerAnim.SetBool("Run", true);
                    }
                    else
                    {
                        playerAnim.SetBool("RunDrop", true);
                    }
                    joystickMovement();
                }
                else if (t.phase == TouchPhase.Ended)
                {
                    playerAnim.SetBool("Idle", true);
                    playerAnim.SetBool("Run", false);
                    playerAnim.SetBool("RunDrop", false);
                }
            }
            else
            {
                if (isCoowFoodDrop == true && isBird == false)
                {
                    this.gameObject.GetComponent<BoxCollider>().enabled = false;
                    StartCoroutine(BirdFoxTrans());

                }
                playerAnim.SetBool("Idle", true);
                playerAnim.SetBool("Run", false);
                playerAnim.SetBool("RunDrop", false);

            }
        }


    }
    public bool isBird = false;
    IEnumerator BirdFoxTrans()
    {
        playerEffect.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        coverrals.SetActive(false);
        stickman.SetActive(false);
        BirdHouse.SetActive(true);
        isBird = true;
    }
    IEnumerator BirdToHuman()
    {
        playerEffect2.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        coverrals.SetActive(true);
        stickman.SetActive(true);
        BirdHouse.SetActive(false);
    }
   public bool isCoowFoodDrop = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CowFood")
        {
            isCoowFoodDrop = true;
            game_manager.plant.SetActive(false);
            game_manager.trueTick.SetActive(true);
            if (LevelValue ==1 || LevelValue == 2 || LevelValue == 3)
            {
                plantOnHandPlantPlayer.SetActive(true);
            }
            else if (LevelValue == 4)
            {
                plantOnHandRaddishPlayer.SetActive(true);
            }
            else if (LevelValue == 5)
            {
                plantOnHandBeetRootPlayer.SetActive(true);
            }
            playerAnim.SetBool("Idle", false);
            playerAnim.SetBool("Run", false);
            playerAnim.SetBool("RunDrop", true);
            game_manager.TakeObjectEffect.SetActive(true);
            //CMvcam1.transform.DOMove(new Vector3(CMvcam1.transform.position.x, CMvcam1.transform.position.y, -11.35f), 10f);
            isRun = false;
        }
        if (plantOnHandPlantPlayer.gameObject.activeSelf == true || plantOnHandRaddishPlayer.gameObject.activeSelf == true || plantOnHandBeetRootPlayer.gameObject.activeSelf == true)
        {
            if (other.tag == "CowFeed")
            {
                //transform.DOLocalMove(new Vector3(-1.1754f, -1.203f, -24.611f), 2f);
                isTouchActive = false;


                StartCoroutine(game_manager.EffectCow());

            }
            if (other.tag == "CowFeed2")
            {
                isTouchActive = false;
                StartCoroutine(game_manager.EffectCow());
            }
            if (other.tag == "SheepFeed")
            {
                isTouchActive = false;
                StartCoroutine(game_manager.EffectCow());
            }
            if (other.tag == "GoatFeed")
            {
                isTouchActive = false;
                StartCoroutine(game_manager.EffectCow());
            }
        }


        if (other.tag == "Fish")
        {
            game_manager.fishHead.GetComponent<SpriteRenderer>().color = Color.red;
            playerAnim.SetBool("Idle", true);
            playerAnim.SetBool("Run", false);
            playerAnim.SetBool("RunDrop", false);
            UI_manager.failLevel.SetActive(true);
            UI_manager.taptorestart.SetActive(true);
            isTouchActive = false;
        }
        if (other.tag == "Deer")
        {
            DeerScript.deerAnim.SetBool("fail", true);
            DeerScript.deerAnim.SetBool("FailEnd", true);
        }
    }

    //public void TryButton()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //}
}
