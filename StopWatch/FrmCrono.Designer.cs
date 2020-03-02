namespace StopWatch
{
    partial class FrmCrono
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
            this.lblEndA = new System.Windows.Forms.Label();
            this.lblEndB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnCrono = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEndA
            // 
            this.lblEndA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEndA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEndA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndA.Location = new System.Drawing.Point(297, 111);
            this.lblEndA.Name = "lblEndA";
            this.lblEndA.Size = new System.Drawing.Size(101, 30);
            this.lblEndA.TabIndex = 1;
            this.lblEndA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEndB
            // 
            this.lblEndB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEndB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEndB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndB.Location = new System.Drawing.Point(426, 111);
            this.lblEndB.Name = "lblEndB";
            this.lblEndB.Size = new System.Drawing.Size(101, 30);
            this.lblEndB.TabIndex = 1;
            this.lblEndB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tempo Cronometrado (ms)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRestart.Location = new System.Drawing.Point(61, 153);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(149, 77);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Pause";
            this.btnRestart.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRestart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // btnCrono
            // 
            this.btnCrono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrono.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCrono.Location = new System.Drawing.Point(61, 55);
            this.btnCrono.Name = "btnCrono";
            this.btnCrono.Size = new System.Drawing.Size(149, 77);
            this.btnCrono.TabIndex = 0;
            this.btnCrono.Text = "Crono";
            this.btnCrono.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCrono.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCrono.UseVisualStyleBackColor = true;
            this.btnCrono.Click += new System.EventHandler(this.BtnCrono_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(297, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cronometro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(426, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "DateTime";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(297, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 2);
            this.label3.TabIndex = 3;
            // 
            // FrmCrono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 277);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEndB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEndA);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnCrono);
            this.Name = "FrmCrono";
            this.Text = "CRONOMETRANDO ...";
            this.Load += new System.EventHandler(this.FrmCrono_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEndA;
        private System.Windows.Forms.Label lblEndB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnCrono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

