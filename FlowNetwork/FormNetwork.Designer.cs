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
            this.btn_add_pipe = new System.Windows.Forms.Button();
            this.lblSelectedComponent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonMerger = new System.Windows.Forms.Button();
            this.buttonSplitter = new System.Windows.Forms.Button();
            this.buttonSink = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btn_add_pipe);
            this.panel1.Controls.Add(this.lblSelectedComponent);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.buttonMerger);
            this.panel1.Controls.Add(this.buttonSplitter);
            this.panel1.Controls.Add(this.buttonSink);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbflow);
            this.panel1.Controls.Add(this.tbcapacity);
            this.panel1.Controls.Add(this.btsubmit);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 524);
            this.panel1.TabIndex = 0;
            // 
            // btn_add_pipe
            // 
            this.btn_add_pipe.Location = new System.Drawing.Point(16, 337);
            this.btn_add_pipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add_pipe.Name = "btn_add_pipe";
            this.btn_add_pipe.Size = new System.Drawing.Size(74, 51);
            this.btn_add_pipe.TabIndex = 21;
            this.btn_add_pipe.Text = "button2";
            this.btn_add_pipe.UseVisualStyleBackColor = true;
            this.btn_add_pipe.Click += new System.EventHandler(this.btn_add_pipe_Click);
            // 
            // lblSelectedComponent
            // 
            this.lblSelectedComponent.AutoSize = true;
            this.lblSelectedComponent.Location = new System.Drawing.Point(133, 4);
            this.lblSelectedComponent.Name = "lblSelectedComponent";
            this.lblSelectedComponent.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedComponent.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "You have selected a:";
            // 
            // buttonMerger
            // 
            this.buttonMerger.BackgroundImage = global::FlowNetwork.Properties.Resources.merger;
            this.buttonMerger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMerger.Location = new System.Drawing.Point(26, 255);
            this.buttonMerger.Name = "buttonMerger";
            this.buttonMerger.Size = new System.Drawing.Size(64, 65);
            this.buttonMerger.TabIndex = 18;
            this.buttonMerger.UseVisualStyleBackColor = true;
            this.buttonMerger.Click += new System.EventHandler(this.buttonMerger_Click);
            // 
            // buttonSplitter
            // 
            this.buttonSplitter.BackgroundImage = global::FlowNetwork.Properties.Resources.splitter;
            this.buttonSplitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSplitter.Location = new System.Drawing.Point(26, 171);
            this.buttonSplitter.Name = "buttonSplitter";
            this.buttonSplitter.Size = new System.Drawing.Size(64, 65);
            this.buttonSplitter.TabIndex = 17;
            this.buttonSplitter.UseVisualStyleBackColor = true;
            this.buttonSplitter.Click += new System.EventHandler(this.buttonSplitter_Click);
            // 
            // buttonSink
            // 
            this.buttonSink.BackgroundImage = global::FlowNetwork.Properties.Resources.sink;
            this.buttonSink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSink.Location = new System.Drawing.Point(26, 94);
            this.buttonSink.Name = "buttonSink";
            this.buttonSink.Size = new System.Drawing.Size(64, 65);
            this.buttonSink.TabIndex = 16;
            this.buttonSink.UseVisualStyleBackColor = true;
            this.buttonSink.Click += new System.EventHandler(this.buttonSink_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FlowNetwork.Properties.Resources.pump2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(26, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 65);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "PIPE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "MERGER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "SPLITTER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "SINK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "PUMP";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(26, 337);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 61);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CAPACITY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CURRENT FLOW";
            // 
            // tbflow
            // 
            this.tbflow.Location = new System.Drawing.Point(133, 411);
            this.tbflow.Name = "tbflow";
            this.tbflow.Size = new System.Drawing.Size(52, 20);
            this.tbflow.TabIndex = 2;
            // 
            // tbcapacity
            // 
            this.tbcapacity.Location = new System.Drawing.Point(133, 439);
            this.tbcapacity.Name = "tbcapacity";
            this.tbcapacity.Size = new System.Drawing.Size(52, 20);
            this.tbcapacity.TabIndex = 1;
            // 
            // btsubmit
            // 
            this.btsubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsubmit.ForeColor = System.Drawing.Color.Black;
            this.btsubmit.Location = new System.Drawing.Point(26, 465);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(159, 46);
            this.btsubmit.TabIndex = 0;
            this.btsubmit.Text = "SUBMIT";
            this.btsubmit.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Location = new System.Drawing.Point(295, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 524);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btremove
            // 
            this.btremove.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btremove.Location = new System.Drawing.Point(295, 546);
            this.btremove.Name = "btremove";
            this.btremove.Size = new System.Drawing.Size(125, 72);
            this.btremove.TabIndex = 2;
            this.btremove.Text = "REMOVE";
            this.btremove.UseVisualStyleBackColor = false;
            // 
            // btreset
            // 
            this.btreset.BackColor = System.Drawing.Color.LightGreen;
            this.btreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreset.Location = new System.Drawing.Point(465, 545);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(125, 73);
            this.btreset.TabIndex = 3;
            this.btreset.Text = "RESET";
            this.btreset.UseVisualStyleBackColor = false;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btsave
            // 
            this.btsave.BackColor = System.Drawing.Color.LightGreen;
            this.btsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.Location = new System.Drawing.Point(626, 546);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(125, 33);
            this.btsave.TabIndex = 4;
            this.btsave.Text = "SAVE";
            this.btsave.UseVisualStyleBackColor = false;
            // 
            // btload
            // 
            this.btload.BackColor = System.Drawing.Color.LightGreen;
            this.btload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btload.Location = new System.Drawing.Point(815, 546);
            this.btload.Name = "btload";
            this.btload.Size = new System.Drawing.Size(125, 72);
            this.btload.TabIndex = 5;
            this.btload.Text = "LOAD";
            this.btload.UseVisualStyleBackColor = false;
            // 
            // btsaveas
            // 
            this.btsaveas.BackColor = System.Drawing.Color.LightGreen;
            this.btsaveas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsaveas.Location = new System.Drawing.Point(626, 585);
            this.btsaveas.Name = "btsaveas";
            this.btsaveas.Size = new System.Drawing.Size(125, 34);
            this.btsaveas.TabIndex = 6;
            this.btsaveas.Text = "SAVE AS";
            this.btsaveas.UseVisualStyleBackColor = false;
            // 
            // FormNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 476);
            this.Controls.Add(this.btsaveas);
            this.Controls.Add(this.btload);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btremove);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormNetwork";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormNetwork_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMerger;
        private System.Windows.Forms.Button buttonSplitter;
        private System.Windows.Forms.Button buttonSink;
        private System.Windows.Forms.Label lblSelectedComponent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_add_pipe;
    }
}

