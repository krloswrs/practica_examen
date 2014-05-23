/*
 * Created by SharpDevelop.
 * User: krlos
 * Date: 02/05/2014
 * Time: 10:09 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Practica_5_Examen
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Nombre = new System.Windows.Forms.Label();
			this.Codigo = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.Ru = new System.Windows.Forms.CheckBox();
			this.Ja = new System.Windows.Forms.CheckBox();
			this.Al = new System.Windows.Forms.CheckBox();
			this.Re = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.Mu = new System.Windows.Forms.RadioButton();
			this.Continente = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.DateTime = new System.Windows.Forms.Label();
			this.Calendario = new System.Windows.Forms.MonthCalendar();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// Nombre
			// 
			this.Nombre.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Nombre.Location = new System.Drawing.Point(13, 13);
			this.Nombre.Name = "Nombre";
			this.Nombre.Size = new System.Drawing.Size(63, 23);
			this.Nombre.TabIndex = 0;
			this.Nombre.Text = "Nombre";
			// 
			// Codigo
			// 
			this.Codigo.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Codigo.Location = new System.Drawing.Point(387, 13);
			this.Codigo.Name = "Codigo";
			this.Codigo.Size = new System.Drawing.Size(100, 23);
			this.Codigo.TabIndex = 1;
			this.Codigo.Text = "Codigo";
			this.Codigo.Click += new System.EventHandler(this.Label2Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(336, 20);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(387, 39);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(120, 20);
			this.textBox2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(336, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "1.-Numero de estados de la Republica Mexicana";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(13, 100);
			this.numericUpDown1.Maximum = new decimal(new int[] {
									50,
									0,
									0,
									0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
			this.numericUpDown1.TabIndex = 5;
			this.numericUpDown1.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(507, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "2.-Que paises hicieron alianza durante la Segunda Guerra Mundial";
			// 
			// Ru
			// 
			this.Ru.Location = new System.Drawing.Point(16, 163);
			this.Ru.Name = "Ru";
			this.Ru.Size = new System.Drawing.Size(104, 24);
			this.Ru.TabIndex = 7;
			this.Ru.Text = "Rusia";
			this.Ru.UseVisualStyleBackColor = true;
			// 
			// Ja
			// 
			this.Ja.Location = new System.Drawing.Point(16, 195);
			this.Ja.Name = "Ja";
			this.Ja.Size = new System.Drawing.Size(104, 24);
			this.Ja.TabIndex = 8;
			this.Ja.Text = "Japon";
			this.Ja.UseVisualStyleBackColor = true;
			// 
			// Al
			// 
			this.Al.Location = new System.Drawing.Point(16, 225);
			this.Al.Name = "Al";
			this.Al.Size = new System.Drawing.Size(104, 24);
			this.Al.TabIndex = 9;
			this.Al.Text = "Alemania";
			this.Al.UseVisualStyleBackColor = true;
			// 
			// Re
			// 
			this.Re.Location = new System.Drawing.Point(16, 255);
			this.Re.Name = "Re";
			this.Re.Size = new System.Drawing.Size(104, 24);
			this.Re.TabIndex = 10;
			this.Re.Text = "Reino Unido";
			this.Re.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 291);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(396, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "3.-Dictador de Italia durante la segunda guerra mundial";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(16, 318);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 12;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Hittler";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(16, 348);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 13;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Berlusconi";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// Mu
			// 
			this.Mu.Location = new System.Drawing.Point(16, 379);
			this.Mu.Name = "Mu";
			this.Mu.Size = new System.Drawing.Size(104, 24);
			this.Mu.TabIndex = 14;
			this.Mu.TabStop = true;
			this.Mu.Text = "Mussolini";
			this.Mu.UseVisualStyleBackColor = true;
			// 
			// Continente
			// 
			this.Continente.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Continente.Location = new System.Drawing.Point(16, 417);
			this.Continente.Name = "Continente";
			this.Continente.Size = new System.Drawing.Size(333, 23);
			this.Continente.TabIndex = 15;
			this.Continente.Text = "4.-En que Continente se encuentra el pais Tuvalu";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"Oceania",
									"Africa",
									"America",
									"Asia",
									"Europa"});
			this.comboBox1.Location = new System.Drawing.Point(16, 443);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 16;
			// 
			// DateTime
			// 
			this.DateTime.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateTime.Location = new System.Drawing.Point(459, 246);
			this.DateTime.Name = "DateTime";
			this.DateTime.Size = new System.Drawing.Size(227, 23);
			this.DateTime.TabIndex = 17;
			this.DateTime.Text = "5.-Fecha del Grito de Dolores";
			this.DateTime.Click += new System.EventHandler(this.Label7Click);
			// 
			// Calendario
			// 
			this.Calendario.Location = new System.Drawing.Point(459, 278);
			this.Calendario.Name = "Calendario";
			this.Calendario.TabIndex = 18;
			this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.SelectionStartDateChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(560, 458);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 30);
			this.button1.TabIndex = 19;
			this.button1.Text = "Guardar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(737, 505);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Calendario);
			this.Controls.Add(this.DateTime);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.Continente);
			this.Controls.Add(this.Mu);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Re);
			this.Controls.Add(this.Al);
			this.Controls.Add(this.Ja);
			this.Controls.Add(this.Ru);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Codigo);
			this.Controls.Add(this.Nombre);
			this.Name = "MainForm";
			this.Text = "Examen";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MonthCalendar Calendario;
		private System.Windows.Forms.Label DateTime;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label Continente;
		private System.Windows.Forms.RadioButton Mu;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox Re;
		private System.Windows.Forms.CheckBox Al;
		private System.Windows.Forms.CheckBox Ja;
		private System.Windows.Forms.CheckBox Ru;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label Codigo;
		private System.Windows.Forms.Label Nombre;
	
		
		
		void Label7Click(object sender, System.EventArgs e)
		{
			
		}
		
		void Label2Click(object sender, System.EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, System.EventArgs e)
		{
			int aciertos=0;
			string Continente=this.comboBox1.Text;
			string Nombre=this.textBox1.Text;
			string Codigo=this.textBox2.Text;
			
				if(this.numericUpDown1.Text=="31"){
				aciertos++;
				}
			
				if(this.Ru.Checked){
			      aciertos++;
                } 
					if(this.Re.Checked){
			      aciertos++;
                } 
			 
				if(this.Mu.Checked){
				aciertos++;
				}
			
				if(Continente=="Oceania"){
				aciertos++;
				}
				
				//DateTime fecha = DateTime.SelectionStart;
				if(this.Calendario.SelectionStart.Date.ToShortDateString() == "16/09/1810"){
					aciertos++;
				}
							
				System.Windows.Forms.MessageBox.Show("Nombre: " + Nombre + "\n Codigo: " + Codigo +"\n Aciertos: " + aciertos);
		}
		
		void SelectionStartDateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, System.EventArgs e)
		{
			
		}
	}
}
