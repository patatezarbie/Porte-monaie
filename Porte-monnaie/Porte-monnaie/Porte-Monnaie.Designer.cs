﻿namespace Porte_monnaie
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoldeTotal = new System.Windows.Forms.Label();
            this.BtnDepense = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solde total :";
            // 
            // lblSoldeTotal
            // 
            this.lblSoldeTotal.AutoSize = true;
            this.lblSoldeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldeTotal.Location = new System.Drawing.Point(133, 9);
            this.lblSoldeTotal.Name = "lblSoldeTotal";
            this.lblSoldeTotal.Size = new System.Drawing.Size(23, 25);
            this.lblSoldeTotal.TabIndex = 1;
            this.lblSoldeTotal.Text = "0";
            // 
            // BtnDepense
            // 
            this.BtnDepense.Location = new System.Drawing.Point(15, 77);
            this.BtnDepense.Name = "BtnDepense";
            this.BtnDepense.Size = new System.Drawing.Size(75, 23);
            this.BtnDepense.TabIndex = 2;
            this.BtnDepense.Text = "Dépense";
            this.BtnDepense.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(150, 77);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(75, 23);
            this.btnStats.TabIndex = 3;
            this.btnStats.Text = "Statistiques";
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // BtnAjout
            // 
            this.BtnAjout.Location = new System.Drawing.Point(278, 77);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(75, 23);
            this.BtnAjout.TabIndex = 4;
            this.BtnAjout.Text = "Ajout";
            this.BtnAjout.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 180);
            this.dataGridView1.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 372);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAjout);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.BtnDepense);
            this.Controls.Add(this.lblSoldeTotal);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Porte ma monnaie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoldeTotal;
        private System.Windows.Forms.Button BtnDepense;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.DataGridView dataGridView1;


    }
}

