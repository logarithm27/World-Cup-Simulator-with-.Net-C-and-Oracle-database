namespace worldCupTest2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.draw = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.A = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.E = new System.Windows.Forms.Label();
            this.F = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.Label();
            this.timerToWait = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timerToWait2 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timerToWait3 = new System.Windows.Forms.Timer(this.components);
            this.a1 = new System.Windows.Forms.Label();
            this.a2 = new System.Windows.Forms.Label();
            this.a3 = new System.Windows.Forms.Label();
            this.a4 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Label();
            this.b2 = new System.Windows.Forms.Label();
            this.b3 = new System.Windows.Forms.Label();
            this.b4 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.Label();
            this.c2 = new System.Windows.Forms.Label();
            this.c3 = new System.Windows.Forms.Label();
            this.c4 = new System.Windows.Forms.Label();
            this.d1 = new System.Windows.Forms.Label();
            this.d2 = new System.Windows.Forms.Label();
            this.d3 = new System.Windows.Forms.Label();
            this.d4 = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.Label();
            this.e4 = new System.Windows.Forms.Label();
            this.e3 = new System.Windows.Forms.Label();
            this.e2 = new System.Windows.Forms.Label();
            this.e1 = new System.Windows.Forms.Label();
            this.f2 = new System.Windows.Forms.Label();
            this.h2 = new System.Windows.Forms.Label();
            this.h1 = new System.Windows.Forms.Label();
            this.g4 = new System.Windows.Forms.Label();
            this.g3 = new System.Windows.Forms.Label();
            this.g2 = new System.Windows.Forms.Label();
            this.g1 = new System.Windows.Forms.Label();
            this.f4 = new System.Windows.Forms.Label();
            this.f3 = new System.Windows.Forms.Label();
            this.h4 = new System.Windows.Forms.Label();
            this.h3 = new System.Windows.Forms.Label();
            this.schedule = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.theTimer);
            // 
            // draw
            // 
            this.draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw.Location = new System.Drawing.Point(1143, 94);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(199, 42);
            this.draw.TabIndex = 0;
            this.draw.Text = "Draw";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.Tick2);
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(22, 363);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(76, 20);
            this.A.TabIndex = 1;
            this.A.Text = "Group A";
            this.A.Visible = false;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(183, 363);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(76, 20);
            this.B.TabIndex = 2;
            this.B.Text = "Group B";
            this.B.Visible = false;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(354, 363);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(76, 20);
            this.C.TabIndex = 3;
            this.C.Text = "Group C";
            this.C.Visible = false;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.Location = new System.Drawing.Point(524, 363);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(77, 20);
            this.D.TabIndex = 4;
            this.D.Text = "Group D";
            this.D.Visible = false;
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E.Location = new System.Drawing.Point(688, 363);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(76, 20);
            this.E.TabIndex = 5;
            this.E.Text = "Group E";
            this.E.Visible = false;
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F.Location = new System.Drawing.Point(852, 363);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(75, 20);
            this.F.TabIndex = 6;
            this.F.Text = "Group F";
            this.F.Visible = false;
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G.Location = new System.Drawing.Point(1022, 363);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(78, 20);
            this.G.TabIndex = 7;
            this.G.Text = "Group G";
            this.G.Visible = false;
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H.Location = new System.Drawing.Point(1193, 363);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(77, 20);
            this.H.TabIndex = 8;
            this.H.Text = "Group H";
            this.H.Visible = false;
            // 
            // timerToWait
            // 
            this.timerToWait.Enabled = true;
            this.timerToWait.Interval = 1000;
            this.timerToWait.Tick += new System.EventHandler(this.tickTowait);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.Tick3);
            // 
            // timerToWait2
            // 
            this.timerToWait2.Enabled = true;
            this.timerToWait2.Interval = 1000;
            this.timerToWait2.Tick += new System.EventHandler(this.tickToWait2);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.Tick4);
            // 
            // timerToWait3
            // 
            this.timerToWait3.Enabled = true;
            this.timerToWait3.Interval = 1000;
            this.timerToWait3.Tick += new System.EventHandler(this.tickTowait3);
            // 
            // a1
            // 
            this.a1.AutoSize = true;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(66, 387);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(22, 12);
            this.a1.TabIndex = 13;
            this.a1.Text = "A 1";
            // 
            // a2
            // 
            this.a2.AutoSize = true;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(66, 417);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(22, 12);
            this.a2.TabIndex = 14;
            this.a2.Text = "A 2";
            // 
            // a3
            // 
            this.a3.AutoSize = true;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(66, 451);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(22, 12);
            this.a3.TabIndex = 15;
            this.a3.Text = "A 3";
            // 
            // a4
            // 
            this.a4.AutoSize = true;
            this.a4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a4.Location = new System.Drawing.Point(66, 482);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(22, 12);
            this.a4.TabIndex = 16;
            this.a4.Text = "A 4";
            // 
            // b1
            // 
            this.b1.AutoSize = true;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(227, 387);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(21, 12);
            this.b1.TabIndex = 17;
            this.b1.Text = "B 1";
            // 
            // b2
            // 
            this.b2.AutoSize = true;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(227, 417);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(21, 12);
            this.b2.TabIndex = 18;
            this.b2.Text = "B 2";
            // 
            // b3
            // 
            this.b3.AutoSize = true;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(227, 451);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(21, 12);
            this.b3.TabIndex = 19;
            this.b3.Text = "B 3";
            // 
            // b4
            // 
            this.b4.AutoSize = true;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(227, 482);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(21, 12);
            this.b4.TabIndex = 20;
            this.b4.Text = "B 4";
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(395, 387);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(22, 12);
            this.c1.TabIndex = 21;
            this.c1.Text = "C 1";
            // 
            // c2
            // 
            this.c2.AutoSize = true;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(395, 417);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(22, 12);
            this.c2.TabIndex = 22;
            this.c2.Text = "C 2";
            // 
            // c3
            // 
            this.c3.AutoSize = true;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(395, 451);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(22, 12);
            this.c3.TabIndex = 23;
            this.c3.Text = "C 3";
            // 
            // c4
            // 
            this.c4.AutoSize = true;
            this.c4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c4.Location = new System.Drawing.Point(395, 482);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(22, 12);
            this.c4.TabIndex = 24;
            this.c4.Text = "C 4";
            // 
            // d1
            // 
            this.d1.AutoSize = true;
            this.d1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1.Location = new System.Drawing.Point(566, 387);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(22, 12);
            this.d1.TabIndex = 25;
            this.d1.Text = "D 1";
            // 
            // d2
            // 
            this.d2.AutoSize = true;
            this.d2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2.Location = new System.Drawing.Point(566, 417);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(22, 12);
            this.d2.TabIndex = 26;
            this.d2.Text = "D 2";
            // 
            // d3
            // 
            this.d3.AutoSize = true;
            this.d3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d3.Location = new System.Drawing.Point(566, 451);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(22, 12);
            this.d3.TabIndex = 27;
            this.d3.Text = "D 3";
            // 
            // d4
            // 
            this.d4.AutoSize = true;
            this.d4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d4.Location = new System.Drawing.Point(566, 482);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(22, 12);
            this.d4.TabIndex = 28;
            this.d4.Text = "D 4";
            // 
            // f1
            // 
            this.f1.AutoSize = true;
            this.f1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1.Location = new System.Drawing.Point(894, 387);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(21, 12);
            this.f1.TabIndex = 29;
            this.f1.Text = "F 1";
            // 
            // e4
            // 
            this.e4.AutoSize = true;
            this.e4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e4.Location = new System.Drawing.Point(730, 482);
            this.e4.Name = "e4";
            this.e4.Size = new System.Drawing.Size(21, 12);
            this.e4.TabIndex = 30;
            this.e4.Text = "E 4";
            // 
            // e3
            // 
            this.e3.AutoSize = true;
            this.e3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e3.Location = new System.Drawing.Point(730, 451);
            this.e3.Name = "e3";
            this.e3.Size = new System.Drawing.Size(21, 12);
            this.e3.TabIndex = 31;
            this.e3.Text = "E 3";
            // 
            // e2
            // 
            this.e2.AutoSize = true;
            this.e2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e2.Location = new System.Drawing.Point(730, 417);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(21, 12);
            this.e2.TabIndex = 32;
            this.e2.Text = "E 2";
            // 
            // e1
            // 
            this.e1.AutoSize = true;
            this.e1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e1.Location = new System.Drawing.Point(730, 387);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(21, 12);
            this.e1.TabIndex = 33;
            this.e1.Text = "E 1";
            // 
            // f2
            // 
            this.f2.AutoSize = true;
            this.f2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2.Location = new System.Drawing.Point(894, 417);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(21, 12);
            this.f2.TabIndex = 34;
            this.f2.Text = "F 2";
            // 
            // h2
            // 
            this.h2.AutoSize = true;
            this.h2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h2.Location = new System.Drawing.Point(1240, 417);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(22, 12);
            this.h2.TabIndex = 35;
            this.h2.Text = "H 2";
            // 
            // h1
            // 
            this.h1.AutoSize = true;
            this.h1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h1.Location = new System.Drawing.Point(1240, 387);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(22, 12);
            this.h1.TabIndex = 36;
            this.h1.Text = "H 1";
            // 
            // g4
            // 
            this.g4.AutoSize = true;
            this.g4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g4.Location = new System.Drawing.Point(1062, 482);
            this.g4.Name = "g4";
            this.g4.Size = new System.Drawing.Size(22, 12);
            this.g4.TabIndex = 37;
            this.g4.Text = "G 4";
            // 
            // g3
            // 
            this.g3.AutoSize = true;
            this.g3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g3.Location = new System.Drawing.Point(1062, 451);
            this.g3.Name = "g3";
            this.g3.Size = new System.Drawing.Size(22, 12);
            this.g3.TabIndex = 38;
            this.g3.Text = "G 3";
            // 
            // g2
            // 
            this.g2.AutoSize = true;
            this.g2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g2.Location = new System.Drawing.Point(1062, 417);
            this.g2.Name = "g2";
            this.g2.Size = new System.Drawing.Size(22, 12);
            this.g2.TabIndex = 39;
            this.g2.Text = "G 2";
            // 
            // g1
            // 
            this.g1.AutoSize = true;
            this.g1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g1.Location = new System.Drawing.Point(1062, 387);
            this.g1.Name = "g1";
            this.g1.Size = new System.Drawing.Size(22, 12);
            this.g1.TabIndex = 40;
            this.g1.Text = "G 1";
            // 
            // f4
            // 
            this.f4.AutoSize = true;
            this.f4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f4.Location = new System.Drawing.Point(894, 482);
            this.f4.Name = "f4";
            this.f4.Size = new System.Drawing.Size(21, 12);
            this.f4.TabIndex = 41;
            this.f4.Text = "F 4";
            // 
            // f3
            // 
            this.f3.AutoSize = true;
            this.f3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3.Location = new System.Drawing.Point(894, 451);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(21, 12);
            this.f3.TabIndex = 42;
            this.f3.Text = "F 3";
            // 
            // h4
            // 
            this.h4.AutoSize = true;
            this.h4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h4.Location = new System.Drawing.Point(1240, 482);
            this.h4.Name = "h4";
            this.h4.Size = new System.Drawing.Size(22, 12);
            this.h4.TabIndex = 43;
            this.h4.Text = "H 4";
            // 
            // h3
            // 
            this.h3.AutoSize = true;
            this.h3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h3.Location = new System.Drawing.Point(1240, 451);
            this.h3.Name = "h3";
            this.h3.Size = new System.Drawing.Size(22, 12);
            this.h3.TabIndex = 44;
            this.h3.Text = "H 3";
            // 
            // schedule
            // 
            this.schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedule.Image = ((System.Drawing.Image)(resources.GetObject("schedule.Image")));
            this.schedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.schedule.Location = new System.Drawing.Point(1143, 174);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(199, 44);
            this.schedule.TabIndex = 47;
            this.schedule.Text = "Show Schedule";
            this.schedule.UseVisualStyleBackColor = true;
            this.schedule.Click += new System.EventHandler(this.schedule_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1342, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutUSToolStripMenuItem
            // 
            this.aboutUSToolStripMenuItem.Name = "aboutUSToolStripMenuItem";
            this.aboutUSToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.aboutUSToolStripMenuItem.Text = "About ";
            this.aboutUSToolStripMenuItem.Click += new System.EventHandler(this.aboutUSToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1342, 517);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.h3);
            this.Controls.Add(this.h4);
            this.Controls.Add(this.f3);
            this.Controls.Add(this.f4);
            this.Controls.Add(this.g1);
            this.Controls.Add(this.g2);
            this.Controls.Add(this.g3);
            this.Controls.Add(this.g4);
            this.Controls.Add(this.h1);
            this.Controls.Add(this.h2);
            this.Controls.Add(this.f2);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.e2);
            this.Controls.Add(this.e3);
            this.Controls.Add(this.e4);
            this.Controls.Add(this.f1);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.H);
            this.Controls.Add(this.G);
            this.Controls.Add(this.F);
            this.Controls.Add(this.E);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Coupe Du Monde";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label E;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.Timer timerToWait;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timerToWait2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timerToWait3;
        public System.Windows.Forms.Label a1;
        private System.Windows.Forms.Label a2;
        private System.Windows.Forms.Label a3;
        private System.Windows.Forms.Label a4;
        private System.Windows.Forms.Label b1;
        private System.Windows.Forms.Label b2;
        private System.Windows.Forms.Label b3;
        private System.Windows.Forms.Label b4;
        private System.Windows.Forms.Label c1;
        private System.Windows.Forms.Label c2;
        private System.Windows.Forms.Label c3;
        private System.Windows.Forms.Label c4;
        private System.Windows.Forms.Label d1;
        private System.Windows.Forms.Label d2;
        private System.Windows.Forms.Label d3;
        private System.Windows.Forms.Label d4;
        private System.Windows.Forms.Label f1;
        private System.Windows.Forms.Label e4;
        private System.Windows.Forms.Label e3;
        private System.Windows.Forms.Label e2;
        private System.Windows.Forms.Label e1;
        private System.Windows.Forms.Label f2;
        private System.Windows.Forms.Label h2;
        private System.Windows.Forms.Label h1;
        private System.Windows.Forms.Label g4;
        private System.Windows.Forms.Label g3;
        private System.Windows.Forms.Label g2;
        private System.Windows.Forms.Label g1;
        private System.Windows.Forms.Label f4;
        private System.Windows.Forms.Label f3;
        private System.Windows.Forms.Label h4;
        private System.Windows.Forms.Label h3;
        private System.Windows.Forms.Button schedule;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutUSToolStripMenuItem;
    }
}

