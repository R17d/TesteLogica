namespace TesteLogica
{
    partial class FrmTestLogic
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
            this.btnResult = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbNumber2 = new System.Windows.Forms.Label();
            this.lbNumber1 = new System.Windows.Forms.Label();
            this.btnAdic = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(17, 180);
            this.btnResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(251, 67);
            this.btnResult.TabIndex = 12;
            this.btnResult.Text = "Calcular";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(17, 287);
            this.txtResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(251, 27);
            this.txtResult.TabIndex = 11;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(154, 79);
            this.txtN2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(114, 27);
            this.txtN2.TabIndex = 10;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(17, 79);
            this.txtN1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(114, 27);
            this.txtN1.TabIndex = 9;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(28, 251);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(75, 20);
            this.lbResult.TabIndex = 15;
            this.lbResult.Text = "Resultado";
            // 
            // lbNumber2
            // 
            this.lbNumber2.AutoSize = true;
            this.lbNumber2.Location = new System.Drawing.Point(165, 44);
            this.lbNumber2.Name = "lbNumber2";
            this.lbNumber2.Size = new System.Drawing.Size(35, 20);
            this.lbNumber2.TabIndex = 14;
            this.lbNumber2.Text = "N. 2";
            // 
            // lbNumber1
            // 
            this.lbNumber1.AutoSize = true;
            this.lbNumber1.Location = new System.Drawing.Point(28, 44);
            this.lbNumber1.Name = "lbNumber1";
            this.lbNumber1.Size = new System.Drawing.Size(35, 20);
            this.lbNumber1.TabIndex = 13;
            this.lbNumber1.Text = "N. 1";
            // 
            // btnAdic
            // 
            this.btnAdic.Location = new System.Drawing.Point(17, 114);
            this.btnAdic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdic.Name = "btnAdic";
            this.btnAdic.Size = new System.Drawing.Size(46, 32);
            this.btnAdic.TabIndex = 16;
            this.btnAdic.Text = "+";
            this.btnAdic.UseVisualStyleBackColor = true;
            this.btnAdic.Click += new System.EventHandler(this.btnAdic_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(85, 114);
            this.btnSub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(46, 32);
            this.btnSub.TabIndex = 17;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click_1);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(154, 114);
            this.btnMult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(46, 32);
            this.btnMult.TabIndex = 18;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(222, 114);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(46, 32);
            this.btnDiv.TabIndex = 19;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "l";
            // 
            // FrmTestLogic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 392);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdic);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbNumber2);
            this.Controls.Add(this.lbNumber1);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Name = "FrmTestLogic";
            this.Text = "Teste Lógica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnResult;
        private TextBox txtResult;
        private TextBox txtN2;
        private TextBox txtN1;
        private Label lbResult;
        private Label lbNumber2;
        private Label lbNumber1;
        private Button btnAdic;
        private Button btnSub;
        private Button btnMult;
        private Button btnDiv;
        private Label label1;
    }
}