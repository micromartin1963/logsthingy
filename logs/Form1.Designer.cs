namespace logs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBox results_;
            quit = new Button();
            Info01 = new TextBox();
            Coords = new TextBox();
            coorInputx = new TextBox();
            results = new TextBox();
            SearchFor_ = new TextBox();
            searchfor = new TextBox();
            steamId_ = new TextBox();
            searchfor2 = new TextBox();
            checkBoxcoord = new CheckBox();
            info04 = new TextBox();
            action = new Button();
            textBox2 = new TextBox();
            test = new Button();
            textBox4 = new TextBox();
            RangeTxt = new TextBox();
            coorInputy = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            button2 = new Button();
            listView1 = new ListView();
            results_ = new TextBox();
            SuspendLayout();
            // 
            // results_
            // 
            results_.Location = new Point(744, 755);
            results_.Name = "results_";
            results_.ReadOnly = true;
            results_.Size = new Size(67, 23);
            results_.TabIndex = 10;
            results_.Text = "Results";
            // 
            // quit
            // 
            quit.Location = new Point(1331, 797);
            quit.Name = "quit";
            quit.Size = new Size(98, 35);
            quit.TabIndex = 2;
            quit.Text = "quit";
            quit.UseVisualStyleBackColor = true;
            quit.Click += quit_Click;
            // 
            // Info01
            // 
            Info01.AcceptsReturn = true;
            Info01.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Info01.Location = new Point(12, 32);
            Info01.MaxLength = 128000;
            Info01.Multiline = true;
            Info01.Name = "Info01";
            Info01.ScrollBars = ScrollBars.Both;
            Info01.Size = new Size(1509, 299);
            Info01.TabIndex = 3;
            Info01.TextChanged += Info01_TextChanged;
            // 
            // Coords
            // 
            Coords.Location = new Point(49, 798);
            Coords.Name = "Coords";
            Coords.ReadOnly = true;
            Coords.Size = new Size(65, 23);
            Coords.TabIndex = 5;
            Coords.Text = "Co-ord ";
            // 
            // coorInputx
            // 
            coorInputx.Location = new Point(120, 798);
            coorInputx.Name = "coorInputx";
            coorInputx.Size = new Size(65, 23);
            coorInputx.TabIndex = 9;
            coorInputx.Text = "7500";
            coorInputx.TextChanged += coorInput_TextChanged;
            // 
            // results
            // 
            results.Location = new Point(834, 755);
            results.Name = "results";
            results.Size = new Size(67, 23);
            results.TabIndex = 11;
            results.Text = "0";
            // 
            // SearchFor_
            // 
            SearchFor_.Location = new Point(423, 755);
            SearchFor_.Name = "SearchFor_";
            SearchFor_.ReadOnly = true;
            SearchFor_.Size = new Size(70, 23);
            SearchFor_.TabIndex = 12;
            SearchFor_.Text = "Search For";
            SearchFor_.TextChanged += SearchFor__TextChanged;
            // 
            // searchfor
            // 
            searchfor.Location = new Point(150, 755);
            searchfor.Name = "searchfor";
            searchfor.Size = new Size(267, 23);
            searchfor.TabIndex = 13;
            searchfor.Text = "Bandage";
            searchfor.TextChanged += searchfor_TextChanged;
            // 
            // steamId_
            // 
            steamId_.Location = new Point(28, 755);
            steamId_.Name = "steamId_";
            steamId_.ReadOnly = true;
            steamId_.Size = new Size(116, 23);
            steamId_.TabIndex = 16;
            steamId_.Text = "Search For";
            // 
            // searchfor2
            // 
            searchfor2.Location = new Point(499, 755);
            searchfor2.Name = "searchfor2";
            searchfor2.Size = new Size(202, 23);
            searchfor2.TabIndex = 17;
            // 
            // checkBoxcoord
            // 
            checkBoxcoord.AutoSize = true;
            checkBoxcoord.Location = new Point(28, 802);
            checkBoxcoord.Name = "checkBoxcoord";
            checkBoxcoord.Size = new Size(15, 14);
            checkBoxcoord.TabIndex = 19;
            checkBoxcoord.UseVisualStyleBackColor = true;
            // 
            // info04
            // 
            info04.AcceptsReturn = true;
            info04.Location = new Point(12, 366);
            info04.MaxLength = 128000;
            info04.Multiline = true;
            info04.Name = "info04";
            info04.ScrollBars = ScrollBars.Both;
            info04.Size = new Size(1509, 146);
            info04.TabIndex = 21;
            // 
            // action
            // 
            action.Location = new Point(509, 797);
            action.Name = "action";
            action.Size = new Size(209, 23);
            action.TabIndex = 22;
            action.Text = "Fetch filtered data";
            action.UseVisualStyleBackColor = true;
            action.Click += action_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(662, 337);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 23);
            textBox2.TabIndex = 24;
            textBox2.Text = "^ All data            /            Filtered data V";
            // 
            // test
            // 
            test.Location = new Point(1242, 762);
            test.Name = "test";
            test.Size = new Size(187, 23);
            test.TabIndex = 25;
            test.Text = "test";
            test.UseVisualStyleBackColor = true;
            test.Visible = false;
            test.Click += test_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(262, 797);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(51, 23);
            textBox4.TabIndex = 27;
            textBox4.Text = "Range";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // RangeTxt
            // 
            RangeTxt.Location = new Point(319, 798);
            RangeTxt.Name = "RangeTxt";
            RangeTxt.Size = new Size(81, 23);
            RangeTxt.TabIndex = 28;
            RangeTxt.Text = "100";
            // 
            // coorInputy
            // 
            coorInputy.Location = new Point(191, 798);
            coorInputy.Name = "coorInputy";
            coorInputy.Size = new Size(65, 23);
            coorInputy.TabIndex = 29;
            coorInputy.Text = "7500";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button2
            // 
            button2.Location = new Point(643, 669);
            button2.Name = "button2";
            button2.Size = new Size(258, 23);
            button2.TabIndex = 30;
            button2.Text = "Select File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(28, 542);
            listView1.Name = "listView1";
            listView1.Size = new Size(1341, 92);
            listView1.TabIndex = 31;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 839);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(coorInputy);
            Controls.Add(RangeTxt);
            Controls.Add(textBox4);
            Controls.Add(test);
            Controls.Add(textBox2);
            Controls.Add(action);
            Controls.Add(info04);
            Controls.Add(checkBoxcoord);
            Controls.Add(searchfor2);
            Controls.Add(steamId_);
            Controls.Add(searchfor);
            Controls.Add(SearchFor_);
            Controls.Add(results);
            Controls.Add(results_);
            Controls.Add(coorInputx);
            Controls.Add(Coords);
            Controls.Add(Info01);
            Controls.Add(quit);
            Name = "Form1";
            Text = "Logs";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button quit;
        private TextBox Info01;
        private TextBox Coords;
        private TextBox coorInputx;
        private TextBox results;
        private TextBox SearchFor_;
        private TextBox searchfor;
        private TextBox steamId_;
        private TextBox searchfor2;
        private CheckBox checkBoxcoord;
        private TextBox info04;
        private Button action;
        private TextBox textBox2;
        private Button test;
        private TextBox textBox4;
        private TextBox RangeTxt;
        private TextBox coorInputy;
        private OpenFileDialog openFileDialog1;
        private Button button2;
        private ListView listView1;
    }
}