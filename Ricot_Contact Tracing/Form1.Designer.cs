
using System;

namespace Ricot_Contact_Tracing
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Headache = new System.Windows.Forms.CheckBox();
            this.Diarrhea = new System.Windows.Forms.CheckBox();
            this.Runny_Nose = new System.Windows.Forms.CheckBox();
            this.Sore_Throat = new System.Windows.Forms.CheckBox();
            this.Coughs = new System.Windows.Forms.CheckBox();
            this.Fever = new System.Windows.Forms.CheckBox();
            this.symptoms = new System.Windows.Forms.Label();
            this.InContact_input = new System.Windows.Forms.TextBox();
            this.InContact = new System.Windows.Forms.Label();
            this.gender_input = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contact_input = new System.Windows.Forms.TextBox();
            this.address_input = new System.Windows.Forms.TextBox();
            this.age_input = new System.Windows.Forms.TextBox();
            this.name_input = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BackgroundImage = global::Ricot_Contact_Tracing.Properties.Resources._187161;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Tracing App";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.BackgroundImage = global::Ricot_Contact_Tracing.Properties.Resources._187161;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.Headache);
            this.panel3.Controls.Add(this.Diarrhea);
            this.panel3.Controls.Add(this.Runny_Nose);
            this.panel3.Controls.Add(this.Sore_Throat);
            this.panel3.Controls.Add(this.Coughs);
            this.panel3.Controls.Add(this.Fever);
            this.panel3.Controls.Add(this.symptoms);
            this.panel3.Controls.Add(this.InContact_input);
            this.panel3.Controls.Add(this.InContact);
            this.panel3.Controls.Add(this.gender_input);
            this.panel3.Controls.Add(this.gender);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.contact_input);
            this.panel3.Controls.Add(this.address_input);
            this.panel3.Controls.Add(this.age_input);
            this.panel3.Controls.Add(this.name_input);
            this.panel3.Controls.Add(this.contact);
            this.panel3.Controls.Add(this.address);
            this.panel3.Controls.Add(this.age);
            this.panel3.Controls.Add(this.name);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(8, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 421);
            this.panel3.TabIndex = 2;
            // 
            // Headache
            // 
            this.Headache.AutoSize = true;
            this.Headache.BackColor = System.Drawing.Color.White;
            this.Headache.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headache.Location = new System.Drawing.Point(156, 362);
            this.Headache.Name = "Headache";
            this.Headache.Size = new System.Drawing.Size(107, 24);
            this.Headache.TabIndex = 25;
            this.Headache.Text = "Headache";
            this.Headache.UseVisualStyleBackColor = false;
            // 
            // Diarrhea
            // 
            this.Diarrhea.AutoSize = true;
            this.Diarrhea.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Diarrhea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diarrhea.Location = new System.Drawing.Point(156, 335);
            this.Diarrhea.Name = "Diarrhea";
            this.Diarrhea.Size = new System.Drawing.Size(96, 24);
            this.Diarrhea.TabIndex = 24;
            this.Diarrhea.Text = "Diarrhea";
            this.Diarrhea.UseVisualStyleBackColor = false;
            // 
            // Runny_Nose
            // 
            this.Runny_Nose.AutoSize = true;
            this.Runny_Nose.BackColor = System.Drawing.Color.White;
            this.Runny_Nose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Runny_Nose.Location = new System.Drawing.Point(156, 308);
            this.Runny_Nose.Name = "Runny_Nose";
            this.Runny_Nose.Size = new System.Drawing.Size(122, 24);
            this.Runny_Nose.TabIndex = 23;
            this.Runny_Nose.Text = "Runny Nose";
            this.Runny_Nose.UseVisualStyleBackColor = false;
            // 
            // Sore_Throat
            // 
            this.Sore_Throat.AutoSize = true;
            this.Sore_Throat.BackColor = System.Drawing.Color.White;
            this.Sore_Throat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sore_Throat.Location = new System.Drawing.Point(10, 362);
            this.Sore_Throat.Name = "Sore_Throat";
            this.Sore_Throat.Size = new System.Drawing.Size(119, 24);
            this.Sore_Throat.TabIndex = 22;
            this.Sore_Throat.Text = "Sore Throat";
            this.Sore_Throat.UseVisualStyleBackColor = false;
            // 
            // Coughs
            // 
            this.Coughs.AutoSize = true;
            this.Coughs.BackColor = System.Drawing.Color.White;
            this.Coughs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coughs.Location = new System.Drawing.Point(12, 335);
            this.Coughs.Name = "Coughs";
            this.Coughs.Size = new System.Drawing.Size(88, 24);
            this.Coughs.TabIndex = 21;
            this.Coughs.Text = "Coughs";
            this.Coughs.UseVisualStyleBackColor = false;
            // 
            // Fever
            // 
            this.Fever.AutoSize = true;
            this.Fever.BackColor = System.Drawing.Color.White;
            this.Fever.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fever.Location = new System.Drawing.Point(12, 308);
            this.Fever.Name = "Fever";
            this.Fever.Size = new System.Drawing.Size(73, 24);
            this.Fever.TabIndex = 20;
            this.Fever.Text = "Fever";
            this.Fever.UseVisualStyleBackColor = false;
            // 
            // symptoms
            // 
            this.symptoms.AutoSize = true;
            this.symptoms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.symptoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptoms.Location = new System.Drawing.Point(7, 271);
            this.symptoms.Name = "symptoms";
            this.symptoms.Size = new System.Drawing.Size(120, 25);
            this.symptoms.TabIndex = 19;
            this.symptoms.Text = "Symptoms:";
            // 
            // InContact_input
            // 
            this.InContact_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InContact_input.Location = new System.Drawing.Point(326, 220);
            this.InContact_input.Name = "InContact_input";
            this.InContact_input.Size = new System.Drawing.Size(86, 30);
            this.InContact_input.TabIndex = 18;
            // 
            // InContact
            // 
            this.InContact.AutoSize = true;
            this.InContact.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InContact.Location = new System.Drawing.Point(5, 210);
            this.InContact.Name = "InContact";
            this.InContact.Size = new System.Drawing.Size(282, 50);
            this.InContact.TabIndex = 17;
            this.InContact.Text = "Have you been in contact \r\nwith other person? (Yes/No)";
            // 
            // gender_input
            // 
            this.gender_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_input.Location = new System.Drawing.Point(541, 41);
            this.gender_input.Name = "gender_input";
            this.gender_input.Size = new System.Drawing.Size(111, 30);
            this.gender_input.TabIndex = 16;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(435, 44);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(90, 25);
            this.gender.TabIndex = 15;
            this.gender.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter information:";
            // 
            // contact_input
            // 
            this.contact_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_input.Location = new System.Drawing.Point(137, 173);
            this.contact_input.Name = "contact_input";
            this.contact_input.Size = new System.Drawing.Size(343, 30);
            this.contact_input.TabIndex = 13;
            this.contact_input.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // address_input
            // 
            this.address_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_input.Location = new System.Drawing.Point(119, 133);
            this.address_input.Name = "address_input";
            this.address_input.Size = new System.Drawing.Size(361, 30);
            this.address_input.TabIndex = 12;
            this.address_input.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // age_input
            // 
            this.age_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_input.Location = new System.Drawing.Point(80, 87);
            this.age_input.Name = "age_input";
            this.age_input.Size = new System.Drawing.Size(74, 30);
            this.age_input.TabIndex = 11;
            this.age_input.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // name_input
            // 
            this.name_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_input.Location = new System.Drawing.Point(98, 41);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(305, 30);
            this.name_input.TabIndex = 10;
            this.name_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(5, 176);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(112, 25);
            this.contact.TabIndex = 4;
            this.contact.Text = "Contact/s:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.WhiteSmoke;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(3, 136);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(99, 25);
            this.address.TabIndex = 3;
            this.address.Text = "Address:";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.BackColor = System.Drawing.Color.WhiteSmoke;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(7, 90);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(58, 25);
            this.age.TabIndex = 2;
            this.age.Text = "Age:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(7, 44);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(75, 25);
            this.name.TabIndex = 1;
            this.name.Text = "Name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(620, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.enter_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::Ricot_Contact_Tracing.Properties.Resources._187161;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(776, 517);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox contact_input;
        private System.Windows.Forms.TextBox address_input;
        private System.Windows.Forms.TextBox age_input;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gender_input;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.TextBox InContact_input;
        private System.Windows.Forms.Label InContact;
        private System.Windows.Forms.CheckBox Headache;
        private System.Windows.Forms.CheckBox Diarrhea;
        private System.Windows.Forms.CheckBox Runny_Nose;
        private System.Windows.Forms.CheckBox Sore_Throat;
        private System.Windows.Forms.CheckBox Coughs;
        private System.Windows.Forms.CheckBox Fever;
        private System.Windows.Forms.Label symptoms;
    }
}

