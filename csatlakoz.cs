using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

namespace fodraszat
{
    class csatlakoz
    {
        private string adatbazis_letrehoz = "CREATE DATABASE `fodrasz` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;";

        List<string> tabla1_adatok = new List<string>();
        List<string> tabla2_adatok = new List<string>();
        //private string tabla2 = "CREATE TABLE IF NOT EXISTS `fodrasz`.`foglalas` (`idd` int(3), `datum` date(10), `idopont` time(5), `nev` varchar(50), `tipus` varchar(25), `ar` int(10)) DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;";

        // „ALTER TABLE `foglalas` ADD PRIMARY KEY(` id `);”
        private string tabla1 = "CREATE TABLE IF NOT EXISTS `fodrasz`.`belepesi_adatok` (`id` int(11),`felhasznalo` varchar(60), `jelszo` varchar(35)) DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;";
        private string tabla2 = "CREATE TABLE IF NOT EXISTS `fodrasz`.`foglalas` (`id` int(4), `idopont` datetime,`idopont_vege` datetime, `nev` varchar(60), `tipus_az` int(4),`fodrasz_az` int(4), `megjegyzes` varchar(300)) DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;";
        private string tabla3 = "CREATE TABLE IF NOT EXISTS `fodrasz`.`tipus_ar` (`id` int(4), `tipus` varchar(50), `ar` int(15), `idotartam` time,`fodrasz_az` int(12)) DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;";
        private string tabla4 = "CREATE TABLE IF NOT EXISTS `fodrasz`.`beallitasok` (`form_hatter` varchar(15),`rgb_szoveg` varchar(15), `rgb_hatter` varchar(15), `rgb_datagrid_hatter` varchar(15),`rgb_datagrid_gridcolor` varchar(15), `rgb_datagrid_forecolor` varchar(15),`rgb_datagrid_kivalasztott_hatter` varchar(15),`rgb_datagrid_kijelolt_betuszin` varchar(15),`rgb_datagrid_paros_sorok_szin` varchar(15),`betu_stilus` varchar(120),`jelszo_elrejtesi_karakter` varchar(1),`fodrasz_az` int(12),`alapertelmezett` int(1)) DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;";
        private string table5 = "CREATE TABLE IF NOT EXISTS `fodrasz`.`proba` (`id` int(11),`vendegneve` varchar(60), `idopont` datetime) DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;";
        private string table6 = "CREATE TABLE IF NOT EXISTS `fodrasz`.`felhasznalo_mentese` (`felhasznalo` varchar(120)) DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;";
        private string kulcs_beallitasok1 = "ALTER TABLE `proba` ADD PRIMARY KEY(`id`);\nALTER TABLE `beallitasok` ADD PRIMARY KEY(`fodrasz_az`);\nALTER TABLE `belepesi_adatok` ADD PRIMARY KEY(`id`);\nALTER TABLE `foglalas` ADD PRIMARY KEY(`id`);\nALTER TABLE `tipus_ar` ADD PRIMARY KEY(`id`); ALTER TABLE belepesi_adatok MODIFY COLUMN id INT auto_increment; ALTER TABLE foglalas MODIFY COLUMN id INT auto_increment; ALTER TABLE tipus_ar MODIFY COLUMN id INT auto_increment;ALTER TABLE proba MODIFY COLUMN id INT auto_increment;";


        private MySqlConnection _kapcs = new MySqlConnection("SERVER=localhost;DATABASE=fodrasz;UID=root;charset=utf8");
        private MySqlCommand _parancs = new MySqlCommand();        
        private MySqlDataAdapter _da = null;
        private DataSet _ds = null;

        //_______________________________________________________________________________Kapcsolat ellenőrzés
        public bool kapcsolat_ellenorzes()
        {
            try
            {
                kapcs.Open();
                kapcs.Close();
                return true;
            }
            catch 
            {
                return false;
            }            
        }

        //______________________________________________________________________________________SEGÉD_DOLGOK
        public string adatbazis_letrehozasa()
        {
            return adatbazis_letrehoz;
        }
        public string tablak_letrehozása1()
        {
            return tabla1;
        }
        public string tablak_letrehozása2()
        {
            return tabla2;
        }
		public string tablak_letrehozása3()
        {
            return tabla3;
        }
        public string tablak_letrehozása4()
        {
            return tabla4;
        }
        public string tablak_letrehozása5()
        {
            return table5;
        }        
        public string tablak_letrehozása6()
        {
            return table6;
        }

        public string kulcs_beallitasok()
        {
            return kulcs_beallitasok1;
        }
        public string kapcsolodas()
        {
            return "SERVER=localhost;DATABASE=fodrasz;UID=root;charset=utf8";
        }
        //_________________________________________________________________________________________________
        public MySqlConnection kapcs
        {
            get { return _kapcs; }
            set { _kapcs = value; }
        }
        public MySqlCommand parancs
        {
            get { return _parancs; }
            set { _parancs = value; }
        }
        public DataSet ds
        {
            get { return _ds; }
            set { _ds = value; }
        }
        public MySqlDataAdapter da
        {
            get { return _da; }
            set { _da = value; }
        }
    }

}
