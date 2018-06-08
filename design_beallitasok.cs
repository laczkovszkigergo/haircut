using System;
using MySql.Data.MySqlClient;

namespace fodraszat
{
    class design_beallitasok
    {

        csatlakoz cs = new csatlakoz();
        fuggvenyek f = new fuggvenyek();

        string _rgb_szoveg_alap = "0;0;0";
        string _rgb_hatter_alap = "255;175;175";
        string _rgb_datagrid_hatter_alap = "255;140;140";
        string _rgb_datagrid_paros_hatter_alap = "255;200;200";
        string _rgb_datagrid_gridcolor_alap = "255;140;140";
        string _rgb_datagrid_forecolor_alap = "255;255;255";
        string _rgb_datagrid_kivalasztott_hatter_alap = "255;255;255";
        string _rgb_datagrid_kijelolt_betuszin_alap = "0;0;0;";
        string _betu_stilus_alap = "Century Gothic;15,75;Bold";
        string _jelszo_elrejtesi_karakter_alap = "♥";
        string _fo_hatter = "255;128;128";
        string _alapertelmezett = "1";
        
        string rgb_szoveg_alap = default(string);
        string rgb_hatter_alap = default(string);
        string rgb_datagrid_hatter_alap = default(string);
        string rgb_datagrid_paros_hatter_alap = default(string);
        string rgb_datagrid_gridcolor_alap = default(string);
        string rgb_datagrid_forecolor_alap = default(string);
        string rgb_datagrid_kivalasztott_hatter_alap = default(string);
        string rgb_datagrid_kijelolt_betuszin_alap = default(string);
        string betu_stilus_alap = default(string);
        string jelszo_elrejtesi_karakter_alap = default(string);
        string fo_hatter = default(string);
        string alapertelmezett = default(string);

        int[] darabolo = new int[3];
        string[] ddarabolo = new string[3];

        private void _TextBox_formazasok( string alap_ertelmezett_e,int id, params System.Windows.Forms.TextBox[] be)
        {
            if (alap_ertelmezett_e == "1" || id == 0)
            {
                 rgb_szoveg_alap= _rgb_szoveg_alap;
                 rgb_hatter_alap = _rgb_hatter_alap;
                 betu_stilus_alap = _betu_stilus_alap;               
            }
         else
            {
                formazas_beallitasok_beolvasasa(id);
            }
            for (int i = 0; i < darabolo.Length; i++)
            {               
                ddarabolo[i] =rgb_szoveg_alap.Split(';')[i]; 
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].ForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]); //betűszín
            }               
                for (int i = 0; i < darabolo.Length; i++)
                {
                ddarabolo[i] = rgb_hatter_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
                }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].BackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]); //háttérszín
                System.Drawing.FontFamily fa = new System.Drawing.FontFamily(betu_stilus_alap.Split(';')[0]);
                float size = float.Parse(betu_stilus_alap.Split(';')[1]);
                System.Drawing.FontStyle f = (System.Drawing.FontStyle)Enum.Parse(typeof(System.Drawing.FontStyle),betu_stilus_alap.Split(';')[2], true);
                be[i].Font = new System.Drawing.Font(fa.Name,size, f); // betűtípus              
            }
        }
        public void TextBox_formazasok(string alap_ertelmezett_e,int id, params System.Windows.Forms.TextBox[] be)
        {
            _TextBox_formazasok(alap_ertelmezett_e,id,be);
        }

        private void _rTextbox_formazasok(string alap_ertelmezett_e, int id, params System.Windows.Forms.RichTextBox[] be)
        {
            if (alap_ertelmezett_e == "1" || id == 0)
            {
                rgb_szoveg_alap = _rgb_szoveg_alap;
                rgb_hatter_alap = _rgb_hatter_alap;
                betu_stilus_alap = _betu_stilus_alap;
            }
            else
            {
                formazas_beallitasok_beolvasasa(id);
            }
            for (int i = 0; i < darabolo.Length; i++)
            {
                ddarabolo[i] = rgb_szoveg_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].ForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]); //betűszín
            }            
            for (int i = 0; i < darabolo.Length; i++)
            {
                ddarabolo[i] = rgb_hatter_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].BackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]); //háttérszín

                System.Drawing.FontFamily fa = new System.Drawing.FontFamily(betu_stilus_alap.Split(';')[0]);
                float size = float.Parse(betu_stilus_alap.Split(';')[1]);
                System.Drawing.FontStyle f = (System.Drawing.FontStyle)Enum.Parse(typeof(System.Drawing.FontStyle), betu_stilus_alap.Split(';')[2], true);
                be[i].Font = new System.Drawing.Font(fa.Name, size, f); // betűtípus    
                //be[i].Font = new System.Drawing.Font(betu_stilus_alap, be[i].Font.Size, System.Drawing.FontStyle.Bold); // betűtípus
            }
        }
        public void rTextbox_formazasok(string alap_ertelmezett_e, int id, params System.Windows.Forms.RichTextBox[] be)
        {
            _rTextbox_formazasok(alap_ertelmezett_e, id,be);
        }
            
        private void _Jelszo_TextBox_beallitas(string alap_ertelmezett_e, int id, params System.Windows.Forms.TextBox[] be)
        {
            if (alap_ertelmezett_e == "1" || id == 0)
            {
                jelszo_elrejtesi_karakter_alap = _jelszo_elrejtesi_karakter_alap;
            }
            else
            {
                formazas_beallitasok_beolvasasa(id);
            }
            for (int i = 0; i < be.Length; i++)
            {
                if (jelszo_elrejtesi_karakter_alap.Length ==1)
                {
                    be[i].PasswordChar = Convert.ToChar(jelszo_elrejtesi_karakter_alap);
                }
                else
                {
                    be[i].PasswordChar = Convert.ToChar(_jelszo_elrejtesi_karakter_alap);
                }               
            }                                  
        }
        public void Jelszo_TextBox_beallitas(string alap_ertelmezett_e, int id, params System.Windows.Forms.TextBox[] be)
        {
            _Jelszo_TextBox_beallitas(alap_ertelmezett_e,id,be);
        }

        private string _Jelszo_TextBox_beallitas1(string alap_ertelmezett_e, int id,params System.Windows.Forms.TextBox[] be)
        {
            if (alap_ertelmezett_e == "1" || id == 0)
            {
                jelszo_elrejtesi_karakter_alap = _jelszo_elrejtesi_karakter_alap;
            }
            else
            {
                formazas_beallitasok_beolvasasa(id);
            }
            if (jelszo_elrejtesi_karakter_alap.Length ==1)
            {
                return jelszo_elrejtesi_karakter_alap;
            }
            else
            {
                return _jelszo_elrejtesi_karakter_alap;
            }
                                                 
        }
        public string Jelszo_TextBox_beallitas1(string alap_ertelmezett_e, int id, params System.Windows.Forms.TextBox[] be)
        {
            return _Jelszo_TextBox_beallitas1(alap_ertelmezett_e, id,be);
        }

        private void _Label_formazasok(string alap_ertelmezett_e, int id,params System.Windows.Forms.Label[] be)
        {
            if (alap_ertelmezett_e == "1" || id == 0)
            {
                rgb_szoveg_alap = _rgb_szoveg_alap;
                betu_stilus_alap = _betu_stilus_alap;
            }
            else
            {
                formazas_beallitasok_beolvasasa(id);
            }
            for (int i = 0; i < darabolo.Length; i++)
                {
                ddarabolo[i] = rgb_szoveg_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
                }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].ForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);

                System.Drawing.FontFamily fa = new System.Drawing.FontFamily(betu_stilus_alap.Split(';')[0]);
                float size = float.Parse(betu_stilus_alap.Split(';')[1]);
                System.Drawing.FontStyle f = (System.Drawing.FontStyle)Enum.Parse(typeof(System.Drawing.FontStyle), betu_stilus_alap.Split(';')[2], true);
                be[i].Font = new System.Drawing.Font(fa.Name, size, f); // betűtípus
                be[i].BackColor = System.Drawing.Color.Transparent;    
            }


        }  
        public void Label_formazasok(string alap_ertelmezett_e, int id, params System.Windows.Forms.Label[] be)
        {
            _Label_formazasok(alap_ertelmezett_e,id,be);
        }

        private void _Szines_hatteru_Label_formazasok(string alap_ertelmezett_e, int id,params System.Windows.Forms.Label[] be)
        {
            if (alap_ertelmezett_e == "1" || id == 0)
            {

              //  rgb_szoveg_alap = _rgb_szoveg_alap;
                rgb_hatter_alap = _rgb_hatter_alap;
              //  betu_stilus_alap = _betu_stilus_alap;
            }
            else
            {
                formazas_beallitasok_beolvasasa(id);
            }
            /*
            for (int i = 0; i < darabolo.Length; i++)
            {
                ddarabolo[i] = rgb_szoveg_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].ForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]); //betűszín
            }
            */

            for (int i = 0; i < darabolo.Length; i++)
            {
                ddarabolo[i] = rgb_hatter_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].BackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]); //háttérszín
            }
            /*
            System.Drawing.FontFamily fa = new System.Drawing.FontFamily(betu_stilus_alap.Split(';')[0]);
            float size = float.Parse(betu_stilus_alap.Split(';')[1]);
            System.Drawing.FontStyle f = (System.Drawing.FontStyle)Enum.Parse(typeof(System.Drawing.FontStyle), betu_stilus_alap.Split(';')[2], true);

            for (int i = 0; i < be.Length; i++)
            {
                be[i].BackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]); //háttérszín
                be[i].Font = new System.Drawing.Font(fa.Name, size, f); // betűtípus                 
            }
            */
        }
        public void Szines_hatteru_Label_formazasok(string alap_ertelmezett_e, int id, params System.Windows.Forms.Label[] be)
        {
            _Szines_hatteru_Label_formazasok(alapertelmezett, id,be);
        }

        private void _Combobox_formazasok(string alap_ertelmezett_e, int id,params System.Windows.Forms.ComboBox[] be)
        {
            if (alap_ertelmezett_e == "1" || id == 0)
            {
                rgb_szoveg_alap = _rgb_szoveg_alap;
                rgb_hatter_alap = _rgb_hatter_alap;
                betu_stilus_alap = _betu_stilus_alap;
            }
            else
            {
                formazas_beallitasok_beolvasasa(id);
            }
            for (int i = 0; i < darabolo.Length; i++)
            {
                ddarabolo[i] = rgb_szoveg_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].ForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
            }
            

            for (int i = 0; i < darabolo.Length; i++)
            {
                ddarabolo[i] = rgb_hatter_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].BackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
                System.Drawing.FontFamily fa = new System.Drawing.FontFamily(betu_stilus_alap.Split(';')[0]);
                float size = float.Parse(betu_stilus_alap.Split(';')[1]);
                System.Drawing.FontStyle f = (System.Drawing.FontStyle)Enum.Parse(typeof(System.Drawing.FontStyle), betu_stilus_alap.Split(';')[2], true);
                be[i].Font = new System.Drawing.Font(fa.Name, size-4, f); // betűtípus    

               // be[i].Font = new System.Drawing.Font(betu_stilus_alap, be[i].Font.Size, System.Drawing.FontStyle.Bold);
            }

        }
        public void Combobox_Formazasok(string alap_ertelmezett_e, int id,params System.Windows.Forms.ComboBox[] be)
        {
            _Combobox_formazasok(alap_ertelmezett_e, id,be);
        }

        private void _Button_formazasok(string alap_ertelmezett_e, int id,params System.Windows.Forms.Button[] be)
        {
            if (alap_ertelmezett_e == "1" || id == 0)
            {
                rgb_szoveg_alap = _rgb_szoveg_alap;
                rgb_hatter_alap = _rgb_hatter_alap;
                betu_stilus_alap = _betu_stilus_alap;                
            }
            else
            {
                formazas_beallitasok_beolvasasa(id);
            }
            for (int i = 0; i < darabolo.Length; i++)
            {               
                ddarabolo[i] = rgb_szoveg_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }

            for (int i = 0; i < be.Length; i++)
            {
                be[i].ForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
            }         
            for (int i = 0; i < darabolo.Length; i++)
            {
                ddarabolo[i] = rgb_hatter_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].BackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
                System.Drawing.FontFamily fa = new System.Drawing.FontFamily(betu_stilus_alap.Split(';')[0]);
                float size = float.Parse(betu_stilus_alap.Split(';')[1]);
                System.Drawing.FontStyle f = (System.Drawing.FontStyle)Enum.Parse(typeof(System.Drawing.FontStyle), betu_stilus_alap.Split(';')[2], true);
                be[i].Font = new System.Drawing.Font(fa.Name, size-2, f); // betűtípus    
                // be[i].Font = new System.Drawing.Font(betu_stilus_alap, be[i].Font.Size, System.Drawing.FontStyle.Bold);
            }
        }
        public void Button_formazasok(string alap_ertelmezett_e, int id,params System.Windows.Forms.Button[] be)
        {
            _Button_formazasok(alap_ertelmezett_e, id,be);
        }

        private void _Datagrid_formazasok( string alap_ertelmezett_e, int id,params System.Windows.Forms.DataGridView[] be)
        {
            if (alap_ertelmezett_e == "1" || id == 0)
            {
                rgb_datagrid_hatter_alap = _rgb_datagrid_hatter_alap;
                rgb_datagrid_gridcolor_alap = _rgb_datagrid_gridcolor_alap;
                rgb_datagrid_forecolor_alap = _rgb_datagrid_forecolor_alap;
                rgb_datagrid_kivalasztott_hatter_alap = _rgb_datagrid_kivalasztott_hatter_alap;
                rgb_datagrid_kijelolt_betuszin_alap = _rgb_datagrid_kijelolt_betuszin_alap;
                rgb_datagrid_paros_hatter_alap = _rgb_datagrid_paros_hatter_alap;
                betu_stilus_alap = _betu_stilus_alap;
            }
            else
            {
                formazas_beallitasok_beolvasasa(id);
            }
            //Data fore color
            for (int i = 0; i < darabolo.Length; i++)
                {
                ddarabolo[i] = rgb_datagrid_forecolor_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
                }

            for (int i = 0; i < be.Length; i++)
            {
                be[i].ForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);

                be[i].AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
                be[i].ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
                be[i].DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
                be[i].RowHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
            }


                //data grid color alap
                for (int i = 0; i < darabolo.Length; i++)
                {
                ddarabolo[i] = rgb_datagrid_gridcolor_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
                }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].GridColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
            }


                //data back color alap
                for (int i = 0; i < darabolo.Length; i++)
                {
                ddarabolo[i] = rgb_datagrid_hatter_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
                }

            for (int i = 0; i < be.Length; i++)
            {
                be[i].BackgroundColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
                be[i].ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
                be[i].EnableHeadersVisualStyles = false;
                be[i].AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
                be[i].ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
                be[i].RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
            }

                //data kivalasztott back color alap
                for (int i = 0; i < darabolo.Length; i++)
                {
                ddarabolo[i] = rgb_datagrid_kivalasztott_hatter_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
                }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
                be[i].ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
                be[i].DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
                be[i].RowHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
            }


                //data kijelolt betuszin alap
                for (int i = 0; i < darabolo.Length; i++)
                {
                ddarabolo[i] = rgb_datagrid_kijelolt_betuszin_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
                }

            for (int i = 0; i < be.Length; i++)
            {
                be[i].AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
                be[i].ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
                be[i].DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
                be[i].RowHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
            }


            for (int i = 0; i < darabolo.Length; i++) // data paros oszlop hatter
            {
                ddarabolo[i] = rgb_datagrid_paros_hatter_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);

                //data betűtípus alap
                System.Drawing.FontFamily fa = new System.Drawing.FontFamily(betu_stilus_alap.Split(';')[0]);
                float size = float.Parse(betu_stilus_alap.Split(';')[1]);
                System.Drawing.FontStyle f = (System.Drawing.FontStyle)Enum.Parse(typeof(System.Drawing.FontStyle), betu_stilus_alap.Split(';')[2], true);

                be[i].Font = new System.Drawing.Font(fa.Name, size, f); // betűtípus                    
                be[i].AlternatingRowsDefaultCellStyle.Font = new System.Drawing.Font(fa.Name, size, f);
                be[i].ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(fa.Name, size, f);
                be[i].DefaultCellStyle.Font = new System.Drawing.Font(fa.Name, size, f);
                be[i].RowHeadersDefaultCellStyle.Font = new System.Drawing.Font(fa.Name, size, f);
              //  be[i].Font = new System.Drawing.Font(betu_stilus_alap, be[i].Font.Size, System.Drawing.FontStyle.Bold);               
            }
        }
        public void Datagrid_formazasok(string alap_ertelmezett_e, int id, params System.Windows.Forms.DataGridView[] be)
        {
            _Datagrid_formazasok(alap_ertelmezett_e,id,be);
        }

        private void _CheckBox_formazasok(string alap_ertelmezett_e,int id,params System.Windows.Forms.CheckBox[] be)
        {
            if (alap_ertelmezett_e == "1" || id == 0)
            {
                rgb_szoveg_alap = _rgb_szoveg_alap;
                betu_stilus_alap = _betu_stilus_alap;
            }
            else
            {               
                formazas_beallitasok_beolvasasa(id);              
            }
            for (int i = 0; i < darabolo.Length; i++)
            {
                ddarabolo[i] = rgb_szoveg_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].ForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);

                System.Drawing.FontFamily fa = new System.Drawing.FontFamily(betu_stilus_alap.Split(';')[0]);
                float size = float.Parse(betu_stilus_alap.Split(';')[1]);
                System.Drawing.FontStyle f = (System.Drawing.FontStyle)Enum.Parse(typeof(System.Drawing.FontStyle), betu_stilus_alap.Split(';')[2], true);
                be[i].Font = new System.Drawing.Font(fa.Name, size, f); // betűtípus  
                //be[i].Font = new System.Drawing.Font(betu_stilus_alap, be[i].Font.Size, System.Drawing.FontStyle.Bold);
            }

        }
        public void CheckBox_formazasok(string alap_ertelmezett_e, int id,params System.Windows.Forms.CheckBox[] be)
        {
            _CheckBox_formazasok(alapertelmezett, id,be);
        }
        
        private void _Panel_formazasok(string alap_ertelmezett_e,int id,params System.Windows.Forms.Panel[] be)
        {
            if (alap_ertelmezett_e == "1" || id == 0)
            {
                rgb_hatter_alap = _rgb_hatter_alap;
            }
            else
            {
                formazas_beallitasok_beolvasasa(id);
            }
            for (int i = 0; i < darabolo.Length; i++)
            {
                ddarabolo[i] = rgb_hatter_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].BackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]); //háttérszín
            }

        }
        public void Panel_formazasok(string alap_ertelmezett_e, int id,params System.Windows.Forms.Panel[] be)
        {
            _Panel_formazasok(alap_ertelmezett_e, id,be);
        }

        private void _Panel_formazasok1(string alap_ertelmezett_e, int id, params System.Windows.Forms.Panel[] be)
        {
            if (alap_ertelmezett_e == "1" || id == 0)
            {
                 fo_hatter= _fo_hatter;            
            }
            else
            {
                formazas_beallitasok_beolvasasa(id);
            }
            for (int i = 0; i < darabolo.Length; i++)
            {
                ddarabolo[i] = fo_hatter.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].BackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]); //háttérszín
            }
           
        }
        public void Panel_formazasok1(string alap_ertelmezett_e, int id, params System.Windows.Forms.Panel[] be)
        {
            _Panel_formazasok1(alap_ertelmezett_e, id,be);
        }
        
        private void _DateTimePicker_formazasok(string alap_ertelmezett_e, int id,params System.Windows.Forms.DateTimePicker[] be)
        {         
            if (alap_ertelmezett_e == "1" || id == 0)
            {
                rgb_szoveg_alap = _rgb_szoveg_alap;
                rgb_hatter_alap = _rgb_hatter_alap;
                betu_stilus_alap = _betu_stilus_alap;
            }
            else
            {
                formazas_beallitasok_beolvasasa(id);
            }
            for (int i = 0; i < darabolo.Length; i++)
            {
                ddarabolo[i] = rgb_szoveg_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
                darabolo[i] = Convert.ToInt32(rgb_szoveg_alap.Split(';').ToString()[i]);
            }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].ForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);
            }
            for (int i = 0; i < darabolo.Length; i++)
            {
                ddarabolo[i] = rgb_hatter_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }

            for (int i = 0; i < be.Length; i++)
            {
                be[i].BackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]);

                System.Drawing.FontFamily fa = new System.Drawing.FontFamily(betu_stilus_alap.Split(';')[0]);
                float size = float.Parse(betu_stilus_alap.Split(';')[1]);
                System.Drawing.FontStyle f = (System.Drawing.FontStyle)Enum.Parse(typeof(System.Drawing.FontStyle), betu_stilus_alap.Split(';')[2], true);
                be[i].Font = new System.Drawing.Font(fa.Name, size-4, f); // betűtípus  
                //be[i].Font = new System.Drawing.Font(betu_stilus_alap, be[i].Font.Size, System.Drawing.FontStyle.Bold);
            }

    }
        public void DateTimePicker_formazasok(string alap_ertelmezett_e, int id, params System.Windows.Forms.DateTimePicker[] be)
        {
            _DateTimePicker_formazasok(alap_ertelmezett_e,id,be);
        }

        private void _Form_formazasok(string alap_ertelmezett_e,int id,params System.Windows.Forms.Form[] be)
        {
                if (alap_ertelmezett_e == "1" || id == 0)
                {
                    rgb_szoveg_alap = _rgb_szoveg_alap;
                    fo_hatter = _fo_hatter;
                }
                else
                {
                    formazas_beallitasok_beolvasasa(id);
                }
                for (int i = 0; i < darabolo.Length; i++)
                {
                    ddarabolo[i] = rgb_szoveg_alap.Split(';')[i];
                    darabolo[i] = Convert.ToInt32(ddarabolo[i]);
                }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].ForeColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]); //betűszín
            }
                for (int i = 0; i < darabolo.Length; i++)
                {
                    ddarabolo[i] = fo_hatter.Split(';')[i];
                    darabolo[i] = Convert.ToInt32(ddarabolo[i]);
                }
            for (int i = 0; i < be.Length; i++)
            {
                be[i].BackColor = System.Drawing.Color.FromArgb(darabolo[0], darabolo[1], darabolo[2]); //háttérszín
            }         
        }
        public void Form_formazasok(string alap_ertelmezett_e, int id, params System.Windows.Forms.Form[] be)
        {
            _Form_formazasok(alap_ertelmezett_e, id,be);
        }

        private void _formazas_beallitasok_beolvasasa(int id )
        {
            try
                {
                if (f.vanewamp() && cs.kapcsolat_ellenorzes())
                {
                    string lekerdezes = "SELECT beallitasok.form_hatter,beallitasok.rgb_szoveg,beallitasok.rgb_hatter,beallitasok.rgb_datagrid_hatter,beallitasok.rgb_datagrid_gridcolor,beallitasok.rgb_datagrid_forecolor,beallitasok.rgb_datagrid_kivalasztott_hatter,beallitasok.rgb_datagrid_kijelolt_betuszin,beallitasok.rgb_datagrid_paros_sorok_szin,beallitasok.betu_stilus,beallitasok.jelszo_elrejtesi_karakter,beallitasok.fodrasz_az,beallitasok.alapertelmezett FROM beallitasok WHERE beallitasok.fodrasz_az = '" + id + "'";
                    // System.Windows.Forms.Clipboard.SetDataObject(lekerdezes, true);
                    cs.kapcs.Open();
                    cs.parancs.CommandText = lekerdezes;
                    cs.parancs.Connection = cs.kapcs;
                    // SQL lekérdezéssel megnézzük az adatbázisban a megadott értékeket (felhasználó név, jelszó)          
                    MySqlDataReader olvas = cs.parancs.ExecuteReader();
                    while (olvas.Read())    //beolvas amíg     
                    {
                        fo_hatter = olvas.GetString(0);
                        rgb_szoveg_alap = olvas.GetString(1);
                        rgb_hatter_alap = olvas.GetString(2);
                        rgb_datagrid_hatter_alap = olvas.GetString(3);
                        rgb_datagrid_gridcolor_alap = olvas.GetString(4);
                        rgb_datagrid_forecolor_alap = olvas.GetString(5);
                        rgb_datagrid_kivalasztott_hatter_alap = olvas.GetString(6);
                        rgb_datagrid_kijelolt_betuszin_alap = olvas.GetString(7);
                        rgb_datagrid_paros_hatter_alap = olvas.GetString(8);
                        betu_stilus_alap = olvas.GetString(9);
                        jelszo_elrejtesi_karakter_alap = olvas.GetString(10);
                        alapertelmezett = olvas.GetString(12);
                    }
                    olvas.Close();

                    if (alapertelmezett == default(string))
                    {
                        fo_hatter = _fo_hatter;
                        rgb_szoveg_alap = _rgb_szoveg_alap;
                        rgb_hatter_alap = _rgb_hatter_alap;
                        rgb_datagrid_hatter_alap = _rgb_datagrid_hatter_alap;
                        rgb_datagrid_gridcolor_alap = _rgb_datagrid_gridcolor_alap;
                        rgb_datagrid_forecolor_alap = _rgb_datagrid_forecolor_alap;
                        rgb_datagrid_kivalasztott_hatter_alap = _rgb_datagrid_kivalasztott_hatter_alap;
                        rgb_datagrid_kijelolt_betuszin_alap = _rgb_datagrid_kijelolt_betuszin_alap;
                        rgb_datagrid_paros_hatter_alap = _rgb_datagrid_paros_hatter_alap;
                        betu_stilus_alap = _betu_stilus_alap;
                        jelszo_elrejtesi_karakter_alap = _jelszo_elrejtesi_karakter_alap;
                        alapertelmezett = _alapertelmezett;

                        string lekerdezes2 = "SELECT beallitasok.form_hatter,beallitasok.rgb_szoveg,beallitasok.rgb_hatter,beallitasok.rgb_datagrid_hatter,beallitasok.rgb_datagrid_gridcolor,beallitasok.rgb_datagrid_forecolor,beallitasok.rgb_datagrid_kivalasztott_hatter,beallitasok.rgb_datagrid_kijelolt_betuszin,beallitasok.rgb_datagrid_paros_sorok_szin,beallitasok.betu_stilus,beallitasok.jelszo_elrejtesi_karakter,beallitasok.fodrasz_az,beallitasok.alapertelmezett FROM beallitasok WHERE beallitasok.fodrasz_az = '0'";

                        if (!f.van_e_ilyen_adat(lekerdezes2))
                        {
                            string feltoltes = "INSERT INTO beallitasok(`form_hatter`,`rgb_szoveg`,`rgb_hatter`,`rgb_datagrid_hatter`,`rgb_datagrid_gridcolor`,`rgb_datagrid_forecolor`,`rgb_datagrid_kivalasztott_hatter`,`rgb_datagrid_kijelolt_betuszin`,`rgb_datagrid_paros_sorok_szin`,`betu_stilus`,`jelszo_elrejtesi_karakter`,`fodrasz_az`,`alapertelmezett`) VALUES('" + _fo_hatter + "' , '" + _rgb_szoveg_alap + "' , '" + _rgb_hatter_alap + "' , '" + _rgb_datagrid_hatter_alap + "' , '" + _rgb_datagrid_gridcolor_alap + "' , '" + _rgb_datagrid_forecolor_alap + "' , '" + _rgb_datagrid_kivalasztott_hatter_alap + "' , '" + _rgb_datagrid_kijelolt_betuszin_alap + "' , '" + _rgb_datagrid_paros_hatter_alap + "' , '" + _betu_stilus_alap + "' , '" + _jelszo_elrejtesi_karakter_alap + "' , '0' , '" + _alapertelmezett + "')";
                            // System.Windows.Forms.Clipboard.SetDataObject(feltoltes, true);
                            f.adat_kezeles(feltoltes);
                        }
                    }
                }
                else
                {
                    fo_hatter = _fo_hatter;
                    rgb_szoveg_alap = _rgb_szoveg_alap;
                    rgb_hatter_alap = _rgb_hatter_alap;
                    rgb_datagrid_hatter_alap = _rgb_datagrid_hatter_alap;
                    rgb_datagrid_gridcolor_alap = _rgb_datagrid_gridcolor_alap;
                    rgb_datagrid_forecolor_alap = _rgb_datagrid_forecolor_alap;
                    rgb_datagrid_kivalasztott_hatter_alap = _rgb_datagrid_kivalasztott_hatter_alap;
                    rgb_datagrid_kijelolt_betuszin_alap = _rgb_datagrid_kijelolt_betuszin_alap;
                    rgb_datagrid_paros_hatter_alap = _rgb_datagrid_paros_hatter_alap;
                    betu_stilus_alap = _betu_stilus_alap;
                    jelszo_elrejtesi_karakter_alap = _jelszo_elrejtesi_karakter_alap;
                    alapertelmezett = _alapertelmezett;
                }
                   

            }
                catch { System.Windows.Forms.MessageBox.Show("Nem sikerült beolvasni a formázási beállításokat!", "Sikertelen beolvasás", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); }
                cs.kapcs.Close();
            
            
        }
        public void formazas_beallitasok_beolvasasa(int id)
        {
            _formazas_beallitasok_beolvasasa(id);
        }

        private int[] _TabControl_formazasok_hatter(string alap_ertelmezett_e, int id,params System.Windows.Forms.TabControl[] be)
        {
            if (alap_ertelmezett_e == "1" || id == 0)
            {
                fo_hatter = _fo_hatter;
            }
            else
            {
                formazas_beallitasok_beolvasasa(id);

            }
            for (int i = 0; i < darabolo.Length; i++)
            {
                ddarabolo[i] = fo_hatter.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }
            return darabolo;              
        }
        public int[] TabControl_formazasok_hatter(string alap_ertelmezett_e, int id, params System.Windows.Forms.TabControl[] be)
        {
            return _TabControl_formazasok_hatter(alapertelmezett, id,be);
        }

        private int[] _TabControl_formazasok_szoveg(string alap_ertelmezett_e, int id,params System.Windows.Forms.TabControl[] be)
        {
            if (alap_ertelmezett_e == "1" || id == 0)
            {
                rgb_szoveg_alap = _rgb_szoveg_alap;
            }
            else
            {
                formazas_beallitasok_beolvasasa(id);
            }
            for (int i = 0; i < darabolo.Length; i++)
            {
                ddarabolo[i] = rgb_szoveg_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }
           return darabolo;            
        }
        public int[] TabControl_formazasok_szoveg(string alap_ertelmezett_e, int id, params System.Windows.Forms.TabControl[] be)
        {
            return _TabControl_formazasok_szoveg(alapertelmezett, id,be);
        }

        private int[] _TabControl_formazasok_gomb_tabcontrolvalto_hatter(string alap_ertelmezett_e, int id,params System.Windows.Forms.TabControl[] be)
        {
                if (alap_ertelmezett_e == "1" || id == 0)
                {
                    rgb_hatter_alap = _rgb_hatter_alap;
                }
                else
                {
                    formazas_beallitasok_beolvasasa(id);
                }
            for (int i = 0; i < darabolo.Length; i++)
            {
                ddarabolo[i] = rgb_hatter_alap.Split(';')[i];
                darabolo[i] = Convert.ToInt32(ddarabolo[i]);
            }
            return darabolo;

        }
        public int[] TabControl_formazasok_tabcontrolvalto_hatter(string alap_ertelmezett_e, int id, params System.Windows.Forms.TabControl[] be)
        {
            return _TabControl_formazasok_gomb_tabcontrolvalto_hatter(alapertelmezett, id,be);
        }

        private string _TabControl_formazasok_betustilus(string alap_ertelmezett_e, int id, params System.Windows.Forms.TabControl[] be)
        {
            if (alap_ertelmezett_e == "1" || id == 0)
            {
                betu_stilus_alap = _betu_stilus_alap;
            }
            else
            {
                formazas_beallitasok_beolvasasa(id);
            }
            return betu_stilus_alap;

        }
        public string TabControl_formazasok_betustilus(string alap_ertelmezett_e, int id, params System.Windows.Forms.TabControl[] be)
        {
            return _TabControl_formazasok_betustilus(alapertelmezett, id, be);
        }
    }
}
