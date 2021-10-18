
namespace Proyecto_final
{
    partial class Reservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservacion));
            this.label1 = new System.Windows.Forms.Label();
            this.DestinoCombox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIDCLIENTE = new System.Windows.Forms.TextBox();
            this.txtNOMBRECLIENTE = new System.Windows.Forms.TextBox();
            this.txtAPELLIDOCLIENTE = new System.Windows.Forms.TextBox();
            this.txtEMAILCLIENTE = new System.Windows.Forms.TextBox();
            this.txtDIRECCION = new System.Windows.Forms.TextBox();
            this.txtIDVUELO = new System.Windows.Forms.TextBox();
            this.txtASIENTOCLIENTE = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.OrigenCombox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTELEFCLIENTE = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 19;
            this.label1.Tag = "";
            this.label1.Text = "Origen:";
            // 
            // DestinoCombox
            // 
            this.DestinoCombox.FormattingEnabled = true;
            this.DestinoCombox.Location = new System.Drawing.Point(453, 54);
            this.DestinoCombox.Name = "DestinoCombox";
            this.DestinoCombox.Size = new System.Drawing.Size(207, 21);
            this.DestinoCombox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 21;
            this.label2.Tag = "";
            this.label2.Text = "Destino:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(937, 677);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(978, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 26);
            this.label4.TabIndex = 25;
            this.label4.Tag = "";
            this.label4.Text = "ID de cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(978, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 26);
            this.label5.TabIndex = 26;
            this.label5.Tag = "";
            this.label5.Text = "Nombre de Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(978, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 26);
            this.label6.TabIndex = 27;
            this.label6.Tag = "";
            this.label6.Text = "Apellido de Cliente:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(675, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 38);
            this.button1.TabIndex = 28;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1304, 703);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 38);
            this.button2.TabIndex = 29;
            this.button2.Text = "Reservar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(978, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 26);
            this.label7.TabIndex = 30;
            this.label7.Tag = "";
            this.label7.Text = "Fecha de nacimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(978, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 26);
            this.label8.TabIndex = 31;
            this.label8.Tag = "";
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(978, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 26);
            this.label9.TabIndex = 32;
            this.label9.Tag = "";
            this.label9.Text = "Teléfono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(978, 507);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 26);
            this.label10.TabIndex = 33;
            this.label10.Tag = "";
            this.label10.Text = "Fecha de viaje:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(978, 453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 26);
            this.label11.TabIndex = 34;
            this.label11.Tag = "";
            this.label11.Text = "Dirección:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(978, 564);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 26);
            this.label12.TabIndex = 35;
            this.label12.Tag = "";
            this.label12.Text = "ID de vuelo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(978, 613);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 26);
            this.label13.TabIndex = 36;
            this.label13.Tag = "";
            this.label13.Text = "Asiento#:";
            // 
            // txtIDCLIENTE
            // 
            this.txtIDCLIENTE.Location = new System.Drawing.Point(1201, 125);
            this.txtIDCLIENTE.Name = "txtIDCLIENTE";
            this.txtIDCLIENTE.Size = new System.Drawing.Size(337, 20);
            this.txtIDCLIENTE.TabIndex = 38;
            // 
            // txtNOMBRECLIENTE
            // 
            this.txtNOMBRECLIENTE.Location = new System.Drawing.Point(1201, 190);
            this.txtNOMBRECLIENTE.Name = "txtNOMBRECLIENTE";
            this.txtNOMBRECLIENTE.ReadOnly = true;
            this.txtNOMBRECLIENTE.Size = new System.Drawing.Size(337, 20);
            this.txtNOMBRECLIENTE.TabIndex = 39;
            // 
            // txtAPELLIDOCLIENTE
            // 
            this.txtAPELLIDOCLIENTE.Location = new System.Drawing.Point(1201, 246);
            this.txtAPELLIDOCLIENTE.Name = "txtAPELLIDOCLIENTE";
            this.txtAPELLIDOCLIENTE.ReadOnly = true;
            this.txtAPELLIDOCLIENTE.Size = new System.Drawing.Size(337, 20);
            this.txtAPELLIDOCLIENTE.TabIndex = 40;
            // 
            // txtEMAILCLIENTE
            // 
            this.txtEMAILCLIENTE.Location = new System.Drawing.Point(1204, 354);
            this.txtEMAILCLIENTE.Name = "txtEMAILCLIENTE";
            this.txtEMAILCLIENTE.ReadOnly = true;
            this.txtEMAILCLIENTE.Size = new System.Drawing.Size(337, 20);
            this.txtEMAILCLIENTE.TabIndex = 41;
            // 
            // txtDIRECCION
            // 
            this.txtDIRECCION.Location = new System.Drawing.Point(1204, 459);
            this.txtDIRECCION.Name = "txtDIRECCION";
            this.txtDIRECCION.ReadOnly = true;
            this.txtDIRECCION.Size = new System.Drawing.Size(337, 20);
            this.txtDIRECCION.TabIndex = 42;
            // 
            // txtIDVUELO
            // 
            this.txtIDVUELO.Location = new System.Drawing.Point(1201, 570);
            this.txtIDVUELO.Name = "txtIDVUELO";
            this.txtIDVUELO.ReadOnly = true;
            this.txtIDVUELO.Size = new System.Drawing.Size(337, 20);
            this.txtIDVUELO.TabIndex = 44;
            // 
            // txtASIENTOCLIENTE
            // 
            this.txtASIENTOCLIENTE.Location = new System.Drawing.Point(1201, 619);
            this.txtASIENTOCLIENTE.Name = "txtASIENTOCLIENTE";
            this.txtASIENTOCLIENTE.Size = new System.Drawing.Size(337, 20);
            this.txtASIENTOCLIENTE.TabIndex = 45;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1201, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(337, 20);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Californian FB", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1263, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(212, 30);
            this.label14.TabIndex = 47;
            this.label14.Tag = "";
            this.label14.Text = "Reservación de tickets";
            // 
            // OrigenCombox
            // 
            this.OrigenCombox.FormattingEnabled = true;
            this.OrigenCombox.Location = new System.Drawing.Point(95, 53);
            this.OrigenCombox.Name = "OrigenCombox";
            this.OrigenCombox.Size = new System.Drawing.Size(207, 21);
            this.OrigenCombox.TabIndex = 48;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1453, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 38);
            this.button3.TabIndex = 50;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTELEFCLIENTE
            // 
            this.txtTELEFCLIENTE.Location = new System.Drawing.Point(1204, 403);
            this.txtTELEFCLIENTE.Name = "txtTELEFCLIENTE";
            this.txtTELEFCLIENTE.ReadOnly = true;
            this.txtTELEFCLIENTE.Size = new System.Drawing.Size(337, 20);
            this.txtTELEFCLIENTE.TabIndex = 51;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1204, 513);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(337, 20);
            this.dateTimePicker2.TabIndex = 52;
            // 
            // Reservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txtTELEFCLIENTE);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.OrigenCombox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtASIENTOCLIENTE);
            this.Controls.Add(this.txtIDVUELO);
            this.Controls.Add(this.txtDIRECCION);
            this.Controls.Add(this.txtEMAILCLIENTE);
            this.Controls.Add(this.txtAPELLIDOCLIENTE);
            this.Controls.Add(this.txtNOMBRECLIENTE);
            this.Controls.Add(this.txtIDCLIENTE);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DestinoCombox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reservacion";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DestinoCombox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIDCLIENTE;
        private System.Windows.Forms.TextBox txtNOMBRECLIENTE;
        private System.Windows.Forms.TextBox txtAPELLIDOCLIENTE;
        private System.Windows.Forms.TextBox txtEMAILCLIENTE;
        private System.Windows.Forms.TextBox txtDIRECCION;
        private System.Windows.Forms.TextBox txtIDVUELO;
        private System.Windows.Forms.TextBox txtASIENTOCLIENTE;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox OrigenCombox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtTELEFCLIENTE;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}