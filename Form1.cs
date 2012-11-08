using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormCows : Form
    {
        private string s;
        private int[,] mat=new int[10000,4];//All possible solutions
        private List<int> matl=new List<int>();//the list of rows in mat which are possible solutions
        private List<int>matl2=new List<int>();//working set, helps...
        //private List<int>::iterator it;//for matl;
        private int[] num=new int[4];//THE NUMBER THAT WE ARE LOOKING FOR
        private int[] question=new int[4];//Currently asked question
        private int[] question2=new int[4];//We check all possible solutions with question[4], it's a workin array
        private int cows,bulls;//The answer from each solution with  our question	///NOT WITH NUM!!! With quetion[4]
        private int Rcows,Rbulls;//the real cows and bulls we have from question[4] and num[4]
        private string[] str = new string[15];
        private Random rand;

        //For Testing
        private int[] testmat = new int[15];
        private double average;
        private string[] outstr = new string[15];

        //Counters 
        private int r;		//counts questions
        private int e; 		//counts deleted solutions

        /**
	    Initialize is to make a 2D-matrix mat[5050][4] and a list of all possible solutions
        */
        private void initialize()
        {
            //set counters:: 
            r = 1; //r-question counter;
            e = 0; //e-removed positions counter;
            Rcows = Rbulls = 0;
            rand = new Random((int)DateTime.Now.Ticks);

            int k = 0;
            for (int i1 = 0; i1 < 10; i1++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    for (int i3 = 0; i3 < 10; i3++)
                    {
                        for (int i4 = 0; i4 < 10; i4++)
                        {
                            if (i1 != i2 && i1 != i3 && i1 != i4 && i2 != i3 && i2 != i4 && i3 != i4)
                            {
                                mat[k,0] = i1;
                                mat[k,1] = i2;
                                mat[k,2] = i3;
                                mat[k,3] = i4;
                                matl2.Add(k);
                                matl.Add(k++);
                            }
                        }
                    }
                }
            }
        }

        /**
bool genquest() is generator of questions. It generates question from the possible solutions we have at the moment 

returs:
	true if possible solutions > 0
	false if there are no possible solutions and we still have no correct answer.

*/
        private bool genquest()
        {
            int w;//To make questions random...
            if (matl.Count() > 0)
            {
                w = rand.Next(1, matl.Count);
                question[0] = mat[matl.ElementAt<int>(w-1), 0];
                question[1] = mat[matl.ElementAt<int>(w-1), 1];
                question[2] = mat[matl.ElementAt<int>(w-1), 2];
                question[3] = mat[matl.ElementAt<int>(w-1), 3];
                if (Rbulls < 4)
                {
                    str[r-1]="Question "+r+" "+question[0].ToString() + question[1].ToString() + question[2].ToString() + question[3].ToString();
                    
                }
                Output.Lines = str;
                return true;
            }
            else
            {
                str[r] = "NOT POSSIBLE, YOU MADE A MISTAKE!\n";
                Output.Lines = str;
                autocheck_enabled(false);
                return false;
            }
            
        }

        /**
        void genquest(set <int>::iterator t) the same but with position on the list with all possible solutions
        */
        private void genquest(int t)
        {
	        question2[0]=mat[t,0];
	        question2[1]=mat[t,1];
	        question2[2]=mat[t,2];
	        question2[3]=mat[t,3];

        }

        /**
        Get an answer for question with num
        */
        private void answer()
        {
            Rcows = Rbulls = 0;

            if (Automatic.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (question[i] == num[j])
                        {
                            if (i == j) Rbulls++;
                            else Rcows++;
                        }
                    }
                }
            }
            else 
            {





            }
            str[r-1] += "  " + Rcows + "C " + Rbulls + "B";
            Output.Lines = str;
            r++;
            //Rcows=cows;//the cows and bulls we have
            //Rbulls=bulls;


        }
        /**
         Get an answer for question2 with qustion	// I should have done this with one function only with parametyrs int* p1 int* p2.... Later.
         */
        void answer2()
        {
            cows = bulls = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (question2[i] == question[j])
                    {
                        if (i == j) bulls++;
                        else cows++;
                    }
                }
            }

        }
        private void remove_posible()
        {
            e = 0;

            for (int i = 0; i < matl.Count(); )
            {
                //cout << *it << " ";
                genquest(matl.ElementAt<int>(i));
                answer2();
                if ((cows == Rcows && bulls == Rbulls))
                {
                    i++;
                }
                else 
                {
                    matl.Remove(matl.ElementAt<int>(i));
                }
            }
            //matl.Clear();
            //matl = matl2;
            //matl2.Clear();
        }

        private void solve()
        {

            while (genquest() && Rbulls < 4)    //until we can gen questions, we do it..  or Bulls < 4
            {
                answer();                       //check the answer for this question
                remove_posible();               //remove possible 
            }
            str[r] = "WINNER!!!";
            Output.Lines = str;
        }

        private void solve2()
        {
            
            if (Rbulls < 4)
            {
                genquest();
                CowsForm.Value = 0;
                BullsForm.Value = 0;
                ButtonAnswer.Enabled = true;
            }
            else 
            {
                str[r] = "WINNER!!!";
                autocheck_enabled(false);
                Output.Lines = str;
            }
        }

        private void ButtonAnswer_Click(object sender, EventArgs e)
        {
            Rcows = (int)CowsForm.Value;
            Rbulls = (int)BullsForm.Value;
            str[r - 1] += "  " + Rcows + "C " + Rbulls + "B";
            Output.Lines = str;
            r++;

            remove_posible();
            solve2();
            ButtonAnswer.Enabled = false;

        }

        public FormCows()
        {
            InitializeComponent();
            initialize();

            Menu.Visible = true;
            Game.Visible = false;

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Exit2_Click(object sender, EventArgs e)
        {
            Menu.Visible = true;
            Game.Visible = false;
            
        }


        private void gennum()
        {

            int w;//To take random num...
            w = rand.Next(1, matl.Count);
            num[0] = mat[matl.ElementAt<int>(w - 1), 0];
            num[1] = mat[matl.ElementAt<int>(w - 1), 1];
            num[2] = mat[matl.ElementAt<int>(w - 1), 2];
            num[3] = mat[matl.ElementAt<int>(w - 1), 3];
        }

        private void Test_Click(object sender, EventArgs e)
        {
            TestText.Clear();
            TestBox.Visible = true;
            average = 0;
            Testprogress.Visible = true;
            int nt = (int)numberoftests.Value;
            for (int i = 0; i < nt; i++)
			{

                Testprogress.Value=(i/(nt/100))<100 ? (i/(nt/100)) : 100;
			    initialize();
                gennum();
                solve();
                testmat[r-1]++;
                average+=r;
			}
            Testprogress.Visible = false;
            for (int i = 1; i < 10; i++)
            {
                outstr[i-1] = i+" "+testmat[i].ToString();
            }
            average /= nt;
            outstr[10] = "Averige is " + average;
            TestText.Lines = outstr;
            

        }



        private void NewGame_Click(object sender, EventArgs e)
        {
            initialize();
            Rbulls = Rcows = 0;
            Menu.Visible = false;
            Game.Visible = true;
            Guess.Enabled = false;
            Num.ReadOnly = false;
            Automatic.Enabled = true;
            Automatic.Checked = true;
            autocheck(false);
            Num.ResetText();
            Output.ResetText();

            ButtonAnswer.Enabled = false;
            autocheck_enabled(false);

            for (int i = 0; i < 10; i++)
            {
                str[i] = string.Empty;
            }
            r = 0;
        }

        private void Guess_Click(object sender, EventArgs e)
        {
            initialize();
            Rbulls = Rcows = 0;
            for (int i = 0; i < 10; i++)
            {
                str[i] = string.Empty;
            }
            Automatic.Enabled = false;
            autocheck_enabled(true);
            Num.ReadOnly = true;
            if (Automatic.Checked)
            {
                solve();
            }
            else
            {
                solve2();
            }


        }

        private void Num_TextChanged(object sender, EventArgs e)
        {
            s = Num.Text.ToString();
            bool Validate=true;
            if (s.Length == 4)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] < '0' || s[i] > '9')
                    {
                        Validate = false;
                    }
                    else 
                    {
                        num[i] = (int)s[i] - (int)'0';
                    }

                }
                if (Validate)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        for (int j = i + 1; j < s.Length; j++)
                        {
                            if (s[i] == s[j]) Validate = false;

                        }
                    }
                }
                if (Validate)
                {
                    Guess.Enabled = true;
                }
            }
            else Guess.Enabled = false;

        }

        private void autocheck(bool b) 
        {
            textBox3.Visible = b;
            textBox4.Visible = b;
            BullsForm.Visible = b;
            CowsForm.Visible = b;
            ButtonAnswer.Visible = b;
        }
        private void autocheck_enabled(bool b)
        {
            BullsForm.Enabled = b;
            CowsForm.Enabled = b;
            ButtonAnswer.Enabled= b;
        }


        private void Automatic_CheckedChanged(object sender, EventArgs e)
        {
            if (Automatic.Checked == false) 
            {
                Num.Visible = false;
                Guess.Enabled=true;

                autocheck(true);
            }
            else
            {
                Num.Visible = true;
                Guess.Enabled = false;
                autocheck(false);
            }
        }

        private void CowsForm_ValueChanged(object sender, EventArgs e)
        {
            if (CowsForm.Value + BullsForm.Value <= 4)
            {
                ButtonAnswer.Enabled = true;
            }
            else
            {
                ButtonAnswer.Enabled = false;
            }
        }

        private void BullsForm_ValueChanged(object sender, EventArgs e)
        {
            if (CowsForm.Value + BullsForm.Value <= 4)
            {
                ButtonAnswer.Enabled = true;
            }
            else
            {
                ButtonAnswer.Enabled = false;
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Test_Click();

        }

        private void FormCows_Load(object sender, EventArgs e)
        {

        }
    }
}
