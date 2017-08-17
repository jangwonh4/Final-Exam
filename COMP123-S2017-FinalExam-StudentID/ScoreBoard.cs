using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_StudentID
{
    public class ScoreBoard
    {
        private int _score;
        private TextBox _finalScoreTextBox;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;
        public TextBox FinalScoreTextBox
        {

            get
            {
                return this._finalScoreTextBox;
            }

            set
            {
                this._finalScoreTextBox = value;
            }
        }
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
                this.ScoreTextBox.Text = this._score.ToString();
                this._finalScoreTextBox.Text = this._score.ToString();
            }
        } 
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
                this.TimeTextBox.Text = this._time.ToString();
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }

        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }

        public void UpdateTime()
        {
            int CurTime = int.Parse(TimeTextBox.Text);
            CurTime--;
            this.Time = CurTime;
            TimeTextBox.Text = this.Time.ToString();
        }
    }
}
