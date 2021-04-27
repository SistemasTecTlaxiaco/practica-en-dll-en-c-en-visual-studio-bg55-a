
namespace calculadora
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
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.siete = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.uno = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.divicion = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.retroceso = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.cubo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pantalla.Location = new System.Drawing.Point(12, 12);
            this.Pantalla.Multiline = true;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(229, 36);
            this.Pantalla.TabIndex = 0;
            this.Pantalla.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(333, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // siete
            // 
            this.siete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.siete.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siete.Location = new System.Drawing.Point(12, 64);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(41, 38);
            this.siete.TabIndex = 2;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = false;
            this.siete.Click += new System.EventHandler(this.siete_Click);
            // 
            // cuatro
            // 
            this.cuatro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cuatro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuatro.Location = new System.Drawing.Point(12, 108);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(41, 38);
            this.cuatro.TabIndex = 3;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = true;
            this.cuatro.Click += new System.EventHandler(this.cuatro_Click);
            // 
            // uno
            // 
            this.uno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uno.Location = new System.Drawing.Point(12, 156);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(41, 38);
            this.uno.TabIndex = 4;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = true;
            this.uno.Click += new System.EventHandler(this.uno_Click);
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.Color.Red;
            this.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.borrar.Location = new System.Drawing.Point(153, 64);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(41, 38);
            this.borrar.TabIndex = 5;
            this.borrar.Text = "C";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // cero
            // 
            this.cero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cero.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cero.Location = new System.Drawing.Point(12, 198);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(41, 38);
            this.cero.TabIndex = 9;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = true;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // dos
            // 
            this.dos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dos.Location = new System.Drawing.Point(59, 156);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(41, 38);
            this.dos.TabIndex = 8;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = true;
            this.dos.Click += new System.EventHandler(this.dos_Click);
            // 
            // cinco
            // 
            this.cinco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cinco.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinco.Location = new System.Drawing.Point(59, 108);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(41, 38);
            this.cinco.TabIndex = 7;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // ocho
            // 
            this.ocho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ocho.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocho.Location = new System.Drawing.Point(59, 64);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(41, 38);
            this.ocho.TabIndex = 6;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = true;
            this.ocho.Click += new System.EventHandler(this.ocho_Click);
            // 
            // punto
            // 
            this.punto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.punto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punto.Location = new System.Drawing.Point(59, 198);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(41, 38);
            this.punto.TabIndex = 13;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = true;
            this.punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // tres
            // 
            this.tres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tres.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.Location = new System.Drawing.Point(106, 156);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(41, 38);
            this.tres.TabIndex = 12;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // seis
            // 
            this.seis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seis.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seis.Location = new System.Drawing.Point(106, 112);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(41, 38);
            this.seis.TabIndex = 11;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // nueve
            // 
            this.nueve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nueve.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nueve.Location = new System.Drawing.Point(106, 64);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(41, 38);
            this.nueve.TabIndex = 10;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = true;
            this.nueve.Click += new System.EventHandler(this.nueve_Click);
            // 
            // suma
            // 
            this.suma.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.suma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.suma.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.Location = new System.Drawing.Point(153, 200);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(41, 38);
            this.suma.TabIndex = 17;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = false;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // resta
            // 
            this.resta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.resta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resta.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.Location = new System.Drawing.Point(153, 156);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(41, 38);
            this.resta.TabIndex = 16;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = false;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.multiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplicacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacion.Location = new System.Drawing.Point(153, 112);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(41, 38);
            this.multiplicacion.TabIndex = 15;
            this.multiplicacion.Text = "*";
            this.multiplicacion.UseVisualStyleBackColor = false;
            this.multiplicacion.Click += new System.EventHandler(this.multiplicacion_Click);
            // 
            // divicion
            // 
            this.divicion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.divicion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divicion.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divicion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divicion.Location = new System.Drawing.Point(106, 200);
            this.divicion.Name = "divicion";
            this.divicion.Size = new System.Drawing.Size(41, 38);
            this.divicion.TabIndex = 14;
            this.divicion.Text = "/";
            this.divicion.UseVisualStyleBackColor = false;
            this.divicion.Click += new System.EventHandler(this.divicion_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.igual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.igual.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Location = new System.Drawing.Point(200, 200);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(41, 38);
            this.igual.TabIndex = 21;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // retroceso
            // 
            this.retroceso.BackColor = System.Drawing.Color.Red;
            this.retroceso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.retroceso.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retroceso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.retroceso.Location = new System.Drawing.Point(200, 64);
            this.retroceso.Name = "retroceso";
            this.retroceso.Size = new System.Drawing.Size(41, 38);
            this.retroceso.TabIndex = 22;
            this.retroceso.Text = "DEL";
            this.retroceso.UseVisualStyleBackColor = false;
            this.retroceso.Click += new System.EventHandler(this.retroceso_Click);
            // 
            // raiz
            // 
            this.raiz.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.raiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.raiz.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiz.Location = new System.Drawing.Point(200, 112);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(41, 38);
            this.raiz.TabIndex = 23;
            this.raiz.Text = "r";
            this.raiz.UseVisualStyleBackColor = false;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // cubo
            // 
            this.cubo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cubo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cubo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cubo.Location = new System.Drawing.Point(200, 156);
            this.cubo.Name = "cubo";
            this.cubo.Size = new System.Drawing.Size(41, 38);
            this.cubo.TabIndex = 24;
            this.cubo.Text = "*2";
            this.cubo.UseVisualStyleBackColor = false;
            this.cubo.Click += new System.EventHandler(this.cubo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(259, 248);
            this.Controls.Add(this.cubo);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.retroceso);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.divicion);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.nueve);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.ocho);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.uno);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.siete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pantalla);
            this.Name = "Form1";
            this.Text = "calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button siete;
        private System.Windows.Forms.Button cuatro;
        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button punto;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button nueve;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button divicion;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button retroceso;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button cubo;
    }
}

