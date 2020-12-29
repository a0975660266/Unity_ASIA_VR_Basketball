using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public int score;
    [Header("投進的分數")]
    public int scoreIn = 2;
    [Header("進球音效")]
    public AudioClip soundIn;

    private AudioSource aud;

    private void Awake()
    {
        //音效來源 = 取得元件<音效來源>
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="籃球")
        {
            AddScore();
        }
        //如果 碰撞的根物件名稱為Player
        if(other.transform.root.name =="Player")
        {
            //玩家進入三分區域，將投進的分數改為三分
            scoreIn = 3;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.name == "Player")
        {
            //玩家離開三分區域，將投進的分數改為二分
            scoreIn = 2;
        }
    }

    ///<summary>
    ///加分數
    ///</summary>
    private void AddScore()
    {
        score += scoreIn;                                                                               //分數遞增  投進的分數
        textScore.text = "分數 :" + score;                                                  //更新介面
        aud.PlayOneShot(soundIn, Random.Range(1f,3f));
    }

}
