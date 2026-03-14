namespace Modul3_103022400085
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            if (satuanAwal.Text == "" && satuanAkhir.Text == "")
            {
                // Dialog box
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }

            if (nilaiAwal.Text == "" && nilaiAkhir.Text == "")
            {
                // Dialog box
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            // Suhu sama
            if (satuanAwal.Text == satuanAkhir.Text)
            {
                nilaiAkhir.Text = nilaiAwal.Text;
                return;
            }

            // Celcius to:
            if (satuanAwal.Text == "Celcius")
            {
                // konversi ke C
                double C = Convert.ToDouble(nilaiAwal.Text);
                // switch suhu lain
                switch (satuanAkhir.Text)
                {
                    case "Fahrenheit":
                        {
                            //konversi
                            double t = 5.0 / 9.0 * (C + 32);
                            nilaiAkhir.Text = Convert.ToString(t) + " *F";
                            break;
                        }
                    case "Kelvin":
                        {
                            //konversi
                            double t = C + 273.15;
                            nilaiAkhir.Text = Convert.ToString(t) + " K";
                            break;
                        }
                    case "Reamur":
                        {
                            //konversi
                            double t = 5.0 / 4.0 * (C * -1); // C * -1 agar dibalik
                            nilaiAkhir.Text = Convert.ToString(t) + " *R";
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("tidak valid");
                            break;
                        }
                }
                return;
            }

            // Fahrenheit to:
            if (satuanAwal.Text == "Fahrenheit")
            {
                // konversi ke C
                double n = Convert.ToDouble(nilaiAwal.Text);
                double C = Convert.ToDouble(5.0/9.0 * (n - 32) );
                // switch suhu lain
                switch (satuanAkhir.Text)
                {
                    case "Celcius":
                        {
                            //konversi
                            double t = C;
                            nilaiAkhir.Text = Convert.ToString(t) + " *C";
                            break;
                        }
                    case "Kelvin":
                        {
                            //konversi
                            double t = C + 273.15;
                            nilaiAkhir.Text = Convert.ToString(t) + " K";
                            break;
                        }
                    case "Reamur":
                        {
                            //konversi
                            double t = 5.0 / 4.0 * (C * -1); // C * -1 agar dibalik
                            nilaiAkhir.Text = Convert.ToString(t) + " *R";
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("tidak valid");
                            break;
                        }
                }
                return;
            }

            // Kelvin to:
            if (satuanAwal.Text == "Kelvin")
            {
                // konversi ke C
                double n = Convert.ToDouble(nilaiAwal.Text);
                double C = Convert.ToDouble(n - 273.15);
                // switch suhu lain
                switch (satuanAkhir.Text)
                {
                    case "Celcius":
                        {
                            //konversi
                            double t = C;
                            nilaiAkhir.Text = Convert.ToString(t) + " *C";
                            break;
                        }
                    case "Fahrenheit":
                        {
                            //konversi
                            double t = 5.0 / 9.0 * (C + 32);
                            nilaiAkhir.Text = Convert.ToString(t) + " *F";
                            break;
                        }
                    case "Reamur":
                        {
                            //konversi
                            double t = 5.0 / 4.0 * (C * -1); // C * -1 agar dibalik
                            nilaiAkhir.Text = Convert.ToString(t) + " *R";
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("tidak valid");
                            break;
                        }
                }
                return;
            }

            // Reamur to:
            if (satuanAwal.Text == "Reamur")
            {
                // konversi ke C
                double n = Convert.ToDouble(nilaiAwal.Text);
                double C = Convert.ToDouble((5.0 / 4.0) * n);
                // switch suhu lain
                switch (satuanAkhir.Text)
                {
                    case "Celcius":
                        {
                            //konversi
                            double t = C;
                            nilaiAkhir.Text = Convert.ToString(t) + " *C";
                            break;
                        }
                    case "Fahrenheit":
                        {
                            //konversi
                            double t = 5.0 / 9.0 * (C + 32);
                            nilaiAkhir.Text = Convert.ToString(t) + " *F";
                            break;
                        }
                    case "Kelvin":
                        {
                            //konversi
                            double t = C + 273.15;
                            nilaiAkhir.Text = Convert.ToString(t) + " K";
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("tidak valid");
                            break;
                        }
                }
                return;
            }

        }
    }
}
