namespace UTR_E3.Eventos_y_sus_parámetros__lógica_de_negocio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCalc = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnComa = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCalc
            // 
            this.txtCalc.Location = new System.Drawing.Point(12, 12);
            this.txtCalc.Name = "txtCalc";
            this.txtCalc.ReadOnly = true;
            this.txtCalc.Size = new System.Drawing.Size(225, 20);
            this.txtCalc.TabIndex = 0;
            this.txtCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 38);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(35, 23);
            this.btn7.TabIndex = 1;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(53, 38);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(35, 23);
            this.btn8.TabIndex = 2;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(94, 38);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(35, 23);
            this.btn9.TabIndex = 3;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(135, 38);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(35, 23);
            this.btnDiv.TabIndex = 4;
            this.btnDiv.Tag = "/";
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnMS
            // 
            this.btnMS.Location = new System.Drawing.Point(176, 38);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(61, 23);
            this.btnMS.TabIndex = 5;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 67);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(34, 23);
            this.btn4.TabIndex = 6;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(52, 67);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(35, 23);
            this.btn5.TabIndex = 7;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(94, 67);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(35, 23);
            this.btn6.TabIndex = 8;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(135, 67);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(35, 23);
            this.btnMul.TabIndex = 9;
            this.btnMul.Tag = "*";
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnMR
            // 
            this.btnMR.Location = new System.Drawing.Point(176, 67);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(61, 23);
            this.btnMR.TabIndex = 10;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 96);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 23);
            this.btn1.TabIndex = 11;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(52, 96);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 23);
            this.btn2.TabIndex = 12;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(94, 96);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(35, 23);
            this.btn3.TabIndex = 13;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(135, 96);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(35, 23);
            this.btnRes.TabIndex = 14;
            this.btnRes.Tag = "-";
            this.btnRes.Text = "-";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(176, 96);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(61, 23);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "C";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 125);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 23);
            this.btn0.TabIndex = 16;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnComa
            // 
            this.btnComa.Location = new System.Drawing.Point(94, 125);
            this.btnComa.Name = "btnComa";
            this.btnComa.Size = new System.Drawing.Size(35, 23);
            this.btnComa.TabIndex = 17;
            this.btnComa.Text = ".";
            this.btnComa.UseVisualStyleBackColor = true;
            this.btnComa.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(135, 125);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(35, 23);
            this.btnSum.TabIndex = 18;
            this.btnSum.Tag = "+";
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(176, 124);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(61, 24);
            this.btnIgual.TabIndex = 19;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnIgual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 162);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnComa);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCalc;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnComa;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnIgual;
    }
}

