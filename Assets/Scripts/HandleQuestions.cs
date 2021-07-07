using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandleQuestions : MonoBehaviour
{
    public Questions questions= new Questions();
    public int questionsAnswered;
    public TextMeshProUGUI Artist;
    public TextMeshProUGUI numRight;
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
        Debug.Log(starting);
        Debug.Log(questions.allQuestions.Count);
        AddBobMarleyData();
        Artist.text = questions.allQuestions[2][questionsAnswered].artist;
        Question.text = questions.allQuestions[2][questionsAnswered].question;
        Option1.gameObject.SetActive(true);
        Option2.gameObject.SetActive(true);
        Option3.gameObject.SetActive(true);
        Option4.gameObject.SetActive(true);
        
        Option1.text = questions.allQuestions[2][questionsAnswered].answers[0];
        Option2.text = questions.allQuestions[2][questionsAnswered].answers[1];
        Option3.text = questions.allQuestions[2][questionsAnswered].answers[2];
        Option4.text = questions.allQuestions[2][questionsAnswered].answers[3];
    }
        

    public void ChooseOption1()
    {
        Debug.Log("Option 1");
        if (questions.allQuestions[2][questionsAnswered].correctAnswer == 0f)
        {           
            Correct();
        }
        else
            Incorrect();
    }
    public void ChooseOption2()
    {
        Debug.Log("Option 2");
        if (questions.allQuestions[2][questionsAnswered].correctAnswer == 1f)
        {
           Correct();
        }
        else
            Incorrect();
    }
    public void ChooseOption3()
    {
        Debug.Log("Option 3");
        if (questions.allQuestions[2][questionsAnswered].correctAnswer == 2f)
        {
            Correct();
        }
        else
            Incorrect();
    }
    public void ChooseOption4()
    {
        Debug.Log("Option 4");
        if (questions.allQuestions[2][questionsAnswered].correctAnswer == 3f)
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

        Artist.text = questions.allQuestions[2][questionsAnswered].artist;
        Question.text = questions.allQuestions[2][questionsAnswered].question;
        Option1.text = questions.allQuestions[2][questionsAnswered].answers[0];
        Option2.text = questions.allQuestions[2][questionsAnswered].answers[1];
        Option3.text = questions.allQuestions[2][questionsAnswered].answers[2];
        Option4.text = questions.allQuestions[2][questionsAnswered].answers[3];
    }

    
    public void Incorrect()
    {        
        Debug.Log("Incorrect! Correct Answer: " + questions.allQuestions[System.Convert.ToInt32(starting)][questionsAnswered].correctAnswer);
        questionsAnswered++;

        Artist.text = questions.allQuestions[2][questionsAnswered].artist;
        Question.text = questions.allQuestions[2][questionsAnswered].question;
        Option1.text = questions.allQuestions[2][questionsAnswered].answers[0];
        Option2.text = questions.allQuestions[2][questionsAnswered].answers[1];
        Option3.text = questions.allQuestions[2][questionsAnswered].answers[2];
        Option4.text = questions.allQuestions[2][questionsAnswered].answers[3];
    }
    // Update is called once per frame
    void Update()
    {
        if(questionsAnswered == 10)
        {
            Debug.Log("Here");
            questionsAnswered = 0;
            starting++;
            if (starting == 3)
                starting = 0;
            numRight.text = "You got " + PlayerData.Instance.numRight.ToString() + " right!";
            StartCoroutine("Waiter");
            Option1.gameObject.SetActive(false);
            Option2.gameObject.SetActive(false);
            Option3.gameObject.SetActive(false);
            Option4.gameObject.SetActive(false);

        }
        else
            numRight.text = "You have " + PlayerData.Instance.numRight.ToString() + " right!";
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(5);

         UnityEngine.SceneManagement.SceneManager.LoadScene(PlayerPrefs.GetString("_LastScene"));
    }

    public void ApplicationQuit()
    {
        Application.Quit();
    }

    public void AddBobMarleyData()        
    {
        List<Question> bobMarley = new List<Question>();
        List<string> q0 = new List<string>();
        q0.Add("45");
        q0.Add("36");
        q0.Add("33");
        q0.Add("50");
        Question question0 = new Question("How old was Bob Marley when he died?",q0,1,"Bob Marley");
        bobMarley.Add(question0);
        List<string> q1 = new List<string>();
        q1.Add("Nesta");
        q1.Add("Gabriel");
        q1.Add("Bartt");
        q1.Add("Dajuan");
        Question question1 = new Question("What was Bob Marley's Middle name?", q1, 0, "Bob Marley");
        bobMarley.Add(question1);
        List<string> q2 = new List<string>();
        q2.Add("Exodus");
        q2.Add("Soul Revolution");
        q2.Add("Burnin'");
        q2.Add("Soul Rebels");
        Question question2 = new Question("What was Bob Marley's first album?", q2, 3, "Bob Marley");
        bobMarley.Add(question2);
        questions.allQuestions.Add(bobMarley);
        List<string> q3 = new List<string>();
        q3.Add("1964");
        q3.Add("1967");
        q3.Add("1972");
        q3.Add("1975");
        Question question3 = new Question("What year did Bob Marley have his first child?", q3, 1, "Bob Marley");
        bobMarley.Add(question3);
        List<string> q4 = new List<string>();
        q4.Add("Swimming");
        q4.Add("Rugby");
        q4.Add("Cricket");
        q4.Add("Soccer");
        Question question4 = new Question("What was Bob Marleys favourite sport?", q4, 3, "Bob Marley");
        bobMarley.Add(question4);
        questions.allQuestions.Add(bobMarley);
        List<string> q5 = new List<string>();
        q5.Add("Hate");
        q5.Add("Indefferent");
        q5.Add("Sacred");
        q5.Add("Whats cannabis?");
        Question question5 = new Question("What was Bob Marley's view on Cannabis", q5, 2, "Bob Marley");
        bobMarley.Add(question5);
        questions.allQuestions.Add(bobMarley);
        List<string> q6 = new List<string>();
        q6.Add("England");
        q6.Add("Jamaica");
        q6.Add("Usa");
        q6.Add("Egypt");
        Question question6 = new Question("Where was Bob Marley born?", q6, 1, "Bob Marley");
        bobMarley.Add(question6);
        questions.allQuestions.Add(bobMarley);
        List<string> q7 = new List<string>();
        q7.Add("England");
        q7.Add("Jamaica");
        q7.Add("Usa");
        q7.Add("Egypt");
        Question question7 = new Question("Where did Bob Marley grow up?", q7, 0, "Bob Marley");
        bobMarley.Add(question7);
        questions.allQuestions.Add(bobMarley);
        List<string> q8 = new List<string>();
        q8.Add("15");
        q8.Add("10");
        q8.Add("12");
        q8.Add("13");
        Question question8 = new Question("What age was Bob Marley when his father died?", q8, 1, "Bob Marley");
        bobMarley.Add(question8);
        questions.allQuestions.Add(bobMarley);
        List<string> q9 = new List<string>();
        q9.Add("1965");
        q9.Add("1970");
        q9.Add("1985");
        q9.Add("1973");
        Question question9 = new Question("In what year did Bob Marley and The Wailers release their first studio album?", q9, 0, "Bob Marley");
        bobMarley.Add(question9);
        questions.allQuestions.Add(bobMarley);
    }
}
