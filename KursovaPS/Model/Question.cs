using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaPS.Model
{
    class Question
    {


        private String text;

        private Answer[] answers = new Answer[4];

        public Question(String text, Answer[] answers)
        {
            this.Text = text;
            this.answers = answers;

        
        }

       public string Text { get => text; set => text = value; }

        public Answer[] getAnwers()
        {
            return answers;
        }

    }
}
