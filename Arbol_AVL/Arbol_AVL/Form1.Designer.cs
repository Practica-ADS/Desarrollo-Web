namespace Arbol_AVL
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.errores = new System.Windows.Forms.ErrorProvider(this.components);
            this.valor = new System.Windows.Forms.TextBox();
            this.post = new System.Windows.Forms.CheckBox();
            this.ino = new System.Windows.Forms.CheckBox();
            this.pre = new System.Windows.Forms.CheckBox();
            this.lblaltura = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(945, 68);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(945, 116);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(945, 162);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // errores
            // 
            this.errores.ContainerControl = this;
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(920, 219);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(100, 23);
            this.valor.TabIndex = 3;
            // 
            // post
            // 
            this.post.AutoSize = true;
            this.post.Location = new System.Drawing.Point(187, 423);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(49, 19);
            this.post.TabIndex = 4;
            this.post.Text = "Post";
            this.post.UseVisualStyleBackColor = true;
            // 
            // ino
            // 
            this.ino.AutoSize = true;
            this.ino.Location = new System.Drawing.Point(368, 423);
            this.ino.Name = "ino";
            this.ino.Size = new System.Drawing.Size(43, 19);
            this.ino.TabIndex = 5;
            this.ino.Text = "Ino";
            this.ino.UseVisualStyleBackColor = true;
            // 
            // pre
            // 
            this.pre.AutoSize = true;
            this.pre.Location = new System.Drawing.Point(547, 423);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(43, 19);
            this.pre.TabIndex = 6;
            this.pre.Text = "Pre";
            this.pre.UseVisualStyleBackColor = true;
            // 
            // lblaltura
            // 
            this.lblaltura.Location = new System.Drawing.Point(150, 472);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(498, 23);
            this.lblaltura.TabIndex = 7;
            // 
            // bsalir
            // 
            this.bsalir.Location = new System.Drawing.Point(945, 325);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(75, 23);
            this.bsalir.TabIndex = 8;
            this.bsalir.Text = "Salir";
            this.bsalir.UseVisualStyleBackColor = true;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 565);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.pre);
            this.Controls.Add(this.ino);
            this.Controls.Add(this.post);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.errores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIngresar;
        private Button btnBuscar;
        private Button btneliminar;
        private ErrorProvider errores;
        private TextBox valor;
        private TextBox lblaltura;
        private CheckBox pre;
        private CheckBox ino;
        private CheckBox post;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button bsalir;
    }
}