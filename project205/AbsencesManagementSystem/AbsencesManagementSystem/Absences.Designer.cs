namespace AbsencesManagementSystem
{
    partial class Absences
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
            this.myabsencemanagementbdDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myabsencemanagementbdDataSet = new AbsencesManagementSystem.myabsencemanagementbdDataSet();
            this.etudiantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matriculeAbs = new System.Windows.Forms.ComboBox();
            this.codeUeAbs = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.etudiantsTableAdapter = new AbsencesManagementSystem.myabsencemanagementbdDataSetTableAdapters.etudiantsTableAdapter();
            this.searchField = new System.Windows.Forms.TextBox();
            this.absGridView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.deleteBtnAbs = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.searchBtnAbs = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.editBtnAbs = new System.Windows.Forms.Button();
            this.saveBtnAbs = new System.Windows.Forms.Button();
            this.duree = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateAbsence = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.idDat = new System.Windows.Forms.TextBox();
            this.anneeAbs = new System.Windows.Forms.TextBox();
            this.niveauAbs = new System.Windows.Forms.TextBox();
            this.niveau2Abs = new System.Windows.Forms.TextBox();
            this.viewBtnAbs = new System.Windows.Forms.Button();
            this.resetBtnAbs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myabsencemanagementbdDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myabsencemanagementbdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // myabsencemanagementbdDataSetBindingSource
            // 
            this.myabsencemanagementbdDataSetBindingSource.DataSource = this.myabsencemanagementbdDataSet;
            this.myabsencemanagementbdDataSetBindingSource.Position = 0;
            // 
            // myabsencemanagementbdDataSet
            // 
            this.myabsencemanagementbdDataSet.DataSetName = "myabsencemanagementbdDataSet";
            this.myabsencemanagementbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etudiantsBindingSource
            // 
            this.etudiantsBindingSource.DataMember = "etudiants";
            this.etudiantsBindingSource.DataSource = this.myabsencemanagementbdDataSet;
            // 
            // matriculeAbs
            // 
            this.matriculeAbs.FormattingEnabled = true;
            this.matriculeAbs.Location = new System.Drawing.Point(679, 598);
            this.matriculeAbs.Name = "matriculeAbs";
            this.matriculeAbs.Size = new System.Drawing.Size(513, 39);
            this.matriculeAbs.TabIndex = 188;
            // 
            // codeUeAbs
            // 
            this.codeUeAbs.FormattingEnabled = true;
            this.codeUeAbs.Items.AddRange(new object[] {
            "2021"});
            this.codeUeAbs.Location = new System.Drawing.Point(1515, 345);
            this.codeUeAbs.Name = "codeUeAbs";
            this.codeUeAbs.Size = new System.Drawing.Size(498, 39);
            this.codeUeAbs.TabIndex = 186;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.textBox2.Location = new System.Drawing.Point(2263, 576);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 61);
            this.textBox2.TabIndex = 183;
            this.textBox2.Text = "duree";
            // 
            // etudiantsTableAdapter
            // 
            this.etudiantsTableAdapter.ClearBeforeFill = true;
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(1186, 774);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(1259, 38);
            this.searchField.TabIndex = 180;
            this.searchField.Text = "search it...";
            // 
            // absGridView
            // 
            this.absGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.absGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.absGridView.Location = new System.Drawing.Point(679, 964);
            this.absGridView.Name = "absGridView";
            this.absGridView.RowTemplate.Height = 40;
            this.absGridView.Size = new System.Drawing.Size(2256, 588);
            this.absGridView.TabIndex = 176;
            this.absGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.absGridView_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(679, 905);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2256, 10);
            this.panel4.TabIndex = 175;
            // 
            // deleteBtnAbs
            // 
            this.deleteBtnAbs.BackColor = System.Drawing.Color.CornflowerBlue;
            this.deleteBtnAbs.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtnAbs.ForeColor = System.Drawing.Color.White;
            this.deleteBtnAbs.Location = new System.Drawing.Point(1567, 659);
            this.deleteBtnAbs.Name = "deleteBtnAbs";
            this.deleteBtnAbs.Size = new System.Drawing.Size(244, 65);
            this.deleteBtnAbs.TabIndex = 174;
            this.deleteBtnAbs.Text = "DELETE";
            this.deleteBtnAbs.UseVisualStyleBackColor = false;
            this.deleteBtnAbs.Click += new System.EventHandler(this.deleteBtnAbs_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(768, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(929, 67);
            this.label19.TabIndex = 1;
            this.label19.Text = "ABSENCE MANAGEMENT SYSTEM";
            // 
            // searchBtnAbs
            // 
            this.searchBtnAbs.BackColor = System.Drawing.Color.CornflowerBlue;
            this.searchBtnAbs.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtnAbs.ForeColor = System.Drawing.Color.White;
            this.searchBtnAbs.Location = new System.Drawing.Point(1994, 659);
            this.searchBtnAbs.Name = "searchBtnAbs";
            this.searchBtnAbs.Size = new System.Drawing.Size(244, 65);
            this.searchBtnAbs.TabIndex = 179;
            this.searchBtnAbs.Text = "SEARCH";
            this.searchBtnAbs.UseVisualStyleBackColor = false;
            this.searchBtnAbs.Click += new System.EventHandler(this.searchBtnAbs_Click);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.textBox4.Location = new System.Drawing.Point(679, 408);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(513, 61);
            this.textBox4.TabIndex = 177;
            this.textBox4.Text = "Niveau";
            // 
            // editBtnAbs
            // 
            this.editBtnAbs.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editBtnAbs.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtnAbs.ForeColor = System.Drawing.Color.White;
            this.editBtnAbs.Location = new System.Drawing.Point(1155, 659);
            this.editBtnAbs.Name = "editBtnAbs";
            this.editBtnAbs.Size = new System.Drawing.Size(244, 65);
            this.editBtnAbs.TabIndex = 173;
            this.editBtnAbs.Text = "EDIT";
            this.editBtnAbs.UseVisualStyleBackColor = false;
            this.editBtnAbs.Click += new System.EventHandler(this.editBtnAbs_Click);
            // 
            // saveBtnAbs
            // 
            this.saveBtnAbs.BackColor = System.Drawing.Color.CornflowerBlue;
            this.saveBtnAbs.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtnAbs.ForeColor = System.Drawing.Color.White;
            this.saveBtnAbs.Location = new System.Drawing.Point(738, 659);
            this.saveBtnAbs.Name = "saveBtnAbs";
            this.saveBtnAbs.Size = new System.Drawing.Size(244, 65);
            this.saveBtnAbs.TabIndex = 172;
            this.saveBtnAbs.Text = "SAVE";
            this.saveBtnAbs.UseVisualStyleBackColor = false;
            this.saveBtnAbs.Click += new System.EventHandler(this.saveBtnAbs_Click);
            // 
            // duree
            // 
            this.duree.Location = new System.Drawing.Point(2626, 596);
            this.duree.Name = "duree";
            this.duree.Size = new System.Drawing.Size(200, 38);
            this.duree.TabIndex = 171;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.textBox9.Location = new System.Drawing.Point(1515, 417);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(201, 61);
            this.textBox9.TabIndex = 170;
            this.textBox9.Text = "Niveau";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.textBox7.Location = new System.Drawing.Point(1515, 278);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(498, 61);
            this.textBox7.TabIndex = 169;
            this.textBox7.Text = "codeUE";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.textBox5.Location = new System.Drawing.Point(2263, 434);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(340, 61);
            this.textBox5.TabIndex = 168;
            this.textBox5.Text = "dateAbsence";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.textBox3.Location = new System.Drawing.Point(679, 278);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(513, 61);
            this.textBox3.TabIndex = 167;
            this.textBox3.Text = "Annee";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.textBox1.Location = new System.Drawing.Point(679, 520);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(513, 61);
            this.textBox1.TabIndex = 165;
            this.textBox1.Text = "Matricule";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(142, 1114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 10);
            this.panel2.TabIndex = 164;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label19);
            this.panel3.Location = new System.Drawing.Point(521, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2608, 233);
            this.panel3.TabIndex = 163;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(133, 1070);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 54);
            this.label8.TabIndex = 162;
            this.label8.Text = "Absences";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(133, 1452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 54);
            this.label7.TabIndex = 161;
            this.label7.Text = "Quitter";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(133, 659);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 54);
            this.label6.TabIndex = 160;
            this.label6.Text = "Etudiants";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(133, 810);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 54);
            this.label3.TabIndex = 159;
            this.label3.Text = "Ues";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(133, 942);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 54);
            this.label2.TabIndex = 158;
            this.label2.Text = "Notes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::AbsencesManagementSystem.Properties.Resources.power_off;
            this.pictureBox9.Location = new System.Drawing.Point(18, 1416);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(90, 90);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 157;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::AbsencesManagementSystem.Properties.Resources.score;
            this.pictureBox8.Location = new System.Drawing.Point(18, 906);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(90, 90);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 156;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::AbsencesManagementSystem.Properties.Resources.test;
            this.pictureBox7.Location = new System.Drawing.Point(18, 1034);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(90, 90);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 155;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AbsencesManagementSystem.Properties.Resources.student;
            this.pictureBox6.Location = new System.Drawing.Point(18, 623);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(90, 90);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 154;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AbsencesManagementSystem.Properties.Resources.book;
            this.pictureBox2.Location = new System.Drawing.Point(18, 774);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 153;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(133, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 54);
            this.label1.TabIndex = 152;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AbsencesManagementSystem.Properties.Resources.accueil;
            this.pictureBox5.Location = new System.Drawing.Point(18, 493);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(90, 90);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 151;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AbsencesManagementSystem.Properties.Resources.school;
            this.pictureBox1.Location = new System.Drawing.Point(63, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 150;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(497, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 1567);
            this.panel1.TabIndex = 149;
            // 
            // dateAbsence
            // 
            this.dateAbsence.Location = new System.Drawing.Point(2626, 457);
            this.dateAbsence.Name = "dateAbsence";
            this.dateAbsence.Size = new System.Drawing.Size(405, 38);
            this.dateAbsence.TabIndex = 189;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.textBox6.Location = new System.Drawing.Point(2263, 296);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(340, 61);
            this.textBox6.TabIndex = 192;
            this.textBox6.Text = "Id Date";
            // 
            // idDat
            // 
            this.idDat.Location = new System.Drawing.Point(2626, 316);
            this.idDat.Name = "idDat";
            this.idDat.Size = new System.Drawing.Size(200, 38);
            this.idDat.TabIndex = 191;
            // 
            // anneeAbs
            // 
            this.anneeAbs.Location = new System.Drawing.Point(679, 346);
            this.anneeAbs.Name = "anneeAbs";
            this.anneeAbs.Size = new System.Drawing.Size(513, 38);
            this.anneeAbs.TabIndex = 193;
            // 
            // niveauAbs
            // 
            this.niveauAbs.Location = new System.Drawing.Point(679, 476);
            this.niveauAbs.Name = "niveauAbs";
            this.niveauAbs.Size = new System.Drawing.Size(513, 38);
            this.niveauAbs.TabIndex = 194;
            // 
            // niveau2Abs
            // 
            this.niveau2Abs.Location = new System.Drawing.Point(1516, 493);
            this.niveau2Abs.Name = "niveau2Abs";
            this.niveau2Abs.Size = new System.Drawing.Size(497, 38);
            this.niveau2Abs.TabIndex = 195;
            // 
            // viewBtnAbs
            // 
            this.viewBtnAbs.BackColor = System.Drawing.Color.CornflowerBlue;
            this.viewBtnAbs.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtnAbs.ForeColor = System.Drawing.Color.White;
            this.viewBtnAbs.Location = new System.Drawing.Point(2394, 659);
            this.viewBtnAbs.Name = "viewBtnAbs";
            this.viewBtnAbs.Size = new System.Drawing.Size(244, 65);
            this.viewBtnAbs.TabIndex = 196;
            this.viewBtnAbs.Text = "VIEW";
            this.viewBtnAbs.UseVisualStyleBackColor = false;
            this.viewBtnAbs.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetBtnAbs
            // 
            this.resetBtnAbs.BackColor = System.Drawing.Color.CornflowerBlue;
            this.resetBtnAbs.Font = new System.Drawing.Font("Courier New", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtnAbs.ForeColor = System.Drawing.Color.White;
            this.resetBtnAbs.Location = new System.Drawing.Point(2787, 668);
            this.resetBtnAbs.Name = "resetBtnAbs";
            this.resetBtnAbs.Size = new System.Drawing.Size(244, 65);
            this.resetBtnAbs.TabIndex = 197;
            this.resetBtnAbs.Text = "RESET";
            this.resetBtnAbs.UseVisualStyleBackColor = false;
            this.resetBtnAbs.Click += new System.EventHandler(this.button2_Click);
            // 
            // Absences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3146, 1564);
            this.Controls.Add(this.viewBtnAbs);
            this.Controls.Add(this.resetBtnAbs);
            this.Controls.Add(this.niveau2Abs);
            this.Controls.Add(this.niveauAbs);
            this.Controls.Add(this.anneeAbs);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.idDat);
            this.Controls.Add(this.dateAbsence);
            this.Controls.Add(this.matriculeAbs);
            this.Controls.Add(this.codeUeAbs);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.absGridView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.deleteBtnAbs);
            this.Controls.Add(this.searchBtnAbs);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.editBtnAbs);
            this.Controls.Add(this.saveBtnAbs);
            this.Controls.Add(this.duree);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Absences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Absences";
            this.Load += new System.EventHandler(this.Absences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myabsencemanagementbdDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myabsencemanagementbdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource myabsencemanagementbdDataSetBindingSource;
        private myabsencemanagementbdDataSet myabsencemanagementbdDataSet;
        private System.Windows.Forms.BindingSource etudiantsBindingSource;
        private System.Windows.Forms.ComboBox matriculeAbs;
        private System.Windows.Forms.ComboBox codeUeAbs;
        private System.Windows.Forms.TextBox textBox2;
        private myabsencemanagementbdDataSetTableAdapters.etudiantsTableAdapter etudiantsTableAdapter;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.DataGridView absGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button deleteBtnAbs;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button searchBtnAbs;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button editBtnAbs;
        private System.Windows.Forms.Button saveBtnAbs;
        private System.Windows.Forms.TextBox duree;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateAbsence;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox idDat;
        private System.Windows.Forms.TextBox anneeAbs;
        private System.Windows.Forms.TextBox niveauAbs;
        private System.Windows.Forms.TextBox niveau2Abs;
        private System.Windows.Forms.Button viewBtnAbs;
        private System.Windows.Forms.Button resetBtnAbs;

    }
}