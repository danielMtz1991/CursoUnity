using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button TrueBtn;
    public Button FalseBtn;                      
    public GameImageElementComponent GameCircle;
    public GameTextElementComponent GameText;
    public ScoreHandler scoreHandler;
    public ColorProperties[] availableColors;

    private void Start()
    {
        ChangeColors();
    }
    public void ChangeColors()
    {
        int randColorGameCircle = Random.Range(0, availableColors.Length - 1);
        int randColorGameText = Random.Range(0, availableColors.Length - 1);

        GameText.SetNewColor(availableColors[randColorGameCircle], availableColors[randColorGameText]);
        GameCircle.SetNewColor(availableColors[randColorGameCircle]);
    }
    public void checkAnswer(bool _answer)
    {
        if(GameCircle.myColor == GameText.myColor && _answer)
        {
            scoreHandler.UpdateScore();
        }
        else if(GameCircle.myColor != GameText.myColor && _answer == false)
        {
            scoreHandler.UpdateScore();
              
        }
        else
        {
            scoreHandler.UpdateColor(availableColors,"RED");
        }
        ChangeColors();
    }

}

