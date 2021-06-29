using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions
{
    public List<List<Question>> allQuestions = new List<List<Question>>();
    List<Question> questions1 = new List<Question>();
    List<Question> questions2 = new List<Question>();
    List<string> genericAnswers = new List<string>();

    
    public void Start()
    {
        genericAnswers.Add("Option 1");
        genericAnswers.Add("Option 2");
        genericAnswers.Add("Option 3");
        genericAnswers.Add("Option 4");

        for (int i = 0; i < 10; i++)
        {
            Question q1 = new Question(("Question " + (i+1).ToString()),genericAnswers, ChooseRandom(0,4), "Artist 1");
            questions1.Add(q1);
            Question q2 = new Question(("Question " + (i+1).ToString()), genericAnswers, ChooseRandom(0,4), "Artist 2");
            questions2.Add(q2);
        }

        allQuestions.Add(questions1);
        allQuestions.Add(questions2);        
    }

    public static float ChooseRandom(float min, float max)
    {
        float ans = Random.Range(min, max);
        return ((float)System.Math.Round((double)ans, 0));
    }
}

public struct Question
{
    public string artist;
    public string question;
    public List<string> answers;
    public float correctAnswer;

    public Question(string q, List<string> a, float cA, string art)
    {
        question = q;
        answers = a;
        correctAnswer = cA;
        artist = art;
    }
}