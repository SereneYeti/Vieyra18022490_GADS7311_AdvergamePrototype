using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandleQuestions : MonoBehaviour
{
    public Questions questions= new Questions();
    public int questionsAnswered;
    public TextMeshProUGUI Artist;
    public TextMeshProUGUI Question;
    public TextMeshProUGUI Option1;
    public TextMeshProUGUI Option2;
    public TextMeshProUGUI Option3;
    public TextMeshProUGUI Option4;
    int starting = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        questions.Start();
        questionsAnswered = 0;
        PlayerData.Instance.numRight = 0;
        starting = 0;
        Artist.text = questions.allQuestions[starting][questionsAnswered].artist;
        Question.text = questions.allQuestions[starting][questionsAnswered].question;
        Option1. text = questions.allQuestions[starting][questionsAnswered].answers[0];
        Option2.text = questions.allQuestions[starting][questionsAnswered].answers[1];
        Option3.text = questions.allQuestions[starting][questionsAnswered].answers[2];
        Option4.text = questions.allQuestions[starting][questionsAnswered].answers[3];
    }

    public void ChooseOption1()
    {
        Debug.Log("Option 1");
        if (questions.allQuestions[starting][questionsAnswered].correctAnswer == 0f)
        {           
            Correct();
        }
        else
            Incorrect();
    }
    public void ChooseOption2()
    {
        Debug.Log("Option 2");
        if (questions.allQuestions[starting][questionsAnswered].correctAnswer == 1f)
        {
           Correct();
        }
        else
            Incorrect();
    }
    public void ChooseOption3()
    {
        Debug.Log("Option 3");
        if (questions.allQuestions[starting][questionsAnswered].correctAnswer == 2f)
        {
            Correct();
        }
        else
            Incorrect();
    }
    public void ChooseOption4()
    {
        Debug.Log("Option 4");
        if (questions.allQuestions[starting][questionsAnswered].correctAnswer == 3f)
        {
            Correct();
        }
        else
            Incorrect();
    }

    public void Correct()
    {
        Debug.Log("Correct!");

        questionsAnswered++;
        PlayerData.Instance.numRight++;

        Artist.text = questions.allQuestions[starting][questionsAnswered].artist;
        Question.text = questions.allQuestions[starting][questionsAnswered].question;
        Option1.text = questions.allQuestions[starting][questionsAnswered].answers[0];
        Option2.text = questions.allQuestions[starting][questionsAnswered].answers[1];
        Option3.text = questions.allQuestions[starting][questionsAnswered].answers[2];
        Option4.text = questions.allQuestions[starting][questionsAnswered].answers[3];
    }

    
    public void Incorrect()
    {        
        Debug.Log("Incorrect! Correct Answer: " + questions.allQuestions[System.Convert.ToInt32(starting)][questionsAnswered].correctAnswer);
        questionsAnswered++;

        Artist.text = questions.allQuestions[System.Convert.ToInt32(starting)][questionsAnswered].artist;
        Question.text = questions.allQuestions[System.Convert.ToInt32(starting)][questionsAnswered].question;
        Option1.text = questions.allQuestions[System.Convert.ToInt32(starting)][questionsAnswered].answers[0];
        Option2.text = questions.allQuestions[System.Convert.ToInt32(starting)][questionsAnswered].answers[1];
        Option3.text = questions.allQuestions[System.Convert.ToInt32(starting)][questionsAnswered].answers[2];
        Option4.text = questions.allQuestions[System.Convert.ToInt32(starting)][questionsAnswered].answers[3];
    }
    // Update is called once per frame
    void Update()
    {
        if(questionsAnswered == 9)
        {
            Debug.Log("Here");
            questionsAnswered = 0;
            starting++;
            if (starting == 3)
                starting = 0;
            Artist.text = "You got " + PlayerData.Instance.numRight.ToString() + " right!";
            StartCoroutine("Waiter");
           
        }
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(5);

         UnityEngine.SceneManagement.SceneManager.LoadScene(PlayerPrefs.GetString("_LastScene"));
    }
}
