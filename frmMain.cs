using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imperialConverter
{
    public partial class frmMain : Form
    {

        private void focusInput()
        {
            txtImperial.Focus();
            txtImperial.DeselectAll();
            txtImperial.SelectionStart = txtImperial.Text.Length;  
            txtImperial.SelectionLength = 0; 
        }

        private void addNumber( String number )
        {
            txtImperial.Text += number;
            focusInput();
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void txtImperial_TextChanged( object sender, EventArgs e )
        {
            double imperialValue = 0.0;
            double imperialValueAdd = 0.0;
            double mm = 0.0;
            try
            {
                if ( txtImperial.Text.Contains( '/' ) )
                {
                    string[] vals = txtImperial.Text.Split( '/' );
                    if( vals.Length > 1 )
                    {
                        if( vals[0].Length > 0 && vals[1].Length > 0 )
                        {
                            // If the whole string also contains a decimal point, for example "3.3/16"
                            // then we treat it as if it is 3" and 3/16"
                            if( vals[0].Contains( '.' ))
                            {
                                string[] firstVals = vals[0].Split( '.' );
                                if( firstVals.Length > 1 )
                                {
                                    if( firstVals[0].Length > 0 )
                                    {
                                        imperialValueAdd = Convert.ToDouble( firstVals[0] );
                                        vals[0] = firstVals[1];
                                    }
                                }
                            }
                            imperialValue = imperialValueAdd + Convert.ToDouble( vals[0] ) / Convert.ToDouble( vals[1] );
                        }
                    }
                }else
                {
                    imperialValue = Convert.ToDouble( txtImperial.Text );
                }
                mm = Math.Round( imperialValue * 25.4, 3 );
            }
            catch
            {
                txtMetric.Clear();
                return;
            }
            txtMetric.Text = mm.ToString();
        }

        private void Form1_FormClosing( object sender, FormClosingEventArgs e )
        {
            Properties.Settings.Default.Location = Location;
            Properties.Settings.Default.Save();
        }

        private void frmMain_Load( object sender, EventArgs e )
        {
            Location = Properties.Settings.Default.Location;
        }

        private void button1_Click( object sender, EventArgs e )
        {
            addNumber( "0" );
        }

        private void button2_Click( object sender, EventArgs e )
        {
            addNumber( "1" );
        }

        private void button3_Click( object sender, EventArgs e )
        {
            addNumber( "2" );
        }

        private void button4_Click( object sender, EventArgs e )
        {
            addNumber( "3" );
        }

        private void button5_Click( object sender, EventArgs e )
        {
            addNumber( "4" );
        }

        private void button6_Click( object sender, EventArgs e )
        {
            addNumber( "5" );
        }

        private void button7_Click( object sender, EventArgs e )
        {
            addNumber( "6" );
        }

        private void button8_Click( object sender, EventArgs e )
        {
            addNumber( "7" );
        }

        private void button9_Click( object sender, EventArgs e )
        {
            addNumber( "8" );
        }

        private void button10_Click( object sender, EventArgs e )
        {
            addNumber( "9" );
        }

        private void button11_Click( object sender, EventArgs e )
        {
            if ( txtImperial.Text.Contains( '.' ) || txtImperial.Text.Contains( '/' ) ) return;
            addNumber( "." );
        }

        private void button12_Click( object sender, EventArgs e )
        {
            txtImperial.Clear();
        }

        private void txtMetric_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == 27 )
            {
                txtImperial.Clear();
                return;
            }
            if ( e.KeyChar == '.' && ( txtImperial.Text.Contains( '.' ) || txtImperial.Text.Contains( '/' ) ) ||
                 e.KeyChar == '/' && ( txtImperial.Text.Contains( '/' ) || txtImperial.Text.Contains( '.' ) )
               )
            {
                e.Handled = true;
                return;
            }
            if ( ( e.KeyChar < '0' || e.KeyChar > '9' ) &&
                e.KeyChar != '.' && e.KeyChar != '/' && e.KeyChar != 8 )
            {
                e.Handled = true;
            }
        }

        private void cmdDrillSize_Click( object sender, EventArgs e )
        {
            Int32 sz = 0;
            try
            {
                sz = Convert.ToInt32( txtImperial.Text );
            }
            catch
            {
                focusInput();
                return;
            }
            double mm = 0.0;
            switch ( sz )
            {
                case 90:
                    mm = 0.2210;
                    break;
                case 89:
                    mm = 0.2311;
                    break;
                case 88:
                    mm = 0.2413;
                    break;
                case 87:
                    mm = 0.2540;
                    break;
                case 86:
                    mm = 0.2667;
                    break;
                case 85:
                    mm = 0.2794;
                    break;
                case 84:
                    mm = 0.2921;
                    break;
                case 83:
                    mm = 0.3048;
                    break;
                case 82:
                    mm = 0.3175;
                    break;
                case 81:
                    mm = 0.3302;
                    break;
                case 80:
                    mm = 0.3429;
                    break;
                case 79:
                    mm = 0.3680;
                    ;
                    break;
                case 78:
                    mm = 0.4064;
                    break;
                case 77:
                    mm = 0.4572;
                    break;
                case 76:
                    mm = 0.5080;
                    break;
                case 75:
                    mm = 0.5334;
                    break;
                case 74:
                    mm = 0.5715;
                    break;
                case 73:
                    mm = 0.6096;
                    break;
                case 72:
                    mm = 0.6350;
                    break;
                case 71:
                    mm = 0.6604;
                    break;
                case 70:
                    mm = 0.7112;
                    break;
                case 69:
                    mm = 0.7417;
                    break;
                case 68:
                    mm = 0.7874;
                    break;
                case 67:
                    mm = 0.8128;
                    break;
                case 66:
                    mm = 0.8382;
                    break;
                case 65:
                    mm = 0.8890;
                    break;
                case 64:
                    mm = 0.9144;
                    break;
                case 63:
                    mm = 0.9398;
                    break;
                case 62:
                    mm = 0.9652;
                    break;
                case 61:
                    mm = 0.9906;
                    break;
                case 60:
                    mm = 1.0160;
                    break;
                case 59:
                    mm = 1.0414;
                    break;
                case 58:
                    mm = 1.0668;
                    break;
                case 57:
                    mm = 1.0922;
                    break;
                case 56:
                    mm = 1.1811;
                    break;
                case 55:
                    mm = 1.3208;
                    break;
                case 54:
                    mm = 1.3970;
                    break;
                case 53:
                    mm = 1.5113;
                    break;
                case 52:
                    mm = 1.6129;
                    break;
                case 51:
                    mm = 1.7018;
                    break;
                case 50:
                    mm = 1.7780;
                    break;
                case 49:
                    mm = 1.8542;
                    break;
                case 48:
                    mm = 1.9304;
                    break;
                case 47:
                    mm = 1.9939;
                    break;
                case 46:
                    mm = 2.0574;
                    break;
                case 45:
                    mm = 2.0828;
                    break;
                case 44:
                    mm = 2.1844;
                    break;
                case 43:
                    mm = 2.2606;
                    break;
                case 42:
                    mm = 2.3749;
                    break;
                case 41:
                    mm = 2.4384;
                    break;
                case 40:
                    mm = 2.4892;
                    break;
                case 39:
                    mm = 2.5273;
                    break;
                case 38:
                    mm = 2.5781;
                    break;
                case 37:
                    mm = 2.6416;
                    break;
                case 36:
                    mm = 2.7051;
                    break;
                case 35:
                    mm = 2.7940;
                    break;
                case 34:
                    mm = 2.8194;
                    break;
                case 33:
                    mm = 2.8702;
                    break;
                case 32:
                    mm = 2.9464;
                    break;
                case 31:
                    mm = 3.0480;
                    break;
                case 30:
                    mm = 3.2639;
                    break;
                case 29:
                    mm = 3.4544;
                    break;
                case 28:
                    mm = 3.5687;
                    break;
                case 27:
                    mm = 3.6576;
                    break;
                case 26:
                    mm = 3.7338;
                    break;
                case 25:
                    mm = 3.7973;
                    break;
                case 24:
                    mm = 3.8608;
                    break;
                case 23:
                    mm = 3.9116;
                    break;
                case 22:
                    mm = 3.9878;
                    break;
                case 21:
                    mm = 4.0386;
                    break;
                case 20:
                    mm = 4.0894;
                    break;
            }
            if ( mm != 0.0 )
            {
                txtImperial.Text = "#" + sz.ToString();
                txtMetric.Text = mm.ToString();
            }
            else
            {
                txtMetric.Clear();
            }
            focusInput();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if ( txtImperial.Text.Contains( '/' ) || txtImperial.Text.Contains( '.' ) ) return;
            addNumber( "/" );
        }
    }
}
