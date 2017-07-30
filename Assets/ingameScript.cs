using UnityEngine;
using System.Collections;

public class ingameScript : MonoBehaviour {

    public string[] msg;
    int index = 0;
    public UILabel showMsg;
    public GameObject getRuby;
    public GameObject ruby;
    public GameObject ALPHA;

    void Start()
    {
        ALPHA.GetComponent<TweenAlpha>().enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void ifTouched()
    {
        if (index != msg.Length - 1)
        {
            index++;
            showMsg.text = msg[index];

            //귀찮았는지 엄청 노가다를 했다..음... 근데 비효율적인듯.
            //길어질 듯 한데. ENUM쓸까?? 아니면 다차원 배열
            //AAA의 n째, BBB의 n째 이렇게 나눠서 하려면
            //장면별로 나눠야하나...귀찮다....으허........
            if (index == 5)
            {
                getRuby.GetComponent<UISprite>().enabled = true;
                getRuby.GetComponent<AudioSource>().Play();
            }
            else if (index == 6)
                getRuby.GetComponent<UISprite>().enabled = false;

            else if (index == 10)
            {
                ruby.GetComponent<AudioSource>().Play();
                ruby.GetComponent<UISprite>().enabled = true;
                ruby.GetComponent<TweenScale>().ResetToBeginning();
                ruby.GetComponent<TweenAlpha>().ResetToBeginning();
                ruby.GetComponent<TweenScale>().Play(true);
                ruby.GetComponent<TweenAlpha>().Play(true);
            }
            else if (index == 11)
                ruby.GetComponent<UISprite>().enabled = false;
        }

    }
    
}
