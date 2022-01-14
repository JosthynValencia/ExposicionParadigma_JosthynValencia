namespace applista
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboGENERO = new System.Windows.Forms.ComboBox();
            this.comboESTADOCIVIL = new System.Windows.Forms.ComboBox();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.txtEDAD = new System.Windows.Forms.TextBox();
            this.btnLISTA = new System.Windows.Forms.Button();
            this.listViewEMPLEADOS = new System.Windows.Forms.ListView();
            this.columnNOMBRECOMPLETO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGENERO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnESTADOCIVIL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEDAD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE COMPLETO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "GENERO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ESTADO CIVIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "EDAD";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboGENERO
            // 
            this.comboGENERO.FormattingEnabled = true;
            this.comboGENERO.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.comboGENERO.Location = new System.Drawing.Point(207, 56);
            this.comboGENERO.Name = "comboGENERO";
            this.comboGENERO.Size = new System.Drawing.Size(135, 21);
            this.comboGENERO.TabIndex = 5;
            // 
            // comboESTADOCIVIL
            // 
            this.comboESTADOCIVIL.FormattingEnabled = true;
            this.comboESTADOCIVIL.Items.AddRange(new object[] {
            "SOLTERO",
            "CASADO",
            "VIUDO",
            "DIVORCIADO",
            "UNION LIBRE"});
            this.comboESTADOCIVIL.Location = new System.Drawing.Point(372, 56);
            this.comboESTADOCIVIL.Name = "comboESTADOCIVIL";
            this.comboESTADOCIVIL.Size = new System.Drawing.Size(147, 21);
            this.comboESTADOCIVIL.TabIndex = 6;
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(46, 58);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(121, 20);
            this.txtNOMBRE.TabIndex = 7;
            // 
            // txtEDAD
            // 
            this.txtEDAD.Location = new System.Drawing.Point(571, 54);
            this.txtEDAD.Name = "txtEDAD";
            this.txtEDAD.Size = new System.Drawing.Size(104, 20);
            this.txtEDAD.TabIndex = 8;
            // 
            // btnLISTA
            // 
            this.btnLISTA.Location = new System.Drawing.Point(37, 84);
            this.btnLISTA.Name = "btnLISTA";
            this.btnLISTA.Size = new System.Drawing.Size(143, 39);
            this.btnLISTA.TabIndex = 9;
            this.btnLISTA.Text = "AGREGAR LISTA";
            this.btnLISTA.UseVisualStyleBackColor = true;
            this.btnLISTA.Click += new System.EventHandler(this.btnLISTA_Click);
            // 
            // listViewESTUDIANTES
            // 
            this.listViewEMPLEADOS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNOMBRECOMPLETO,
            this.columnGENERO,
            this.columnESTADOCIVIL,
            this.columnEDAD});
            this.listViewEMPLEADOS.HideSelection = false;
            this.listViewEMPLEADOS.Location = new System.Drawing.Point(12, 129);
            this.listViewEMPLEADOS.Name = "listViewESTUDIANTES";
            this.listViewEMPLEADOS.Size = new System.Drawing.Size(662, 211);
            this.listViewEMPLEADOS.TabIndex = 10;
            this.listViewEMPLEADOS.UseCompatibleStateImageBehavior = false;
            this.listViewEMPLEADOS.View = System.Windows.Forms.View.Details;
            // 
            // columnNOMBRECOMPLETO
            // 
            this.columnNOMBRECOMPLETO.Text = "NOMBRECOMPLETO";
            // 
            // columnGENERO
            // 
            this.columnGENERO.Text = "GENERO";
            // 
            // columnESTADOCIVIL
            // 
            this.columnESTADOCIVIL.Text = "ESTADOCIVIL";
            // 
            // columnEDAD
            // 
            this.columnEDAD.Text = "EDAD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewEMPLEADOS);
            this.Controls.Add(this.btnLISTA);
            this.Controls.Add(this.txtEDAD);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.comboESTADOCIVIL);
            this.Controls.Add(this.comboGENERO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboGENERO;
        private System.Windows.Forms.ComboBox comboESTADOCIVIL;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.TextBox txtEDAD;
        private System.Windows.Forms.Button btnLISTA;
        private System.Windows.Forms.ListView listViewEMPLEADOS;
        private System.Windows.Forms.ColumnHeader columnNOMBRECOMPLETO;
        private System.Windows.Forms.ColumnHeader columnGENERO;
        private System.Windows.Forms.ColumnHeader columnESTADOCIVIL;
        private System.Windows.Forms.ColumnHeader columnEDAD;
    }
}

