namespace aula_funçoes
{
    partial class lbresultado
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.lbresultadoo = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb1
            // 
            this.txb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb1.Location = new System.Drawing.Point(111, 69);
            this.txb1.Multiline = true;
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(100, 43);
            this.txb1.TabIndex = 0;
            // 
            // txb2
            // 
            this.txb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb2.Location = new System.Drawing.Point(244, 69);
            this.txb2.Multiline = true;
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(100, 43);
            this.txb2.TabIndex = 1;
            // 
            // lbresultadoo
            // 
            this.lbresultadoo.Font = new System.Drawing.Font("Swis721 Blk BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresultadoo.Location = new System.Drawing.Point(350, 66);
            this.lbresultadoo.Name = "lbresultadoo";
            this.lbresultadoo.Size = new System.Drawing.Size(133, 46);
            this.lbresultadoo.TabIndex = 2;
            this.lbresultadoo.Text = "R:";
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Swis721 Hv BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(108, 139);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(103, 99);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "+";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Swis721 Blk BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(241, 139);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(103, 99);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "-";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Font = new System.Drawing.Font("Swis721 Blk BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicar.Location = new System.Drawing.Point(108, 244);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(103, 108);
            this.btnmultiplicar.TabIndex = 5;
            this.btnmultiplicar.Text = "x";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btndividir
            // 
            this.btndividir.Font = new System.Drawing.Font("Swis721 Blk BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndividir.Location = new System.Drawing.Point(244, 244);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(103, 108);
            this.btndividir.TabIndex = 6;
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // lbresultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbresultadoo);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Name = "lbresultado";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.Label lbresultadoo;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btndividir;
    }
}

