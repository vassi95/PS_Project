using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace KursovaPS.Model
{
    class XmlParser1
    {

        public static List<Question> parseQuestions()
        {
            List<Question> questions = new List<Question>();
            List<Answer> answers = new List<Answer>();


            XmlDocument xmlDoc = new XmlDocument(); // Create an XML document object
            xmlDoc.Load("c:\\users\\i333468\\documents\\visual studio 2017\\Projects\\KursovaPS\\KursovaPS\\questions.xml");

            
            XmlNodeList nodelist = xmlDoc.DocumentElement.ChildNodes;
            

            foreach (XmlNode node in nodelist) // for each <testcase> node
            {
                try
                {
                    string questionText = node.FirstChild.InnerText;
                    XmlNodeList answersOfQuestion = node.SelectNodes("answer");
                    answers = parseAnswers(answersOfQuestion);

                    Question q = new Question(questionText,answers.ToArray<Answer>());
                    questions.Add(q);
                    
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error in reading XML", "xmlError", MessageBoxButtons.OK);
                }
            }
            return questions;

        }

        private static List<Answer> parseAnswers(XmlNodeList answersOfQuestion)
        {
            
            List<Answer> answers = new List<Answer>();


            
            foreach (XmlNode node in answersOfQuestion) // for each <testcase> node
            {
                try
                {
                    string answer = node.InnerText;
                    int score = int.Parse(node.Attributes["score"].Value);
                    Answer a = new Answer(score, answer);
                    answers.Add(a);

                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error in reading XML", "xmlError", MessageBoxButtons.OK);
                }
            }
            return answers;
        }


        }
    }
