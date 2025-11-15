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
            lblNamn.Location = new Point(6, 30);
            lblNamn.Margin = new Padding(2, 0, 2, 0);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(40, 15);
            lblNamn.TabIndex = 0;
            lblNamn.Text = "Namn";
            lblNamn.Click += label1_Click;
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Location = new Point(6, 55);
            lblURL.Margin = new Padding(2, 0, 2, 0);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(52, 15);
            lblURL.TabIndex = 1;
            lblURL.Text = "RSS/URL";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(6, 78);
            lblKategori.Margin = new Padding(2, 0, 2, 0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(51, 15);
            lblKategori.TabIndex = 2;
            lblKategori.Text = "Kategori";
            // 
            // lblKategorier
            // 
            lblKategorier.AutoSize = true;
            lblKategorier.Location = new Point(6, 177);
            lblKategorier.Margin = new Padding(2, 0, 2, 0);
            lblKategorier.Name = "lblKategorier";
            lblKategorier.Size = new Size(61, 15);
            lblKategorier.TabIndex = 3;
            lblKategorier.Text = "Kategorier";
            // 
            // lblMinaPodcast
            // 
            lblMinaPodcast.AutoSize = true;
            lblMinaPodcast.Location = new Point(289, 20);
            lblMinaPodcast.Margin = new Padding(2, 0, 2, 0);
            lblMinaPodcast.Name = "lblMinaPodcast";
            lblMinaPodcast.Size = new Size(79, 15);
            lblMinaPodcast.TabIndex = 4;
            lblMinaPodcast.Text = "Mina Podcast";
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Location = new Point(628, 20);
            lblAvsnitt.Margin = new Padding(2, 0, 2, 0);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(44, 15);
            lblAvsnitt.TabIndex = 5;
            lblAvsnitt.Text = "Avsnitt";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(628, 207);
            lbl.Margin = new Padding(2, 0, 2, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(78, 15);
            lbl.TabIndex = 6;
            lbl.Text = "Beskrivningar";
            // 
            // TbxURL
            // 
            TbxURL.Location = new Point(69, 55);
            TbxURL.Margin = new Padding(2, 1, 2, 1);
            TbxURL.Name = "TbxURL";
            TbxURL.Size = new Size(110, 23);
            TbxURL.TabIndex = 7;
            // 
            // TbxKategorier
            // 
            TbxKategorier.Location = new Point(164, 203);
            TbxKategorier.Margin = new Padding(2, 1, 2, 1);
            TbxKategorier.Name = "TbxKategorier";
            TbxKategorier.Size = new Size(110, 23);
            TbxKategorier.TabIndex = 8;
            // 
            // TbxNamn
            // 
            TbxNamn.Location = new Point(69, 29);
            TbxNamn.Margin = new Padding(2, 1, 2, 1);
            TbxNamn.Name = "TbxNamn";
            TbxNamn.Size = new Size(110, 23);
            TbxNamn.TabIndex = 9;
            // 
            // BtnLaggtillPodcast
            // 
            BtnLaggtillPodcast.Location = new Point(6, 116);
            BtnLaggtillPodcast.Margin = new Padding(2, 1, 2, 1);
            BtnLaggtillPodcast.Name = "BtnLaggtillPodcast";
            BtnLaggtillPodcast.Size = new Size(170, 22);
            BtnLaggtillPodcast.TabIndex = 10;
            BtnLaggtillPodcast.Text = "Lägg till Podcast";
            BtnLaggtillPodcast.UseVisualStyleBackColor = true;
            BtnLaggtillPodcast.Click += BtnLaggtillPodcast_Click;
            // 
            // button2
            // 
            button2.Location = new Point(164, 233);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(108, 39);
            button2.TabIndex = 11;
            button2.Text = "Lägg till kategori";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BtnTaBort
            // 
            BtnTaBort.Location = new Point(164, 283);
            BtnTaBort.Margin = new Padding(2, 1, 2, 1);
            BtnTaBort.Name = "BtnTaBort";
            BtnTaBort.Size = new Size(108, 22);
            BtnTaBort.TabIndex = 12;
            BtnTaBort.Text = "Ta bort";
            BtnTaBort.UseVisualStyleBackColor = true;
            BtnTaBort.Click += BtnTaBort_Click;
            // 
            // BtnUppdateraNamn
            // 
            BtnUppdateraNamn.Location = new Point(164, 313);
            BtnUppdateraNamn.Margin = new Padding(2, 1, 2, 1);
            BtnUppdateraNamn.Name = "BtnUppdateraNamn";
            BtnUppdateraNamn.Size = new Size(108, 34);
            BtnUppdateraNamn.TabIndex = 13;
            BtnUppdateraNamn.Text = "Uppdatera namn";
            BtnUppdateraNamn.UseVisualStyleBackColor = true;
            BtnUppdateraNamn.Click += BtnUppdateraNamn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(628, 163);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(240, 22);
            button1.TabIndex = 14;
            button1.Text = "Sortera Avsnitt";
            button1.UseVisualStyleBackColor = true;
            // 
            // ListAvsnitt
            // 
            ListAvsnitt.FormattingEnabled = true;
            ListAvsnitt.ItemHeight = 15;
            ListAvsnitt.Location = new Point(628, 47);
            ListAvsnitt.Margin = new Padding(2, 1, 2, 1);
            ListAvsnitt.Name = "ListAvsnitt";
            ListAvsnitt.Size = new Size(241, 109);
            ListAvsnitt.TabIndex = 15;
            // 
            // ListBeskrivningar
            // 
            ListBeskrivningar.FormattingEnabled = true;
            ListBeskrivningar.ItemHeight = 15;
            ListBeskrivningar.Location = new Point(628, 223);
            ListBeskrivningar.Margin = new Padding(2, 1, 2, 1);
            ListBeskrivningar.Name = "ListBeskrivningar";
            ListBeskrivningar.Size = new Size(241, 124);
            ListBeskrivningar.TabIndex = 16;
            // 
            // ListMinaPodcast
            // 
            ListMinaPodcast.FormattingEnabled = true;
            ListMinaPodcast.ItemHeight = 15;
            ListMinaPodcast.Location = new Point(289, 47);
            ListMinaPodcast.Margin = new Padding(2, 1, 2, 1);
            ListMinaPodcast.Name = "ListMinaPodcast";
            ListMinaPodcast.Size = new Size(241, 304);
            ListMinaPodcast.TabIndex = 17;
            // 
            // ListKategorier
            // 
            ListKategorier.FormattingEnabled = true;
            ListKategorier.ItemHeight = 15;
            ListKategorier.Location = new Point(6, 195);
            ListKategorier.Margin = new Padding(2, 1, 2, 1);
            ListKategorier.Name = "ListKategorier";
            ListKategorier.Size = new Size(149, 154);
            ListKategorier.TabIndex = 18;
            ListKategorier.SelectedIndexChanged += ListKategorier_SelectedIndexChanged;
            // 
            // BtnTabortPodcast
            // 
            BtnTabortPodcast.Location = new Point(536, 47);
            BtnTabortPodcast.Margin = new Padding(2, 1, 2, 1);
            BtnTabortPodcast.Name = "BtnTabortPodcast";
            BtnTabortPodcast.Size = new Size(82, 41);
            BtnTabortPodcast.TabIndex = 19;
            BtnTabortPodcast.Text = "Ta bort Podcast";
            BtnTabortPodcast.UseVisualStyleBackColor = true;
            // 
            // BtnUppdatera
            // 
            BtnUppdatera.Location = new Point(536, 181);
            BtnUppdatera.Margin = new Padding(2, 1, 2, 1);
            BtnUppdatera.Name = "BtnUppdatera";
            BtnUppdatera.Size = new Size(82, 41);
            BtnUppdatera.TabIndex = 20;
            BtnUppdatera.Text = "Uppdatera Namn";
            BtnUppdatera.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(536, 295);
            button4.Margin = new Padding(2, 1, 2, 1);
            button4.Name = "button4";
            button4.Size = new Size(82, 50);
            button4.TabIndex = 21;
            button4.Text = "Uppdatera alla";
            button4.UseVisualStyleBackColor = true;
            // 
            // CBXKategori
            // 
            CBXKategori.FormattingEnabled = true;
            CBXKategori.Location = new Point(69, 78);
            CBXKategori.Margin = new Padding(2, 1, 2, 1);
            CBXKategori.Name = "CBXKategori";
            CBXKategori.Size = new Size(110, 23);
            CBXKategori.TabIndex = 22;
            CBXKategori.SelectedIndexChanged += CBXKategori_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 376);
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
            Margin = new Padding(2, 1, 2, 1);
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
