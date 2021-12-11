
namespace SimpleRobot
{
    partial class frmRobot
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
            this.btnEast = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnGoTen = new System.Windows.Forms.Button();
            this.btnGoOne = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRobot = new System.Windows.Forms.Label();
            this.lblCoord = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(175, 327);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(42, 42);
            this.btnEast.TabIndex = 0;
            this.btnEast.Tag = "E";
            this.btnEast.Text = "E";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.Direction_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(79, 327);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(42, 42);
            this.btnWest.TabIndex = 1;
            this.btnWest.Tag = "W";
            this.btnWest.Text = "W";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.Direction_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(127, 299);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(42, 42);
            this.btnNorth.TabIndex = 2;
            this.btnNorth.Tag = "N";
            this.btnNorth.Text = "N";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.Direction_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(127, 361);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(42, 42);
            this.btnSouth.TabIndex = 3;
            this.btnSouth.Tag = "S";
            this.btnSouth.Text = "S";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.Direction_Click);
            // 
            // btnGoTen
            // 
            this.btnGoTen.Location = new System.Drawing.Point(233, 337);
            this.btnGoTen.Name = "btnGoTen";
            this.btnGoTen.Size = new System.Drawing.Size(75, 23);
            this.btnGoTen.TabIndex = 4;
            this.btnGoTen.Text = "Go 10";
            this.btnGoTen.UseVisualStyleBackColor = true;
            this.btnGoTen.Click += new System.EventHandler(this.btnGoTen_Click);
            // 
            // btnGoOne
            // 
            this.btnGoOne.Location = new System.Drawing.Point(12, 337);
            this.btnGoOne.Name = "btnGoOne";
            this.btnGoOne.Size = new System.Drawing.Size(52, 23);
            this.btnGoOne.TabIndex = 5;
            this.btnGoOne.Text = "Go 1";
            this.btnGoOne.UseVisualStyleBackColor = true;
            this.btnGoOne.Click += new System.EventHandler(this.btnGoOne_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(233, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lblRobot);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 266);
            this.panel1.TabIndex = 7;
            // 
            // lblRobot
            // 
            this.lblRobot.AutoSize = true;
            this.lblRobot.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRobot.Location = new System.Drawing.Point(125, 108);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(0, 17);
            this.lblRobot.TabIndex = 0;
            // 
            // lblCoord
            // 
            this.lblCoord.AutoSize = true;
            this.lblCoord.Location = new System.Drawing.Point(112, 9);
            this.lblCoord.Name = "lblCoord";
            this.lblCoord.Size = new System.Drawing.Size(0, 15);
            this.lblCoord.TabIndex = 8;
            // 
            // frmRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.lblCoord);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoOne);
            this.Controls.Add(this.btnGoTen);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnEast);
            this.Name = "frmRobot";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmRobot_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnGoTen;
        private System.Windows.Forms.Button btnGoOne;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCoord;
        private System.Windows.Forms.Label lblRobot;
    }
}

