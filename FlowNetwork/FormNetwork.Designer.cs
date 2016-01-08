namespace FlowNetwork
{
    partial class FormNetwork
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbflow = new System.Windows.Forms.TextBox();
            this.tbcapacity = new System.Windows.Forms.TextBox();
            this.btsubmit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btremove = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.btload = new System.Windows.Forms.Button();
            this.btsaveas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbflow);
            this.panel1.Controls.Add(this.tbcapacity);
            this.panel1.Controls.Add(this.btsubmit);
            this.panel1.Location = new System.Drawing.Point(38, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 806);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(168, 554);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "PIPE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 429);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "MERGER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "SPLITTER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "SINK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "PUMP";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(39, 518);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(96, 94);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FlowNetwork.Properties.Resources.merger;
            this.pictureBox4.InitialImage = global::FlowNetwork.Properties.Resources.merger;
            this.pictureBox4.Location = new System.Drawing.Point(39, 394);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(96, 100);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FlowNetwork.Properties.Resources.splitter;
            this.pictureBox3.InitialImage = global::FlowNetwork.Properties.Resources.splitter;
            this.pictureBox3.Location = new System.Drawing.Point(39, 266);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 102);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FlowNetwork.Properties.Resources.sink;
            this.pictureBox2.Location = new System.Drawing.Point(39, 145);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 98);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::FlowNetwork.Properties.Resources.pump2;
            this.pictureBox1.Image = global::FlowNetwork.Properties.Resources.pump2;
            this.pictureBox1.InitialImage = global::FlowNetwork.Properties.Resources.sink;
            this.pictureBox1.Location = new System.Drawing.Point(38, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 680);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "CAPACITY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 637);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "CURRENT FLOW";
            // 
            // tbflow
            // 
            this.tbflow.Location = new System.Drawing.Point(200, 632);
            this.tbflow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbflow.Name = "tbflow";
            this.tbflow.Size = new System.Drawing.Size(76, 26);
            this.tbflow.TabIndex = 2;
            // 
            // tbcapacity
            // 
            this.tbcapacity.Location = new System.Drawing.Point(200, 675);
            this.tbcapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcapacity.Name = "tbcapacity";
            this.tbcapacity.Size = new System.Drawing.Size(76, 26);
            this.tbcapacity.TabIndex = 1;
            // 
            // btsubmit
            // 
            this.btsubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsubmit.ForeColor = System.Drawing.Color.Black;
            this.btsubmit.Location = new System.Drawing.Point(39, 715);
            this.btsubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(238, 71);
            this.btsubmit.TabIndex = 0;
            this.btsubmit.Text = "SUBMIT";
            this.btsubmit.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Location = new System.Drawing.Point(376, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 663);
            this.panel2.TabIndex = 1;
            // 
            // btremove
            // 
            this.btremove.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btremove.Location = new System.Drawing.Point(376, 711);
            this.btremove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btremove.Name = "btremove";
            this.btremove.Size = new System.Drawing.Size(188, 111);
            this.btremove.TabIndex = 2;
            this.btremove.Text = "REMOVE";
            this.btremove.UseVisualStyleBackColor = false;
            // 
            // btreset
            // 
            this.btreset.BackColor = System.Drawing.Color.LightGreen;
            this.btreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreset.Location = new System.Drawing.Point(591, 711);
            this.btreset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(188, 112);
            this.btreset.TabIndex = 3;
            this.btreset.Text = "RESET";
            this.btreset.UseVisualStyleBackColor = false;
            // 
            // btsave
            // 
            this.btsave.BackColor = System.Drawing.Color.LightGreen;
            this.btsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.Location = new System.Drawing.Point(807, 711);
            this.btsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(188, 51);
            this.btsave.TabIndex = 4;
            this.btsave.Text = "SAVE";
            this.btsave.UseVisualStyleBackColor = false;
            // 
            // btload
            // 
            this.btload.BackColor = System.Drawing.Color.LightGreen;
            this.btload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btload.Location = new System.Drawing.Point(1029, 711);
            this.btload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btload.Name = "btload";
            this.btload.Size = new System.Drawing.Size(188, 111);
            this.btload.TabIndex = 5;
            this.btload.Text = "LOAD";
            this.btload.UseVisualStyleBackColor = false;
            // 
            // btsaveas
            // 
            this.btsaveas.BackColor = System.Drawing.Color.LightGreen;
            this.btsaveas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsaveas.Location = new System.Drawing.Point(807, 769);
            this.btsaveas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btsaveas.Name = "btsaveas";
            this.btsaveas.Size = new System.Drawing.Size(188, 52);
            this.btsaveas.TabIndex = 6;
            this.btsaveas.Text = "SAVE AS";
            this.btsaveas.UseVisualStyleBackColor = false;
            // 
            // FormNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 843);
            this.Controls.Add(this.btsaveas);
            this.Controls.Add(this.btload);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btremove);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNetwork";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbflow;
        private System.Windows.Forms.TextBox tbcapacity;
        private System.Windows.Forms.Button btsubmit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btremove;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btload;
        private System.Windows.Forms.Button btsaveas;
    }
}

