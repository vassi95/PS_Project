using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaPS.Model
{
    class Answer
    {

        private int score;
        private String text;
        public Answer(int score, String text)
        {
            this.Score = score;
            this.Text = text;
        }

        public int Score { get => score; set => score = value; }
        public string Text { get => text; set => text = value; }
    }
}
