namespace TM_GUI
{
    partial class TM_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TM_GUI));
            this.buttonNext = new System.Windows.Forms.Button();
            this.currentStateLabel = new System.Windows.Forms.Label();
            this.tapeLabel = new System.Windows.Forms.Label();
            this.listViewMachineTape = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelCurrentState = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(226, 155);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(69, 23);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Następny";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // currentStateLabel
            // 
            this.currentStateLabel.AutoSize = true;
            this.currentStateLabel.Location = new System.Drawing.Point(12, 16);
            this.currentStateLabel.Name = "currentStateLabel";
            this.currentStateLabel.Size = new System.Drawing.Size(71, 13);
            this.currentStateLabel.TabIndex = 1;
            this.currentStateLabel.Text = "Aktualny stan";
            // 
            // tapeLabel
            // 
            this.tapeLabel.AutoSize = true;
            this.tapeLabel.Location = new System.Drawing.Point(8, 92);
            this.tapeLabel.Name = "tapeLabel";
            this.tapeLabel.Size = new System.Drawing.Size(306, 13);
            this.tapeLabel.TabIndex = 3;
            this.tapeLabel.Text = "Taśma - aktualna pozycja głowicy oznaczona jest na czerwono";
            // 
            // listViewMachineTape
            // 
            this.listViewMachineTape.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listViewMachineTape.BackgroundImage")));
            this.listViewMachineTape.Location = new System.Drawing.Point(11, 108);
            this.listViewMachineTape.Name = "listViewMachineTape";
            this.listViewMachineTape.Scrollable = false;
            this.listViewMachineTape.Size = new System.Drawing.Size(512, 34);
            this.listViewMachineTape.TabIndex = 4;
            this.listViewMachineTape.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "studia niestacjonarne drugiego stopnia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Indeks: 233132";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marcin Szymkowski";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Politechnika Łódzka - informatyka EEIA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(322, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(191, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 71);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Wejście:";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(66, 45);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(53, 13);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "input_text";
            // 
            // labelCurrentState
            // 
            this.labelCurrentState.AutoSize = true;
            this.labelCurrentState.Location = new System.Drawing.Point(136, 16);
            this.labelCurrentState.Name = "labelCurrentState";
            this.labelCurrentState.Size = new System.Drawing.Size(30, 13);
            this.labelCurrentState.TabIndex = 8;
            this.labelCurrentState.Text = "state";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelInput);
            this.groupBox4.Controls.Add(this.labelCurrentState);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.currentStateLabel);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 71);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // TM_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 192);
            this.Controls.Add(this.listViewMachineTape);
            this.Controls.Add(this.tapeLabel);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TM_GUI";
            this.Text = "Maszyna Turinga";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label currentStateLabel;
        private System.Windows.Forms.Label tapeLabel;
        private System.Windows.Forms.ListView listViewMachineTape;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelCurrentState;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

