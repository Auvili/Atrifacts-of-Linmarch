using UnityEngine;
using Fungus;

public class SCR_StartMenu : MonoBehaviour
{
    public Flowchart Flow;
    public string blockname = "Start";
    public void StartGame()
    {
        Flow.ExecuteBlock(blockname);
    }

  public void QuitGame()
  {
    Application.Quit();
  }
}