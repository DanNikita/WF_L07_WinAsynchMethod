﻿namespace WinAsynchMethod
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
            txbA = new TextBox();
            txbB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txbA
            // 
            txbA.Location = new Point(102, 33);
            txbA.Name = "txbA";
            txbA.Size = new Size(100, 23);
            txbA.TabIndex = 0;
            // 
            // txbB
            // 
            txbB.Location = new Point(336, 33);
            txbB.Name = "txbB";
            txbB.Size = new Size(100, 23);
            txbB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Value A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 41);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Value B";
            // 
            // button1
            // 
            button1.Location = new Point(29, 81);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Summarize";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(150, 128);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Work";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(260, 81);
            button3.Name = "button3";
            button3.Size = new Size(91, 23);
            button3.TabIndex = 6;
            button3.Text = "Substraction";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(279, 132);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(38, 15);
            lblResult.TabIndex = 7;
            lblResult.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 174);
            Controls.Add(lblResult);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbB);
            Controls.Add(txbA);
            Name = "Form1";
            Text = "Asynch Work";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbA;
        private TextBox txbB;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblResult;
    }
}
