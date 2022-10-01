namespace E4.Polymorphism_Example
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
            this.lblHuman = new System.Windows.Forms.Label();
            this.lblWarwick = new System.Windows.Forms.Label();
            this.lblRammus = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHuman
            // 
            this.lblHuman.BackColor = System.Drawing.Color.Pink;
            this.lblHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHuman.Location = new System.Drawing.Point(78, 64);
            this.lblHuman.Name = "lblHuman";
            this.lblHuman.Size = new System.Drawing.Size(132, 56);
            this.lblHuman.TabIndex = 0;
            this.lblHuman.Text = "Human";
            this.lblHuman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWarwick
            // 
            this.lblWarwick.BackColor = System.Drawing.Color.Pink;
            this.lblWarwick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarwick.Location = new System.Drawing.Point(78, 166);
            this.lblWarwick.Name = "lblWarwick";
            this.lblWarwick.Size = new System.Drawing.Size(132, 56);
            this.lblWarwick.TabIndex = 0;
            this.lblWarwick.Text = "warwick";
            this.lblWarwick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRammus
            // 
            this.lblRammus.BackColor = System.Drawing.Color.Pink;
            this.lblRammus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRammus.Location = new System.Drawing.Point(78, 279);
            this.lblRammus.Name = "lblRammus";
            this.lblRammus.Size = new System.Drawing.Size(132, 56);
            this.lblRammus.TabIndex = 0;
            this.lblRammus.Text = "Rammus";
            this.lblRammus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.HotPink;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinish.Location = new System.Drawing.Point(660, 35);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(17, 379);
            this.lblFinish.TabIndex = 0;
            this.lblFinish.Text = "Finish";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Chocolate;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.Color.Cyan;
            this.btnStart.Location = new System.Drawing.Point(42, 378);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(212, 52);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 1000;
            this.tmrGame.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblRammus);
            this.Controls.Add(this.lblWarwick);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblHuman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHuman;
        private System.Windows.Forms.Label lblWarwick;
        private System.Windows.Forms.Label lblRammus;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrGame;
    }
}

