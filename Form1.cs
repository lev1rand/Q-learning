using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int previousLocation = 0;
        int currentLocation = 0;
        double reward = 0;
        bool firstTick = true;
        int[,] R =
                {
           {-1, 0,0,-1,-1,-1,-1},
           {0,-1,-1,-1, 0,-1,-1},
           {0,-1,-1,0, 0,-1,-1},
           {-1,-1,0,-1,-1, 0,-1},
           {-1,0,0,-1,-1,0,100},
           {-1,-1,-1,0,-1,-1,-1},
           {-1,-1,-1,-1,0,-1,100}
        };
        int[,] Q =
        {
           {0,0,0,0,0,0,0},
           {0,0,0,0,0,0,0},
           {0,0,0,0,0,0,0},
           {0,0,0,0,0,0,0},
           {0,0,0,0,0,0,0},
           {0,0,0,0,0,0,0},
           {0,0,0,0,0,0,0}
        };

        private void start_Click(object sender, EventArgs e)
        {
            timer.Start();
            start.Enabled = false;

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randomIndex;
            var posVars = new List<int>();
            if (firstTick)
            {
                previousLocation = currentLocation;
                for (int i = currentLocation; i < currentLocation + 1; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (R[i, j] != -1)
                        {
                            posVars.Add(j);
                        }
                    }
                }
                currentLocation = posVars[rand.Next(posVars.Count)];
                ClearOrAddPic(previousLocation, true);
                ClearOrAddPic(currentLocation, false);
                posVars.Clear();
                firstTick = false;
            }
            else
            {
                var futureWays = new List<int>();
                for (int i = currentLocation; i < currentLocation + 1; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (R[i, j] != -1)
                        {
                            futureWays.Add(R[i, j]);
                        }
                    }
                }
                if (R[previousLocation, currentLocation] != -1)
                {
                    reward = R[previousLocation, currentLocation] + 0.8 * futureWays.Max();
                    Q[previousLocation, currentLocation] += int.Parse(reward.ToString());
                }
                switch (currentLocation)
                {
                    case 0:
                        {
                            int maxi = futureWays.Max();
                            for (int i = currentLocation; i < currentLocation + 1; i++)
                            {
                                for (int j = 0; j < 7; j++)
                                {
                                    if (R[i, j] == maxi)
                                    {
                                        posVars.Add(j);
                                    }
                                }
                            }
                            previousLocation = currentLocation;
                            if (posVars.Count > 1)
                            {
                                randomIndex = rand.Next(posVars.Count);
                                currentLocation = posVars[randomIndex];
                            }
                            else
                                currentLocation = posVars[0];
                            ClearOrAddPic(previousLocation, true);
                            ClearOrAddPic(currentLocation, false);
                            posVars.Clear();
                            futureWays.Clear();
                            break;
                        }
                    case 1:
                        {
                            int maxi = futureWays.Max();
                            for (int i = currentLocation; i < currentLocation + 1; i++)
                            {
                                for (int j = 0; j < 7; j++)
                                {
                                    if (R[i, j] == maxi)
                                    {
                                        posVars.Add(j);
                                    }
                                }
                            }
                            previousLocation = currentLocation;
                            if (posVars.Count > 1)
                            {
                                randomIndex = rand.Next(posVars.Count);
                                currentLocation = posVars[randomIndex];
                            }
                            else
                                currentLocation = posVars[0];
                            ClearOrAddPic(previousLocation, true);
                            ClearOrAddPic(currentLocation, false);
                            posVars.Clear();
                            futureWays.Clear();
                            break;
                        }
                    case 2:
                        {
                            int maxi = futureWays.Max();
                            for (int i = currentLocation; i < currentLocation + 1; i++)
                            {
                                for (int j = 0; j < 7; j++)
                                {
                                    if (R[i, j] == maxi)
                                    {
                                        posVars.Add(j);
                                    }
                                }
                            }
                            previousLocation = currentLocation;
                            if (posVars.Count > 1)
                            {
                                randomIndex = rand.Next(posVars.Count);
                                currentLocation = posVars[randomIndex];
                            }
                            else
                                currentLocation = posVars[0];
                            ClearOrAddPic(previousLocation, true);
                            ClearOrAddPic(currentLocation, false);
                            posVars.Clear();
                            futureWays.Clear();
                            break;
                        }
                    case 3:
                        {
                            int maxi = futureWays.Max();
                            for (int i = currentLocation; i < currentLocation + 1; i++)
                            {
                                for (int j = 0; j < 7; j++)
                                {

                                    if (R[i, j] == maxi)
                                    {
                                        posVars.Add(j);
                                    }
                                }
                            }
                            previousLocation = currentLocation;
                            if (posVars.Count > 1)
                            {
                                randomIndex = rand.Next(posVars.Count);
                                currentLocation = posVars[randomIndex];
                            }
                            else
                                currentLocation = posVars[0];
                            ClearOrAddPic(previousLocation, true);
                            ClearOrAddPic(currentLocation, false);
                            break;
                        }
                    case 4:
                        {
                            int maxi = futureWays.Max();
                            for (int i = currentLocation; i < currentLocation + 1; i++)
                            {
                                for (int j = 0; j < 7; j++)
                                {
                                    if (R[i, j] == maxi)
                                    {
                                        posVars.Add(j);
                                    }
                                }
                            }
                            previousLocation = currentLocation;
                            if (posVars.Count > 1)
                            {
                                randomIndex = rand.Next(posVars.Count);
                                currentLocation = posVars[randomIndex];
                            }
                            else
                                currentLocation = posVars[0];
                            ClearOrAddPic(previousLocation, true);
                            ClearOrAddPic(currentLocation, false);
                            break;
                        }
                    case 5:
                        {
                            int maxi = futureWays.Max();
                            for (int i = currentLocation; i < currentLocation + 1; i++)
                            {
                                for (int j = 0; j < 7; j++)
                                {
                                    if (R[i, j] == maxi)
                                    {
                                        posVars.Add(j);
                                    }
                                }
                            }
                            previousLocation = currentLocation;
                            if (posVars.Count > 1)
                            {
                                randomIndex = rand.Next(posVars.Count);
                                currentLocation = posVars[randomIndex];
                            }
                            else
                                currentLocation = posVars[0];
                            ClearOrAddPic(previousLocation, true);
                            ClearOrAddPic(currentLocation, false);
                            break;
                        }
                    case 6:
                        {
                            int maxi = futureWays.Max();
                            for (int i = currentLocation; i < currentLocation + 1; i++)
                            {
                                for (int j = 0; j < 7; j++)
                                {
                                    if (R[i, j] == maxi)
                                    {
                                        posVars.Add(j);
                                    }
                                }
                            }  
                            previousLocation = currentLocation;
                            if (posVars.Count > 1)
                            {
                                randomIndex = rand.Next(posVars.Count);
                                currentLocation = posVars[randomIndex];
                            }
                            else
                                currentLocation = posVars[0];
                            ClearOrAddPic(previousLocation, true);
                            ClearOrAddPic(currentLocation, false);
                            break;
                        }
                }
            }
        }

        private void ClearOrAddPic(int Indx, bool whatToDo)
        {
            if (whatToDo)
            {
                switch (Indx)
                {
                    case 0:
                        {
                            p01.BackgroundImage = null;
                            break;
                        }
                    case 1:
                        {
                            p10.BackgroundImage = null;
                            break;
                        }
                    case 2:
                        {
                            p12.BackgroundImage = null;
                            break;
                        }
                    case 3:
                        {
                            p23.BackgroundImage = null;
                            break;
                        }
                    case 4:
                        {
                            p21.BackgroundImage = null;
                            break;
                        }
                    case 5:
                        {
                            p32.BackgroundImage = null;
                            break;
                        }
                    case 6:
                        {
                            p30.BackgroundImage = null;
                            break;
                        }
                }
            }
            else
            {
                switch (Indx)
                {
                    case 0:
                        {
                            p01.BackgroundImage = Image.FromFile("animal_elephant_Evernote_2592.png");
                            break;
                        }
                    case 1:
                        {
                            p10.BackgroundImage = Image.FromFile("animal_elephant_Evernote_2592.png");
                            break;
                        }
                    case 2:
                        {
                            p12.BackgroundImage = Image.FromFile("animal_elephant_Evernote_2592.png");
                            break;
                        }
                    case 3:
                        {
                            p23.BackgroundImage = Image.FromFile("animal_elephant_Evernote_2592.png");
                            break;
                        }
                    case 4:
                        {
                            p21.BackgroundImage = Image.FromFile("animal_elephant_Evernote_2592.png");
                            break;
                        }
                    case 5:
                        {
                            p32.BackgroundImage = Image.FromFile("animal_elephant_Evernote_2592.png");
                            break;
                        }
                    case 6:
                        {
                            p30.BackgroundImage = Image.FromFile("animal_elephant_Evernote_2592.png");
                            break;
                        }
                }
            }
        }

        private void repeat_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
            p01.BackgroundImage = Image.FromFile("animal_elephant_Evernote_2592.png");
            p10.BackgroundImage = null;
            p12.BackgroundImage = null;
            p23.BackgroundImage = null;
            p21.BackgroundImage = null;
            p32.BackgroundImage = null;
            p30.BackgroundImage = null;
            currentLocation = previousLocation = 0;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

