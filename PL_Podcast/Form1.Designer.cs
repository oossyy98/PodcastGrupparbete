namespace PL_Podcast
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
            lblNamn = new Label();
            lblURL = new Label();
            lblKategori = new Label();
            lblKategorier = new Label();
            lblMinaPodcast = new Label();
            lblAvsnitt = new Label();
            lbl = new Label();
            TbxURL = new TextBox();
            TbxKategorier = new TextBox();
            TbxNamn = new TextBox();
            BtnLaggtillPodcast = new Button();
            button2 = new Button();
            BtnTaBort = new Button();
            BtnUppdateraNamn = new Button();
            button1 = new Button();
            ListAvsnitt = new ListBox();
            ListBeskrivningar = new ListBox();
            ListMinaPodcast = new ListBox();
            ListKategorier = new ListBox();
            BtnTabortPodcast = new Button();
            BtnUppdatera = new Button();
            button4 = new Button();
            CBXKategori = new ComboBox();
            SuspendLayout();
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(12, 65);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(79, 32);
            lblNamn.TabIndex = 0;
            lblNamn.Text = "Namn";
            lblNamn.Click += label1_Click;
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Location = new Point(12, 118);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(104, 32);
            lblURL.TabIndex = 1;
            lblURL.Text = "RSS/URL";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(12, 167);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(103, 32);
            lblKategori.TabIndex = 2;
            lblKategori.Text = "Kategori";
            // 
            // lblKategorier
            // 
            lblKategorier.AutoSize = true;
            lblKategorier.Location = new Point(12, 377);
            lblKategorier.Name = "lblKategorier";
            lblKategorier.Size = new Size(124, 32);
            lblKategorier.TabIndex = 3;
            lblKategorier.Text = "Kategorier";
            // 
            // lblMinaPodcast
            // 
            lblMinaPodcast.AutoSize = true;
            lblMinaPodcast.Location = new Point(536, 42);
            lblMinaPodcast.Name = "lblMinaPodcast";
            lblMinaPodcast.Size = new Size(156, 32);
            lblMinaPodcast.TabIndex = 4;
            lblMinaPodcast.Text = "Mina Podcast";
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Location = new Point(1167, 42);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(87, 32);
            lblAvsnitt.TabIndex = 5;
            lblAvsnitt.Text = "Avsnitt";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(1167, 441);
            lbl.Name = "lbl";
            lbl.Size = new Size(157, 32);
            lbl.TabIndex = 6;
            lbl.Text = "Beskrivningar";
            // 
            // TbxURL
            // 
            TbxURL.Location = new Point(128, 118);
            TbxURL.Name = "TbxURL";
            TbxURL.Size = new Size(200, 39);
            TbxURL.TabIndex = 7;
            // 
            // TbxKategorier
            // 
            TbxKategorier.Location = new Point(305, 434);
            TbxKategorier.Name = "TbxKategorier";
            TbxKategorier.Size = new Size(200, 39);
            TbxKategorier.TabIndex = 8;
            // 
            // TbxNamn
            // 
            TbxNamn.Location = new Point(128, 62);
            TbxNamn.Name = "TbxNamn";
            TbxNamn.Size = new Size(200, 39);
            TbxNamn.TabIndex = 9;
            // 
            // BtnLaggtillPodcast
            // 
            BtnLaggtillPodcast.Location = new Point(12, 248);
            BtnLaggtillPodcast.Name = "BtnLaggtillPodcast";
            BtnLaggtillPodcast.Size = new Size(316, 46);
            BtnLaggtillPodcast.TabIndex = 10;
            BtnLaggtillPodcast.Text = "Lägg till Podcast";
            BtnLaggtillPodcast.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(305, 498);
            button2.Name = "button2";
            button2.Size = new Size(200, 83);
            button2.TabIndex = 11;
            button2.Text = "Lägg till kategori";
            button2.UseVisualStyleBackColor = true;
            // 
            // BtnTaBort
            // 
            BtnTaBort.Location = new Point(305, 604);
            BtnTaBort.Name = "BtnTaBort";
            BtnTaBort.Size = new Size(200, 46);
            BtnTaBort.TabIndex = 12;
            BtnTaBort.Text = "Ta bort";
            BtnTaBort.UseVisualStyleBackColor = true;
            // 
            // BtnUppdateraNamn
            // 
            BtnUppdateraNamn.Location = new Point(305, 668);
            BtnUppdateraNamn.Name = "BtnUppdateraNamn";
            BtnUppdateraNamn.Size = new Size(200, 73);
            BtnUppdateraNamn.TabIndex = 13;
            BtnUppdateraNamn.Text = "Uppdatera namn";
            BtnUppdateraNamn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1167, 348);
            button1.Name = "button1";
            button1.Size = new Size(445, 46);
            button1.TabIndex = 14;
            button1.Text = "Sortera Avsnitt";
            button1.UseVisualStyleBackColor = true;
            // 
            // ListAvsnitt
            // 
            ListAvsnitt.FormattingEnabled = true;
            ListAvsnitt.Location = new Point(1167, 100);
            ListAvsnitt.Name = "ListAvsnitt";
            ListAvsnitt.Size = new Size(445, 228);
            ListAvsnitt.TabIndex = 15;
            // 
            // ListBeskrivningar
            // 
            ListBeskrivningar.FormattingEnabled = true;
            ListBeskrivningar.Location = new Point(1167, 476);
            ListBeskrivningar.Name = "ListBeskrivningar";
            ListBeskrivningar.Size = new Size(445, 260);
            ListBeskrivningar.TabIndex = 16;
            // 
            // ListMinaPodcast
            // 
            ListMinaPodcast.FormattingEnabled = true;
            ListMinaPodcast.Location = new Point(536, 100);
            ListMinaPodcast.Name = "ListMinaPodcast";
            ListMinaPodcast.Size = new Size(445, 644);
            ListMinaPodcast.TabIndex = 17;
            // 
            // ListKategorier
            // 
            ListKategorier.FormattingEnabled = true;
            ListKategorier.Location = new Point(12, 417);
            ListKategorier.Name = "ListKategorier";
            ListKategorier.Size = new Size(273, 324);
            ListKategorier.TabIndex = 18;
            // 
            // BtnTabortPodcast
            // 
            BtnTabortPodcast.Location = new Point(996, 100);
            BtnTabortPodcast.Name = "BtnTabortPodcast";
            BtnTabortPodcast.Size = new Size(152, 87);
            BtnTabortPodcast.TabIndex = 19;
            BtnTabortPodcast.Text = "Ta bort Podcast";
            BtnTabortPodcast.UseVisualStyleBackColor = true;
            // 
            // BtnUppdatera
            // 
            BtnUppdatera.Location = new Point(996, 386);
            BtnUppdatera.Name = "BtnUppdatera";
            BtnUppdatera.Size = new Size(152, 87);
            BtnUppdatera.TabIndex = 20;
            BtnUppdatera.Text = "Uppdatera Namn";
            BtnUppdatera.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(996, 629);
            button4.Name = "button4";
            button4.Size = new Size(152, 107);
            button4.TabIndex = 21;
            button4.Text = "Uppdatera alla";
            button4.UseVisualStyleBackColor = true;
            // 
            // CBXKategori
            // 
            CBXKategori.FormattingEnabled = true;
            CBXKategori.Location = new Point(128, 167);
            CBXKategori.Name = "CBXKategori";
            CBXKategori.Size = new Size(200, 40);
            CBXKategori.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1668, 802);
            Controls.Add(CBXKategori);
            Controls.Add(button4);
            Controls.Add(BtnUppdatera);
            Controls.Add(BtnTabortPodcast);
            Controls.Add(ListKategorier);
            Controls.Add(ListMinaPodcast);
            Controls.Add(ListBeskrivningar);
            Controls.Add(ListAvsnitt);
            Controls.Add(button1);
            Controls.Add(BtnUppdateraNamn);
            Controls.Add(BtnTaBort);
            Controls.Add(button2);
            Controls.Add(BtnLaggtillPodcast);
            Controls.Add(TbxNamn);
            Controls.Add(TbxKategorier);
            Controls.Add(TbxURL);
            Controls.Add(lbl);
            Controls.Add(lblAvsnitt);
            Controls.Add(lblMinaPodcast);
            Controls.Add(lblKategorier);
            Controls.Add(lblKategori);
            Controls.Add(lblURL);
            Controls.Add(lblNamn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNamn;
        private Label lblURL;
        private Label lblKategori;
        private Label lblKategorier;
        private Label lblMinaPodcast;
        private Label lblAvsnitt;
        private Label lbl;
        private TextBox TbxURL;
        private TextBox TbxKategorier;
        private TextBox TbxNamn;
        private Button BtnLaggtillPodcast;
        private Button button2;
        private Button BtnTaBort;
        private Button BtnUppdateraNamn;
        private Button button1;
        private ListBox ListAvsnitt;
        private ListBox ListBeskrivningar;
        private ListBox ListMinaPodcast;
        private ListBox ListKategorier;
        private Button BtnTabortPodcast;
        private Button BtnUppdatera;
        private Button button4;
        private ComboBox CBXKategori;
    }
}
