using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerDeutschenNichtigkeiten
{
    public partial class Form2 : Form
    {
        int actualQuest = 0;
        int points = 0;
        string myAnswer;
        Selectare_Limba limba = new Selectare_Limba();

        Question quest1 = new Question("Which was the capital of the GDR (German Democratic Republic)?", "Berlin", "Hamburg", "Bremen", "Bonn");
        Question quest2 = new Question("Which was the capital of the West Germany?", "Bonn", "Mainz", "Dresden", "Hannover");
        Question quest3 = new Question("Who is a famous german Formula One driver?", " Michael Schumacher", "Fernando Alonso", "Lewis Hamilton", "Daniil Kvyat");
        Question quest4 = new Question("How was the wall that divided the country named?", "The Berlin Wall", "The München Wall", "The Bremen Wall", "The Hamburg Wall");
        Question quest5 = new Question("Who was a good german tennis player? (He won two Wimbledon titles.)", "Boris Becker", "Simona Halep", "Roger Federer", "Björn Borg");
        Question quest6 = new Question("In which year did the FIFA World Cup take place in Germany?", "2006", "2002", "1986", "2010");
        Question quest7 = new Question("Which one is a german tradition?", "Oktoberfest", "Sharpen teeth", "Burns Night", "Songkran");
        Question quest8 = new Question("How do you travel in Wuppertal?", "By hanging trains", "Taxi", "Walking", "By bus");
        Question quest9 = new Question("Which traditional dish do the Germans eat after a hard day's work?", "Sausage", "Tiramisu", "Meatballs", "Salad");
        Question quest10 = new Question("Which country is located below Germany?", "Switzerland", "Spain", "France", "Norway");

        public Form2()
        {
            InitializeComponent();
            NextQuestion();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int lastBtn = 0;

        public void NextQuestion()
        {
            button_WOC1.Text = "";
            button_WOC2.Text = "";
            button_WOC3.Text = "";
            button_WOC4.Text = "";
            button_WOC5.Text = "";

            if (actualQuest == 0)
            {
                button_WOC5.Text = quest1.Prep;
                Random rand = new Random();
                int n = rand.Next(1, 4); //hotaram unde punem GoodAnswer

                if (n == 1) //punem GoodAnswer
                    button_WOC1.Text = quest1.GoodAnswer;
                else if (n == 2)
                    button_WOC2.Text = quest1.GoodAnswer;
                else if (n == 3)
                    button_WOC3.Text = quest1.GoodAnswer;
                else if (n == 4)
                    button_WOC4.Text = quest1.GoodAnswer;

                if (button_WOC1.Text == "") //punem Answer2
                    button_WOC1.Text = quest1.Answer2;
                else button_WOC2.Text = quest1.Answer2;

                if (button_WOC2.Text == "") //punem Answer3
                    button_WOC2.Text = quest1.Answer3;
                else button_WOC3.Text = quest1.Answer3;

                if (button_WOC3.Text == "") //punem Answer4
                    button_WOC3.Text = quest1.Answer4;
                else button_WOC4.Text = quest1.Answer4;
            }

            if (actualQuest == 1)
            {
                if (myAnswer == quest1.GoodAnswer) //verificam daca e raspunsul bun
                    points++;

                button_WOC5.Text = quest2.Prep;
                Random rand = new Random();
                int n = rand.Next(1, 4); //hotaram unde punem GoodAnswer

                if (n == 1) //punem GoodAnswer
                    button_WOC1.Text = quest2.GoodAnswer;
                else if (n == 2)
                    button_WOC2.Text = quest2.GoodAnswer;
                else if (n == 3)
                    button_WOC3.Text = quest2.GoodAnswer;
                else if (n == 4)
                    button_WOC4.Text = quest2.GoodAnswer;

                if (button_WOC1.Text == "") //punem Answer2
                    button_WOC1.Text = quest2.Answer2;
                else button_WOC2.Text = quest2.Answer2;

                if (button_WOC2.Text == "") //punem Answer3
                    button_WOC2.Text = quest2.Answer3;
                else button_WOC3.Text = quest2.Answer3;

                if (button_WOC3.Text == "") //punem Answer4
                    button_WOC3.Text = quest2.Answer4;
                else button_WOC4.Text = quest2.Answer4;
            }

            if (actualQuest == 2)
            {
                if (myAnswer == quest2.GoodAnswer) //verificam daca e raspunsul bun
                    points++;

                button_WOC5.Text = quest3.Prep;
                Random rand = new Random();
                int n = rand.Next(1, 4); //hotaram unde punem GoodAnswer

                if (n == 1) //punem GoodAnswer
                    button_WOC1.Text = quest3.GoodAnswer;
                else if (n == 2)
                    button_WOC2.Text = quest3.GoodAnswer;
                else if (n == 3)
                    button_WOC3.Text = quest3.GoodAnswer;
                else if (n == 4)
                    button_WOC4.Text = quest3.GoodAnswer;

                if (button_WOC1.Text == "") //punem Answer2
                    button_WOC1.Text = quest3.Answer2;
                else button_WOC2.Text = quest3.Answer2;

                if (button_WOC2.Text == "") //punem Answer3
                    button_WOC2.Text = quest3.Answer3;
                else button_WOC3.Text = quest3.Answer3;

                if (button_WOC3.Text == "") //punem Answer4
                    button_WOC3.Text = quest3.Answer4;
                else button_WOC4.Text = quest3.Answer4;
            }

            if (actualQuest == 3)
            {
                if (myAnswer == quest3.GoodAnswer) //verificam daca e raspunsul bun
                    points++;

                button_WOC5.Text = quest4.Prep;
                Random rand = new Random();
                int n = rand.Next(1, 4); //hotaram unde punem GoodAnswer

                if (n == 1) //punem GoodAnswer
                    button_WOC1.Text = quest4.GoodAnswer;
                else if (n == 2)
                    button_WOC2.Text = quest4.GoodAnswer;
                else if (n == 3)
                    button_WOC3.Text = quest4.GoodAnswer;
                else if (n == 4)
                    button_WOC4.Text = quest4.GoodAnswer;

                if (button_WOC1.Text == "") //punem Answer2
                    button_WOC1.Text = quest4.Answer2;
                else button_WOC2.Text = quest4.Answer2;

                if (button_WOC2.Text == "") //punem Answer3
                    button_WOC2.Text = quest4.Answer3;
                else button_WOC3.Text = quest4.Answer3;

                if (button_WOC3.Text == "") //punem Answer4
                    button_WOC3.Text = quest4.Answer4;
                else button_WOC4.Text = quest4.Answer4;
            }

            if (actualQuest == 4)
            {
                if (myAnswer == quest4.GoodAnswer) //verificam daca e raspunsul bun
                    points++;

                button_WOC5.Text = quest5.Prep;
                Random rand = new Random();
                int n = rand.Next(1, 4); //hotaram unde punem GoodAnswer

                if (n == 1) //punem GoodAnswer
                    button_WOC1.Text = quest5.GoodAnswer;
                else if (n == 2)
                    button_WOC2.Text = quest5.GoodAnswer;
                else if (n == 3)
                    button_WOC3.Text = quest5.GoodAnswer;
                else if (n == 4)
                    button_WOC4.Text = quest5.GoodAnswer;

                if (button_WOC1.Text == "") //punem Answer2
                    button_WOC1.Text = quest5.Answer2;
                else button_WOC2.Text = quest5.Answer2;

                if (button_WOC2.Text == "") //punem Answer3
                    button_WOC2.Text = quest5.Answer3;
                else button_WOC3.Text = quest5.Answer3;

                if (button_WOC3.Text == "") //punem Answer4
                    button_WOC3.Text = quest5.Answer4;
                else button_WOC4.Text = quest5.Answer4;
            }

            if (actualQuest == 5)
            {
                if (myAnswer == quest5.GoodAnswer) //verificam daca e raspunsul bun
                    points++;

                button_WOC5.Text = quest6.Prep;
                Random rand = new Random();
                int n = rand.Next(1, 4); //hotaram unde punem GoodAnswer

                if (n == 1) //punem GoodAnswer
                    button_WOC1.Text = quest6.GoodAnswer;
                else if (n == 2)
                    button_WOC2.Text = quest6.GoodAnswer;
                else if (n == 3)
                    button_WOC3.Text = quest6.GoodAnswer;
                else if (n == 4)
                    button_WOC4.Text = quest6.GoodAnswer;

                if (button_WOC1.Text == "") //punem Answer2
                    button_WOC1.Text = quest6.Answer2;
                else button_WOC2.Text = quest6.Answer2;

                if (button_WOC2.Text == "") //punem Answer3
                    button_WOC2.Text = quest6.Answer3;
                else button_WOC3.Text = quest6.Answer3;

                if (button_WOC3.Text == "") //punem Answer4
                    button_WOC3.Text = quest6.Answer4;
                else button_WOC4.Text = quest6.Answer4;
            }

            if (actualQuest == 6)
            {
                if (myAnswer == quest6.GoodAnswer) //verificam daca e raspunsul bun
                    points++;

                button_WOC5.Text = quest7.Prep;
                Random rand = new Random();
                int n = rand.Next(1, 4); //hotaram unde punem GoodAnswer

                if (n == 1) //punem GoodAnswer
                    button_WOC1.Text = quest7.GoodAnswer;
                else if (n == 2)
                    button_WOC2.Text = quest7.GoodAnswer;
                else if (n == 3)
                    button_WOC3.Text = quest7.GoodAnswer;
                else if (n == 4)
                    button_WOC4.Text = quest7.GoodAnswer;

                if (button_WOC1.Text == "") //punem Answer2
                    button_WOC1.Text = quest7.Answer2;
                else button_WOC2.Text = quest7.Answer2;

                if (button_WOC2.Text == "") //punem Answer3
                    button_WOC2.Text = quest7.Answer3;
                else button_WOC3.Text = quest7.Answer3;

                if (button_WOC3.Text == "") //punem Answer4
                    button_WOC3.Text = quest7.Answer4;
                else button_WOC4.Text = quest7.Answer4;
            }

            if (actualQuest == 7)
            {
                if (myAnswer == quest7.GoodAnswer) //verificam daca e raspunsul bun
                    points++;

                button_WOC5.Text = quest8.Prep;
                Random rand = new Random();
                int n = rand.Next(1, 4); //hotaram unde punem GoodAnswer

                if (n == 1) //punem GoodAnswer
                    button_WOC1.Text = quest8.GoodAnswer;
                else if (n == 2)
                    button_WOC2.Text = quest8.GoodAnswer;
                else if (n == 3)
                    button_WOC3.Text = quest8.GoodAnswer;
                else if (n == 4)
                    button_WOC4.Text = quest8.GoodAnswer;

                if (button_WOC1.Text == "") //punem Answer2
                    button_WOC1.Text = quest8.Answer2;
                else button_WOC2.Text = quest8.Answer2;

                if (button_WOC2.Text == "") //punem Answer3
                    button_WOC2.Text = quest8.Answer3;
                else button_WOC3.Text = quest8.Answer3;

                if (button_WOC3.Text == "") //punem Answer4
                    button_WOC3.Text = quest8.Answer4;
                else button_WOC4.Text = quest8.Answer4;
            }

            if (actualQuest == 8)
            {
                if (myAnswer == quest8.GoodAnswer) //verificam daca e raspunsul bun
                    points++;

                button_WOC5.Text = quest9.Prep;
                Random rand = new Random();
                int n = rand.Next(1, 4); //hotaram unde punem GoodAnswer

                if (n == 1) //punem GoodAnswer
                    button_WOC1.Text = quest9.GoodAnswer;
                else if (n == 2)
                    button_WOC2.Text = quest9.GoodAnswer;
                else if (n == 3)
                    button_WOC3.Text = quest9.GoodAnswer;
                else if (n == 4)
                    button_WOC4.Text = quest9.GoodAnswer;

                if (button_WOC1.Text == "") //punem Answer2
                    button_WOC1.Text = quest9.Answer2;
                else button_WOC2.Text = quest9.Answer2;

                if (button_WOC2.Text == "") //punem Answer3
                    button_WOC2.Text = quest9.Answer3;
                else button_WOC3.Text = quest9.Answer3;

                if (button_WOC3.Text == "") //punem Answer4
                    button_WOC3.Text = quest9.Answer4;
                else button_WOC4.Text = quest9.Answer4;
            }

            if (actualQuest == 9)
            {
                if (myAnswer == quest9.GoodAnswer) //verificam daca e raspunsul bun
                    points++;

                button_WOC5.Text = quest10.Prep;
                Random rand = new Random();
                int n = rand.Next(1, 4); //hotaram unde punem GoodAnswer

                if (n == 1) //punem GoodAnswer
                    button_WOC1.Text = quest10.GoodAnswer;
                else if (n == 2)
                    button_WOC2.Text = quest10.GoodAnswer;
                else if (n == 3)
                    button_WOC3.Text = quest10.GoodAnswer;
                else if (n == 4)
                    button_WOC4.Text = quest10.GoodAnswer;

                if (button_WOC1.Text == "") //punem Answer2
                    button_WOC1.Text = quest10.Answer2;
                else button_WOC2.Text = quest10.Answer2;

                if (button_WOC2.Text == "") //punem Answer3
                    button_WOC2.Text = quest10.Answer3;
                else button_WOC3.Text = quest10.Answer3;

                if (button_WOC3.Text == "") //punem Answer4
                    button_WOC3.Text = quest10.Answer4;
                else button_WOC4.Text = quest10.Answer4;
            }

            if (actualQuest == 10)
            {
                if (myAnswer == quest10.GoodAnswer) //verificam daca e raspunsul bun
                    points++;

                button_WOC1.Visible = false;
                button_WOC2.Visible = false;
                button_WOC3.Visible = false;
                button_WOC4.Visible = false;
                button_WOC5.Visible = false;
                button_WOC6.Visible = true;
                label2.Text = "You've obtained " + points + " points!";
                label2.Visible = true;
                points = 0;
            }

            actualQuest++;
        } 

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            lastBtn = 1;
            myAnswer = button_WOC1.Text;

            if (actualQuest == 1)
            {
                if (button_WOC1.Text == quest1.GoodAnswer)
                {
                    button_WOC1.ButtonColor = Color.Green;
                    button_WOC1.OnHoverButtonColor = Color.Green;
                }
                else
                {
                    button_WOC1.ButtonColor = Color.Red;
                    button_WOC1.OnHoverButtonColor = Color.Red;
                }
            }
            else if (actualQuest == 2)
            {
                if (button_WOC1.Text == quest2.GoodAnswer)
                {
                    button_WOC1.ButtonColor = Color.Green;
                    button_WOC1.OnHoverButtonColor = Color.Green;
                }
                else
                {
                    button_WOC1.ButtonColor = Color.Red;
                    button_WOC1.OnHoverButtonColor = Color.Red;
                }
            }
            else if (actualQuest == 3)
            {
                if (button_WOC1.Text == quest3.GoodAnswer)
                {
                    button_WOC1.ButtonColor = Color.Green;
                    button_WOC1.OnHoverButtonColor = Color.Green;
                }
                else
                {
                    button_WOC1.ButtonColor = Color.Red;
                    button_WOC1.OnHoverButtonColor = Color.Red;
                }
            }
            else if (actualQuest == 4)
            {
                if (button_WOC1.Text == quest4.GoodAnswer)
                {
                    button_WOC1.ButtonColor = Color.Green;
                    button_WOC1.OnHoverButtonColor = Color.Green;
                }
                else
                {
                    button_WOC1.ButtonColor = Color.Red;
                    button_WOC1.OnHoverButtonColor = Color.Red;
                }
            }
            else if (actualQuest == 5)
            {
                if (button_WOC1.Text == quest5.GoodAnswer)
                {
                    button_WOC1.ButtonColor = Color.Green;
                    button_WOC1.OnHoverButtonColor = Color.Green;
                }
                else
                {
                    button_WOC1.ButtonColor = Color.Red;
                    button_WOC1.OnHoverButtonColor = Color.Red;
                }
            }
            else if (actualQuest == 6)
            {
                if (button_WOC1.Text == quest6.GoodAnswer)
                {
                    button_WOC1.ButtonColor = Color.Green;
                    button_WOC1.OnHoverButtonColor = Color.Green;
                }
                else
                {
                    button_WOC1.ButtonColor = Color.Red;
                    button_WOC1.OnHoverButtonColor = Color.Red;
                }
            }
            else if (actualQuest == 7)
            {
                if (button_WOC1.Text == quest7.GoodAnswer)
                {
                    button_WOC1.ButtonColor = Color.Green;
                    button_WOC1.OnHoverButtonColor = Color.Green;
                }
                else
                {
                    button_WOC1.ButtonColor = Color.Red;
                    button_WOC1.OnHoverButtonColor = Color.Red;
                }
            }
            else if (actualQuest == 8)
            {
                if (button_WOC1.Text == quest8.GoodAnswer)
                {
                    button_WOC1.ButtonColor = Color.Green;
                    button_WOC1.OnHoverButtonColor = Color.Green;
                }
                else
                {
                    button_WOC1.ButtonColor = Color.Red;
                    button_WOC1.OnHoverButtonColor = Color.Red;
                }
            }
            else if (actualQuest == 9)
            {
                if (button_WOC1.Text == quest9.GoodAnswer)
                {
                    button_WOC1.ButtonColor = Color.Green;
                    button_WOC1.OnHoverButtonColor = Color.Green;
                }
                else
                {
                    button_WOC1.ButtonColor = Color.Red;
                    button_WOC1.OnHoverButtonColor = Color.Red;
                }
            }
            else if (actualQuest == 10)
            {
                if (button_WOC1.Text == quest10.GoodAnswer)
                {
                    button_WOC1.ButtonColor = Color.Green;
                    button_WOC1.OnHoverButtonColor = Color.Green;
                }
                else
                {
                    button_WOC1.ButtonColor = Color.Red;
                    button_WOC1.OnHoverButtonColor = Color.Red;
                }
            }

            timer1.Start();
        }

        private void button_WOC3_Click_1(object sender, EventArgs e)
        {
            lastBtn = 3;
            myAnswer = button_WOC3.Text;

            if (actualQuest == 1 && button_WOC3.Text == quest1.GoodAnswer)
            {
                button_WOC3.ButtonColor = Color.Green;
                button_WOC3.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 2 && button_WOC3.Text == quest2.GoodAnswer)
            {
                button_WOC3.ButtonColor = Color.Green;
                button_WOC3.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 3 && button_WOC3.Text == quest3.GoodAnswer)
            {
                button_WOC3.ButtonColor = Color.Green;
                button_WOC3.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 4 && button_WOC3.Text == quest4.GoodAnswer)
            {
                button_WOC3.ButtonColor = Color.Green;
                button_WOC3.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 5 && button_WOC3.Text == quest5.GoodAnswer)
            {
                button_WOC3.ButtonColor = Color.Green;
                button_WOC3.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 6 && button_WOC3.Text == quest6.GoodAnswer)
            {
                button_WOC3.ButtonColor = Color.Green;
                button_WOC3.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 7 && button_WOC3.Text == quest7.GoodAnswer)
            {
                button_WOC3.ButtonColor = Color.Green;
                button_WOC3.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 8 && button_WOC3.Text == quest8.GoodAnswer)
            {
                button_WOC3.ButtonColor = Color.Green;
                button_WOC3.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 9 && button_WOC3.Text == quest9.GoodAnswer)
            {
                button_WOC3.ButtonColor = Color.Green;
                button_WOC3.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 10 && button_WOC3.Text == quest10.GoodAnswer)
            {
                button_WOC3.ButtonColor = Color.Green;
                button_WOC3.OnHoverButtonColor = Color.Green;
            }
            else
            {
                button_WOC3.ButtonColor = Color.Red;
                button_WOC3.OnHoverButtonColor = Color.Red;
            }

            timer1.Start();
        }

        private void button_WOC2_Click_1(object sender, EventArgs e)
        {
            lastBtn = 2;
            myAnswer = button_WOC2.Text;

            if (actualQuest == 1 && button_WOC2.Text == quest1.GoodAnswer)
            {
                button_WOC2.ButtonColor = Color.Green;
                button_WOC2.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 2 && button_WOC2.Text == quest2.GoodAnswer)
            {
                button_WOC2.ButtonColor = Color.Green;
                button_WOC2.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 3 && button_WOC2.Text == quest3.GoodAnswer)
            {
                button_WOC2.ButtonColor = Color.Green;
                button_WOC2.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 4 && button_WOC2.Text == quest4.GoodAnswer)
            {
                button_WOC2.ButtonColor = Color.Green;
                button_WOC2.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 5 && button_WOC2.Text == quest5.GoodAnswer)
            {
                button_WOC2.ButtonColor = Color.Green;
                button_WOC2.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 6 && button_WOC2.Text == quest6.GoodAnswer)
            {
                button_WOC2.ButtonColor = Color.Green;
                button_WOC2.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 7 && button_WOC2.Text == quest7.GoodAnswer)
            {
                button_WOC2.ButtonColor = Color.Green;
                button_WOC2.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 8 && button_WOC2.Text == quest8.GoodAnswer)
            {
                button_WOC2.ButtonColor = Color.Green;
                button_WOC2.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 9 && button_WOC2.Text == quest9.GoodAnswer)
            {
                button_WOC2.ButtonColor = Color.Green;
                button_WOC2.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 10 && button_WOC2.Text == quest10.GoodAnswer)
            {
                button_WOC2.ButtonColor = Color.Green;
                button_WOC2.OnHoverButtonColor = Color.Green;
            }
            else
            {
                button_WOC2.ButtonColor = Color.Red;
                button_WOC2.OnHoverButtonColor = Color.Red;
            }

            timer1.Start();
        }

        private void button_WOC4_Click_1(object sender, EventArgs e)
        {
            lastBtn = 4;
            myAnswer = button_WOC4.Text;

            if (actualQuest == 1 && button_WOC4.Text == quest1.GoodAnswer)
            {
                button_WOC4.ButtonColor = Color.Green;
                button_WOC4.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 2 && button_WOC4.Text == quest2.GoodAnswer)
            {
                button_WOC4.ButtonColor = Color.Green;
                button_WOC4.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 3 && button_WOC4.Text == quest3.GoodAnswer)
            {
                button_WOC4.ButtonColor = Color.Green;
                button_WOC4.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 4 && button_WOC4.Text == quest4.GoodAnswer)
            {
                button_WOC4.ButtonColor = Color.Green;
                button_WOC4.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 5 && button_WOC4.Text == quest5.GoodAnswer)
            {
                button_WOC4.ButtonColor = Color.Green;
                button_WOC4.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 6 && button_WOC4.Text == quest6.GoodAnswer)
            {
                button_WOC4.ButtonColor = Color.Green;
                button_WOC4.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 7 && button_WOC4.Text == quest7.GoodAnswer)
            {
                button_WOC4.ButtonColor = Color.Green;
                button_WOC4.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 8 && button_WOC4.Text == quest8.GoodAnswer)
            {
                button_WOC4.ButtonColor = Color.Green;
                button_WOC4.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 9 && button_WOC4.Text == quest9.GoodAnswer)
            {
                button_WOC4.ButtonColor = Color.Green;
                button_WOC4.OnHoverButtonColor = Color.Green;
            }
            else if (actualQuest == 10 && button_WOC4.Text == quest10.GoodAnswer)
            {
                button_WOC4.ButtonColor = Color.Green;
                button_WOC4.OnHoverButtonColor = Color.Green;
            }
            else
            {
                button_WOC4.ButtonColor = Color.Red;
                button_WOC4.OnHoverButtonColor = Color.Red;
            }

            timer1.Start();
        }

        private void button_WOC6_Click_1(object sender, EventArgs e)
        {
            button_WOC7.Visible = true;
            label2.Visible = false;
            button_WOC6.Visible = false;
            pictureBox3.Visible = true;
            label3.Visible = true;
            actualQuest = 0;
            NextQuestion();
        }

        private void button_WOC7_Click_1(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            button_WOC1.Visible = true;
            button_WOC2.Visible = true;
            button_WOC3.Visible = true;
            button_WOC4.Visible = true;
            button_WOC5.Visible = true;
            label3.Visible = false;
            button_WOC7.Visible = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            button_WOC1.ButtonColor = Color.CornflowerBlue;
            button_WOC1.OnHoverButtonColor = Color.DeepSkyBlue;

            button_WOC2.ButtonColor = Color.CornflowerBlue;
            button_WOC2.OnHoverButtonColor = Color.DeepSkyBlue;

            button_WOC3.ButtonColor = Color.CornflowerBlue;
            button_WOC3.OnHoverButtonColor = Color.DeepSkyBlue;

            button_WOC4.ButtonColor = Color.CornflowerBlue;
            button_WOC4.OnHoverButtonColor = Color.DeepSkyBlue;

            NextQuestion();
            timer1.Stop();
        }
    }
}
