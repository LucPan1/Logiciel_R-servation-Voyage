namespace exo1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelDepart = new System.Windows.Forms.Label();
            this.labelArrivee = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelNbPlaceDispo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(72, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 160);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.ForeColor = System.Drawing.Color.Lime;
            this.labelDestination.Location = new System.Drawing.Point(76, 27);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(82, 13);
            this.labelDestination.TabIndex = 4;
            this.labelDestination.Text = "labelDestination";
            // 
            // labelDepart
            // 
            this.labelDepart.AutoSize = true;
            this.labelDepart.ForeColor = System.Drawing.Color.Black;
            this.labelDepart.Location = new System.Drawing.Point(92, 85);
            this.labelDepart.Name = "labelDepart";
            this.labelDepart.Size = new System.Drawing.Size(61, 13);
            this.labelDepart.TabIndex = 5;
            this.labelDepart.Text = "labelDepart";
            // 
            // labelArrivee
            // 
            this.labelArrivee.AutoSize = true;
            this.labelArrivee.ForeColor = System.Drawing.Color.Black;
            this.labelArrivee.Location = new System.Drawing.Point(92, 118);
            this.labelArrivee.Name = "labelArrivee";
            this.labelArrivee.Size = new System.Drawing.Size(56, 13);
            this.labelArrivee.TabIndex = 6;
            this.labelArrivee.Text = "labelArrive";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.ForeColor = System.Drawing.Color.Gold;
            this.labelPrix.Location = new System.Drawing.Point(40, 55);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(46, 13);
            this.labelPrix.TabIndex = 7;
            this.labelPrix.Text = "labelPrix";
            // 
            // labelNbPlaceDispo
            // 
            this.labelNbPlaceDispo.AutoSize = true;
            this.labelNbPlaceDispo.ForeColor = System.Drawing.Color.Crimson;
            this.labelNbPlaceDispo.Location = new System.Drawing.Point(161, 154);
            this.labelNbPlaceDispo.Name = "labelNbPlaceDispo";
            this.labelNbPlaceDispo.Size = new System.Drawing.Size(102, 13);
            this.labelNbPlaceDispo.TabIndex = 8;
            this.labelNbPlaceDispo.Text = "labelNbPlacesDispo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonConfirmer);
            this.groupBox1.Controls.Add(this.labelDepart);
            this.groupBox1.Controls.Add(this.labelDestination);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelArrivee);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelPrix);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelNbPlaceDispo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(251, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 222);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Réservation de voyages";
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.Location = new System.Drawing.Point(133, 184);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmer.TabIndex = 37;
            this.buttonConfirmer.Text = "Reserver";
            this.buttonConfirmer.UseVisualStyleBackColor = true;
            this.buttonConfirmer.Click += new System.EventHandler(this.buttonConfirmer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(7, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nombre de places disponible:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Prix:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Date d\'arrivée:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date de départ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(7, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Destination:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.Text = "Reservation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelDepart;
        private System.Windows.Forms.Label labelArrivee;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelNbPlaceDispo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonConfirmer;
    }
}

