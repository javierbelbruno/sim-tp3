namespace WindowsFormsApplication1
{
    partial class TP3
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInicio = new System.Windows.Forms.Label();
            this.btnUniforme = new System.Windows.Forms.Button();
            this.btnExpo = new System.Windows.Forms.Button();
            this.btnPoisson = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.lbl_Aleatorio = new System.Windows.Forms.Label();
            this.txt_numeros = new System.Windows.Forms.TextBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.dgv_numeros = new System.Windows.Forms.DataGridView();
            this.lbl_media = new System.Windows.Forms.Label();
            this.txt_media = new System.Windows.Forms.TextBox();
            this.lbl_lambda = new System.Windows.Forms.Label();
            this.txt_lambda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_numeros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(541, 56);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(141, 16);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Seleccione un método:";
            // 
            // btnUniforme
            // 
            this.btnUniforme.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUniforme.Location = new System.Drawing.Point(544, 85);
            this.btnUniforme.Name = "btnUniforme";
            this.btnUniforme.Size = new System.Drawing.Size(158, 49);
            this.btnUniforme.TabIndex = 1;
            this.btnUniforme.Text = "UNIFORME";
            this.btnUniforme.UseVisualStyleBackColor = true;
            this.btnUniforme.Click += new System.EventHandler(this.btnUniforme_Click);
            // 
            // btnExpo
            // 
            this.btnExpo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpo.Location = new System.Drawing.Point(544, 160);
            this.btnExpo.Name = "btnExpo";
            this.btnExpo.Size = new System.Drawing.Size(158, 49);
            this.btnExpo.TabIndex = 2;
            this.btnExpo.Text = "EXPONENCIAL";
            this.btnExpo.UseVisualStyleBackColor = true;
            this.btnExpo.Click += new System.EventHandler(this.btnExpo_Click);
            // 
            // btnPoisson
            // 
            this.btnPoisson.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoisson.Location = new System.Drawing.Point(544, 230);
            this.btnPoisson.Name = "btnPoisson";
            this.btnPoisson.Size = new System.Drawing.Size(158, 49);
            this.btnPoisson.TabIndex = 3;
            this.btnPoisson.Text = "POISSON";
            this.btnPoisson.UseVisualStyleBackColor = true;
            this.btnPoisson.Click += new System.EventHandler(this.btnPoisson_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.Location = new System.Drawing.Point(544, 298);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(158, 49);
            this.btnNormal.TabIndex = 4;
            this.btnNormal.Text = "NORMAL";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // lbl_Aleatorio
            // 
            this.lbl_Aleatorio.AutoSize = true;
            this.lbl_Aleatorio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aleatorio.Location = new System.Drawing.Point(34, 25);
            this.lbl_Aleatorio.Name = "lbl_Aleatorio";
            this.lbl_Aleatorio.Size = new System.Drawing.Size(310, 16);
            this.lbl_Aleatorio.TabIndex = 5;
            this.lbl_Aleatorio.Text = "Ingrese la cantidad de aleatorios que desea generar:";
            // 
            // txt_numeros
            // 
            this.txt_numeros.Location = new System.Drawing.Point(37, 58);
            this.txt_numeros.Name = "txt_numeros";
            this.txt_numeros.Size = new System.Drawing.Size(230, 20);
            this.txt_numeros.TabIndex = 7;
            this.txt_numeros.TextChanged += new System.EventHandler(this.txt_numeros_TextChanged);
            // 
            // btn_generar
            // 
            this.btn_generar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(288, 56);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(232, 23);
            this.btn_generar.TabIndex = 8;
            this.btn_generar.Text = "Generar números aleatorios";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // dgv_numeros
            // 
            this.dgv_numeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_numeros.Location = new System.Drawing.Point(37, 85);
            this.dgv_numeros.Name = "dgv_numeros";
            this.dgv_numeros.Size = new System.Drawing.Size(483, 262);
            this.dgv_numeros.TabIndex = 9;
            this.dgv_numeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_numeros_CellContentClick);
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Location = new System.Drawing.Point(53, 366);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(39, 13);
            this.lbl_media.TabIndex = 10;
            this.lbl_media.Text = "Media:";
            // 
            // txt_media
            // 
            this.txt_media.Enabled = false;
            this.txt_media.Location = new System.Drawing.Point(112, 359);
            this.txt_media.Name = "txt_media";
            this.txt_media.Size = new System.Drawing.Size(126, 20);
            this.txt_media.TabIndex = 11;
            this.txt_media.TextChanged += new System.EventHandler(this.txt_media_TextChanged);
            // 
            // lbl_lambda
            // 
            this.lbl_lambda.AutoSize = true;
            this.lbl_lambda.Location = new System.Drawing.Point(53, 402);
            this.lbl_lambda.Name = "lbl_lambda";
            this.lbl_lambda.Size = new System.Drawing.Size(48, 13);
            this.lbl_lambda.TabIndex = 12;
            this.lbl_lambda.Text = "Lambda:";
            // 
            // txt_lambda
            // 
            this.txt_lambda.Enabled = false;
            this.txt_lambda.Location = new System.Drawing.Point(112, 394);
            this.txt_lambda.Name = "txt_lambda";
            this.txt_lambda.Size = new System.Drawing.Size(126, 20);
            this.txt_lambda.TabIndex = 13;
            this.txt_lambda.TextChanged += new System.EventHandler(this.txt_lambda_TextChanged);
            // 
            // TP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 498);
            this.Controls.Add(this.txt_lambda);
            this.Controls.Add(this.lbl_lambda);
            this.Controls.Add(this.txt_media);
            this.Controls.Add(this.lbl_media);
            this.Controls.Add(this.dgv_numeros);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.txt_numeros);
            this.Controls.Add(this.lbl_Aleatorio);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnPoisson);
            this.Controls.Add(this.btnExpo);
            this.Controls.Add(this.btnUniforme);
            this.Controls.Add(this.lblInicio);
            this.Name = "TP3";
            this.Text = "TP N2 SIMULACION";
            this.Load += new System.EventHandler(this.TP3Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_numeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Button btnUniforme;
        private System.Windows.Forms.Button btnExpo;
        private System.Windows.Forms.Button btnPoisson;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Label lbl_Aleatorio;
        private System.Windows.Forms.TextBox txt_numeros;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.DataGridView dgv_numeros;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.TextBox txt_media;
        private System.Windows.Forms.Label lbl_lambda;
        private System.Windows.Forms.TextBox txt_lambda;
    }
}

