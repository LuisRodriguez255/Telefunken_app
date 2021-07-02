using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppRegistro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataPage : ContentPage
    {
        List<Entry> J1 = new List<Entry>();
        List<Entry> J2 = new List<Entry>();
        List<Entry> J3 = new List<Entry>();
        List<Entry> J4 = new List<Entry>();
        List<Entry> J5 = new List<Entry>();
        List<Entry> J6 = new List<Entry>();
        List<Entry> J7 = new List<Entry>();
        List<Entry> J8 = new List<Entry>();
        protected int total_1, total_2, total_3, total_4,
            total_5, total_6, total_7, total_8;

        public DataPage()
        {
            InitializeComponent();
        }

        private void tbx_j1_Completed(object sender, EventArgs e)
        {
            if (tbx_j1.Text == null)
            {
                Alerta_1();
            }
            else if (tbx_j1.Text != null)
            {
                lbl_j1.Text = tbx_j1.Text;
                tbx_j1.IsVisible = false;
                MostrarEntry_1();
            }
        }

        private void tbx_j2_Completed(object sender, EventArgs e)
        {
            if (tbx_j2.Text == null)
            {
                Alerta_1();
            }
            else if (tbx_j2.Text != null)
            {
                lbl_j2.Text = tbx_j2.Text;
                tbx_j2.IsVisible = false;
                MostrarEntry_2();
            }
        }

        private void tbx_j3_Completed(object sender, EventArgs e)
        {
            if (tbx_j3.Text == null)
            {
                Alerta_1();
            }
            else if (tbx_j3.Text != null)
            {
                lbl_j3.Text = tbx_j3.Text;
                tbx_j3.IsVisible = false;
                MostrarEntry_3();
            }
        }

        private void tbx_j4_Completed(object sender, EventArgs e)
        {
            if (tbx_j4.Text == null)
            {
                Alerta_1();
            }
            else if (tbx_j4.Text != null)
            {
                lbl_j4.Text = tbx_j4.Text;
                tbx_j4.IsVisible = false;
                MostrarEntry_4();
            }
        }

        private void tbx_j5_Completed(object sender, EventArgs e)
        {
            if (tbx_j5.Text == null)
            {
                Alerta_1();
            }
            else if (tbx_j5.Text != null)
            {
                lbl_j5.Text = tbx_j5.Text;
                tbx_j5.IsVisible = false;
                MostrarEntry_5();
            }
        }

        private void tbx_j6_Completed(object sender, EventArgs e)
        {
            if (tbx_j6.Text == null)
            {
                Alerta_1();
            }
            else if (tbx_j6.Text != null)
            {
                lbl_j6.Text = tbx_j6.Text;
                tbx_j6.IsVisible = false;
                MostrarEntry_6();
            }
        }

        private void tbx_j7_Completed(object sender, EventArgs e)
        {
            if (tbx_j7.Text == null)
            {
                Alerta_1();
            }
            else if (tbx_j7.Text != null)
            {
                lbl_j7.Text = tbx_j7.Text;
                tbx_j7.IsVisible = false;
                MostrarEntry_7();
            }
        }

        private void tbx_j8_Completed(object sender, EventArgs e)
        {
            if (tbx_j8.Text == null)
            {
                Alerta_1();
            }
            else if (tbx_j8.Text != null)
            {
                lbl_j8.Text = tbx_j8.Text;
                tbx_j8.IsVisible = false;
                MostrarEntry_8();
            }
        }

        protected async void Alerta_1()
        {
            await DisplayAlert("UPS!", "Debe poner un identificador para el jugador (nombre, nick)"
                , "ACEPTAR");
        }

        protected async void Alerta_2()
        {
            await DisplayAlert("UPS!", "LAS COMPRAS NO PUEDEN SER MAYOR A 12", "OK");
        }

        protected async void Alerta_3()
        {
            await DisplayAlert("UPS!", "EL CAMPO NO PUEDE ESTÁR VACÍO", "ACEPTAR");
        }

        private void tbx_p1_j1_Completed(object sender, EventArgs e)
        {
            lbl_p1_j1.Text = tbx_p1_j1.Text;
            tbx_p1_j1.Opacity = 0;
            tbx_p1_j1.IsEnabled = false;
        }

        private void tbx_p2_j1_Completed(object sender, EventArgs e)
        {
            lbl_p2_j1.Text = tbx_p2_j1.Text;
            tbx_p2_j1.Opacity = 0;
            tbx_p2_j1.IsEnabled = false;
        }

        private void tbx_p3_j1_Completed(object sender, EventArgs e)
        {
            lbl_p3_j1.Text = tbx_p3_j1.Text;
            tbx_p3_j1.Opacity = 0;
            tbx_p3_j1.IsEnabled = false;
        }

        private void tbx_p4_j1_Completed(object sender, EventArgs e)
        {
            lbl_p4_j1.Text = tbx_p4_j1.Text;
            tbx_p4_j1.Opacity = 0;
            tbx_p4_j1.IsEnabled = false;
        }

        private void tbx_p5_j1_Completed(object sender, EventArgs e)
        {
            lbl_p5_j1.Text = tbx_p5_j1.Text;
            tbx_p5_j1.Opacity = 0;
            tbx_p5_j1.IsEnabled = false;
        }

        private void tbx_p6_j1_Completed(object sender, EventArgs e)
        {
            lbl_p6_j1.Text = tbx_p6_j1.Text;
            tbx_p6_j1.Opacity = 0;
            tbx_p6_j1.IsEnabled = false;
        }

        private void tbx_p7_j1_Completed(object sender, EventArgs e)
        {
            lbl_p7_j1.Text = tbx_p7_j1.Text;
            tbx_p7_j1.Opacity = 0;
            tbx_p7_j1.IsEnabled = false;
            btn_total_j1.IsVisible = true;
        }

        private void btn_total_j1_Clicked(object sender, EventArgs e)
        {
            total_1 = int.Parse(lbl_p1_j1.Text) + int.Parse(lbl_p2_j1.Text) + int.Parse(lbl_p3_j1.Text) +
                int.Parse(lbl_p4_j1.Text) + int.Parse(lbl_p5_j1.Text) + int.Parse(lbl_p6_j1.Text)
                + int.Parse(lbl_p7_j1.Text);
            lbl_total_j1.Text = total_1.ToString();
            btn_total_j1.IsVisible = false;
        }

        private void btn_compra_j1_Clicked(object sender, EventArgs e)
        {
            int acumulador = int.Parse(lbl_compra_j1.Text) + 1;
            lbl_compra_j1.Text = acumulador.ToString();
            if (acumulador > 12)
            {
                Alerta_2();
                lbl_compra_j1.Text = "12";
                btn_compra_j1.IsEnabled = false;
            }
        }

        private void MostrarEntry_1()
        {
            J1.Add(tbx_p1_j1);
            J1.Add(tbx_p2_j1);
            J1.Add(tbx_p3_j1);
            J1.Add(tbx_p4_j1);
            J1.Add(tbx_p5_j1);
            J1.Add(tbx_p6_j1);
            J1.Add(tbx_p7_j1);
            foreach (Entry pt1 in J1)
            {
                pt1.IsVisible = true;
            }
            lbl_compra_j1.IsVisible = true;
            btn_compra_j1.IsVisible = true;
        }

        private void tbx_p1_j2_Completed(object sender, EventArgs e)
        {
            lbl_p1_j2.Text = tbx_p1_j2.Text;
            tbx_p1_j2.Opacity = 0;
            tbx_p1_j2.IsEnabled = false;
        }

        private void tbx_p2_j2_Completed(object sender, EventArgs e)
        {
            lbl_p2_j2.Text = tbx_p2_j2.Text;
            tbx_p2_j2.Opacity = 0;
            tbx_p2_j2.IsEnabled = false;
        }

        private void tbx_p3_j2_Completed(object sender, EventArgs e)
        {
            lbl_p3_j2.Text = tbx_p3_j2.Text;
            tbx_p3_j2.Opacity = 0;
            tbx_p3_j2.IsEnabled = false;
        }

        private void tbx_p4_j2_Completed(object sender, EventArgs e)
        {
            lbl_p4_j2.Text = tbx_p4_j2.Text;
            tbx_p4_j2.Opacity = 0;
            tbx_p4_j2.IsEnabled = false;
        }

        private void tbx_p5_j2_Completed(object sender, EventArgs e)
        {
            lbl_p5_j2.Text = tbx_p5_j2.Text;
            tbx_p5_j2.Opacity = 0;
            tbx_p5_j2.IsEnabled = false;
        }

        private void tbx_p6_j2_Completed(object sender, EventArgs e)
        {
            lbl_p6_j2.Text = tbx_p6_j2.Text;
            tbx_p6_j2.Opacity = 0;
            tbx_p6_j2.IsEnabled = false;
        }

        private void tbx_p7_j2_Completed(object sender, EventArgs e)
        {
            lbl_p7_j2.Text = tbx_p7_j2.Text;
            tbx_p7_j2.Opacity = 0;
            tbx_p7_j2.IsEnabled = false;
            btn_total_j2.IsVisible = true;
        }

        private void btn_total_j2_Clicked(object sender, EventArgs e)
        {
            total_2 = int.Parse(lbl_p1_j2.Text) + int.Parse(lbl_p2_j2.Text) + int.Parse(lbl_p3_j2.Text) +
                int.Parse(lbl_p4_j2.Text) + int.Parse(lbl_p5_j2.Text) + int.Parse(lbl_p6_j2.Text)
                + int.Parse(lbl_p7_j2.Text);
            lbl_total_j2.Text = total_2.ToString();
            btn_total_j2.IsVisible = false;
        }

        private void btn_compra_j2_Clicked(object sender, EventArgs e)
        {
            int acumulador = int.Parse(lbl_compra_j2.Text) + 1;
            lbl_compra_j2.Text = acumulador.ToString();
            if (acumulador > 12)
            {
                Alerta_2();
                lbl_compra_j2.Text = "12";
                btn_compra_j2.IsEnabled = false;
            }
        }

        private void MostrarEntry_2()
        {
            J2.Add(tbx_p1_j2);
            J2.Add(tbx_p2_j2);
            J2.Add(tbx_p3_j2);
            J2.Add(tbx_p4_j2);
            J2.Add(tbx_p5_j2);
            J2.Add(tbx_p6_j2);
            J2.Add(tbx_p7_j2);
            foreach (Entry pt2 in J2)
            {
                pt2.IsVisible = true;
            }
            lbl_compra_j2.IsVisible = true;
            btn_compra_j2.IsVisible = true;
        }

        private void tbx_p1_j3_Completed(object sender, EventArgs e)
        {
            lbl_p1_j3.Text = tbx_p1_j3.Text;
            tbx_p1_j3.Opacity = 0;
            tbx_p1_j3.IsEnabled = false;
        }

        private void tbx_p2_j3_Completed(object sender, EventArgs e)
        {
            lbl_p2_j3.Text = tbx_p2_j3.Text;
            tbx_p2_j3.Opacity = 0;
            tbx_p2_j3.IsEnabled = false;
        }

        private void tbx_p3_j3_Completed(object sender, EventArgs e)
        {
            lbl_p3_j3.Text = tbx_p3_j3.Text;
            tbx_p3_j3.Opacity = 0;
            tbx_p3_j3.IsEnabled = false;
        }

        private void tbx_p4_j3_Completed(object sender, EventArgs e)
        {
            lbl_p4_j3.Text = tbx_p4_j3.Text;
            tbx_p4_j3.Opacity = 0;
            tbx_p4_j3.IsEnabled = false;
        }

        private void tbx_p5_j3_Completed(object sender, EventArgs e)
        {
            lbl_p5_j3.Text = tbx_p5_j3.Text;
            tbx_p5_j3.Opacity = 0;
            tbx_p5_j3.IsEnabled = false;
        }

        private void tbx_p6_j3_Completed(object sender, EventArgs e)
        {
            lbl_p6_j3.Text = tbx_p6_j3.Text;
            tbx_p6_j3.Opacity = 0;
            tbx_p6_j3.IsEnabled = false;
        }

        private void tbx_p7_j3_Completed(object sender, EventArgs e)
        {
            lbl_p7_j3.Text = tbx_p7_j3.Text;
            tbx_p7_j3.Opacity = 0;
            tbx_p7_j3.IsEnabled = false;
            btn_total_j3.IsVisible = true;
        }

        private void btn_total_j3_Clicked(object sender, EventArgs e)
        {
            total_3 = int.Parse(lbl_p1_j3.Text) + int.Parse(lbl_p2_j3.Text) + int.Parse(lbl_p3_j3.Text) +
                int.Parse(lbl_p4_j3.Text) + int.Parse(lbl_p5_j3.Text) + int.Parse(lbl_p6_j3.Text)
                + int.Parse(lbl_p7_j3.Text);
            lbl_total_j3.Text = total_3.ToString();
            btn_total_j3.IsVisible = false;
        }

        private void btn_compra_j3_Clicked(object sender, EventArgs e)
        {
            int acumulador = int.Parse(lbl_compra_j3.Text) + 1;
            lbl_compra_j3.Text = acumulador.ToString();
            if (acumulador > 12)
            {
                Alerta_2();
                lbl_compra_j3.Text = "12";
                btn_compra_j3.IsEnabled = false;
            }
        }

        private void MostrarEntry_3()
        {
            J3.Add(tbx_p1_j3);
            J3.Add(tbx_p2_j3);
            J3.Add(tbx_p3_j3);
            J3.Add(tbx_p4_j3);
            J3.Add(tbx_p5_j3);
            J3.Add(tbx_p6_j3);
            J3.Add(tbx_p7_j3);
            foreach (Entry pt3 in J3)
            {
                pt3.IsVisible = true;
            }
            lbl_compra_j3.IsVisible = true;
            btn_compra_j3.IsVisible = true;
        }

        private void tbx_p1_j4_Completed(object sender, EventArgs e)
        {
            lbl_p1_j4.Text = tbx_p1_j4.Text;
            tbx_p1_j4.Opacity = 0;
            tbx_p1_j4.IsEnabled = false;
        }

        private void tbx_p2_j4_Completed(object sender, EventArgs e)
        {
            lbl_p2_j4.Text = tbx_p2_j4.Text;
            tbx_p2_j4.Opacity = 0;
            tbx_p2_j4.IsEnabled = false;
        }

        private void tbx_p3_j4_Completed(object sender, EventArgs e)
        {
            lbl_p3_j4.Text = tbx_p3_j4.Text;
            tbx_p3_j4.Opacity = 0;
            tbx_p3_j4.IsEnabled = false;
        }

        private void tbx_p4_j4_Completed(object sender, EventArgs e)
        {
            lbl_p4_j4.Text = tbx_p4_j4.Text;
            tbx_p4_j4.Opacity = 0;
            tbx_p4_j4.IsEnabled = false;
        }

        private void tbx_p5_j4_Completed(object sender, EventArgs e)
        {
            lbl_p5_j4.Text = tbx_p5_j4.Text;
            tbx_p5_j4.Opacity = 0;
            tbx_p5_j4.IsEnabled = false;
        }

        private void tbx_p6_j4_Completed(object sender, EventArgs e)
        {
            lbl_p6_j4.Text = tbx_p6_j4.Text;
            tbx_p6_j4.Opacity = 0;
            tbx_p6_j4.IsEnabled = false;
        }

        private void tbx_p7_j4_Completed(object sender, EventArgs e)
        {
            lbl_p7_j4.Text = tbx_p7_j4.Text;
            tbx_p7_j4.Opacity = 0;
            tbx_p7_j4.IsEnabled = false;
            btn_total_j4.IsVisible = true;
        }

        private void btn_total_j4_Clicked(object sender, EventArgs e)
        {
            total_4 = int.Parse(lbl_p1_j4.Text) + int.Parse(lbl_p2_j4.Text) + int.Parse(lbl_p3_j4.Text) +
                int.Parse(lbl_p4_j4.Text) + int.Parse(lbl_p5_j4.Text) + int.Parse(lbl_p6_j4.Text)
                + int.Parse(lbl_p7_j4.Text);
            lbl_total_j4.Text = total_4.ToString();
            btn_total_j4.IsVisible = false;
        }

        private void btn_compra_j4_Clicked(object sender, EventArgs e)
        {
            int acumulador = int.Parse(lbl_compra_j4.Text) + 1;
            lbl_compra_j4.Text = acumulador.ToString();
            if (acumulador > 12)
            {
                Alerta_2();
                lbl_compra_j4.Text = "12";
                btn_compra_j4.IsEnabled = false;
            }
        }

        private void MostrarEntry_4()
        {
            J4.Add(tbx_p1_j4);
            J4.Add(tbx_p2_j4);
            J4.Add(tbx_p3_j4);
            J4.Add(tbx_p4_j4);
            J4.Add(tbx_p5_j4);
            J4.Add(tbx_p6_j4);
            J4.Add(tbx_p7_j4);
            foreach (Entry pt4 in J4)
            {
                pt4.IsVisible = true;
            }
            lbl_compra_j4.IsVisible = true;
            btn_compra_j4.IsVisible = true;
        }

        private void tbx_p1_j5_Completed(object sender, EventArgs e)
        {
            lbl_p1_j5.Text = tbx_p1_j5.Text;
            tbx_p1_j5.Opacity = 0;
            tbx_p1_j5.IsEnabled = false;
        }

        private void tbx_p2_j5_Completed(object sender, EventArgs e)
        {
            lbl_p2_j5.Text = tbx_p2_j5.Text;
            tbx_p2_j5.Opacity = 0;
            tbx_p2_j5.IsEnabled = false;
        }

        private void tbx_p3_j5_Completed(object sender, EventArgs e)
        {
            lbl_p3_j5.Text = tbx_p3_j5.Text;
            tbx_p3_j5.Opacity = 0;
            tbx_p3_j5.IsEnabled = false;
        }

        private void tbx_p4_j5_Completed(object sender, EventArgs e)
        {
            lbl_p4_j5.Text = tbx_p4_j5.Text;
            tbx_p4_j5.Opacity = 0;
            tbx_p4_j5.IsEnabled = false;
        }

        private void tbx_p5_j5_Completed(object sender, EventArgs e)
        {
            lbl_p5_j5.Text = tbx_p5_j5.Text;
            tbx_p5_j5.Opacity = 0;
            tbx_p5_j5.IsEnabled = false;
        }

        private void tbx_p6_j5_Completed(object sender, EventArgs e)
        {
            lbl_p6_j5.Text = tbx_p6_j5.Text;
            tbx_p6_j5.Opacity = 0;
            tbx_p6_j5.IsEnabled = false;
        }

        private void tbx_p7_j5_Completed(object sender, EventArgs e)
        {
            lbl_p7_j5.Text = tbx_p7_j5.Text;
            tbx_p7_j5.Opacity = 0;
            tbx_p7_j5.IsEnabled = false;
            btn_total_j5.IsVisible = true;
        }

        private void btn_total_j5_Clicked(object sender, EventArgs e)
        {
            total_5 = int.Parse(lbl_p1_j5.Text) + int.Parse(lbl_p2_j5.Text) + int.Parse(lbl_p3_j5.Text) +
                int.Parse(lbl_p4_j5.Text) + int.Parse(lbl_p5_j5.Text) + int.Parse(lbl_p6_j5.Text)
                + int.Parse(lbl_p7_j5.Text);
            lbl_total_j5.Text = total_5.ToString();
            btn_total_j5.IsVisible = false;
        }

        private void btn_compra_j5_Clicked(object sender, EventArgs e)
        {
            int acumulador = int.Parse(lbl_compra_j5.Text) + 1;
            lbl_compra_j5.Text = acumulador.ToString();
            if (acumulador > 12)
            {
                Alerta_2();
                lbl_compra_j5.Text = "12";
                btn_compra_j5.IsEnabled = false;
            }
        }

        private void MostrarEntry_5()
        {
            J5.Add(tbx_p1_j5);
            J5.Add(tbx_p2_j5);
            J5.Add(tbx_p3_j5);
            J5.Add(tbx_p4_j5);
            J5.Add(tbx_p5_j5);
            J5.Add(tbx_p6_j5);
            J5.Add(tbx_p7_j5);
            foreach (Entry pt5 in J5)
            {
                pt5.IsVisible = true;
            }
            lbl_compra_j5.IsVisible = true;
            btn_compra_j5.IsVisible = true;
        }

        private void tbx_p1_j6_Completed(object sender, EventArgs e)
        {
            lbl_p1_j6.Text = tbx_p1_j6.Text;
            tbx_p1_j6.Opacity = 0;
            tbx_p1_j6.IsEnabled = false;
        }

        private void tbx_p2_j6_Completed(object sender, EventArgs e)
        {
            lbl_p2_j6.Text = tbx_p2_j6.Text;
            tbx_p2_j6.Opacity = 0;
            tbx_p2_j6.IsEnabled = false;
        }

        private void tbx_p3_j6_Completed(object sender, EventArgs e)
        {
            lbl_p3_j6.Text = tbx_p3_j6.Text;
            tbx_p3_j6.Opacity = 0;
            tbx_p3_j6.IsEnabled = false;
        }

        private void tbx_p4_j6_Completed(object sender, EventArgs e)
        {
            lbl_p4_j6.Text = tbx_p4_j6.Text;
            tbx_p4_j6.Opacity = 0;
            tbx_p4_j6.IsEnabled = false;
        }

        private void tbx_p5_j6_Completed(object sender, EventArgs e)
        {
            lbl_p5_j6.Text = tbx_p5_j6.Text;
            tbx_p5_j6.Opacity = 0;
            tbx_p5_j6.IsEnabled = false;
        }

        private void tbx_p6_j6_Completed(object sender, EventArgs e)
        {
            lbl_p6_j6.Text = tbx_p6_j6.Text;
            tbx_p6_j6.Opacity = 0;
            tbx_p6_j6.IsEnabled = false;
        }

        private void tbx_p7_j6_Completed(object sender, EventArgs e)
        {
            lbl_p7_j6.Text = tbx_p7_j6.Text;
            tbx_p7_j6.Opacity = 0;
            tbx_p7_j6.IsEnabled = false;
            btn_total_j6.IsVisible = true;
        }

        private void btn_total_j6_Clicked(object sender, EventArgs e)
        {
            total_6 = int.Parse(lbl_p1_j6.Text) + int.Parse(lbl_p2_j6.Text) + int.Parse(lbl_p3_j6.Text) +
                int.Parse(lbl_p4_j6.Text) + int.Parse(lbl_p5_j6.Text) + int.Parse(lbl_p6_j6.Text)
                + int.Parse(lbl_p7_j6.Text);
            lbl_total_j6.Text = total_6.ToString();
            btn_total_j6.IsVisible = false;
        }

        private void btn_compra_j6_Clicked(object sender, EventArgs e)
        {
            int acumulador = int.Parse(lbl_compra_j6.Text) + 1;
            lbl_compra_j6.Text = acumulador.ToString();
            if (acumulador > 12)
            {
                Alerta_2();
                lbl_compra_j6.Text = "12";
                btn_compra_j6.IsEnabled = false;
            }
        }

        private void MostrarEntry_6()
        {
            J6.Add(tbx_p1_j6);
            J6.Add(tbx_p2_j6);
            J6.Add(tbx_p3_j6);
            J6.Add(tbx_p4_j6);
            J6.Add(tbx_p5_j6);
            J6.Add(tbx_p6_j6);
            J6.Add(tbx_p7_j6);
            foreach (Entry pt6 in J6)
            {
                pt6.IsVisible = true;
            }
            lbl_compra_j6.IsVisible = true;
            btn_compra_j6.IsVisible = true;
        }

        private void tbx_p1_j7_Completed(object sender, EventArgs e)
        {
            lbl_p1_j7.Text = tbx_p1_j7.Text;
            tbx_p1_j7.Opacity = 0;
            tbx_p1_j7.IsEnabled = false;
        }

        private void tbx_p2_j7_Completed(object sender, EventArgs e)
        {
            lbl_p2_j7.Text = tbx_p2_j7.Text;
            tbx_p2_j7.Opacity = 0;
            tbx_p2_j7.IsEnabled = false;
        }

        private void tbx_p3_j7_Completed(object sender, EventArgs e)
        {
            lbl_p3_j7.Text = tbx_p3_j7.Text;
            tbx_p3_j7.Opacity = 0;
            tbx_p3_j7.IsEnabled = false;
        }

        private void tbx_p4_j7_Completed(object sender, EventArgs e)
        {
            lbl_p4_j7.Text = tbx_p4_j7.Text;
            tbx_p4_j7.Opacity = 0;
            tbx_p4_j7.IsEnabled = false;
        }

        private void tbx_p5_j7_Completed(object sender, EventArgs e)
        {
            lbl_p5_j7.Text = tbx_p1_j7.Text;
            tbx_p5_j7.Opacity = 0;
            tbx_p5_j7.IsEnabled = false;
        }

        private void tbx_p6_j7_Completed(object sender, EventArgs e)
        {
            lbl_p6_j7.Text = tbx_p1_j7.Text;
            tbx_p6_j7.Opacity = 0;
            tbx_p6_j7.IsEnabled = false;
        }

        private void tbx_p7_j7_Completed(object sender, EventArgs e)
        {
            lbl_p7_j7.Text = tbx_p7_j7.Text;
            tbx_p7_j7.Opacity = 0;
            tbx_p7_j7.IsEnabled = false;
            btn_total_j7.IsVisible = true;
        }

        private void btn_total_j7_Clicked(object sender, EventArgs e)
        {
            total_7 = int.Parse(lbl_p1_j7.Text) + int.Parse(lbl_p2_j7.Text) + int.Parse(lbl_p3_j7.Text) +
                int.Parse(lbl_p4_j7.Text) + int.Parse(lbl_p5_j7.Text) + int.Parse(lbl_p6_j7.Text)
                + int.Parse(lbl_p7_j7.Text);
            lbl_total_j7.Text = total_7.ToString();
            btn_total_j7.IsVisible = false;
        }

        private void btn_compra_j7_Clicked(object sender, EventArgs e)
        {
            int acumulador = int.Parse(lbl_compra_j7.Text) + 1;
            lbl_compra_j7.Text = acumulador.ToString();
            if (acumulador > 12)
            {
                Alerta_2();
                lbl_compra_j7.Text = "12";
                btn_compra_j7.IsEnabled = false;
            }
        }

        private void MostrarEntry_7()
        {
            J7.Add(tbx_p1_j7);
            J7.Add(tbx_p2_j7);
            J7.Add(tbx_p3_j7);
            J7.Add(tbx_p4_j7);
            J7.Add(tbx_p5_j7);
            J7.Add(tbx_p6_j7);
            J7.Add(tbx_p7_j7);
            foreach (Entry pt7 in J7)
            {
                pt7.IsVisible = true;
            }
            lbl_compra_j7.IsVisible = true;
            btn_compra_j7.IsVisible = true;
        }

        private void tbx_p1_j8_Completed(object sender, EventArgs e)
        {
            lbl_p1_j8.Text = tbx_p1_j8.Text;
            tbx_p1_j8.Opacity = 0;
            tbx_p1_j8.IsEnabled = false;
        }

        private void tbx_p2_j8_Completed(object sender, EventArgs e)
        {
            lbl_p2_j8.Text = tbx_p2_j8.Text;
            tbx_p2_j8.Opacity = 0;
            tbx_p2_j8.IsEnabled = false;
        }

        private void tbx_p3_j8_Completed(object sender, EventArgs e)
        {
            lbl_p3_j8.Text = tbx_p3_j8.Text;
            tbx_p3_j8.Opacity = 0;
            tbx_p3_j8.IsEnabled = false;
        }

        private void tbx_p4_j8_Completed(object sender, EventArgs e)
        {
            lbl_p4_j8.Text = tbx_p4_j8.Text;
            tbx_p4_j8.Opacity = 0;
            tbx_p4_j8.IsEnabled = false;
        }

        private void tbx_p5_j8_Completed(object sender, EventArgs e)
        {
            lbl_p5_j8.Text = tbx_p5_j8.Text;
            tbx_p5_j8.Opacity = 0;
            tbx_p5_j8.IsEnabled = false;
        }

        private void tbx_p6_j8_Completed(object sender, EventArgs e)
        {
            lbl_p6_j8.Text = tbx_p6_j8.Text;
            tbx_p6_j8.Opacity = 0;
            tbx_p6_j8.IsEnabled = false;
        }

        private void tbx_p7_j8_Completed(object sender, EventArgs e)
        {
            lbl_p7_j8.Text = tbx_p7_j8.Text;
            tbx_p7_j8.Opacity = 0;
            tbx_p7_j8.IsEnabled = false;
            btn_total_j8.IsVisible = true;
        }

        private void btn_total_j8_Clicked(object sender, EventArgs e)
        {
            total_8 = int.Parse(lbl_p1_j8.Text) + int.Parse(lbl_p2_j8.Text) + int.Parse(lbl_p3_j8.Text) +
                int.Parse(lbl_p4_j8.Text) + int.Parse(lbl_p5_j8.Text) + int.Parse(lbl_p6_j8.Text)
                + int.Parse(lbl_p7_j8.Text);
            lbl_total_j8.Text = total_8.ToString();
            btn_total_j8.IsVisible = false;
        }

        private void btn_compra_j8_Clicked(object sender, EventArgs e)
        {
            int acumulador = int.Parse(lbl_compra_j8.Text) + 1;
            lbl_compra_j8.Text = acumulador.ToString();
            if (acumulador > 12)
            {
                Alerta_2();
                lbl_compra_j8.Text = "12";
                btn_compra_j8.IsEnabled = false;
            }
        }

        private void MostrarEntry_8()
        {
            J8.Add(tbx_p1_j8);
            J8.Add(tbx_p2_j8);
            J8.Add(tbx_p3_j8);
            J8.Add(tbx_p4_j8);
            J8.Add(tbx_p5_j8);
            J8.Add(tbx_p6_j8);
            J8.Add(tbx_p7_j8);
            foreach (Entry pt8 in J8)
            {
                pt8.IsVisible = true;
            }
            lbl_compra_j8.IsVisible = true;
            btn_compra_j8.IsVisible = true;
        }
    }
}