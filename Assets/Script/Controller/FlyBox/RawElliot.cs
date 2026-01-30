using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Random = UnityEngine.Random;

public class RawElliot : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("boxImg")]    [UnityEngine.Serialization.FormerlySerializedAs("AntRed")]public GameObject RagCod;
[UnityEngine.Serialization.FormerlySerializedAs("boxBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("AntFew")]public Button RagWhy;
[UnityEngine.Serialization.FormerlySerializedAs("bubbleGifImage")]    [UnityEngine.Serialization.FormerlySerializedAs("FacadeBitHoney")]public GameObject PalaceWetSword;
    private Sequence _Lap1;
    private Sequence _Lap2;


    void Start()
    {
        RawGazeBreath();

        RagWhy.onClick.AddListener(() =>
        {
            CudBreath();
            RawKeyCongestion.Instance.FirnServeSkill();
        });
    }


    public void RawOffer()
    {
        GapWhyNucleic();
        transform.DOPause();
        _Lap1.Pause();
        _Lap2.Pause();
    }

    public void RawEncase()
    {
        GapWhyChorus();
        transform.DOPlay();
        _Lap1.Play();
        _Lap2.Play();
    }

    public void GapWhyChorus()
    {
        RagWhy.enabled = true;
    }

    public void GapWhyNucleic()
    {
        RagWhy.enabled = false;
    }

    private void CudBreath()
    {
        RagCod.SetActive(false);
        RagWhy.gameObject.SetActive(false);
        PalaceWetSword.SetActive(true);
    }


    private void RawGazeBreath()
    {
        _Lap1 = DOTween.Sequence();
        _Lap2 = DOTween.Sequence();
        int leftOrRight = Random.Range(0, 2);
        if (leftOrRight == 0)
        {
            transform.localPosition = new Vector3(-450f, 0, 0);
            _Lap1.Append(transform.DOLocalMoveY(150f + Random.Range(-50f, 50f), 2.5f).SetEase(Ease.InSine));
            _Lap1.Append(transform.DOLocalMoveY(0, 2.5f).SetEase(Ease.InSine));
            _Lap1.SetLoops(-1);
            _Lap1.Play();

            _Lap2.Append(transform.DOScale(1.4f, 0.5f).SetEase(Ease.Linear));
            _Lap2.Append(transform.DOScale(1.3f, 0.5f).SetEase(Ease.Linear));
            _Lap2.SetLoops(-1);
            _Lap2.Play();
            transform.DOLocalMoveX(450, 10f).SetEase(Ease.Linear).OnComplete(() =>
            {
                _Lap1.Kill();
                _Lap2.Kill();
                transform.DOKill();
                GetComponent<RectTransform>().DOKill();
                Destroy(gameObject);
            });
        }
        else
        {
            transform.localPosition = new Vector3(450, 0, 0);
            _Lap1.Append(transform.DOLocalMoveY(150f + Random.Range(-50f, 50f), 2.5f).SetEase(Ease.InSine));
            _Lap1.Append(transform.DOLocalMoveY(0, 2.5f).SetEase(Ease.InSine));
            _Lap1.SetLoops(-1);
            _Lap1.Play();

            _Lap2.Append(transform.DOScale(1.4f, 0.5f).SetEase(Ease.Linear));
            _Lap2.Append(transform.DOScale(1.3f, 0.5f).SetEase(Ease.Linear));
            _Lap2.SetLoops(-1);
            _Lap2.Play();
            transform.DOLocalMoveX(-450, 10f).SetEase(Ease.Linear).OnComplete(() =>
            {
                _Lap1.Kill();
                _Lap2.Kill();
                transform.DOKill();
                GetComponent<RectTransform>().DOKill();
                Destroy(gameObject);
            });
        }
    }
}