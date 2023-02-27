namespace FunctionCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numC = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panResultado = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblRaizDelta = new System.Windows.Forms.Label();
            this.lblDeltaRes = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panX = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcX = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).BeginInit();
            this.panResultado.SuspendLayout();
            this.panX.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo de Equação de Segundo Grau";
            // 
            // numA
            // 
            this.numA.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numA.Location = new System.Drawing.Point(31, 78);
            this.numA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numA.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numA.Name = "numA";
            this.numA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numA.Size = new System.Drawing.Size(48, 20);
            this.numA.TabIndex = 1;
            this.numA.ValueChanged += new System.EventHandler(this.numA_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "x²";
            // 
            // numB
            // 
            this.numB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numB.Location = new System.Drawing.Point(120, 78);
            this.numB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numB.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(56, 20);
            this.numB.TabIndex = 3;
            this.numB.ValueChanged += new System.EventHandler(this.numB_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "x +";
            // 
            // numC
            // 
            this.numC.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numC.Location = new System.Drawing.Point(228, 78);
            this.numC.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numC.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(57, 20);
            this.numC.TabIndex = 5;
            this.numC.ValueChanged += new System.EventHandler(this.numC_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "= 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Δ =";
            // 
            // lblB
            // 
            this.lblB.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.Red;
            this.lblB.Location = new System.Drawing.Point(79, 142);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(35, 24);
            this.lblB.TabIndex = 8;
            this.lblB.Text = "B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "²  - 4 .";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.Red;
            this.lblA.Location = new System.Drawing.Point(178, 142);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(25, 24);
            this.lblA.TabIndex = 10;
            this.lblA.Text = "A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(202, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = ".";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.Red;
            this.lblC.Location = new System.Drawing.Point(224, 142);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(25, 24);
            this.lblC.TabIndex = 12;
            this.lblC.Text = "C";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(255, 142);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(118, 23);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Calcular Δ";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 24);
            this.label11.TabIndex = 14;
            this.label11.Text = "Resultados";
            // 
            // panResultado
            // 
            this.panResultado.Controls.Add(this.lblTipo);
            this.panResultado.Controls.Add(this.lblRaizDelta);
            this.panResultado.Controls.Add(this.lblDeltaRes);
            this.panResultado.Controls.Add(this.label14);
            this.panResultado.Controls.Add(this.label13);
            this.panResultado.Controls.Add(this.label12);
            this.panResultado.Location = new System.Drawing.Point(31, 202);
            this.panResultado.Name = "panResultado";
            this.panResultado.Size = new System.Drawing.Size(363, 122);
            this.panResultado.TabIndex = 15;
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(117, 73);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(233, 44);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "------";
            // 
            // lblRaizDelta
            // 
            this.lblRaizDelta.AutoSize = true;
            this.lblRaizDelta.Location = new System.Drawing.Point(109, 45);
            this.lblRaizDelta.Name = "lblRaizDelta";
            this.lblRaizDelta.Size = new System.Drawing.Size(25, 13);
            this.lblRaizDelta.TabIndex = 8;
            this.lblRaizDelta.Text = "------";
            // 
            // lblDeltaRes
            // 
            this.lblDeltaRes.AutoSize = true;
            this.lblDeltaRes.Location = new System.Drawing.Point(109, 13);
            this.lblDeltaRes.Name = "lblDeltaRes";
            this.lblDeltaRes.Size = new System.Drawing.Size(25, 13);
            this.lblDeltaRes.TabIndex = 7;
            this.lblDeltaRes.Text = "------";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 18);
            this.label14.TabIndex = 2;
            this.label14.Text = "Tipo de Raís = ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Raíz de Δ = ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Valor de Δ = ";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX2.Location = new System.Drawing.Point(288, 84);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(14, 16);
            this.lblX2.TabIndex = 6;
            this.lblX2.Text = "0";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX1.Location = new System.Drawing.Point(288, 54);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(14, 16);
            this.lblX1.TabIndex = 5;
            this.lblX1.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(194, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "Valor do x2 = ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(194, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Valor do x1 = ";
            // 
            // panX
            // 
            this.panX.Controls.Add(this.label6);
            this.panX.Controls.Add(this.btnCalcX);
            this.panX.Controls.Add(this.label15);
            this.panX.Controls.Add(this.label16);
            this.panX.Controls.Add(this.lblX1);
            this.panX.Controls.Add(this.lblX2);
            this.panX.Location = new System.Drawing.Point(31, 341);
            this.panX.Name = "panX";
            this.panX.Size = new System.Drawing.Size(363, 124);
            this.panX.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Calcular X1 e X2";
            // 
            // btnCalcX
            // 
            this.btnCalcX.Location = new System.Drawing.Point(34, 65);
            this.btnCalcX.Name = "btnCalcX";
            this.btnCalcX.Size = new System.Drawing.Size(111, 23);
            this.btnCalcX.TabIndex = 0;
            this.btnCalcX.Text = "Calcular X1 e X2";
            this.btnCalcX.UseVisualStyleBackColor = true;
            this.btnCalcX.Click += new System.EventHandler(this.btnCalcX_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(41, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(136, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "B";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(238, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 19);
            this.label17.TabIndex = 19;
            this.label17.Text = "C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 477);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panX);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panResultado);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).EndInit();
            this.panResultado.ResumeLayout(false);
            this.panResultado.PerformLayout();
            this.panX.ResumeLayout(false);
            this.panX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panResultado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblRaizDelta;
        private System.Windows.Forms.Label lblDeltaRes;
        private System.Windows.Forms.Panel panX;
        private System.Windows.Forms.Button btnCalcX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
    }
}

