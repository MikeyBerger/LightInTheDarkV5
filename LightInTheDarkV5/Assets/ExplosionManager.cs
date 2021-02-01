using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionManager : MonoBehaviour
{
    public GameObject[] Explosions;
    public float Timer;
    public float Limit;
    bool Fire0;
    bool Fire1;
    bool Fire2;
    bool Fire3;
    bool Fire4;
    bool Fire5;

    #region Coroutines
    [System.Obsolete]
    IEnumerator Explosion0()
    {
        Explosions[0].active = true;
        yield return new WaitForSeconds(Timer);
        Explosions[0].active = false;
    }

    [System.Obsolete]
    IEnumerator Explosion1()
    {
        Explosions[1].active = true;
        yield return new WaitForSeconds(Timer);
        Explosions[1].active = false;
    }

    [System.Obsolete]
    IEnumerator Explosion2()
    {
        Explosions[2].active = true;
        yield return new WaitForSeconds(Timer);
        Explosions[2].active = false;
    }

    [System.Obsolete]
    IEnumerator Explosion3()
    {
        Explosions[3].active = true;
        yield return new WaitForSeconds(Timer);
        Explosions[3].active = false;
    }

    [System.Obsolete]
    IEnumerator Explosion4()
    {
        Explosions[4].active = true;
        yield return new WaitForSeconds(Timer);
        Explosions[4].active = false;
    }

    [System.Obsolete]
    IEnumerator Explosion5()
    {
        Explosions[5].active = true;
        yield return new WaitForSeconds(Timer);
        Explosions[5].active = false;
    }
    #endregion

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        Explosions[0].active = false;
        Explosions[1].active = false;
        Explosions[2].active = false;
        Explosions[3].active = false;
        Explosions[4].active = false;
        Explosions[5].active = false;
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        /*
        StartCoroutine(Explosion0());
        StartCoroutine(Explosion1());
        StartCoroutine(Explosion2());
        StartCoroutine(Explosion3());
        StartCoroutine(Explosion4());
        StartCoroutine(Explosion5());
        */

        Timer += Time.deltaTime;
        // ExplodeTrigger();
        // ExplodeImpact();
        ExplodeDesperate();
    }

    [System.Obsolete]
    void ExplodeTrigger()
    {
        /*
        if (Timer >= 2)
        {
            Explosions[0].active = true;
            Explosions[1].active = false;
            Explosions[2].active = false;
            Explosions[3].active = false;
            Explosions[4].active = false;
            Explosions[5].active = false;
        }
        else if (Timer >= 4)
        {
            Explosions[0].active = false;
            Explosions[1].active = true;
            Explosions[2].active = false;
            Explosions[3].active = false;
            Explosions[4].active = false;
            Explosions[5].active = false;
        }
        else if (Timer >= 6)
        {
            Explosions[0].active = false;
            Explosions[1].active = false;
            Explosions[2].active = true;
            Explosions[3].active = false;
            Explosions[4].active = false;
            Explosions[5].active = false;
        }
        else if (Timer >= 8)
        {
            Explosions[0].active = false;
            Explosions[1].active = false;
            Explosions[2].active = false;
            Explosions[3].active = true;
            Explosions[4].active = false;
            Explosions[5].active = false;
        }
        else if (Timer >= 10)
        {
            Explosions[0].active = false;
            Explosions[1].active = false;
            Explosions[2].active = false;
            Explosions[3].active = false;
            Explosions[4].active = true;
            Explosions[5].active = false;
        }
        else if (Timer >= 12)
        {
            Explosions[0].active = false;
            Explosions[1].active = false;
            Explosions[2].active = false;
            Explosions[3].active = false;
            Explosions[4].active = false;
            Explosions[5].active = true;
            Timer = 0;
        }
        */
        /*
        if (Timer >= 2)
        {
            Fire0 = true;
            Timer = 0;
        }
        else if (Timer >= 2 && Fire0)
        {
            Fire0 = false;
            Fire1 = true;
            Timer = 0;
        }
        else if (Timer >= 2 && !Fire0 && Fire1)
        {
            Fire0 = false;
            Fire1 = false;
            Fire2 = true;
            Timer = 0;
        }
        else if (Timer >= 2 && !Fire0 && !Fire1 && Fire2)
        {
            Fire0 = false;
            Fire1 = false;
            Fire2 = false;
            Fire3 = true;
            Timer = 0;
        }
        else if (Timer >= 2 && !Fire0 && !Fire1 && !Fire2 && Fire3)
        {
            Fire0 = false;
            Fire1 = false;
            Fire2 = false;
            Fire3 = false;
            Fire4 = true;
            Timer = 0;
        }
        else if (Timer >= 2 && !Fire0 && !Fire1 && !Fire2 && !Fire3 && Fire4)
        {
            Fire0 = false;
            Fire1 = false;
            Fire2 = false;
            Fire3 = false;
            Fire4 = false;
            Fire5 = true;
            Timer = 0;
        }
        else if (Timer >= 2 && !Fire0 && !Fire1 && !Fire2 && !Fire3 && !Fire4 && Fire5)
        {
            Fire0 = false;
            Fire1 = false;
            Fire2 = false;
            Fire3 = false;
            Fire4 = false;
            Fire5 = false;
            Timer = 0;
        }
        */

    }

    [System.Obsolete]
    void ExplodeImpact()
    {
        if (Fire0)
        {
            Explosions[0].active = true;
        }
        else if (Fire1)
        {
            Explosions[1].active = false;
        }
        else if (Fire2)
        {
            Explosions[2].active = false;
        }
        else if (Fire3)
        {
            Explosions[3].active = false;
        }
        else if (Fire4)
        {
            Explosions[4].active = false;
        }
        else if (Fire5)
        {
            Explosions[5].active = false;
        }
    }

    [System.Obsolete]
    void ExplodeDesperate()
    {
        if (Timer >= 2 && Limit == 0)
        {
            Explosions[0].active = true;
            Explosions[1].active = false;
            Explosions[2].active = false;
            Explosions[3].active = false;
            Explosions[4].active = false;
            Explosions[5].active = false;
            Limit++;
            Timer = 0;
        }

        if (Timer >= 2 && Limit == 1)
        {
            Explosions[0].active = false;
            Explosions[1].active = true;
            Explosions[2].active = false;
            Explosions[3].active = false;
            Explosions[4].active = false;
            Explosions[5].active = false;
            Limit++;
            Timer = 0;
        }

        if (Timer >= 2 && Limit == 2)
        {
            Explosions[0].active = false;
            Explosions[1].active = false;
            Explosions[2].active = true;
            Explosions[3].active = false;
            Explosions[4].active = false;
            Explosions[5].active = false;
            Limit++;
            Timer = 0;
        }

        if (Timer >= 2 && Limit == 3)
        {
            Explosions[0].active = false;
            Explosions[1].active = false;
            Explosions[2].active = false;
            Explosions[3].active = true;
            Explosions[4].active = false;
            Explosions[5].active = false;
            Limit++;
            Timer = 0;
        }

        if (Timer >= 2 && Limit == 4)
        {
            Explosions[0].active = false;
            Explosions[1].active = false;
            Explosions[2].active = false;
            Explosions[3].active = false;
            Explosions[4].active = true;
            Explosions[5].active = false;
            Limit++;
            Timer = 0;
        }

        if (Timer >= 2 && Limit == 5)
        {
            Explosions[0].active = false;
            Explosions[1].active = false;
            Explosions[2].active = false;
            Explosions[3].active = false;
            Explosions[4].active = false;
            Explosions[5].active = true;
            Limit = 0;
            Timer = 0;
        }
    }
}
