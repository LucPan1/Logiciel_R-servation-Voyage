namespace exo1.Formulaire
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPassagers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPlaceDispo = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.labelArr = new System.Windows.Forms.Label();
            this.labelDep = new System.Windows.Forms.Label();
            this.labelDes = new System.Windows.Forms.Label();
            this.nbPersonnesChoisi = new System.Windows.Forms.TextBox();
            this.labelPlacesAReserver = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirmer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Date de départ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(86, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Destination :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Date d\'arrivé:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(347, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Place disponible :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Montant Total TTC:";
            // 
            // labelPassagers
            // 
            this.labelPassagers.AutoSize = true;
            this.labelPassagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassagers.ForeColor = System.Drawing.Color.Maroon;
            this.labelPassagers.Location = new System.Drawing.Point(473, 93);
            this.labelPassagers.Name = "labelPassagers";
            this.labelPassagers.Size = new System.Drawing.Size(130, 18);
            this.labelPassagers.TabIndex = 30;
            this.labelPassagers.Text = "labelPlaceReserve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(344, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Place(s) réservé :";
            // 
            // labelPlaceDispo
            // 
            this.labelPlaceDispo.AutoSize = true;
            this.labelPlaceDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaceDispo.ForeColor = System.Drawing.Color.Red;
            this.labelPlaceDispo.Location = new System.Drawing.Point(485, 150);
            this.labelPlaceDispo.Name = "labelPlaceDispo";
            this.labelPlaceDispo.Size = new System.Drawing.Size(109, 17);
            this.labelPlaceDispo.TabIndex = 28;
            this.labelPlaceDispo.Text = "labelPlaceDispo";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontant.ForeColor = System.Drawing.Color.Black;
            this.labelMontant.Location = new System.Drawing.Point(482, 210);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(121, 17);
            this.labelMontant.TabIndex = 27;
            this.labelMontant.Text = "labelMontantTotal";
            // 
            // labelArr
            // 
            this.labelArr.AutoSize = true;
            this.labelArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArr.ForeColor = System.Drawing.Color.Black;
            this.labelArr.Location = new System.Drawing.Point(206, 199);
            this.labelArr.Name = "labelArr";
            this.labelArr.Size = new System.Drawing.Size(83, 17);
            this.labelArr.TabIndex = 26;
            this.labelArr.Text = "labelArrivee";
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDep.ForeColor = System.Drawing.Color.Black;
            this.labelDep.Location = new System.Drawing.Point(208, 149);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(81, 17);
            this.labelDep.TabIndex = 25;
            this.labelDep.Text = "labelDepart";
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDes.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelDes.Location = new System.Drawing.Point(206, 95);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(109, 17);
            this.labelDes.TabIndex = 24;
            this.labelDes.Text = "labelDestination";
            // 
            // nbPersonnesChoisi
            // 
            this.nbPersonnesChoisi.Location = new System.Drawing.Point(284, 45);
            this.nbPersonnesChoisi.Name = "nbPersonnesChoisi";
            this.nbPersonnesChoisi.Size = new System.Drawing.Size(100, 20);
            this.nbPersonnesChoisi.TabIndex = 38;
            // 
            // labelPlacesAReserver
            // 
            this.labelPlacesAReserver.AutoSize = true;
            this.labelPlacesAReserver.Location = new System.Drawing.Point(110, 48);
            this.labelPlacesAReserver.Name = "labelPlacesAReserver";
            this.labelPlacesAReserver.Size = new System.Drawing.Size(146, 13);
            this.labelPlacesAReserver.TabIndex = 37;
            this.labelPlacesAReserver.Text = "Nombre de places à réserver:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 39);
            this.button2.TabIndex = 39;
            this.button2.Text = "Suivant";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(709, 336);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nbPersonnesChoisi);
            this.Controls.Add(this.labelPlacesAReserver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPassagers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPlaceDispo);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.labelArr);
            this.Controls.Add(this.labelDep);
            this.Controls.Add(this.labelDes);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Confirmation de la réservation";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPassagers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPlaceDispo;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.Label labelArr;
        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.TextBox nbPersonnesChoisi;
        private System.Windows.Forms.Label labelPlacesAReserver;
        private System.Windows.Forms.Button button2;
    }
}