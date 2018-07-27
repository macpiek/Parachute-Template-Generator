namespace DarkParachute
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.marginBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.goresBox = new System.Windows.Forms.NumericUpDown();
            this.sphereBox = new System.Windows.Forms.NumericUpDown();
            this.ratioBox = new System.Windows.Forms.NumericUpDown();
            this.holeBox = new System.Windows.Forms.NumericUpDown();
            this.radiusBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.renderPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cylinderRenderPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.holeRadiusBox = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cylinderMarginBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.exportCylinderButton = new System.Windows.Forms.Button();
            this.holesBox = new System.Windows.Forms.NumericUpDown();
            this.cylinderRadiusBox = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.circleRenderPanel = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.circleHoleRadius = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.exportCircleButton = new System.Windows.Forms.Button();
            this.circleRadius = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marginBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goresBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sphereBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratioBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holeRadiusBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cylinderMarginBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cylinderRadiusBox)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleHoleRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exportButton);
            this.groupBox1.Controls.Add(this.marginBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.goresBox);
            this.groupBox1.Controls.Add(this.sphereBox);
            this.groupBox1.Controls.Add(this.ratioBox);
            this.groupBox1.Controls.Add(this.holeBox);
            this.groupBox1.Controls.Add(this.radiusBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(730, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcje";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(12, 96);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(124, 34);
            this.exportButton.TabIndex = 17;
            this.exportButton.Text = "Eksportuj";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // marginBox
            // 
            this.marginBox.Location = new System.Drawing.Point(607, 64);
            this.marginBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.marginBox.Name = "marginBox";
            this.marginBox.Size = new System.Drawing.Size(120, 26);
            this.marginBox.TabIndex = 16;
            this.marginBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.marginBox.ValueChanged += new System.EventHandler(this.marginBox_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Margines [mm]";
            // 
            // goresBox
            // 
            this.goresBox.Location = new System.Drawing.Point(142, 64);
            this.goresBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.goresBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.goresBox.Name = "goresBox";
            this.goresBox.Size = new System.Drawing.Size(120, 26);
            this.goresBox.TabIndex = 14;
            this.goresBox.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.goresBox.ValueChanged += new System.EventHandler(this.goresBox_ValueChanged);
            // 
            // sphereBox
            // 
            this.sphereBox.Location = new System.Drawing.Point(607, 35);
            this.sphereBox.Name = "sphereBox";
            this.sphereBox.Size = new System.Drawing.Size(120, 26);
            this.sphereBox.TabIndex = 13;
            this.sphereBox.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.sphereBox.ValueChanged += new System.EventHandler(this.sphereBox_ValueChanged);
            // 
            // ratioBox
            // 
            this.ratioBox.DecimalPlaces = 2;
            this.ratioBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ratioBox.Location = new System.Drawing.Point(363, 35);
            this.ratioBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.ratioBox.Name = "ratioBox";
            this.ratioBox.Size = new System.Drawing.Size(120, 26);
            this.ratioBox.TabIndex = 12;
            this.ratioBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ratioBox.ValueChanged += new System.EventHandler(this.ratioBox_ValueChanged);
            // 
            // holeBox
            // 
            this.holeBox.Location = new System.Drawing.Point(363, 64);
            this.holeBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.holeBox.Name = "holeBox";
            this.holeBox.Size = new System.Drawing.Size(120, 26);
            this.holeBox.TabIndex = 11;
            this.holeBox.ValueChanged += new System.EventHandler(this.holeBox_ValueChanged);
            // 
            // radiusBox
            // 
            this.radiusBox.Location = new System.Drawing.Point(142, 35);
            this.radiusBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(120, 26);
            this.radiusBox.TabIndex = 10;
            this.radiusBox.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.radiusBox.ValueChanged += new System.EventHandler(this.radiusBox_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "% kuli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Otwór [mm]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ratio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ilość segmentów";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promień [mm]";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(730, 683);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podgląd";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.renderPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 526);
            this.panel1.TabIndex = 1;
            // 
            // renderPanel
            // 
            this.renderPanel.BackColor = System.Drawing.SystemColors.Window;
            this.renderPanel.Location = new System.Drawing.Point(0, 0);
            this.renderPanel.Name = "renderPanel";
            this.renderPanel.Size = new System.Drawing.Size(414, 436);
            this.renderPanel.TabIndex = 0;
            this.renderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.renderPanel_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(744, 722);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(736, 689);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Spadochron";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(736, 689);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Otwory na walcu";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.cylinderRenderPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 531);
            this.panel2.TabIndex = 2;
            // 
            // cylinderRenderPanel
            // 
            this.cylinderRenderPanel.BackColor = System.Drawing.SystemColors.Window;
            this.cylinderRenderPanel.Location = new System.Drawing.Point(2, 0);
            this.cylinderRenderPanel.Name = "cylinderRenderPanel";
            this.cylinderRenderPanel.Size = new System.Drawing.Size(414, 436);
            this.cylinderRenderPanel.TabIndex = 0;
            this.cylinderRenderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.cylinderRenderPanel_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.holeRadiusBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cylinderMarginBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.exportCylinderButton);
            this.groupBox3.Controls.Add(this.holesBox);
            this.groupBox3.Controls.Add(this.cylinderRadiusBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(730, 144);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opcje";
            // 
            // holeRadiusBox
            // 
            this.holeRadiusBox.Location = new System.Drawing.Point(459, 68);
            this.holeRadiusBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.holeRadiusBox.Name = "holeRadiusBox";
            this.holeRadiusBox.Size = new System.Drawing.Size(120, 26);
            this.holeRadiusBox.TabIndex = 21;
            this.holeRadiusBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.holeRadiusBox.ValueChanged += new System.EventHandler(this.holeRadiusBox_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Promień otworu [mm]";
            // 
            // cylinderMarginBox
            // 
            this.cylinderMarginBox.Location = new System.Drawing.Point(459, 35);
            this.cylinderMarginBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.cylinderMarginBox.Name = "cylinderMarginBox";
            this.cylinderMarginBox.Size = new System.Drawing.Size(120, 26);
            this.cylinderMarginBox.TabIndex = 19;
            this.cylinderMarginBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cylinderMarginBox.ValueChanged += new System.EventHandler(this.cylinderMarginBox_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Margines [mm]";
            // 
            // exportCylinderButton
            // 
            this.exportCylinderButton.Location = new System.Drawing.Point(12, 96);
            this.exportCylinderButton.Name = "exportCylinderButton";
            this.exportCylinderButton.Size = new System.Drawing.Size(124, 34);
            this.exportCylinderButton.TabIndex = 17;
            this.exportCylinderButton.Text = "Eksportuj";
            this.exportCylinderButton.UseVisualStyleBackColor = true;
            this.exportCylinderButton.Click += new System.EventHandler(this.exportCylinderButton_Click);
            // 
            // holesBox
            // 
            this.holesBox.Location = new System.Drawing.Point(161, 64);
            this.holesBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.holesBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.holesBox.Name = "holesBox";
            this.holesBox.Size = new System.Drawing.Size(120, 26);
            this.holesBox.TabIndex = 14;
            this.holesBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.holesBox.ValueChanged += new System.EventHandler(this.holesBox_ValueChanged);
            // 
            // cylinderRadiusBox
            // 
            this.cylinderRadiusBox.Location = new System.Drawing.Point(161, 35);
            this.cylinderRadiusBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.cylinderRadiusBox.Name = "cylinderRadiusBox";
            this.cylinderRadiusBox.Size = new System.Drawing.Size(120, 26);
            this.cylinderRadiusBox.TabIndex = 10;
            this.cylinderRadiusBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cylinderRadiusBox.ValueChanged += new System.EventHandler(this.cylinderRadiusBox_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ilość otworów";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Promień walca [mm]";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(736, 689);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Koło";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.circleRenderPanel);
            this.panel3.Location = new System.Drawing.Point(3, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(730, 531);
            this.panel3.TabIndex = 4;
            // 
            // circleRenderPanel
            // 
            this.circleRenderPanel.BackColor = System.Drawing.SystemColors.Window;
            this.circleRenderPanel.Location = new System.Drawing.Point(4, 0);
            this.circleRenderPanel.Name = "circleRenderPanel";
            this.circleRenderPanel.Size = new System.Drawing.Size(414, 436);
            this.circleRenderPanel.TabIndex = 0;
            this.circleRenderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.circleRenderPanel_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.circleHoleRadius);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.exportCircleButton);
            this.groupBox4.Controls.Add(this.circleRadius);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(730, 144);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opcje";
            // 
            // circleHoleRadius
            // 
            this.circleHoleRadius.Location = new System.Drawing.Point(171, 64);
            this.circleHoleRadius.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.circleHoleRadius.Name = "circleHoleRadius";
            this.circleHoleRadius.Size = new System.Drawing.Size(120, 26);
            this.circleHoleRadius.TabIndex = 21;
            this.circleHoleRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.circleHoleRadius.ValueChanged += new System.EventHandler(this.circleHoleRadius_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Promień otworu [mm]";
            // 
            // exportCircleButton
            // 
            this.exportCircleButton.Location = new System.Drawing.Point(12, 96);
            this.exportCircleButton.Name = "exportCircleButton";
            this.exportCircleButton.Size = new System.Drawing.Size(124, 34);
            this.exportCircleButton.TabIndex = 17;
            this.exportCircleButton.Text = "Eksportuj";
            this.exportCircleButton.UseVisualStyleBackColor = true;
            this.exportCircleButton.Click += new System.EventHandler(this.exportCircleButton_Click);
            // 
            // circleRadius
            // 
            this.circleRadius.Location = new System.Drawing.Point(171, 35);
            this.circleRadius.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.circleRadius.Name = "circleRadius";
            this.circleRadius.Size = new System.Drawing.Size(120, 26);
            this.circleRadius.TabIndex = 10;
            this.circleRadius.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.circleRadius.ValueChanged += new System.EventHandler(this.circleRadius_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Promień koła [mm]";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 722);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DarkParachute (c) 2013 Maciej Piekarski";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marginBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goresBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sphereBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratioBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holeRadiusBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cylinderMarginBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cylinderRadiusBox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circleHoleRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleRadius)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel renderPanel;
        private System.Windows.Forms.NumericUpDown goresBox;
        private System.Windows.Forms.NumericUpDown sphereBox;
        private System.Windows.Forms.NumericUpDown ratioBox;
        private System.Windows.Forms.NumericUpDown holeBox;
        private System.Windows.Forms.NumericUpDown radiusBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown marginBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button exportCylinderButton;
        private System.Windows.Forms.NumericUpDown holesBox;
        private System.Windows.Forms.NumericUpDown cylinderRadiusBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel cylinderRenderPanel;
        private System.Windows.Forms.NumericUpDown cylinderMarginBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown holeRadiusBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel circleRenderPanel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown circleHoleRadius;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button exportCircleButton;
        private System.Windows.Forms.NumericUpDown circleRadius;
        private System.Windows.Forms.Label label14;
    }
}

