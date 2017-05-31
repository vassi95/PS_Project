using KursovaPS.Model;
using KursovaPS.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace KursovaPS.ViewModel
{
    class MyViewModel : INotifyPropertyChanged
    {
        private ICommand playCommand;
        private ICommand rulesCommand;
        private ICommand audienceHelpCommand;
        private ICommand fiftyFiftyCommand;
        private ICommand answerSelected;
        private List<Question> questions;
        private string image;
        private string generalPath = "c:\\users\\i333468\\documents\\visual studio 2017\\Projects\\KursovaPS\\KursovaPS\\";
        private string extension = ".png";
        private static int counter = 1;
        private static int currentWin=0;
        private static int win = 0;
        private PlayWindow p;
        private string questionText;
        private Answer answer1;
        private Answer answer2;
        private Answer answer3;
        private Answer answer4;
        private bool isEnabled;
        private bool isEnabled2;

        private int current;

        public ICommand PlayCommand
            {
                get
                {
                    return playCommand;
                }
                set
            {
                    playCommand = value;
                }
            }
        public ICommand AnswerSelected
        {
            get
            {
                return answerSelected;
            }
            set
            {
                answerSelected = value;
            }
        }
        public ICommand RulesCommand
            {
                get
                {
                    return rulesCommand;
                }
                set
                {
                    rulesCommand = value;
                }
            }
            public ICommand AudienceHelpCommand
        {
                get
                {
                    return audienceHelpCommand;
                }
                set
                {
                audienceHelpCommand = value;
                }
            }
            public ICommand FiftyFiftyCommand
        {
                get
                {
                    return fiftyFiftyCommand;
                }
                set
                {
                fiftyFiftyCommand = value;
                }
            }
        
        public string QuestionText
        {
            get
            {
                return questionText;
            }
            set
            {
                questionText = value;
                NotifyPropertyChanged();
            }

        }
        public string Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                NotifyPropertyChanged();
            }

        }
        public Answer Answer1
        {
            get
            {
                return answer1;
            }
            set
            {
                answer1 = value;
                NotifyPropertyChanged();
            }

        }
        public Answer Answer2 {
            get
            {
                return answer2;
            }
            set
            {
                answer2 = value;                
                NotifyPropertyChanged();
            }
        }
        public Answer Answer3 {
            get
            {
                return answer3;
            }
            set
            {
                answer3 = value;
                NotifyPropertyChanged();
            }

        }

        public Answer Answer4
        {
            get
            {
                return answer4;
            }
            set
            {
                answer4 = value;
                NotifyPropertyChanged();
            }

        }

        public static int Win { get => win; set => win = value; }
        public bool IsEnabled
        {
            get
            {
                return isEnabled;

            }
            set
            {
                isEnabled = value;
                NotifyPropertyChanged();
            }
        }
        public bool IsEnabled2
        {
            get
            {
                return isEnabled2;

            }
            set
            {
                isEnabled2 = value;
                NotifyPropertyChanged();
            }
        }
        public MyViewModel()
            {
            IsEnabled = true;
            IsEnabled2 = true;
            Image = generalPath + counter.ToString() + extension;
            questions = XmlParser1.parseQuestions();
            PlayCommand = new RelayCommand(Play);
                RulesCommand = new RelayCommand(ShowRules);
                AudienceHelpCommand = new RelayCommand(Help);
                FiftyFiftyCommand = new RelayCommand(FiftyHelp);
            AnswerSelected = new RelayCommand(CheckAnswer);
            }
            public void Play(object obj)
            {

            changeContent();

            p = new PlayWindow();
            p.DataContext = this;
            p.Show();

            }

        public void ShowRules(object obj)
        {
            Rules r = new Rules();
            r.Show();
        }

        public void CheckAnswer(object sender)
        {
            if (sender.ToString().Equals("1"))
            {
                counter++;
                if(counter == 13)
                {
                    currentWin = 125000;
                }
                else if(counter>1 && counter < 5)
                {
                    currentWin += 100;
                }
                else if(counter>4 && counter < 6)
                {
                    currentWin += 200;
                }
                else
                {
                    currentWin *= 2;
                    if (currentWin == 1000)
                    {
                        Win = 1000;
                    }
                    else if(currentWin == 32000)
                    {
                        Win = 32000;
                    }
                    else if (currentWin == 1000000) {
                        Win = 1000000;
                        WinWin w = new WinWin();
                        p.Close();
                        w.Show();

                    }
                }
                Image = generalPath+ counter.ToString() + extension;
                questions.RemoveAt(current);

                changeContent();
            }
            else
            {
                if (win > 0)
                {
                    WinWin w = new WinWin();
                    p.Close();
                    w.Show();
                }
                else
                {
                    LoseWin l = new LoseWin();
                    p.Close();
                    l.Show();

                }
            }
        }


        public void Help(object obj)
            {
            MessageBox.Show(string.Format("A -> {0}\nB -> {1}\nC -> {2}\nD -> {3}", 28,25,23,24));
            IsEnabled2 = false;

        }

            public void FiftyHelp(object obj)
            {

            List<string> reduced = reduceAnswerCount();
            foreach(string s in reduced)
            {
                if (s.Equals(Answer1.Text))
                {
                    Answer1.Text = "";
                    Answer1 = Answer1;
                }
                else if (s.Equals(Answer2.Text))
                {
                    Answer2.Text = "";
                    Answer2 = Answer2;
                }
                else if (s.Equals(Answer3.Text))
                {
                    Answer3.Text = "";
                    Answer3 = Answer3;
                }
                else
                {
                    Answer4.Text = "";
                    Answer4 = Answer4;
                }
            }

            IsEnabled = false;

        }

        private List<string> reduceAnswerCount()
        {
            List<Answer> answers = new List<Answer>();
            List<string> reduced = new List<string>();
            answers.Add(Answer1);
            answers.Add(Answer2);
            answers.Add(Answer3);
            answers.Add(Answer4);

            foreach (Answer a in answers.ToList())
            {
                if (a.Score == 1)
                {
                    answers.Remove(a);
                }
            }

            Random rndm = new Random();
            answers.Remove(answers[rndm.Next(0, 3)]);
            reduced.Add(answers[0].Text);
            reduced.Add(answers[1].Text);

            return reduced;


        }

        public void changeContent()
        {
            Random random = new Random();
            current = random.Next(0, questions.Count()-1);
            Question q = questions.ElementAt(current);
            QuestionText = q.Text;
            Answer1 = q.getAnwers().ElementAt(0);
            Answer2 = q.getAnwers().ElementAt(1);
            Answer3 = q.getAnwers().ElementAt(2);
            Answer4 = q.getAnwers().ElementAt(3);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }




    }
}
