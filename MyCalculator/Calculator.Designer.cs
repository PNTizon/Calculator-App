namespace MyCalculator
{
    partial class Calculator
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
            Zero = new Button();
            Decimal = new Button();
            EqualSign = new Button();
            AdditionSign = new Button();
            three = new Button();
            two = new Button();
            One = new Button();
            SubtractionSign = new Button();
            Six = new Button();
            Five = new Button();
            Four = new Button();
            MultiplySign = new Button();
            Nine = new Button();
            Eight = new Button();
            Seven = new Button();
            DivisionSign = new Button();
            button18 = new Button();
            ClearEntry = new Button();
            ClearButton = new Button();
            txtOutput = new TextBox();
            txtOperationBox = new TextBox();
            SuspendLayout();
            // 
            // Zero
            // 
            Zero.Anchor = AnchorStyles.None;
            Zero.BackColor = SystemColors.Control;
            Zero.Font = new Font("Segoe UI", 14.25F);
            Zero.Location = new Point(8, 356);
            Zero.Name = "Zero";
            Zero.Size = new Size(138, 60);
            Zero.TabIndex = 1;
            Zero.TabStop = false;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = false;
            Zero.Click += button_click;
            // 
            // Decimal
            // 
            Decimal.Anchor = AnchorStyles.None;
            Decimal.BackColor = SystemColors.Control;
            Decimal.Font = new Font("Segoe UI", 14.25F);
            Decimal.Location = new Point(147, 356);
            Decimal.Name = "Decimal";
            Decimal.Size = new Size(66, 60);
            Decimal.TabIndex = 2;
            Decimal.TabStop = false;
            Decimal.Text = ".";
            Decimal.UseVisualStyleBackColor = false;
            Decimal.Click += button_click;
            // 
            // EqualSign
            // 
            EqualSign.Anchor = AnchorStyles.None;
            EqualSign.BackColor = Color.FromArgb(255, 128, 0);
            EqualSign.Font = new Font("Segoe UI", 14.25F);
            EqualSign.Location = new Point(214, 356);
            EqualSign.Name = "EqualSign";
            EqualSign.Size = new Size(82, 60);
            EqualSign.TabIndex = 3;
            EqualSign.TabStop = false;
            EqualSign.Text = "=";
            EqualSign.UseVisualStyleBackColor = false;
            EqualSign.Click += EqualSign_Click;
            // 
            // AdditionSign
            // 
            AdditionSign.Anchor = AnchorStyles.None;
            AdditionSign.BackColor = Color.FromArgb(255, 128, 0);
            AdditionSign.Font = new Font("Segoe UI", 14.25F);
            AdditionSign.Location = new Point(214, 295);
            AdditionSign.Name = "AdditionSign";
            AdditionSign.Size = new Size(82, 60);
            AdditionSign.TabIndex = 7;
            AdditionSign.TabStop = false;
            AdditionSign.Text = "+";
            AdditionSign.UseVisualStyleBackColor = false;
            AdditionSign.Click += operation_click;
            // 
            // three
            // 
            three.Anchor = AnchorStyles.None;
            three.BackColor = SystemColors.Control;
            three.Font = new Font("Segoe UI", 14.25F);
            three.Location = new Point(147, 295);
            three.Name = "three";
            three.Size = new Size(66, 60);
            three.TabIndex = 6;
            three.TabStop = false;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += button_click;
            // 
            // two
            // 
            two.Anchor = AnchorStyles.None;
            two.BackColor = SystemColors.Control;
            two.Font = new Font("Segoe UI", 14.25F);
            two.Location = new Point(80, 295);
            two.Name = "two";
            two.Size = new Size(66, 60);
            two.TabIndex = 5;
            two.TabStop = false;
            two.Text = "2";
            two.UseVisualStyleBackColor = false;
            two.Click += button_click;
            // 
            // One
            // 
            One.Anchor = AnchorStyles.None;
            One.BackColor = SystemColors.Control;
            One.Font = new Font("Segoe UI", 14.25F);
            One.Location = new Point(8, 295);
            One.Name = "One";
            One.Size = new Size(70, 60);
            One.TabIndex = 4;
            One.TabStop = false;
            One.Text = "1";
            One.UseVisualStyleBackColor = false;
            One.Click += button_click;
            // 
            // SubtractionSign
            // 
            SubtractionSign.Anchor = AnchorStyles.None;
            SubtractionSign.BackColor = Color.FromArgb(255, 128, 0);
            SubtractionSign.Font = new Font("Segoe UI", 14.25F);
            SubtractionSign.Location = new Point(214, 235);
            SubtractionSign.Name = "SubtractionSign";
            SubtractionSign.Size = new Size(82, 60);
            SubtractionSign.TabIndex = 11;
            SubtractionSign.TabStop = false;
            SubtractionSign.Text = "-";
            SubtractionSign.UseVisualStyleBackColor = false;
            SubtractionSign.Click += operation_click;
            // 
            // Six
            // 
            Six.Anchor = AnchorStyles.None;
            Six.BackColor = SystemColors.Control;
            Six.Font = new Font("Segoe UI", 14.25F);
            Six.Location = new Point(147, 235);
            Six.Name = "Six";
            Six.Size = new Size(66, 60);
            Six.TabIndex = 10;
            Six.TabStop = false;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = false;
            Six.Click += button_click;
            // 
            // Five
            // 
            Five.Anchor = AnchorStyles.None;
            Five.BackColor = SystemColors.Control;
            Five.Font = new Font("Segoe UI", 14.25F);
            Five.Location = new Point(80, 235);
            Five.Name = "Five";
            Five.Size = new Size(66, 60);
            Five.TabIndex = 9;
            Five.TabStop = false;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = false;
            Five.Click += button_click;
            // 
            // Four
            // 
            Four.Anchor = AnchorStyles.None;
            Four.BackColor = SystemColors.Control;
            Four.Font = new Font("Segoe UI", 14.25F);
            Four.Location = new Point(8, 235);
            Four.Name = "Four";
            Four.Size = new Size(70, 60);
            Four.TabIndex = 8;
            Four.TabStop = false;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = false;
            Four.Click += button_click;
            // 
            // MultiplySign
            // 
            MultiplySign.Anchor = AnchorStyles.None;
            MultiplySign.BackColor = Color.FromArgb(255, 128, 0);
            MultiplySign.Font = new Font("Segoe UI", 14.25F);
            MultiplySign.Location = new Point(214, 173);
            MultiplySign.Name = "MultiplySign";
            MultiplySign.Size = new Size(82, 60);
            MultiplySign.TabIndex = 15;
            MultiplySign.TabStop = false;
            MultiplySign.Text = "*";
            MultiplySign.UseVisualStyleBackColor = false;
            MultiplySign.Click += operation_click;
            // 
            // Nine
            // 
            Nine.Anchor = AnchorStyles.None;
            Nine.BackColor = SystemColors.Control;
            Nine.Font = new Font("Segoe UI", 14.25F);
            Nine.Location = new Point(147, 173);
            Nine.Name = "Nine";
            Nine.Size = new Size(66, 60);
            Nine.TabIndex = 14;
            Nine.TabStop = false;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = false;
            Nine.Click += button_click;
            // 
            // Eight
            // 
            Eight.Anchor = AnchorStyles.None;
            Eight.BackColor = SystemColors.Control;
            Eight.Font = new Font("Segoe UI", 14.25F);
            Eight.Location = new Point(80, 173);
            Eight.Name = "Eight";
            Eight.Size = new Size(66, 60);
            Eight.TabIndex = 13;
            Eight.TabStop = false;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = false;
            Eight.Click += button_click;
            // 
            // Seven
            // 
            Seven.Anchor = AnchorStyles.None;
            Seven.BackColor = SystemColors.Control;
            Seven.Font = new Font("Segoe UI", 14.25F);
            Seven.Location = new Point(8, 173);
            Seven.Name = "Seven";
            Seven.Size = new Size(70, 60);
            Seven.TabIndex = 12;
            Seven.TabStop = false;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = false;
            Seven.Click += button_click;
            // 
            // DivisionSign
            // 
            DivisionSign.Anchor = AnchorStyles.None;
            DivisionSign.BackColor = Color.FromArgb(255, 128, 0);
            DivisionSign.Font = new Font("Segoe UI", 14.25F);
            DivisionSign.Location = new Point(214, 112);
            DivisionSign.Name = "DivisionSign";
            DivisionSign.Size = new Size(82, 60);
            DivisionSign.TabIndex = 19;
            DivisionSign.TabStop = false;
            DivisionSign.Text = "/";
            DivisionSign.UseVisualStyleBackColor = false;
            DivisionSign.Click += operation_click;
            // 
            // button18
            // 
            button18.Anchor = AnchorStyles.None;
            button18.BackColor = SystemColors.Control;
            button18.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button18.Location = new Point(147, 112);
            button18.Name = "button18";
            button18.Size = new Size(66, 60);
            button18.TabIndex = 18;
            button18.TabStop = false;
            button18.Text = "%";
            button18.UseVisualStyleBackColor = false;
            button18.Click += btnPercent_Click;
            // 
            // ClearEntry
            // 
            ClearEntry.Anchor = AnchorStyles.None;
            ClearEntry.BackColor = SystemColors.Control;
            ClearEntry.Font = new Font("Segoe UI", 14.25F);
            ClearEntry.Location = new Point(80, 112);
            ClearEntry.Name = "ClearEntry";
            ClearEntry.Size = new Size(66, 60);
            ClearEntry.TabIndex = 17;
            ClearEntry.TabStop = false;
            ClearEntry.Text = "CE";
            ClearEntry.UseVisualStyleBackColor = false;
            ClearEntry.Click += ClearEntry_Click;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.None;
            ClearButton.BackColor = SystemColors.Control;
            ClearButton.Font = new Font("Segoe UI", 14.25F);
            ClearButton.Location = new Point(8, 112);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(70, 60);
            ClearButton.TabIndex = 16;
            ClearButton.TabStop = false;
            ClearButton.Text = "C";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += Clear_Click;
            // 
            // txtOutput
            // 
            txtOutput.Anchor = AnchorStyles.None;
            txtOutput.BackColor = SystemColors.Control;
            txtOutput.BorderStyle = BorderStyle.None;
            txtOutput.Font = new Font("Gadugi", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOutput.Location = new Point(2, 42);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(301, 67);
            txtOutput.TabIndex = 22;
            txtOutput.TabStop = false;
            txtOutput.Text = "0";
            txtOutput.TextAlign = HorizontalAlignment.Right;
            // 
            // txtOperationBox
            // 
            txtOperationBox.Anchor = AnchorStyles.None;
            txtOperationBox.BackColor = SystemColors.Control;
            txtOperationBox.BorderStyle = BorderStyle.None;
            txtOperationBox.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOperationBox.Location = new Point(2, 0);
            txtOperationBox.Multiline = true;
            txtOperationBox.Name = "txtOperationBox";
            txtOperationBox.Size = new Size(301, 33);
            txtOperationBox.TabIndex = 24;
            txtOperationBox.TabStop = false;
            txtOperationBox.TextAlign = HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 421);
            Controls.Add(txtOperationBox);
            Controls.Add(txtOutput);
            Controls.Add(DivisionSign);
            Controls.Add(button18);
            Controls.Add(ClearEntry);
            Controls.Add(ClearButton);
            Controls.Add(MultiplySign);
            Controls.Add(Nine);
            Controls.Add(Eight);
            Controls.Add(Seven);
            Controls.Add(SubtractionSign);
            Controls.Add(Six);
            Controls.Add(Five);
            Controls.Add(Four);
            Controls.Add(AdditionSign);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(One);
            Controls.Add(EqualSign);
            Controls.Add(Decimal);
            Controls.Add(Zero);
            ForeColor = Color.Black;
            Name = "Calculator";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button Zero;
        private Button Decimal;
        private Button EqualSign;
        private Button AdditionSign;
        private Button three;
        private Button two;
        private Button One;
        private Button SubtractionSign;
        private Button Six;
        private Button Five;
        private Button Four;
        private Button button11;
        private Button button12;
        private Button MultiplySign;
        private Button Nine;
        private Button Eight;
        private Button button14;
        private Button button15;
        private Button Seven;
        private Button DivisionSign;
        private Button button18;
        private Button ClearEntry;
        private Button ClearButton;
        private TextBox txtOutput;
        private TextBox txtOperationBox;
    }
}
