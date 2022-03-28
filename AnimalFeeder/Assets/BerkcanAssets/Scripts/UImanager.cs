using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class UImanager : MonoBehaviour
{
    
    [SerializeField] public GameObject soil, basket;
    [SerializeField] TextMeshProUGUI TextlevelValue, TextLevel;
    int ActiveSceneValue;
    [SerializeField] public GameObject taptorestart;
    [SerializeField] public GameObject failLevel;
    [SerializeField] public GameObject TapToContinue;
    [SerializeField] public GameObject LevelComplate;
    [SerializeField] public Player player;
    // Start is called before the first frame update
    void Start()
    {
        GameObject playergameobject = GameObject.Find("Player");
        player = playergameobject.GetComponent<Player>();
        ActiveSceneValue = SceneManager.GetActiveScene().buildIndex+1;
        TextlevelValue.text = "" + ActiveSceneValue;
        TextLevel.text = "LEVEL ";
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void checkplayer()
    {
        GameObject playergameobject = GameObject.Find("Player");
        player = playergameobject.GetComponent<Player>();
    }
    public void TryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        StartCoroutine(checkGameManagers());
        player.game_manager.CMvcam1.SetActive(true);
        player.game_manager.CMCowCam.SetActive(false);
        failLevel.SetActive(false);
        taptorestart.SetActive(false);
        player.isTouchActive = true;
        //player.isNextLevel = true;
        LevelComplate.SetActive(false);
        TapToContinue.SetActive(false);
        soil.SetActive(false);
        basket.SetActive(false);
        player.UI_manager.failLevel.SetActive(false);
        player.UI_manager.taptorestart.SetActive(false);
        if (player.LevelValue ==1)
        {
            player.transform.localPosition = new Vector3(0, -1.276707f, -23.05456f);
        }
        if (player.LevelValue == 2)
        {
            player.transform.localPosition = new Vector3(0.4446331f, -2.697414f, -46.97912f);
        }
        player.playerAnim.SetBool("Idle", true); player.playerAnim.SetBool("Run", false); player.playerAnim.SetBool("RunDrop", false);
        player.plantOnHandPlantPlayer.SetActive(false); player.isRun = true;player.plantOnHandRaddishPlayer.SetActive(false);player.plantOnHandBeetRootPlayer.SetActive(false);
        player.isCoowFoodDrop = false;
    }
    public void NextLevelButton()
    {
        player.LevelValue++;
        SceneManager.LoadScene(player.LevelValue-1);
        ActiveSceneValue = player.LevelValue;
        PlayerPrefs.SetInt("SavedScene", player.LevelValue);
        print(SceneManager.GetActiveScene().buildIndex);
        TextlevelValue.text = "" + ActiveSceneValue;
        StartCoroutine(checkGameManagers());
        player.game_manager.CMvcam1.SetActive(true);
        player.game_manager.CMCowCam.SetActive(false);
        LevelComplate.SetActive(false);
        TapToContinue.SetActive(false);
        soil.SetActive(false);
        basket.SetActive(false);
        player.transform.position = new Vector3(0, -1.276707f, -23.05456f);
        player.playerAnim.SetBool("Idle", true); player.playerAnim.SetBool("Run", false); player.playerAnim.SetBool("RunDrop", false); player.playerAnim.SetBool("StandToSit", false);
        player.plantOnHandPlantPlayer.SetActive(false);
        player.plantOnHandRaddishPlayer.SetActive(false);
        player.plantOnHandBeetRootPlayer.SetActive(false);
        player.isRun = true;
        player.isTouchActive = true;
        player.isCoowFoodDrop = false;

    }
    IEnumerator checkGameManagers()
    {
        yield return new WaitForSeconds(0.5f);
        player.CheckGameManager();
    }
}
