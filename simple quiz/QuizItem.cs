using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleQuiz
{
    public class QuizItem
    {
        public string Text { get; set; }
        public QuizItem(string text) => Text = text;
    }
}