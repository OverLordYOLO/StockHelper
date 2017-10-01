namespace StockHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.capitalTextBox = new System.Windows.Forms.TextBox();
            this.sharePriceTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.setEurButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.stopLossTextBox = new System.Windows.Forms.RichTextBox();
            this.takeProfitLabel = new System.Windows.Forms.Label();
            this.takeProfitTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.riskPercentageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfSharesTextBox = new System.Windows.Forms.RichTextBox();
            this.riskRewardTextBox = new System.Windows.Forms.RichTextBox();
            this.finalPriceTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.riskRewardLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.commissionsPercentageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.commissionsPerShareNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.commissionsPerTradeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.commissionsMinPerTradeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.commissionsMaxPerTradeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.riskTextBox = new System.Windows.Forms.TextBox();
            this.oneRLabel = new System.Windows.Forms.Label();
            this.setCzkButton = new System.Windows.Forms.Button();
            this.setUsdButton = new System.Windows.Forms.Button();
            this.loadUsdbutton = new System.Windows.Forms.Button();
            this.loadCzkbutton = new System.Windows.Forms.Button();
            this.loadEurbutton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.gainTextBox = new System.Windows.Forms.RichTextBox();
            this.riskingTextBox = new System.Windows.Forms.RichTextBox();
            this.gainLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.countButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimumPerTradePercentageRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumPerTradeCurrencyRadioButton = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maximumPerTradePercentageRadioButton = new System.Windows.Forms.RadioButton();
            this.maximumPerTradeCurrencyRadioButton = new System.Windows.Forms.RadioButton();
            this.testButton = new System.Windows.Forms.Button();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.riskPercentageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionsPercentageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionsPerShareNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionsPerTradeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionsMinPerTradeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionsMaxPerTradeNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // capitalTextBox
            // 
            this.capitalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.capitalTextBox.Location = new System.Drawing.Point(65, 591);
            this.capitalTextBox.Name = "capitalTextBox";
            this.capitalTextBox.Size = new System.Drawing.Size(127, 29);
            this.capitalTextBox.TabIndex = 0;
            this.capitalTextBox.TabStop = false;
            this.capitalTextBox.TextChanged += new System.EventHandler(this.capitalTextBox_TextChanged);
            this.capitalTextBox.Leave += new System.EventHandler(this.capitalTextBox_Leave);
            // 
            // sharePriceTextBox
            // 
            this.sharePriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sharePriceTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sharePriceTextBox.Location = new System.Drawing.Point(83, 169);
            this.sharePriceTextBox.Multiline = false;
            this.sharePriceTextBox.Name = "sharePriceTextBox";
            this.sharePriceTextBox.Size = new System.Drawing.Size(199, 65);
            this.sharePriceTextBox.TabIndex = 1;
            this.sharePriceTextBox.Text = "";
            this.sharePriceTextBox.Leave += new System.EventHandler(this.sharePriceTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Capital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // setEurButton
            // 
            this.setEurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setEurButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.setEurButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.setEurButton.Location = new System.Drawing.Point(577, 487);
            this.setEurButton.Name = "setEurButton";
            this.setEurButton.Size = new System.Drawing.Size(150, 54);
            this.setEurButton.TabIndex = 4;
            this.setEurButton.TabStop = false;
            this.setEurButton.Text = "Set EUR";
            this.setEurButton.UseVisualStyleBackColor = true;
            this.setEurButton.Click += new System.EventHandler(this.setEurButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(99, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stop-Loss";
            // 
            // stopLossTextBox
            // 
            this.stopLossTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stopLossTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopLossTextBox.Location = new System.Drawing.Point(83, 275);
            this.stopLossTextBox.Multiline = false;
            this.stopLossTextBox.Name = "stopLossTextBox";
            this.stopLossTextBox.Size = new System.Drawing.Size(199, 65);
            this.stopLossTextBox.TabIndex = 2;
            this.stopLossTextBox.Text = "";
            this.stopLossTextBox.Leave += new System.EventHandler(this.stopLossTextBox_Leave);
            // 
            // takeProfitLabel
            // 
            this.takeProfitLabel.AutoSize = true;
            this.takeProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.takeProfitLabel.ForeColor = System.Drawing.Color.White;
            this.takeProfitLabel.Location = new System.Drawing.Point(99, 32);
            this.takeProfitLabel.Name = "takeProfitLabel";
            this.takeProfitLabel.Size = new System.Drawing.Size(106, 25);
            this.takeProfitLabel.TabIndex = 8;
            this.takeProfitLabel.Text = "Take Profit";
            // 
            // takeProfitTextBox
            // 
            this.takeProfitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.takeProfitTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.takeProfitTextBox.Location = new System.Drawing.Point(83, 60);
            this.takeProfitTextBox.Multiline = false;
            this.takeProfitTextBox.Name = "takeProfitTextBox";
            this.takeProfitTextBox.Size = new System.Drawing.Size(199, 65);
            this.takeProfitTextBox.TabIndex = 3;
            this.takeProfitTextBox.Text = "";
            this.takeProfitTextBox.Leave += new System.EventHandler(this.takeProfitTextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(206, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Risk % of Capital";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 594);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "%";
            // 
            // riskPercentageNumericUpDown
            // 
            this.riskPercentageNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.riskPercentageNumericUpDown.DecimalPlaces = 1;
            this.riskPercentageNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.riskPercentageNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.riskPercentageNumericUpDown.Location = new System.Drawing.Point(233, 594);
            this.riskPercentageNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.riskPercentageNumericUpDown.Name = "riskPercentageNumericUpDown";
            this.riskPercentageNumericUpDown.Size = new System.Drawing.Size(52, 22);
            this.riskPercentageNumericUpDown.TabIndex = 12;
            this.riskPercentageNumericUpDown.TabStop = false;
            this.riskPercentageNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.riskPercentageNumericUpDown.ValueChanged += new System.EventHandler(this.riskPercentageNumericUpDown_ValueChanged);
            // 
            // numberOfSharesTextBox
            // 
            this.numberOfSharesTextBox.AutoWordSelection = true;
            this.numberOfSharesTextBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.numberOfSharesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberOfSharesTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.numberOfSharesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOfSharesTextBox.Location = new System.Drawing.Point(557, 169);
            this.numberOfSharesTextBox.Multiline = false;
            this.numberOfSharesTextBox.Name = "numberOfSharesTextBox";
            this.numberOfSharesTextBox.ReadOnly = true;
            this.numberOfSharesTextBox.Size = new System.Drawing.Size(178, 65);
            this.numberOfSharesTextBox.TabIndex = 13;
            this.numberOfSharesTextBox.TabStop = false;
            this.numberOfSharesTextBox.Text = "";
            // 
            // riskRewardTextBox
            // 
            this.riskRewardTextBox.AutoWordSelection = true;
            this.riskRewardTextBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.riskRewardTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.riskRewardTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.riskRewardTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.riskRewardTextBox.Location = new System.Drawing.Point(557, 60);
            this.riskRewardTextBox.Multiline = false;
            this.riskRewardTextBox.Name = "riskRewardTextBox";
            this.riskRewardTextBox.ReadOnly = true;
            this.riskRewardTextBox.Size = new System.Drawing.Size(178, 65);
            this.riskRewardTextBox.TabIndex = 14;
            this.riskRewardTextBox.TabStop = false;
            this.riskRewardTextBox.Text = "";
            // 
            // finalPriceTextBox
            // 
            this.finalPriceTextBox.AutoWordSelection = true;
            this.finalPriceTextBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.finalPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.finalPriceTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.finalPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.finalPriceTextBox.Location = new System.Drawing.Point(557, 275);
            this.finalPriceTextBox.Multiline = false;
            this.finalPriceTextBox.Name = "finalPriceTextBox";
            this.finalPriceTextBox.ReadOnly = true;
            this.finalPriceTextBox.Size = new System.Drawing.Size(178, 65);
            this.finalPriceTextBox.TabIndex = 15;
            this.finalPriceTextBox.TabStop = false;
            this.finalPriceTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(570, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Final Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(570, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Number Of Shares";
            // 
            // riskRewardLabel
            // 
            this.riskRewardLabel.AutoSize = true;
            this.riskRewardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.riskRewardLabel.ForeColor = System.Drawing.Color.White;
            this.riskRewardLabel.Location = new System.Drawing.Point(596, 32);
            this.riskRewardLabel.Name = "riskRewardLabel";
            this.riskRewardLabel.Size = new System.Drawing.Size(131, 25);
            this.riskRewardLabel.TabIndex = 18;
            this.riskRewardLabel.Text = "Risk / Reward";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(310, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(272, 48);
            this.label10.TabIndex = 19;
            this.label10.Text = "Commissions";
            // 
            // commissionsPercentageNumericUpDown
            // 
            this.commissionsPercentageNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commissionsPercentageNumericUpDown.DecimalPlaces = 3;
            this.commissionsPercentageNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commissionsPercentageNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.commissionsPercentageNumericUpDown.Location = new System.Drawing.Point(65, 440);
            this.commissionsPercentageNumericUpDown.Name = "commissionsPercentageNumericUpDown";
            this.commissionsPercentageNumericUpDown.Size = new System.Drawing.Size(64, 22);
            this.commissionsPercentageNumericUpDown.TabIndex = 20;
            this.commissionsPercentageNumericUpDown.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(135, 452);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "%";
            // 
            // commissionsPerShareNumericUpDown
            // 
            this.commissionsPerShareNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commissionsPerShareNumericUpDown.DecimalPlaces = 3;
            this.commissionsPerShareNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commissionsPerShareNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.commissionsPerShareNumericUpDown.Location = new System.Drawing.Point(65, 470);
            this.commissionsPerShareNumericUpDown.Name = "commissionsPerShareNumericUpDown";
            this.commissionsPerShareNumericUpDown.Size = new System.Drawing.Size(64, 22);
            this.commissionsPerShareNumericUpDown.TabIndex = 22;
            this.commissionsPerShareNumericUpDown.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(138, 480);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Per Share";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(138, 506);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "Per Trade";
            // 
            // commissionsPerTradeNumericUpDown
            // 
            this.commissionsPerTradeNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commissionsPerTradeNumericUpDown.DecimalPlaces = 3;
            this.commissionsPerTradeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commissionsPerTradeNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.commissionsPerTradeNumericUpDown.Location = new System.Drawing.Point(65, 502);
            this.commissionsPerTradeNumericUpDown.Name = "commissionsPerTradeNumericUpDown";
            this.commissionsPerTradeNumericUpDown.Size = new System.Drawing.Size(64, 22);
            this.commissionsPerTradeNumericUpDown.TabIndex = 24;
            this.commissionsPerTradeNumericUpDown.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(289, 450);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Minimum Per Trade";
            // 
            // commissionsMinPerTradeNumericUpDown
            // 
            this.commissionsMinPerTradeNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commissionsMinPerTradeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commissionsMinPerTradeNumericUpDown.Location = new System.Drawing.Point(311, 473);
            this.commissionsMinPerTradeNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.commissionsMinPerTradeNumericUpDown.Name = "commissionsMinPerTradeNumericUpDown";
            this.commissionsMinPerTradeNumericUpDown.Size = new System.Drawing.Size(75, 19);
            this.commissionsMinPerTradeNumericUpDown.TabIndex = 26;
            this.commissionsMinPerTradeNumericUpDown.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(289, 505);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 15);
            this.label15.TabIndex = 29;
            this.label15.Text = "Maximum Per Trade";
            // 
            // commissionsMaxPerTradeNumericUpDown
            // 
            this.commissionsMaxPerTradeNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commissionsMaxPerTradeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commissionsMaxPerTradeNumericUpDown.Location = new System.Drawing.Point(311, 528);
            this.commissionsMaxPerTradeNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.commissionsMaxPerTradeNumericUpDown.Name = "commissionsMaxPerTradeNumericUpDown";
            this.commissionsMaxPerTradeNumericUpDown.Size = new System.Drawing.Size(72, 19);
            this.commissionsMaxPerTradeNumericUpDown.TabIndex = 28;
            this.commissionsMaxPerTradeNumericUpDown.TabStop = false;
            // 
            // riskTextBox
            // 
            this.riskTextBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.riskTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.riskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.riskTextBox.Location = new System.Drawing.Point(323, 597);
            this.riskTextBox.Name = "riskTextBox";
            this.riskTextBox.ReadOnly = true;
            this.riskTextBox.Size = new System.Drawing.Size(100, 22);
            this.riskTextBox.TabIndex = 30;
            this.riskTextBox.TabStop = false;
            // 
            // oneRLabel
            // 
            this.oneRLabel.AutoSize = true;
            this.oneRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oneRLabel.ForeColor = System.Drawing.Color.White;
            this.oneRLabel.Location = new System.Drawing.Point(429, 600);
            this.oneRLabel.Name = "oneRLabel";
            this.oneRLabel.Size = new System.Drawing.Size(37, 15);
            this.oneRLabel.TabIndex = 31;
            this.oneRLabel.Text = "= 1R";
            // 
            // setCzkButton
            // 
            this.setCzkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setCzkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.setCzkButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.setCzkButton.Location = new System.Drawing.Point(577, 550);
            this.setCzkButton.Name = "setCzkButton";
            this.setCzkButton.Size = new System.Drawing.Size(150, 54);
            this.setCzkButton.TabIndex = 32;
            this.setCzkButton.TabStop = false;
            this.setCzkButton.Text = "Set CZK";
            this.setCzkButton.UseVisualStyleBackColor = true;
            this.setCzkButton.Click += new System.EventHandler(this.setCzkButton_Click);
            // 
            // setUsdButton
            // 
            this.setUsdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setUsdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.setUsdButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.setUsdButton.Location = new System.Drawing.Point(577, 427);
            this.setUsdButton.Name = "setUsdButton";
            this.setUsdButton.Size = new System.Drawing.Size(150, 54);
            this.setUsdButton.TabIndex = 33;
            this.setUsdButton.TabStop = false;
            this.setUsdButton.Text = "Set USD";
            this.setUsdButton.UseVisualStyleBackColor = true;
            this.setUsdButton.Click += new System.EventHandler(this.setUsdButton_Click);
            // 
            // loadUsdbutton
            // 
            this.loadUsdbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadUsdbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadUsdbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loadUsdbutton.Location = new System.Drawing.Point(733, 427);
            this.loadUsdbutton.Name = "loadUsdbutton";
            this.loadUsdbutton.Size = new System.Drawing.Size(150, 54);
            this.loadUsdbutton.TabIndex = 36;
            this.loadUsdbutton.TabStop = false;
            this.loadUsdbutton.Text = "Load &USD";
            this.loadUsdbutton.UseVisualStyleBackColor = true;
            this.loadUsdbutton.Click += new System.EventHandler(this.loadUsdbutton_Click);
            // 
            // loadCzkbutton
            // 
            this.loadCzkbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadCzkbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadCzkbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loadCzkbutton.Location = new System.Drawing.Point(733, 550);
            this.loadCzkbutton.Name = "loadCzkbutton";
            this.loadCzkbutton.Size = new System.Drawing.Size(150, 54);
            this.loadCzkbutton.TabIndex = 35;
            this.loadCzkbutton.TabStop = false;
            this.loadCzkbutton.Text = "Load &CZK";
            this.loadCzkbutton.UseVisualStyleBackColor = true;
            this.loadCzkbutton.Click += new System.EventHandler(this.loadCzkbutton_Click);
            // 
            // loadEurbutton
            // 
            this.loadEurbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadEurbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadEurbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loadEurbutton.Location = new System.Drawing.Point(733, 487);
            this.loadEurbutton.Name = "loadEurbutton";
            this.loadEurbutton.Size = new System.Drawing.Size(150, 54);
            this.loadEurbutton.TabIndex = 34;
            this.loadEurbutton.TabStop = false;
            this.loadEurbutton.Text = "Load &EUR";
            this.loadEurbutton.UseVisualStyleBackColor = true;
            this.loadEurbutton.Click += new System.EventHandler(this.loadEurbutton_Click);
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(18, 369);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(900, 2);
            this.label17.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(768, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "0 = Best, the bigger the worse";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(771, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "0,5 and Smaller is good";
            // 
            // gainTextBox
            // 
            this.gainTextBox.AutoWordSelection = true;
            this.gainTextBox.BackColor = System.Drawing.Color.Green;
            this.gainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gainTextBox.Location = new System.Drawing.Point(791, 152);
            this.gainTextBox.Name = "gainTextBox";
            this.gainTextBox.Size = new System.Drawing.Size(90, 28);
            this.gainTextBox.TabIndex = 40;
            this.gainTextBox.TabStop = false;
            this.gainTextBox.Text = "";
            // 
            // riskingTextBox
            // 
            this.riskingTextBox.AutoWordSelection = true;
            this.riskingTextBox.BackColor = System.Drawing.Color.DarkRed;
            this.riskingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.riskingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.riskingTextBox.Location = new System.Drawing.Point(791, 218);
            this.riskingTextBox.Name = "riskingTextBox";
            this.riskingTextBox.Size = new System.Drawing.Size(90, 28);
            this.riskingTextBox.TabIndex = 41;
            this.riskingTextBox.TabStop = false;
            this.riskingTextBox.Text = "";
            // 
            // gainLabel
            // 
            this.gainLabel.AutoSize = true;
            this.gainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gainLabel.ForeColor = System.Drawing.Color.White;
            this.gainLabel.Location = new System.Drawing.Point(812, 126);
            this.gainLabel.Name = "gainLabel";
            this.gainLabel.Size = new System.Drawing.Size(43, 20);
            this.gainLabel.TabIndex = 42;
            this.gainLabel.Text = "Gain";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(805, 186);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 20);
            this.label21.TabIndex = 43;
            this.label21.Text = "Risking";
            // 
            // countButton
            // 
            this.countButton.BackColor = System.Drawing.Color.DarkGray;
            this.countButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countButton.Location = new System.Drawing.Point(341, 121);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(171, 89);
            this.countButton.TabIndex = 44;
            this.countButton.TabStop = false;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = false;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.clearButton.Location = new System.Drawing.Point(384, 256);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(88, 34);
            this.clearButton.TabIndex = 45;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Red;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("SimSun-ExtB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minimizeButton.Location = new System.Drawing.Point(860, 10);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(33, 23);
            this.minimizeButton.TabIndex = 46;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Text = "-";
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(899, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 23);
            this.closeButton.TabIndex = 47;
            this.closeButton.TabStop = false;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimumPerTradePercentageRadioButton
            // 
            this.minimumPerTradePercentageRadioButton.Location = new System.Drawing.Point(12, 0);
            this.minimumPerTradePercentageRadioButton.Name = "minimumPerTradePercentageRadioButton";
            this.minimumPerTradePercentageRadioButton.Size = new System.Drawing.Size(15, 23);
            this.minimumPerTradePercentageRadioButton.TabIndex = 48;
            this.minimumPerTradePercentageRadioButton.Text = "radioButton1";
            this.minimumPerTradePercentageRadioButton.UseVisualStyleBackColor = true;
            // 
            // minimumPerTradeCurrencyRadioButton
            // 
            this.minimumPerTradeCurrencyRadioButton.Location = new System.Drawing.Point(49, 0);
            this.minimumPerTradeCurrencyRadioButton.Name = "minimumPerTradeCurrencyRadioButton";
            this.minimumPerTradeCurrencyRadioButton.Size = new System.Drawing.Size(15, 23);
            this.minimumPerTradeCurrencyRadioButton.TabIndex = 49;
            this.minimumPerTradeCurrencyRadioButton.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(401, 492);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 13);
            this.label22.TabIndex = 52;
            this.label22.Text = "%        Currency";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(401, 549);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 13);
            this.label23.TabIndex = 53;
            this.label23.Text = "%       Currency";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.minimumPerTradePercentageRadioButton);
            this.panel1.Controls.Add(this.minimumPerTradeCurrencyRadioButton);
            this.panel1.Location = new System.Drawing.Point(392, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 22);
            this.panel1.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.maximumPerTradePercentageRadioButton);
            this.panel2.Controls.Add(this.maximumPerTradeCurrencyRadioButton);
            this.panel2.Location = new System.Drawing.Point(392, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(84, 22);
            this.panel2.TabIndex = 55;
            // 
            // maximumPerTradePercentageRadioButton
            // 
            this.maximumPerTradePercentageRadioButton.Location = new System.Drawing.Point(12, 0);
            this.maximumPerTradePercentageRadioButton.Name = "maximumPerTradePercentageRadioButton";
            this.maximumPerTradePercentageRadioButton.Size = new System.Drawing.Size(15, 23);
            this.maximumPerTradePercentageRadioButton.TabIndex = 48;
            this.maximumPerTradePercentageRadioButton.Text = "radioButton5";
            this.maximumPerTradePercentageRadioButton.UseVisualStyleBackColor = true;
            // 
            // maximumPerTradeCurrencyRadioButton
            // 
            this.maximumPerTradeCurrencyRadioButton.Location = new System.Drawing.Point(49, 0);
            this.maximumPerTradeCurrencyRadioButton.Name = "maximumPerTradeCurrencyRadioButton";
            this.maximumPerTradeCurrencyRadioButton.Size = new System.Drawing.Size(15, 23);
            this.maximumPerTradeCurrencyRadioButton.TabIndex = 49;
            this.maximumPerTradeCurrencyRadioButton.Text = "CZK, EUR, USD";
            this.maximumPerTradeCurrencyRadioButton.UseVisualStyleBackColor = true;
            // 
            // testButton
            // 
            this.testButton.Enabled = false;
            this.testButton.Location = new System.Drawing.Point(323, 40);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(205, 53);
            this.testButton.TabIndex = 56;
            this.testButton.TabStop = false;
            this.testButton.Text = "Test Button";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Visible = false;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currencyLabel.ForeColor = System.Drawing.Color.White;
            this.currencyLabel.Location = new System.Drawing.Point(388, 320);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(0, 25);
            this.currencyLabel.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(674, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 60;
            this.label9.Text = "To buy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(942, 657);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.currencyLabel);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.gainLabel);
            this.Controls.Add(this.riskingTextBox);
            this.Controls.Add(this.gainTextBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.loadUsdbutton);
            this.Controls.Add(this.loadCzkbutton);
            this.Controls.Add(this.loadEurbutton);
            this.Controls.Add(this.setUsdButton);
            this.Controls.Add(this.setCzkButton);
            this.Controls.Add(this.oneRLabel);
            this.Controls.Add(this.riskTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.commissionsMaxPerTradeNumericUpDown);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.commissionsMinPerTradeNumericUpDown);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.commissionsPerTradeNumericUpDown);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.commissionsPerShareNumericUpDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.commissionsPercentageNumericUpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.riskRewardLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.finalPriceTextBox);
            this.Controls.Add(this.riskRewardTextBox);
            this.Controls.Add(this.numberOfSharesTextBox);
            this.Controls.Add(this.riskPercentageNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.takeProfitLabel);
            this.Controls.Add(this.takeProfitTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stopLossTextBox);
            this.Controls.Add(this.setEurButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sharePriceTextBox);
            this.Controls.Add(this.capitalTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Stock Helper";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.riskPercentageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionsPercentageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionsPerShareNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionsPerTradeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionsMinPerTradeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionsMaxPerTradeNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox capitalTextBox;
        private System.Windows.Forms.RichTextBox sharePriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button setEurButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox stopLossTextBox;
        private System.Windows.Forms.Label takeProfitLabel;
        private System.Windows.Forms.RichTextBox takeProfitTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown riskPercentageNumericUpDown;
        private System.Windows.Forms.RichTextBox numberOfSharesTextBox;
        private System.Windows.Forms.RichTextBox riskRewardTextBox;
        private System.Windows.Forms.RichTextBox finalPriceTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label riskRewardLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown commissionsPercentageNumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown commissionsPerShareNumericUpDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown commissionsPerTradeNumericUpDown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown commissionsMinPerTradeNumericUpDown;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown commissionsMaxPerTradeNumericUpDown;
        private System.Windows.Forms.TextBox riskTextBox;
        private System.Windows.Forms.Label oneRLabel;
        private System.Windows.Forms.Button setCzkButton;
        private System.Windows.Forms.Button setUsdButton;
        private System.Windows.Forms.Button loadUsdbutton;
        private System.Windows.Forms.Button loadCzkbutton;
        private System.Windows.Forms.Button loadEurbutton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RichTextBox gainTextBox;
        private System.Windows.Forms.RichTextBox riskingTextBox;
        private System.Windows.Forms.Label gainLabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.RadioButton minimumPerTradePercentageRadioButton;
        private System.Windows.Forms.RadioButton minimumPerTradeCurrencyRadioButton;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton maximumPerTradePercentageRadioButton;
        private System.Windows.Forms.RadioButton maximumPerTradeCurrencyRadioButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.Label label9;
    }
}

