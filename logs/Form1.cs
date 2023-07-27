using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Configuration;
using System.Numerics;
using System.Windows;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace logs
{
    public partial class Form1 : Form
    {

        string[] info = new string[1000000];
        string[] filteredInfo = new string[1000000];
        string[] filteredInfo2 = new string[1000000];

        string[] useablefolders = new string[100];
        string[] folderTimeRef = new string[100];
        DateTime[] folderDateRef = new DateTime[100];
        DateTime[] folderDateRef2 = new DateTime[100];
        string[] folderDateTimefoldernameRef = new string[100];

        DateTime[] DateRef = new DateTime[100];
        string[] DateRefStr = new string[100];

        int numberOfTotalLines = 0;
        string wip;
        Vector2 vx, vy;



        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            createFile();
        }

        public static void DoWork()
        {
            Form frm2 = new Form2();
            frm2.Show();
        }


        private void createFile()
        {
            string fileName = @"C:\Logs\fileData.txt";
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                using (FileStream fs = File.Create(fileName))
                {
                    // Adding some info into the file
                    byte[] info = new UTF8Encoding(true).GetBytes("");
                    fs.Write(info, 0, info.Length);
                    fs.Close();
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void createFile2()
        {
            string fileName = @"C:\Logs\index.htm";
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                using (FileStream fs = File.Create(fileName))
                {
                    // Adding some info into the file
                    byte[] info = new UTF8Encoding(true).GetBytes("<!doctype html>\r\n<html>\r\n<head>\r\n<title>Our LOGS  Page</title>\r\n<meta name=\"description\" content=\"page\">\r\n<meta name=\"keywords\" content=\"template\">\r\n</head>\r\n<body><font size=\"2\">");
                    fs.Write(info, 0, info.Length);
                    fs.Close();
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void appendMyFile(string extra)
        {
            string path = @"C:\Logs\fileData.txt";
            if (File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(extra);
                    sw.Close();
                }
            }
        }

        private void appendMyFile2(string extra)
        {
            string path = @"C:\Logs\index.htm";
            if (File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(extra);
                    sw.Close();
                }
            }
        }


        private void To_TextChanged(object sender, EventArgs e)
        {

        }

        private void quit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void DisplayInfo1()
        {
            if (numberOfTotalLines > 10000)
            {
                MessageBox.Show("Too many to display in top window just use filtered");
            }
            else
            {
                for (int x = 0; x < numberOfTotalLines; x++)
                {
                    Info01.Text = Info01.Text + "\r\n" + info[x];
                }

            }
        }

        private void lineToVxAndVy(string input)
        {
            vx.X = 0;
            vx.Y = 0;
            wip = "";
            string a, b, c;
            int ai, bi, ci, getpastnameint;
            //   [2023 - 06 - 18T19: 04:56Z] babadoei(76561198436743669) moved 1 Izh18(1841740397) - HANDS > GROUND < 4647.545410, 273.265839, 6760.885254 >
            // < 4647.545410, 273.265839, 6760.885254 >
            // 
            string str = input;
            string wholeVector = "";
            string firstvector, secondvector, thirdvector, firstsplit, secondsplit, thirdsplit;
            // we need to move past name in case it contains a <

            getpastnameint = str.IndexOf("moved") + 1;  // new bit
            str = str.Substring(getpastnameint, (str.Length - getpastnameint) - 1);  // new bit


            ai = str.IndexOf("<") + 1; // < 4647.545410, 273.265839, 6760.885254 >
            wholeVector = str.Substring(ai, (str.Length - ai) - 1); // 4647.545410, 273.265839, 6760.885254 
            bi = wholeVector.IndexOf(",");
            firstvector = wholeVector.Substring(0, bi);
            secondsplit = wholeVector.Substring(bi + 1, (wholeVector.Length - (bi + 1)));  //  273.265839, 6760.885254
            ci = secondsplit.IndexOf(",");
            secondvector = secondsplit.Substring(0, ci);
            thirdvector = secondsplit.Substring(ci + 1, (secondsplit.Length - (ci + 1)));
            firstvector.Replace(" ", "");
            secondvector.Replace(" ", "");
            //  info04.Text = input;
            //  info04.Refresh();
            vx.X = float.Parse(firstvector);
            vx.Y = float.Parse(thirdvector);

            // info04.Text = info04.Text + "\r\n   x and y coord are   " + vx + vy  + " whole  " + wholeVector + " firstvector " + firstvector + " second split " + secondsplit + " seond vector " + secondvector + " third vector " + thirdvector;
        }



        private void ShowInfo04(int lines)
        {

            info04.Text = "";
            for (int x = 0; x < lines; x++)
            {
                info04.Text = info04.Text + filteredInfo[x];
            }
            results.Text = lines.ToString();

        }

        private void ShowListView(int lines)
        {

            info04.Text = "";
            for (int x = 0; x < lines; x++)
            {
                listView1.Items.Add(new ListViewItem(filteredInfo[x]));
                //info04.Text = info04.Text + filteredInfo[x];
            }
            results.Text = lines.ToString();

        }

        private void SetTimeStrings()
        {


        }

        private void action_Click(object sender, EventArgs e)
        {
            doIt();
        }

        void doIt()
        {

            bool showInfo = true;
            info04.Text = "Working....";
            info04.Refresh();
            string str = searchfor.Text;
            string str2 = searchfor2.Text;
            int y = 0;
            int a, b, l;
            float thisvx = 0, thisvy = 0;
            int range = Int32.Parse(RangeTxt.Text);
            int maxx = 0, maxy = 0, minx = 0, miny = 0;
            Vector2 vector, localvx, localvy;





            for (int lines = 0; lines < numberOfTotalLines; lines++)
            {
                filteredInfo[lines] = "";
            }

            createFile2();

            vector.X = Int32.Parse(coorInputx.Text);
            vector.Y = Int32.Parse(coorInputy.Text);

            for (int i = 0; i < numberOfTotalLines; i++)
            {
                string strstr = info[i];  // get coords maybe


                if (checkBoxcoord.Checked)
                {
                    lineToVxAndVy(info[i]); // this populate vx and vy with that lines vectors
                                            // [2023-06-18T19:14:26Z] Smoke (76561199394760517) moved 4 BandageDressing (1450147839) - FOG_Player_TrackPants (868704584)>FOG_Hoodie_Jacket_Rolled_CDAJ (1206255577) <1102.718384, 150.332321, 6622.836914>

                    //  vx = "1102";
                    //   vy = "6622"; // test
                    localvx.X = vx.X;
                    localvy.Y = vx.Y;

                    thisvx = localvx.X - vector.X;
                    thisvy = localvy.Y - vector.Y;
                    if (thisvx < 0)
                    {
                        thisvx = +Math.Abs(thisvx);
                    }

                    if (thisvy < 0)
                    {
                        thisvy = +Math.Abs(thisvy);
                    }

                    // if (strstr.Contains(str) && strstr.Contains(str2) )
                    if (strstr.Contains(str) && strstr.Contains(str2))
                    {

                        if ((thisvx < range) && (thisvy < range))
                        {
                            filteredInfo[y] = strstr + "\r\n";
                            appendMyFile2(strstr + "<br>");  // added
                                                             //   appendMyFile2("</font></body>\r\n</html>");  // added
                            y++;
                        }
                    }
                }
                else
                {
                    if (strstr.Contains(str) && strstr.Contains(str2))
                    {
                        filteredInfo[y] = strstr + "\r\n";
                        appendMyFile2(strstr + "<br>");
                        appendMyFile2("</font></body>\r\n</html>");
                        y++;
                    }
                }

                results.Text = y.ToString();
                results.Refresh();
                if (y > 25000)
                {
                    i = numberOfTotalLines;
                    MessageBox.Show("it's taking too long refine search");
                    showInfo = false;
                }
                info04.Text = "done index.htm....";

            }

            if (showInfo)
            {
                // ShowListView(y);
                //  ShowInfo04(y);
            }
            else
            {
                info04.Text = "Restart filter ....";
            }


            // info04.Text = info04.Text + "Finished   " + y.ToString()  + "  x  "+ thisvx + "  y  " + thisvy + "   " + maxx.ToString() + "   " + maxy.ToString() + "   " + minx.ToString() + "   " + miny.ToString() + "  vx " + vx + " vy  " + vy;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog(this);
            info04.Text = openFileDialog1.FileName;
            createFile2();
            appendMyFile(openFileDialog1.FileName);
            ReadMyFile(openFileDialog1.FileName);
            DisplayInfo1();
        }


        private void ReadMyFile(string path)
        {

            string str = "";

            Info01.Refresh();
            int x = 0, y = 0;

            for (x = 0; x < 99; x++)
            {
                if (useablefolders[x] == "0")
                {
                }
                else
                {
                    y++; //this gets number of used cells in useablefolders
                }
            }

            x = 0;

            if (File.Exists(path))
            {
                Info01.Text = Info01.Text + "\r\n" + "  Loading... please wait";
                Info01.Refresh();
                //int x = 0;
                foreach (string line in File.ReadLines(path))
                {
                    str = line;
                    info[x] = str;
                    x++;
                }
                Info01.Text = Info01.Text + "\r\n" + "  Processed... please wait";
                Info01.Refresh();
            }

            numberOfTotalLines = x;
        }

        private string ReadMyFileFirstLine(string filename)
        {
            string path = filename;
            string firstline = "default";
            if (File.Exists(path))
            {
                int x = 0;
                foreach (string line in File.ReadLines(path))
                {
                    if (x == 0) firstline = line;
                    x++;
                }
            }
            return firstline;
        }

        private string ReadMyFileLastLine(string filename)
        {
            string path = filename;
            string Lastline = "default";
            if (File.Exists(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    Lastline = line;
                }
            }
            return Lastline;
        }


        private int ReturnLinesInFileData()
        {
            int x = 0;
            string path = @"C:\Logs\fileData.txt";

            if (File.Exists(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    x++;
                }
            }
            return x;
        }

        private void test_Click(object sender, EventArgs e)
        {
            lineToVxAndVy(info[0]);
        }

        private void Search_Click(object sender, EventArgs e)
        {
        }
        private void Info01_TextChanged(object sender, EventArgs e)
        {

        }
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }
        private double ToUnixTimeStamp(DateTime dtime)
        {
            return (dtime - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds;
        }
        private DateTime FromUnixTimeStamp(double unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(unixTimeStamp).ToLocalTime();
        }


        private void coorInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void SearchFor__TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }



        private void searchfor_TextChanged(object sender, EventArgs e)
        {

        }
        private void From_TextChanged(object sender, EventArgs e)
        {

        }

    }
}