namespace WinApp
{
    partial class Kadet
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.imieTitleTextbox = new Kuik.UIControls.TitleTextbox();
            this.nazwiskoTitleTextbox = new Kuik.UIControls.TitleTextbox();
            this.emailTitleTextbox = new Kuik.UIControls.TitleTextbox();
            this.peselTitleTextbox = new Kuik.UIControls.TitleTextbox();
            this.numerTitleTextbox = new Kuik.UIControls.TitleTextbox();
            this.wyszukajButton = new System.Windows.Forms.Button();
            this.iloscLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.usunTitleTextbox = new Kuik.UIControls.TitleTextbox();
            this.usunButton = new System.Windows.Forms.Button();
            this.pracownikBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.edytujButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.Controls.Add(this.imieTitleTextbox);
            this.flowLayoutPanel1.Controls.Add(this.nazwiskoTitleTextbox);
            this.flowLayoutPanel1.Controls.Add(this.emailTitleTextbox);
            this.flowLayoutPanel1.Controls.Add(this.peselTitleTextbox);
            this.flowLayoutPanel1.Controls.Add(this.numerTitleTextbox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(654, 230);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // imieTitleTextbox
            // 
            this.imieTitleTextbox.Location = new System.Drawing.Point(3, 3);
            this.imieTitleTextbox.Name = "imieTitleTextbox";
            this.imieTitleTextbox.Nazwa = "Imie";
            this.imieTitleTextbox.Padding = new System.Windows.Forms.Padding(5);
            this.imieTitleTextbox.Size = new System.Drawing.Size(305, 70);
            this.imieTitleTextbox.TabIndex = 0;
            this.imieTitleTextbox.textBoxNazwa = "";
            // 
            // nazwiskoTitleTextbox
            // 
            this.nazwiskoTitleTextbox.Location = new System.Drawing.Point(314, 3);
            this.nazwiskoTitleTextbox.Name = "nazwiskoTitleTextbox";
            this.nazwiskoTitleTextbox.Nazwa = "Nazwisko";
            this.nazwiskoTitleTextbox.Padding = new System.Windows.Forms.Padding(5);
            this.nazwiskoTitleTextbox.Size = new System.Drawing.Size(305, 70);
            this.nazwiskoTitleTextbox.TabIndex = 1;
            this.nazwiskoTitleTextbox.textBoxNazwa = "";
            // 
            // emailTitleTextbox
            // 
            this.emailTitleTextbox.Location = new System.Drawing.Point(3, 79);
            this.emailTitleTextbox.Name = "emailTitleTextbox";
            this.emailTitleTextbox.Nazwa = "Email";
            this.emailTitleTextbox.Padding = new System.Windows.Forms.Padding(5);
            this.emailTitleTextbox.Size = new System.Drawing.Size(305, 70);
            this.emailTitleTextbox.TabIndex = 2;
            this.emailTitleTextbox.textBoxNazwa = "";
            // 
            // peselTitleTextbox
            // 
            this.peselTitleTextbox.Location = new System.Drawing.Point(314, 79);
            this.peselTitleTextbox.Name = "peselTitleTextbox";
            this.peselTitleTextbox.Nazwa = "Pesel";
            this.peselTitleTextbox.Padding = new System.Windows.Forms.Padding(5);
            this.peselTitleTextbox.Size = new System.Drawing.Size(305, 66);
            this.peselTitleTextbox.TabIndex = 3;
            this.peselTitleTextbox.textBoxNazwa = "";
            // 
            // numerTitleTextbox
            // 
            this.numerTitleTextbox.Location = new System.Drawing.Point(3, 155);
            this.numerTitleTextbox.Name = "numerTitleTextbox";
            this.numerTitleTextbox.Nazwa = "Numer kadrowy";
            this.numerTitleTextbox.Padding = new System.Windows.Forms.Padding(5);
            this.numerTitleTextbox.Size = new System.Drawing.Size(305, 66);
            this.numerTitleTextbox.TabIndex = 4;
            this.numerTitleTextbox.textBoxNazwa = "";
            // 
            // wyszukajButton
            // 
            this.wyszukajButton.Location = new System.Drawing.Point(828, 354);
            this.wyszukajButton.Name = "wyszukajButton";
            this.wyszukajButton.Size = new System.Drawing.Size(176, 74);
            this.wyszukajButton.TabIndex = 4;
            this.wyszukajButton.Text = "Wyszukaj pracownika";
            this.wyszukajButton.UseVisualStyleBackColor = true;
            this.wyszukajButton.Click += new System.EventHandler(this.wyszukajButton_Click);
            // 
            // iloscLabel
            // 
            this.iloscLabel.AutoSize = true;
            this.iloscLabel.Location = new System.Drawing.Point(842, 52);
            this.iloscLabel.Name = "iloscLabel";
            this.iloscLabel.Size = new System.Drawing.Size(0, 16);
            this.iloscLabel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(211, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dodaj nowego pracownika";
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(364, 315);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(267, 47);
            this.dodajButton.TabIndex = 5;
            this.dodajButton.Text = "Dodaj pracownika";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(778, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuń pracownika";
            // 
            // usunTitleTextbox
            // 
            this.usunTitleTextbox.Location = new System.Drawing.Point(746, 108);
            this.usunTitleTextbox.Name = "usunTitleTextbox";
            this.usunTitleTextbox.Nazwa = "Podaj pesel";
            this.usunTitleTextbox.Padding = new System.Windows.Forms.Padding(5);
            this.usunTitleTextbox.Size = new System.Drawing.Size(245, 73);
            this.usunTitleTextbox.TabIndex = 9;
            this.usunTitleTextbox.textBoxNazwa = "";
            // 
            // usunButton
            // 
            this.usunButton.Location = new System.Drawing.Point(762, 187);
            this.usunButton.Name = "usunButton";
            this.usunButton.Size = new System.Drawing.Size(214, 41);
            this.usunButton.TabIndex = 10;
            this.usunButton.Text = "Usuń pracownika";
            this.usunButton.UseVisualStyleBackColor = true;
            this.usunButton.Click += new System.EventHandler(this.usunButton_Click);
            // 
            // pracownikBindingSource3
            // 
            this.pracownikBindingSource3.DataSource = typeof(WinApp.API.Pracownik);
            // 
            // edytujButton
            // 
            this.edytujButton.Location = new System.Drawing.Point(53, 315);
            this.edytujButton.Name = "edytujButton";
            this.edytujButton.Size = new System.Drawing.Size(267, 47);
            this.edytujButton.TabIndex = 11;
            this.edytujButton.Text = "Edytuj pracownika";
            this.edytujButton.UseVisualStyleBackColor = true;
            this.edytujButton.Click += new System.EventHandler(this.edytujButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 439);
            this.Controls.Add(this.edytujButton);
            this.Controls.Add(this.usunButton);
            this.Controls.Add(this.usunTitleTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iloscLabel);
            this.Controls.Add(this.wyszukajButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dodajButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource pracownikBindingSource3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Kuik.UIControls.TitleTextbox imieTitleTextbox;
        private Kuik.UIControls.TitleTextbox nazwiskoTitleTextbox;
        private Kuik.UIControls.TitleTextbox emailTitleTextbox;
        private Kuik.UIControls.TitleTextbox peselTitleTextbox;
        private Kuik.UIControls.TitleTextbox numerTitleTextbox;
        private System.Windows.Forms.Button wyszukajButton;
        private System.Windows.Forms.Label iloscLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Label label2;
        private Kuik.UIControls.TitleTextbox usunTitleTextbox;
        private System.Windows.Forms.Button usunButton;
        private System.Windows.Forms.Button edytujButton;
    }
}

